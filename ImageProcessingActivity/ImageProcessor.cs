using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingActivity
{
    public partial class ImageProcessor : Form
    {
        private Bitmap imageB, imageA;
        private Device device;
        bool isCamOn = false;
        Timer deviceTimer = new Timer();

        enum ProcessingMode { None, Copy, Grayscale, Invert, Sepia }
        ProcessingMode mode = ProcessingMode.None;

        public ImageProcessor()
        {
            InitializeComponent();

            deviceTimer.Interval = 30;
            deviceTimer.Tick += deviceTimer_Tick;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void deviceTimer_Tick(object sender, EventArgs e)
        {
            Bitmap currentFrame = GetDeviceFrame();
            if (currentFrame == null) return;

            // Apply filter based on mode
            switch (mode)
            {
                case ProcessingMode.Grayscale:
                    webcam_grayscale(currentFrame);
                    break;

                case ProcessingMode.Invert:
                    webcam_invert(currentFrame);
                    break;

                case ProcessingMode.Sepia:
                    webcam_sepia(currentFrame);
                    break;

                case ProcessingMode.Copy:
                case ProcessingMode.None:
                default:
                    // Do nothing
                    break;
            }

            var oldImage = pic_box2.Image;
            pic_box2.Image = currentFrame;
            pic_box2.SizeMode = PictureBoxSizeMode.StretchImage;
            oldImage?.Dispose();
        }

        private Bitmap GetDeviceFrame()
        {
            try
            {
                device.Sendmessage();

                Image clipboardImage = Clipboard.GetImage();
                if (clipboardImage == null)
                    return null;

                Bitmap bmp32 = new Bitmap(clipboardImage.Width, clipboardImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(bmp32))
                {
                    g.DrawImage(clipboardImage, new Rectangle(0, 0, bmp32.Width, bmp32.Height));
                }

                return bmp32;
            }
            catch
            {
                return null;
            }
        }

        private void ApplyModeToStaticImage()
        {
            Bitmap sourceImage = null;

            if (isCamOn && pic_box2.Image != null)
            {
                // Use webcam frame
                sourceImage = new Bitmap(pic_box2.Image);
            }
            else if (pic_box1.Image != null)
            {
                // Use loaded image
                sourceImage = new Bitmap(pic_box1.Image);
            }
            else
            {
                MessageBox.Show("Please load an image first!");
                return;
            }

            switch (mode)
            {
                case ProcessingMode.Copy:
                    copyToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case ProcessingMode.Grayscale:
                    Bitmap grayCopy = new Bitmap(sourceImage);
                    for (int y = 0; y < grayCopy.Height; y++)
                        for (int x = 0; x < grayCopy.Width; x++)
                        {
                            Color pixelColor = grayCopy.GetPixel(x, y);
                            int greyValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            grayCopy.SetPixel(x, y, Color.FromArgb(greyValue, greyValue, greyValue));
                        }
                    pic_box2.Image?.Dispose();
                    pic_box2.Image = grayCopy;
                    break;
                case ProcessingMode.Invert:
                    Bitmap invertCopy = new Bitmap(sourceImage);
                    for (int y = 0; y < invertCopy.Height; y++)
                        for (int x = 0; x < invertCopy.Width; x++)
                        {
                            Color pixelColor = invertCopy.GetPixel(x, y);
                            invertCopy.SetPixel(x, y, Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B));
                        }
                    pic_box2.Image?.Dispose();
                    pic_box2.Image = invertCopy;
                    break;
                case ProcessingMode.Sepia:
                    Bitmap sepiaCopy = new Bitmap(sourceImage);
                    for (int y = 0; y < sepiaCopy.Height; y++)
                        for (int x = 0; x < sepiaCopy.Width; x++)
                        {
                            Color pixelColor = sepiaCopy.GetPixel(x, y);
                            int tr = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                            int tg = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                            int tb = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                            tr = Math.Min(255, tr);
                            tg = Math.Min(255, tg);
                            tb = Math.Min(255, tb);

                            sepiaCopy.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                        }
                    pic_box2.Image?.Dispose();
                    pic_box2.Image = sepiaCopy;
                    break;
            }

            sourceImage.Dispose();
        }

        private void webcam_grayscale(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int bytes = Math.Abs(data.Stride) * data.Height;
            byte[] pixels = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(data.Scan0, pixels, 0, bytes);

            for (int i = 0; i < pixels.Length; i += 4)
            {
                byte gray = (byte)((pixels[i] + pixels[i + 1] + pixels[i + 2]) / 3);
                pixels[i] = gray;
                pixels[i + 1] = gray;
                pixels[i + 2] = gray;
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, data.Scan0, bytes);
            bmp.UnlockBits(data);
        }

        private void webcam_invert(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int bytes = Math.Abs(data.Stride) * data.Height;
            byte[] pixels = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(data.Scan0, pixels, 0, bytes);

            for (int i = 0; i < pixels.Length; i += 4)
            {
                pixels[i] = (byte)(255 - pixels[i]);
                pixels[i + 1] = (byte)(255 - pixels[i + 1]);
                pixels[i + 2] = (byte)(255 - pixels[i + 2]);
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, data.Scan0, bytes);
            bmp.UnlockBits(data);
        }

        private void webcam_sepia(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int bytes = Math.Abs(data.Stride) * data.Height;
            byte[] pixels = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(data.Scan0, pixels, 0, bytes);

            for (int i = 0; i < pixels.Length; i += 4)
            {
                byte B = pixels[i];
                byte G = pixels[i + 1];
                byte R = pixels[i + 2];

                int tr = (int)(0.393 * R + 0.769 * G + 0.189 * B);
                int tg = (int)(0.349 * R + 0.686 * G + 0.168 * B);
                int tb = (int)(0.272 * R + 0.534 * G + 0.131 * B);

                pixels[i] = (byte)Math.Min(255, tb);
                pixels[i + 1] = (byte)Math.Min(255, tg);
                pixels[i + 2] = (byte)Math.Min(255, tr);
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, data.Scan0, bytes);
            bmp.UnlockBits(data);
        }

        private void reseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic_box1.Image?.Dispose();
            pic_box2.Image?.Dispose();
            pic_box1.Image = null;
            pic_box2.Image = null;
            label2.Text = "RESULT";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_box1.Image?.Dispose();
                    pic_box1.Image = Image.FromFile(ofd.FileName);
                    pic_box1.SizeMode = PictureBoxSizeMode.StretchImage;
                    imageB = new Bitmap(pic_box1.Image);
                }

            }
        }

        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_box1.Image != null)
            {
                pic_box1.Image.Dispose();
                pic_box1.Image = null;
                pic_box1.Invalidate();
                return;
            }

            MessageBox.Show("No more image.");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = ProcessingMode.Copy;

            Bitmap sourceImage = null;

            if (isCamOn && pic_box2.Image != null)
            {
                sourceImage = new Bitmap(pic_box2.Image); // capture webcam
            }
            else if (pic_box1.Image != null)
            {
                sourceImage = new Bitmap(pic_box1.Image); // loaded image
            }
            else
            {
                MessageBox.Show("Please load an image first!");
                return;
            }

            Bitmap copy = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    copy.SetPixel(x, y, pixelColor);
                }
            }

            label2.Text = "RESULT";
            pic_box2.Image?.Dispose();
            pic_box2.Image = copy;
            pic_box2.SizeMode = PictureBoxSizeMode.StretchImage;

            sourceImage.Dispose();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = ProcessingMode.Grayscale;
            ApplyModeToStaticImage();
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = ProcessingMode.Invert;
            ApplyModeToStaticImage();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = ProcessingMode.Sepia;
            ApplyModeToStaticImage();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_box1.Image == null)
            {
                MessageBox.Show("Please load an image first!");
                return;
            }

            Bitmap original = new Bitmap(pic_box1.Image);
            int[] histogram = new int[256];

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    int greyValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    histogram[greyValue]++;
                }
            }

            Bitmap histImage = new Bitmap(256, 100);
            int max = histogram.Max();

            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);

                for (int x = 0; x < 256; x++)
                {
                    int histHeight = (int)((histogram[x] / (float)max) * histImage.Height);
                    int scaledX = (int)(x * (histImage.Width / 256f));
                    g.DrawLine(Pens.Black, scaledX, histImage.Height - 1, scaledX, histImage.Height - histHeight);
                }

            }

            label2.Text = "RESULT";
            pic_box2.Image?.Dispose();
            pic_box2.Image = histImage;
            pic_box2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            loadImageToolStripMenuItem_Click(sender, e);
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (pic_box1.Image == null || pic_box2.Image == null)
            {
                MessageBox.Show("Please load BOTH foreground and background images first!");
                return;
            }

            Bitmap foreground = new Bitmap(pic_box1.Image);
            Bitmap background = new Bitmap(pic_box2.Image);

            int width = Math.Min(foreground.Width, background.Width);
            int height = Math.Min(foreground.Height, background.Height);

            Bitmap result = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color fg = foreground.GetPixel(x, y);
                    Color bg = background.GetPixel(x, y);

                    if (fg.G > 100 && fg.G > fg.R + 40 && fg.G > fg.B + 40)
                    {
                        result.SetPixel(x, y, bg);
                    }
                    else
                    {
                        result.SetPixel(x, y, fg);
                    }
                }
            }

            pic_box3.Image?.Dispose();
            pic_box3.Image = result;
            pic_box3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void startWebcamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Device[] devices = DeviceManager.GetAllDevices();
            if (devices.Length == 0)
            {
                MessageBox.Show("No webcam found.");
                return;
            }

            device = devices[0];

            try
            {
                device.ShowWindow(pic_box1);
                pic_box2.SizeMode = PictureBoxSizeMode.StretchImage;
                isCamOn = true;
                deviceTimer.Start();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error starting webcam: " + ee.Message);
            }
        }

        private void stopWebcamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device?.Stop();
            isCamOn = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (pic_box2.Image == null)
            {
                MessageBox.Show("No image to save!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Image";
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.FileName = "ProcessedImage";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;

                        if (ext == ".jpg" || ext == ".jpeg")
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        else if (ext == ".bmp")
                            format = System.Drawing.Imaging.ImageFormat.Bmp;

                        pic_box2.Image.Save(sfd.FileName, format);
                        MessageBox.Show("Image saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message);
                    }
                }
            }
        }

        private void btnLoad_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_box2.Image?.Dispose();
                    pic_box2.Image = Image.FromFile(ofd.FileName);
                    imageA = new Bitmap(pic_box1.Image);
                    pic_box2.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Text = "BACKGROUND";
                }
            }
        }
    }
}

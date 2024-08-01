using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public int UserType {  get; set; }
    }


    internal class Utility
    {
        public static void TogglePasswordVisibility(Guna2TextBox textBox, Guna2Button button)
        {
            if (textBox.PasswordChar != '●')
            {
                textBox.PasswordChar = '●';
                // textBox.UseSystemPasswordChar = false;
                button.Image = Properties.Resources.hide;
                return;
            }

            textBox.PasswordChar = '\0';
            // textBox.UseSystemPasswordChar = true;
            button.Image = Properties.Resources.show;
        }

        public bool IsNumeric(string input)
        {
            // Define a regular expression pattern to match numeric digits
            string pattern = "^[0-9]+$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }

        public static int ConvertStringToInt(string num, out string error)
        {
            try
            {
                error = string.Empty;
                return Int32.Parse(num);
            }
            catch (FormatException)
            {
                error = null;
                return 0;
            }
        }


        public static ImageFormat GetImageFormat(System.Drawing.Image image)
        {
            if (image.RawFormat.Equals(ImageFormat.Jpeg))
                return ImageFormat.Jpeg;
            
            else if (image.RawFormat.Equals(ImageFormat.Png))
                return ImageFormat.Png;
            
            else if (image.RawFormat.Equals(ImageFormat.Gif))
                return ImageFormat.Gif;
            
            else if (image.RawFormat.Equals(ImageFormat.Bmp))
                return ImageFormat.Bmp;
            
            else if (image.RawFormat.Equals(ImageFormat.Icon))
                return ImageFormat.Icon;
            
            else
                // Handle other formats or return null if not recognized
                return null;
            
        }

        // For Database to normal formated image
        public static System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
                return System.Drawing.Image.FromStream(ms);
            
        }

        // For normal to Database formated image
        public static byte[] ImageToByteArray(System.Drawing.Image image, ImageFormat imageFormat)
        {
            if (image == null)
                return null;
            

            // Use a try-catch block to handle any potential GDI+ exceptions
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    if (imageFormat != null)
                        image.Save(stream, imageFormat); // Save the image with the determined format
                    
                    else
                        image.Save(stream, ImageFormat.Jpeg);  // If the image format is not recognized, save it as JPEG (or another default format)

                    return stream.ToArray();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions related to GDI+ here
                MessageBox.Show("Error in ImageToByteArray: " + ex.Message);
                return null;
            }
        }


        public static void pictureUpload(Guna2PictureBox pictureBox)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Perform the necessary actions with the selected file here
                    // For example, you can display the file path in a TextBox:
                    // Load the image from the selected file
                    Image originalImage = Image.FromFile(selectedFile);

                    // Resize the image to fit the PictureBox size
                    Image resizedImage = new Bitmap(originalImage, new Size(130, 130));

                    // Display the resized image in the PictureBox
                    pictureBox.Image = resizedImage;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Picture Error");
            }
        }

    }
}

using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project214.Utilities
{
    public static class GeneralUtils
    {
        public static string HashString(string text, string salt)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text + salt);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
        public static bool RegexEmail(string text)
        {
            return Regex.IsMatch(text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        public static bool RegexPassword(string text)
        {
            return Regex.IsMatch(text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", RegexOptions.Singleline);
        }
        public static bool RegexName(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9_]{3,16}$", RegexOptions.IgnoreCase);
        }

        public static bool EmailUsed(SqlConnection connection, string Email)
        {
            string query = "SELECT COUNT(*) FROM UserAccount WHERE Email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", Email);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public static bool UsernameUsed(SqlConnection connection, string Username)
        {
            string query = "SELECT COUNT(*) FROM UserAccount WHERE Username = @Username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", Username);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public static Point Remap(Point point, Point min, Point max, Point newMin, Point newMax)
        {
            // Map X coordinate
            int newX = (int)Remap(point.X, min.X, max.X, newMin.X, newMax.X);

            // Map Y coordinate
            int newY = (int)Remap(point.Y, min.Y, max.Y, newMin.Y, newMax.Y);

            // Return the remapped point
            return new Point(newX, newY);
        }

        public static float Remap(float point, float min, float max, float newMin, float newMax)
        {
            // Ensure point is within the range [min, max]
            point = Math.Min(max, Math.Max(min, point));

            // Calculate the ratio of the point's position between min and max
            float ratio = (point - min) / (max - min);

            // Map the ratio to the new range [newMin, newMax]
            return newMin + (newMax - newMin) * ratio;
        }

        public static Bitmap ByteArrayToBitmap(byte[] byteArray)
        {
            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                Bitmap bitmap = new Bitmap(stream);
                return bitmap;
            }
        }
        public static Bitmap Base64ToBitmap(string base64String)
        {
            // Convert the Base64 string to a byte array
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Create a MemoryStream from the byte array
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Create a Bitmap from the MemoryStream
                Bitmap bitmap = new Bitmap(ms);
                return bitmap;
            }
        }
        public static string ImageToBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static string GetImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image file
                    using (Image selectedImage = Image.FromFile(openFileDialog.FileName))
                    {
                        return ImageToBase64(selectedImage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No image selected.");
            }

            return null;
        }
    }
}

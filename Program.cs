using QRCoder;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.IO;
using System.Diagnostics; // For opening the image

class Program
{
    static void Main(string[] args)
    {
        // Create a QR code generator
        QRCodeGenerator qrGenerator = new QRCodeGenerator();

        // Set the text to encode
        string text = "Lead Operational Excellence as a COO with IIM Kozhikode’s Co ..\r\n\r\nRead more at:\r\nhttp://timesofindia.indiatimes.com/articleshow/108043076.cms?utm_source=contentofinterest&utm_medium=text&utm_campaign=cppst";

        // Generate the QR code
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

        // Create a bitmap image from the QR code data
        int width = qrCodeData.ModuleMatrix[0].Length;
        int height = qrCodeData.ModuleMatrix.Count;
        int scaleFactor = 300 / Math.Max(width, height); // Scale the image to 300px, or adjust as needed
        int newWidth = width * scaleFactor;
        int newHeight = height * scaleFactor;

        using (var image = new Image<Rgba32>(newWidth, newHeight))
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bool color = qrCodeData.ModuleMatrix[y][x];
                    for (int i = 0; i < scaleFactor; i++)
                    {
                        for (int j = 0; j < scaleFactor; j++)
                        {
                            image[x * scaleFactor + i, y * scaleFactor + j] = color ? Color.Black : Color.White;
                        }
                    }
                }
            }

            // Ensure the directory exists
            string outputPath = Path.Combine("E:\\.net project\\QR-Code-Generator","qrcode.png");
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

            // Save the QR code image to a file
            image.Save(outputPath);

            // Provide feedback in the console
            Console.WriteLine("QR code generated and saved successfully!");

            // Pop up the image using the default image viewer
            OpenImage(outputPath);
        }
    }

    // Method to open the image using the default viewer
    static void OpenImage(string path)
    {
        try
        {
            // Open the image using the default system viewer
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
            Console.WriteLine("QR code image opened successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error opening the image: " + ex.Message);
        }
    }
}

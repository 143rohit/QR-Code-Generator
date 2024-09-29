using QRCoder;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

class Program
{
    static void Main(string[] args)
    {
        // Create a QR code generator
        QRCodeGenerator qrGenerator = new QRCodeGenerator();

        // Set the text to encode
        string text = "12345678998455422 .";

        // Generate the QR code
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

        // Create a bitmap image from the QR code data
        int width = qrCodeData.ModuleMatrix[0].Length;
        int height = qrCodeData.ModuleMatrix.Count;
        int scaleFactor = 300 / Math.Max(width, height);
        int newWidth = width * scaleFactor;
        int newHeight = height * scaleFactor;

        using var image = new Image<Rgba32>(newWidth, newHeight);
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

        // Save the QR code image to a file
        image.Save("C:\\Users\\rohit\\source\\repos\\ConsoleApp3\\qrcode.png");
    }
}
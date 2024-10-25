# QR Code Generator

A simple console application developed in C# that generates QR codes from user-inputted text or URLs. This application allows users to create and save QR codes as image files, making sharing information easy and efficient.

## Features

- **Generate QR Codes**: Create QR codes from any text or URL.
- **Save QR Codes**: Save generated QR codes as image files (PNG format).
- **Automatic Image Viewer**: Automatically opens the generated QR code image using the default image viewer.

## Technologies Used

- C# (.NET Core)
- [QRCoder](https://github.com/codebude/QRCoder) for QR code generation
- [ImageSharp](https://github.com/SixLabors/ImageSharp) for image handling
- Console Application

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/QRCodeGenerator.git
2. Open the project in your preferred C# IDE (e.g., Visual Studio or Visual Studio Code).
3. Restore dependencies and build the project.
4. Run the application.
   
## Usage

1. The QR code generator will encode a predefined text or URL into a QR code.
2. After execution, the QR code image will be saved in the specified directory.
3. The generated QR code will automatically open in your default image viewer.

## Sample Commands

* Generate QR Code: The application generates a QR code from the predefined text when run.
* Save QR Code: The QR code will be saved as qrcode.png in the specified directory 
* Open Image: The generated QR code image will automatically open after creation.
  
## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Author
Rohit Gaikwad - [GitHub Profile](https://github.com/rgaikwad7749)

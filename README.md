Free Gmail Creator (Open Source)

A free, open-source tool for automating Gmail account creation, shared with the community.

License

This project is licensed under the "MIT License".  
You are free to use, modify, and distribute it, even for commercial purposes.

Requirements

- Windows
- .NET Framework (for building/running the .exe)
- Google Chrome installed

Build

Open the solution (`GmailCreator.sln`) in **Visual Studio**.  
Build the project to generate `GmailCreator.exe`.

Usage

You can run the executable with command-line arguments to register new Gmail accounts automatically.

Show All Command-Line Arguments
To see all available options and help:

Register Command Example
Here’s an example of how to run the creator with all parameters:

GmailCreator.exe ^
--BrowserPath="C:\Program Files\Google\Chrome\Application\chrome.exe" ^
--UserDataDir="./test" ^
--PhoneKey="xxx" ^
--UserName="xxx" ^
--Password="xxx" ^
--FirstName="xxx" ^
--LastName="xxx" ^
--Gender=1 ^
--Birthday="1997-04-01" ^
--RecoveryEmail="xxx@gmail.com"


Parameter Descriptions:
- `--BrowserPath` – Path to Chrome executable
- `--UserDataDir` – Profile storage folder
- `--PhoneKey` – Phone verification key/service
- `--UserName` – Gmail username
- `--Password` – Account password
- `--FirstName` – First name
- `--LastName` – Last name
- `--Gender` – Gender (1=Male, 2=Female)
- `--Birthday` – Date of birth (YYYY-MM-DD)
- `--RecoveryEmail` – Optional recovery email

Contributing

Pull requests are welcome! If you have improvements or bug fixes, feel free to submit them.


Contact

For questions, please contact +86 137 0946 2144

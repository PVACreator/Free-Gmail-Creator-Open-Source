Free Gmail Creator (Open Source)

A free, open-source tool for automating Gmail account creation, shared with the community.

License

This project is open source under the MIT License (see [LICENSE] for full text).

© 2025 PVACreator. Free to use, modify, and distribute with attribution.

Features and Advantages

Batch Import Thousands of Accounts
Import thousands of accounts at once (Manage Multiple Gmail, Facebook, Instagram, Twitter and TikTok Accounts in Free Account Manager)

Batch Fingerprint and Proxy Binding
Automatically assign unique fingerprints and proxies to large account batches.

Batch Auto-Login & Status Check
Accounts can log in automatically in bulk Gmail, Facebook, Instagram, Twitter and TikTok and verify their login status.

Account warmup Feature
Create unique role presets for each account — customize behavior, preferences, and interaction styles to warmup accounts.

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

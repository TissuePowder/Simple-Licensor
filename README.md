# Simple-Licensor
A licensing service to distribute your software to your clients in a simple hassle-free way.

## Motivation
The goal of developing this project is to prevent software piracy and improve protection and security measures for software. The software piracy protection system works by injecting the system into the newly downloaded software product. Users must first register for using a software product and then purchase the software via online payment. Once the payment is complete, users can download the software and the serial key for the same. The software reads the ID of your machine (PC/laptop) and generates a unique user ID by using an algorithm. The user can now log in via the user ID by providing the serial key.

## Features
There will be three sectors to discuss features.

### Server-side features
1. A database for managing serial keys.
2. UI for Create, Read, Update and Delete (CRUD) operations.
3. Recording each serial key with it's creation date, activation date, license type, duration length, condition etc.

### Library (DLL) features
1. Add arbitrary trial day limitation to the software.
2. Option to select either onine key validation or offline.
3. Saving registration information in an encrypted file in system directory securely (changeable).
4. Generating a unique hardware ID for the user's machine with options to select signatures from following devices.
   - Processor
   - Base Board
   - Disk Drive
   - Video Controller
   - Physical Media
   - BIOS
   - Operating System
5. Using TripleDES encryption to generate serial keys.
6. Different license level to lock functions for different usecase.

### Offline Keygen features
1. Generate serial keys for offline validation.
2. Take users' hardware ID and software identifier into account.
3. Generate valid keys for different amount of days.


## How to install and use
First clone the repository with `git clone git@github.com:TissuePowder/Simple-Licensor.git`
Then proceed to the following sectors to set up each of them.

### Setting up the server
1. Go to the `License Server` directory, open a shell/terminal and run the command `npm install`
2. Install postgresql in your machine and set up a database named `simple-licensor`
3. Create a user with username `admin` and password `12345` or edit the `config/database.js` accordingly.
4. Start the server with `npm start` for production mode or `npm run dev` for development mode.

### Working with the library (DLL) as a developer
1. Install .net framework 4.0 or higher to be able to use this dll.
2. Project is developed in [SharpDevelop](https://github.com/icsharpcode/SharpDevelop) v4.4. Any compatible IDE including Visual Studio that supports C# version >= 5.0 is necessary to work on this project.

### Integrating the library (DLL) in your software
1. Add a reference to the dll in your project.
2. Add namespace `using SimpleLicensor;` (C#) at the beginning of your main `.cs` file.
3. Add the following piece of code in your `main()` function. Set values for the variables as you wish.
```C#
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
		    
		    
//SoftwareName: Your software's name, this will be used to make ComputerID
string SoftwareName = "TestApp1";
		    
//RegFilePath: The file path that, if the user entered the registration code, will save it and check on every run.
string RegfilePath = Application.StartupPath + "\\keyfile.reg";
		    
//HiddenFilePath: This file will be used to save system information, days to finish trial mode, and current date.
string HiddenFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\SimpleLicensor.bfr";
						
//DefaultDays: How many days the user can run in trial mode.
int DefaultDays = 30;

//Identifier: Three character string for making serial key.
string Identifier = "538";
			
//CheckOnline: Whether the key would be checked in an online server or offline.
bool CheckOnline = true;
			
//Server: Server address to check the serial key.
string Server = "https://yourserver.com/api/keycheck";
		
AppLocker t = new AppLocker(SoftwareName, RegfilePath, HiddenFilePath, DefaultDays, Identifier, Server);

//Change the bits in the following array as you wish, or it will use default encryption.
byte[] MyOwnKey = { 97, 250,  1,  5,  84, 21,   7, 63,
		                         4,  54, 87, 56, 123, 10,   3, 62,
		                         7,   9, 20, 36,  37, 21, 101, 57};
t.TripleDESKey = MyOwnKey;
		
AppLocker.RunTypes RT = t.ShowDialog(CheckOnline);
		    
bool is_trial;

if (RT != AppLocker.RunTypes.Expired) {

  if (RT == AppLocker.RunTypes.Full) {
    is_trial = false;
  }
  else {
    is_trial = true;
	}
  
  //Pass the is_trial boolean in your MainForm's constructor and use the value to lock functions.
  Application.Run(new MainForm(is_trial));
}
```

### Using the offline Serial Maker
1. Use the identifier and client's hardware ID to generate a serial key.
2. Use to serial in your app's trial registration dialog to register.

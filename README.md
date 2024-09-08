# Project Name
My Profile - WPF Desktop Application

## Overview
"My Profile" is a WPF desktop application that consolidates social media profiles from Facebook, YouTube, Instagram, and LinkedIn into a single interface. The app includes a notifications bar, follower statistics, recent posts, and a scheduling calendar. It provides secure login using OAuth 2.0 and connects to a MySQL database to store user preferences.

## How to Install
1. Clone or Download the Repository
Clone this repository to your local machine using Git, or download the project zip file and extract it to a folder on your computer.

2. Open in Visual Studio
Open the solution file (MyProfile.sln) in Visual Studio 2022 or higher.

3. Install .NET SDK
Ensure that the .NET 6.0 SDK or higher is installed on your system. You can download it from Microsoft .NET Downloads.

4. Install Dependencies
The project uses NuGet packages. Visual Studio will prompt you to restore the NuGet packages. Click on "Restore" or run the following command in the Package Manager Console:


## How to Run
Instructions on running the project:
How to Run the Project
1. Build the Solution
In Visual Studio, click Build > Build Solution or press Ctrl + Shift + B.

2. Run the Application

Press F5 or click Start to run the project.
The login page will appear first. Use OAuth 2.0 credentials to log in and connect your social media profiles.
Once authenticated, the main dashboard will display your social media notifications, follower statistics, and calendar.

## Dependencies
List of libraries, frameworks, and tools used in your project.

.NET 6.0 SDK or higher
WPF (Windows Presentation Foundation)
MySQL.Data: For MySQL database connections.
Newtonsoft.Json: For JSON parsing and handling social media API responses.
RestSharp: For making HTTP requests to social media platforms.
OAuth2: For user authentication via social media platforms.

## Database
Database Name: MyProfileDB
The database stores login credentials, user preferences, and OAuth tokens.
Ensure that MySQL is installed and properly configured to connect to the app.

##Settings Needed to Run the WPF Project:
Ensure that the .NET SDK is properly installed.
Verify that MySQL Server is running and accessible via the provided connection string.
Update any API keys and OAuth 2.0 credentials for social media integration in the app configuration.
Install any missing dependencies via NuGet package manager as needed.

## Credits
This project was completed individually.
Name: Ashwin Thapa, Emmanuel Nkachukwu and Kamal

#### Min Chang

## Technologies Used

- C# / .NET 5 Framework / MySQL / Entity

## Description

This application lets the user create stylits and add clients to those stylists.

## Setup/Installation Requirements

- Get the source code: `$ git clone https://github.com/M-H-Chang/HairSalon.Solution`
- In HairSalon get your dependencies: `$ dotnet restore`
- Create file to store your database with touch appsettings.json in your terminal (make sure it is in the hairsalon root directory)
- In appsettings.json enter in the following 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=EauClaireSalon;uid=[user mysql username];pwd=[user mysql password];"
  }
}
- Create a database using SQL via MySQL:
  - Using the import function under administrations select Data Import/Restore
  - Select option for Self-Contained File then navigate to root directory for file
  - Start the import
  - Refresh schema
- `$ dotnet watch build` for live changes
- Local Host 5000


## Known Bugs

- none identified

## License

GPL 3.0 or Later

## Contact Information
Min Chang: minchangmhc at gmail dot com
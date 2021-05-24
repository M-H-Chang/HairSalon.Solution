#### Min Chang

## Technologies Used

- C# / .NET 5 Framework / MySQL

## Description

This application lets the user create stylits and add clients to those stylists.

## Setup/Installation Requirements

- Get the source code: `$ git clone https://github.com/M-H-Chang/HairSalon.Solution`
- In HairSalon get your dependencies: `$ dotnet restore`
- Create a database using SQL via MySQL:
  - `CREATE DATABASE <firstname_lastname>;`
  - `USE <firstname_lastname>;`
  - `CREATE TABLE <Stylists> (<Add StylistId, StylistName columns>);`
  - `CREATE TABLE <Clients> (<Add ClientId, ClientName, StylistId columns>);`
- `$ dotnet watch build` for live changes
- Local Host 5000


## Known Bugs

- none identified

## License

GPL 3.0 or Later

## Contact Information
Min Chang: minchangmhc at gmail dot com
final project Travel Agency
Link to the project directory on google drive - https://drive.google.com/drive/folders/1axSRhhvNfvStDMiaZmZebUPXgEngPN2a?usp=sharing
presents:
ofri rom:208891804
avigail shekasta:209104314
instructions to run the project:
1.open visual studio.
2.click on open project.
3.browes for the project .sln file then click open.
4.in visual studio top bar click on debug then start without debug.
5.the web site will run on your defualt web browser.
requierments to run the projecc:
1.make sure the data base is on your local machine and configure with the ASP.NET project.
the data base need to contain the following tables:
Table flights - CREATE TABLE [dbo].[Flights](
	[country_1] [nvarchar](50) NOT NULL,
	[counrty_2] [nvarchar](50) NOT NULL,
	[Time_1] [nvarchar](20) NOT NULL,
	[Time_2] [nvarchar](20) NOT NULL,
	[Total_Number_of_seats_1] [int] NOT NULL,
	[Free_Number_of_seats_1] [int] NOT NULL,
	[Total_Number_of_seats_2] [int] NOT NULL,
	[Free_Number_of_seats_2] [int] NOT NULL,
	[Price_ticket] [real] NOT NULL,
	[Date_1] [nvarchar](20) NOT NULL,
	[Date_2] [nvarchar](20) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Flights] PRIMARY KEY CLUSTERED 
(

Table checkout - CREATE TABLE [dbo].[CheckOut](
	[Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Last_name] [nvarchar](50) NOT NULL,
	[credit_number] [nvarchar](max) NOT NULL,
	[Exp_date] [nvarchar](50) NOT NULL,
	[Cvv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CheckOut1] PRIMARY KEY CLUSTERED 
(
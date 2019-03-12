USE [master]
GO
/****** Object:  Database [CS6232_g3]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE DATABASE [CS6232_g3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CS6232_g3] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232_g3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232_g3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232_g3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232_g3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232_g3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232_g3] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232_g3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232_g3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232_g3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232_g3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232_g3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232_g3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232_g3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232_g3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232_g3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232_g3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CS6232_g3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232_g3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232_g3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232_g3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232_g3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232_g3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232_g3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232_g3] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232_g3] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232_g3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232_g3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232_g3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232_g3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CS6232_g3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CS6232_g3] SET QUERY_STORE = OFF
GO
USE [CS6232_g3]
GO
/****** Object:  Table [dbo].[administrator]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administrator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
 CONSTRAINT [PK_administrator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[scheduled_datetime] [datetime] NOT NULL,
	[reason_for_visit] [varchar](250) NOT NULL,
	[doctor_id] [int] NOT NULL,
	[patient_id] [int] NOT NULL,
 CONSTRAINT [PK_appointment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nurse]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
 CONSTRAINT [PK_nurse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personal_information_id] [int] NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[person]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[ssn] [char](9) NULL,
	[gender] [varchar](15) NOT NULL,
	[street_address] [varchar](50) NOT NULL,
	[phone] [varchar](11) NOT NULL,
	[zipcode] [varchar](5) NOT NULL,
 CONSTRAINT [PK_personal_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialty]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[specialty] [varchar](50) NOT NULL,
	[doctor_id] [int] NOT NULL,
 CONSTRAINT [PK_specialty] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[visit_id] [int] NOT NULL,
	[date_performed] [date] NOT NULL,
	[date_available] [date] NULL,
	[test_code_id] [int] NOT NULL,
	[abnormal_result] [tinyint] NULL,
	[result] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test_code]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_code](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](5) NOT NULL,
	[description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_test_code] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[person_id] [int] NOT NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visit]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[visit_datetime] [datetime] NOT NULL,
	[weight] [decimal](18, 0) NULL,
	[bp_systolic] [int] NULL,
	[bp_diastolic] [int] NULL,
	[body_temp] [decimal](18, 0) NULL,
	[pulse] [int] NULL,
	[symptoms] [varchar](500) NULL,
	[checkup_info] [varchar](500) NULL,
	[nurse_id] [int] NOT NULL,
	[appointment_id] [int] NOT NULL,
	[initial_diagnosis] [varchar](500) NULL,
	[final_diagnosis] [varchar](500) NULL,
 CONSTRAINT [PK_visit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zipcode]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zipcode](
	[zipcode] [varchar](5) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](2) NOT NULL,
 CONSTRAINT [PK_zipcode] PRIMARY KEY CLUSTERED 
(
	[zipcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[administrator] ON 

INSERT [dbo].[administrator] ([id], [person_id]) VALUES (1, 30)
INSERT [dbo].[administrator] ([id], [person_id]) VALUES (2, 71)
SET IDENTITY_INSERT [dbo].[administrator] OFF
SET IDENTITY_INSERT [dbo].[appointment] ON 

INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (1, CAST(N'1964-09-02T19:47:00.980' AS DateTime), N'novum quad Versus estum. in imaginator pars dolorum quo nomen essit. novum esset Multum non Tam fecundio, glavans vobis plorum e', 7, 4)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (2, CAST(N'1984-06-05T00:55:26.527' AS DateTime), N'essit. quo Sed non eggredior. si regit, manifestum ut vobis manifestum regit, Sed Et linguens linguens e', 7, 4)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (3, CAST(N'1965-09-09T17:24:56.410' AS DateTime), N'vantis. manifestum quoque glavans trepicandor quartu et transit. sed parte bono quis plurissimum Tam homo,', 7, 10)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (4, CAST(N'1971-07-18T09:42:18.407' AS DateTime), N'bono non esset non nomen essit. rarendum et dolorum et Quad pladior linguens quad Et pars quo, homo,', 7, 10)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (5, CAST(N'2006-11-03T05:40:20.217' AS DateTime), N'gravis quoque novum quorum manifestum si plorum essit. et dolorum Pro plorum Tam trepicandor volcans quo et', 7, 8)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (6, CAST(N'1969-09-23T16:10:01.260' AS DateTime), N'brevens, eudis volcans et et fecit. gravis dolorum quis e habitatio et vobis glavans Multum e apparens', 7, 5)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (7, CAST(N'1962-01-11T09:42:22.370' AS DateTime), N'essit. si Tam Id sed essit. manifestum quo, quad et si esset quad Sed transit. essit. funem. Longam, si', 7, 5)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (8, CAST(N'1989-10-11T04:15:02.543' AS DateTime), N'dolorum e volcans nomen bono homo, habitatio quis linguens fecit, venit. pladior glavans non quorum plurissimum nomen quoque', 7, 9)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (9, CAST(N'1996-04-17T09:44:16.903' AS DateTime), N'si fecit, rarendum non vobis nomen pladior gravis nomen quo, brevens, quad gravis quad gravis rarendum vobis apparens quad', 1, 9)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (10, CAST(N'1966-05-26T02:05:45.747' AS DateTime), N'manifestum novum egreddior regit, rarendum quad dolorum linguens dolorum Tam Id quantare non et e eggredior. si', 1, 7)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (11, CAST(N'1977-03-28T02:59:03.847' AS DateTime), N'trepicandor egreddior fecundio, quad quad quantare quo regit, homo, quo Sed e non et Pro Multum travissimantor', 1, 2)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (12, CAST(N'1991-06-24T14:28:35.897' AS DateTime), N'quo quo novum novum pladior fecit, plurissimum e rarendum quo, si eggredior. non linguens linguens quis', 1, 2)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (13, CAST(N'1967-11-07T16:58:26.373' AS DateTime), N'Quad fecit, Et esset fecundio, dolorum plurissimum rarendum eudis et pars parte volcans novum quis dolorum plurissimum', 1, 1)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (14, CAST(N'1993-03-19T07:58:42.747' AS DateTime), N'si Versus e pladior e egreddior non quo, vobis et fecit. regit, nomen quis et Tam quis quis sed bono', 1, 1)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (15, CAST(N'1977-12-07T22:52:34.143' AS DateTime), N'et gravum et quartu manifestum rarendum delerium. quad quoque dolorum nomen vobis egreddior delerium. si manifestum pladior', 1, 6)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (16, CAST(N'1962-01-14T06:53:07.310' AS DateTime), N'travissimantor quartu linguens quad estum. quad nomen non Id pars ut e quad rarendum non nomen dolorum Sed novum vobis', 1, 6)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (17, CAST(N'1993-03-04T19:58:23.150' AS DateTime), N'quad quoque si eudis vobis et non parte pars non egreddior pars et fecundio, nomen et nomen novum quoque manifestum esset', 6, 3)
INSERT [dbo].[appointment] ([id], [scheduled_datetime], [reason_for_visit], [doctor_id], [patient_id]) VALUES (18, CAST(N'1980-03-16T14:16:18.100' AS DateTime), N'quartu quad vobis homo, dolorum brevens, nomen estis quis brevens, transit. vantis. novum et et apparens', 6, 3)
SET IDENTITY_INSERT [dbo].[appointment] OFF
SET IDENTITY_INSERT [dbo].[doctor] ON 

INSERT [dbo].[doctor] ([id], [person_id]) VALUES (5, 20)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (10, 26)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (8, 43)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (4, 55)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (6, 56)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (1, 73)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (3, 77)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (2, 82)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (7, 92)
INSERT [dbo].[doctor] ([id], [person_id]) VALUES (9, 98)
SET IDENTITY_INSERT [dbo].[doctor] OFF
SET IDENTITY_INSERT [dbo].[nurse] ON 

INSERT [dbo].[nurse] ([id], [person_id]) VALUES (7, 4)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (4, 6)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (5, 37)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (1, 39)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (3, 66)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (6, 69)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (9, 84)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (10, 85)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (2, 88)
INSERT [dbo].[nurse] ([id], [person_id]) VALUES (8, 96)
SET IDENTITY_INSERT [dbo].[nurse] OFF
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (1, 23)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (9, 27)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (2, 60)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (5, 64)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (8, 69)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (10, 78)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (7, 79)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (3, 82)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (4, 86)
INSERT [dbo].[patient] ([id], [personal_information_id]) VALUES (6, 90)
SET IDENTITY_INSERT [dbo].[patient] OFF
SET IDENTITY_INSERT [dbo].[person] ON 

INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (1, N'Prince', N'Jane', CAST(N'1994-01-18' AS Date), N'W0WT4UB  ', N'6P3', N'343 New Avenue', N'7157188676', N'74920')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (2, N'Lopez', N'Damion', CAST(N'1986-06-01' AS Date), N'RF       ', N'ZATV455B61S', N'15 Green Clarendon Drive', N'4056460473', N'80694')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (3, N'Bray', N'Danny', CAST(N'1970-08-18' AS Date), N'MOC69N   ', N'AMPDG', N'40 Green First Freeway', N'2102727299', N'76962')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (4, N'Sims', N'Darla', CAST(N'1990-07-04' AS Date), N'B87L     ', N'QK1', N'90 Green Cowley Boulevard', N'6029554276', N'60346')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (5, N'Moody', N'Clay', CAST(N'1973-12-24' AS Date), N'GEDCAM   ', N'YKFLPX7RNMLM', N'39 White Fabien Freeway', N'1186789705', N'25837')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (6, N'Ballard', N'David', CAST(N'1966-10-19' AS Date), N'FJ6FLSX  ', N'5H51VTU570I', N'52 New Drive', N'9477558668', N'60346')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (7, N'Shaffer', N'Darcy', CAST(N'1975-01-22' AS Date), N'OD7KX    ', N'8RQC', N'24 West White Oak Street', N'1878375150', N'91510')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (8, N'David', N'Tonia', CAST(N'1998-01-30' AS Date), N'YH54VE   ', N'ZJ9RB9GJ', N'61 Cowley Parkway', N'1153276046', N'44283')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (9, N'Navarro', N'Margaret', CAST(N'1988-01-18' AS Date), N'IJI2BMF  ', N'74FE62ND', N'467 West New Parkway', N'1045286001', N'98371')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (10, N'Hobbs', N'Jenifer', CAST(N'1974-10-29' AS Date), N'RI14J    ', N'WAPUQ7', N'95 Green Milton Boulevard', N'7883163461', N'32848')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (11, N'Lane', N'Keith', CAST(N'1990-07-26' AS Date), N'         ', N'RKXVG6HF7M2DHT7', N'187 Clarendon Blvd.', N'4097311612', N'34572')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (12, N'Lee', N'Tricia', CAST(N'1985-01-31' AS Date), N'G        ', N'IFMP', N'596 Milton Avenue', N'3130554962', N'45491')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (13, N'Massey', N'Gina', CAST(N'2004-11-17' AS Date), N'QDB7WY1  ', N'TTF2', N'341 Nobel Drive', N'2036728720', N'64731')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (14, N'Alexander', N'Marissa', CAST(N'1961-04-26' AS Date), N'N0I      ', N'6', N'39 Green Second Parkway', N'7051718477', N'45491')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (15, N'Howell', N'Tasha', CAST(N'1988-09-29' AS Date), N'7        ', N'1Q', N'31 East White New Street', N'1581230002', N'99541')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (16, N'Beck', N'Kathy', CAST(N'1982-12-20' AS Date), N'E8YWZNC  ', N'T2PKPJN01NZ6J', N'67 Old Boulevard', N'3934157497', N'05217')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (17, N'Key', N'Gustavo', CAST(N'1999-02-18' AS Date), N'5H0XV5G  ', N'AVQOL7E4HBXQHSK', N'81 White First Way', N'8005505648', N'85607')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (18, N'Pineda', N'Bernard', CAST(N'1955-06-24' AS Date), N'D41WDH   ', N'', N'983 Rocky First Way', N'9730534233', N'99823')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (19, N'Shaffer', N'Candice', CAST(N'1983-10-10' AS Date), N'2MLHGNMXJ', N'DHH8B', N'21 East Rocky Nobel Parkway', N'6271924297', N'71946')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (20, N'Rose', N'Elena', CAST(N'2004-11-16' AS Date), N'9MWK     ', N'8I6', N'87 Green Old Avenue', N'4273961731', N'35718')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (21, N'Clements', N'Heather', CAST(N'1958-11-20' AS Date), N'UTWG8U6Z2', N'FK', N'491 New Boulevard', N'4358698741', N'80694')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (22, N'Logan', N'Dana', CAST(N'2005-07-25' AS Date), N'6        ', N'RMAFS0F5GIQPKE', N'59 Rocky Oak Freeway', N'4514490145', N'82996')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (23, N'Bennett', N'Rolando', CAST(N'1975-11-16' AS Date), N'NEUBUX6  ', N'Z1VG1', N'736 First Boulevard', N'3725324999', N'99823')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (24, N'Dominguez', N'Barbara', CAST(N'1954-11-02' AS Date), N'A        ', N'', N'55 South Rocky Nobel Street', N'2704264166', N'05217')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (25, N'Mills', N'Kelly', CAST(N'1972-11-23' AS Date), N'5WMJKG   ', N'P2RY4I', N'635 White Hague Freeway', N'8181183224', N'72950')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (26, N'Norman', N'Virginia', CAST(N'1994-01-29' AS Date), N'LJJTB9   ', N'FCZJEKBG20KJH', N'502 Hague Boulevard', N'1866251243', N'59264')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (27, N'Noble', N'Henry', CAST(N'1980-09-03' AS Date), N'0X98VNJ  ', N'Y', N'720 White Second St.', N'1905584180', N'95720')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (28, N'Pope', N'Maribel', CAST(N'1992-11-09' AS Date), N'9EY      ', N'JQC', N'797 Green Hague Road', N'7044711714', N'72295')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (29, N'Waters', N'Wendi', CAST(N'1953-05-23' AS Date), N'P8EP     ', N'J4ZZJ2', N'845 South Old Avenue', N'4029400993', N'60234')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (30, N'Lane', N'Joel', CAST(N'1998-02-16' AS Date), N'PR       ', N'X8NUVXZ15Q66U', N'57 Rocky Second Boulevard', N'7607794562', N'07683')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (31, N'Owens', N'Vanessa', CAST(N'2000-07-24' AS Date), N'NZTO9    ', N'JZVVHIPQA8', N'92 West Green Hague Way', N'7251840707', N'20941')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (32, N'Russo', N'Travis', CAST(N'1962-06-24' AS Date), N'LG       ', N'RWNAD0ZBFE7E', N'63 North First St.', N'4030550515', N'44935')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (33, N'Parks', N'Sherman', CAST(N'1960-01-09' AS Date), N'MGC5MB   ', N'OLIVT0DKI9Z54', N'50 Second St.', N'3564646880', N'34572')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (34, N'Butler', N'Kevin', CAST(N'1961-03-03' AS Date), N'         ', N'1KF6XFM31CQSQ6', N'66 Rocky New Road', N'0958982956', N'99541')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (35, N'Hardy', N'Brian', CAST(N'1957-01-24' AS Date), N'Y0N      ', N'EX', N'74 Rocky Fabien Way', N'0696334949', N'67128')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (36, N'Gibbs', N'Randal', CAST(N'1984-01-26' AS Date), N'J        ', N'KP7VZTX9VN9', N'58 South White Old Drive', N'4302474623', N'76962')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (37, N'Lambert', N'Benjamin', CAST(N'2005-11-04' AS Date), N'8K1      ', N'N49XX', N'968 Green Nobel Freeway', N'2756045719', N'05217')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (38, N'Brandt', N'Tanisha', CAST(N'1966-08-09' AS Date), N'56       ', N'Z7A', N'39 Oak Freeway', N'5669075544', N'38686')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (39, N'Bird', N'Ruth', CAST(N'1968-09-28' AS Date), N'T        ', N'', N'22 Old Boulevard', N'1910641663', N'37525')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (40, N'Gamble', N'Chandra', CAST(N'1959-05-23' AS Date), N'JSL03KY5 ', N'LK651A6', N'22 White Nobel St.', N'4425899058', N'96771')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (41, N'Hughes', N'Donald', CAST(N'1986-12-27' AS Date), N'29NXMD2XH', N'3COK', N'75 Clarendon Way', N'1511069589', N'51405')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (42, N'Cortez', N'Josephine', CAST(N'2003-10-19' AS Date), N'RP4M3CK47', N'W5KM9NJZU', N'41 Rocky Fabien St.', N'5520026236', N'74380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (43, N'Rubio', N'Ricky', CAST(N'1953-06-24' AS Date), N'         ', N'PLJT83FQ0', N'814 Cowley Freeway', N'5568674885', N'10461')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (44, N'Mathis', N'Lindsay', CAST(N'1997-08-29' AS Date), N'9ISBT    ', N'5MBTOV', N'588 North Milton St.', N'5639393485', N'32848')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (45, N'Reilly', N'Allen', CAST(N'1998-11-02' AS Date), N'0AT3ZU   ', N'', N'183 Rocky Fabien Avenue', N'5692705127', N'91510')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (46, N'Powers', N'Annette', CAST(N'1956-08-20' AS Date), NULL, N'X5AY', N'26 Green Clarendon Freeway', N'2226385521', N'79990')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (47, N'Tyler', N'Jerrod', CAST(N'1961-08-31' AS Date), N'RAZ      ', N'T0R6DXM', N'27 Green Hague Boulevard', N'9601860049', N'36175')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (48, N'Henderson', N'Karin', CAST(N'1960-04-12' AS Date), N'XOO7PS   ', N'KQ5GJIHY', N'52 East Green Clarendon Avenue', N'1425181763', N'44935')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (49, N'Bender', N'Katie', CAST(N'1953-11-03' AS Date), N'FE5IOJGQ6', N'OMOZ9', N'56 Milton Boulevard', N'4751747324', N'17998')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (50, N'Mc Cormick', N'Leigh', CAST(N'1993-08-31' AS Date), N'TRUL     ', N'UQYEOU1P4Q1', N'47 Green Milton St.', N'4081802325', N'27373')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (51, N'Ramirez', N'Jo', CAST(N'1968-01-20' AS Date), N'0        ', N'SGW2', N'11 Hague Street', N'1319474930', N'41005')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (52, N'Good', N'James', CAST(N'1998-08-22' AS Date), N'MNYRUIVSC', N'D5L', N'238 North White Second Boulevard', N'7571056730', N'74380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (53, N'Haynes', N'Marisa', CAST(N'1996-10-06' AS Date), N'6JA8JQQ  ', N'5', N'744 North Nobel Way', N'8273255179', N'61611')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (54, N'Zavala', N'Anitra', CAST(N'1971-12-13' AS Date), N'         ', N'4DHQAHOAKK', N'42 Nobel Way', N'7661510539', N'47420')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (55, N'Davila', N'Kevin', CAST(N'1970-10-11' AS Date), N'7IMAM    ', N'XGEJ', N'916 Green Old Parkway', N'2945875462', N'23927')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (56, N'Franklin', N'Margaret', CAST(N'1996-06-25' AS Date), N'N1XI5P4  ', N'', N'244 South Cowley Drive', N'1463932995', N'85813')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (57, N'Bird', N'Lakeisha', CAST(N'1963-07-18' AS Date), N'ML2      ', N'I11QHS', N'73 North White Fabien Parkway', N'8827419670', N'80752')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (58, N'Boone', N'Randy', CAST(N'1968-10-17' AS Date), N'A        ', N'HQMS', N'950 White Nobel Avenue', N'9101073659', N'75054')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (59, N'Ross', N'Sheila', CAST(N'1970-08-11' AS Date), N'W9PB     ', N'UNEPDT064R8', N'411 First Way', N'3549599908', N'84209')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (60, N'Jackson', N'Susan', CAST(N'1987-11-26' AS Date), N'96WB913  ', N'GH52JFN9', N'88 West Green Old St.', N'2138800270', N'71946')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (61, N'Conway', N'Priscilla', CAST(N'1994-02-15' AS Date), N'ETJ      ', N'J3U4MNKS8', N'85 Green First St.', N'8892680679', N'63152')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (62, N'White', N'Eileen', CAST(N'1990-03-14' AS Date), N'CBI6GYA7K', N'UV0PWB7', N'97 White Nobel Avenue', N'2152938632', N'27121')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (63, N'Espinoza', N'Roderick', CAST(N'1997-09-10' AS Date), N'WNNGWGCIX', N'LISHRTKA0NNYAY', N'941 East Oak Boulevard', N'7833706014', N'89380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (64, N'Daniels', N'Monique', CAST(N'1997-12-02' AS Date), N'A        ', N'VAKKLR5', N'49 South Rocky New Street', N'3925526930', N'89380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (65, N'Wilkins', N'Candice', CAST(N'1982-04-06' AS Date), N'D2RPNH10P', N'EV6DLFR8Q', N'49 North Rocky Hague Parkway', N'7632529017', N'07683')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (66, N'Huff', N'Vincent', CAST(N'1981-02-01' AS Date), N'3        ', N'D2RM2B1JCN', N'679 East Green Cowley Avenue', N'0930445416', N'82419')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (67, N'Huang', N'Tracie', CAST(N'1978-01-23' AS Date), N'PHRD     ', N'5', N'257 Rocky First Way', N'7948019395', N'19863')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (68, N'Hartman', N'Benjamin', CAST(N'1996-09-16' AS Date), N'BF3P7    ', N'9WC4EBQLBF3', N'90 White Old Parkway', N'5219035389', N'67128')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (69, N'Pruitt', N'Moses', CAST(N'1957-04-03' AS Date), N'9OS4MCW  ', N'LKFZU8FWM', N'81 Old Way', N'8632138398', N'80752')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (70, N'Buckley', N'Jamal', CAST(N'1957-09-04' AS Date), N'P        ', N'W', N'264 Nobel Street', N'1695409231', N'27121')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (71, N'Bright', N'Nikki', CAST(N'1985-02-15' AS Date), N'CY       ', N'879', N'719 Rocky New Freeway', N'1385511597', N'99823')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (72, N'Griffin', N'Esther', CAST(N'1985-07-12' AS Date), N'FQAT5    ', N'2FII8LX', N'87 Milton Avenue', N'7279259733', N'47420')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (73, N'Frye', N'Ross', CAST(N'1994-09-25' AS Date), N'C3J3     ', N'9BCWZP2M', N'33 West White New Freeway', N'4864000925', N'67677')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (74, N'Velasquez', N'Neal', CAST(N'1977-05-21' AS Date), N'FO       ', N'8HRLK', N'31 East Rocky New Freeway', N'3710937841', N'74380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (75, N'Long', N'Orlando', CAST(N'1970-11-21' AS Date), N'         ', N'EH9NBZKW', N'44 Second Drive', N'1656581221', N'80059')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (76, N'French', N'Angela', CAST(N'1963-02-02' AS Date), N'ME7A5SH1U', N'27JWWL50MZPJ', N'722 North Cowley Way', N'9632418879', N'07843')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (77, N'Castaneda', N'Erick', CAST(N'2005-02-01' AS Date), N'FNSXDU   ', N'I', N'692 Fabien Street', N'3040278427', N'74920')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (78, N'Lindsey', N'Chandra', CAST(N'1986-03-19' AS Date), N'ICYP1L   ', N'W', N'580 Green Second Drive', N'6604889699', N'74380')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (79, N'Decker', N'Simon', CAST(N'1963-12-31' AS Date), N'         ', N'94', N'994 South Milton Boulevard', N'9017822824', N'11062')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (80, N'Frye', N'Gene', CAST(N'1969-04-05' AS Date), N'U6PK1PXE ', N'', N'65 North Old Street', N'0302197515', N'91510')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (81, N'Carney', N'Ira', CAST(N'1985-05-31' AS Date), N'9        ', N'HYHX', N'305 Hague Road', N'9073572704', N'20941')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (82, N'Small', N'Joanne', CAST(N'1973-05-24' AS Date), N'I1SNXO   ', N'0ZXLGOE5TS55P', N'834 East Rocky Oak Blvd.', N'3438777488', N'46741')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (83, N'Khan', N'William', CAST(N'1992-01-07' AS Date), N'GQWK5    ', N'3H4MUYIZCQGPFWG', N'683 East Fabien Boulevard', N'7065979228', N'60234')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (84, N'Mc Knight', N'Kevin', CAST(N'1967-09-22' AS Date), N'8DWCZCKS ', N'92YSL6', N'70 Hague Way', N'7765068452', N'35829')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (85, N'Rose', N'Hannah', CAST(N'1983-01-28' AS Date), N'4BLSGSM  ', N'1I14QO4RPK2W9DC', N'56 East Green Clarendon Freeway', N'3816847790', N'71946')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (86, N'Cunningham', N'Janice', CAST(N'1954-12-04' AS Date), N'9XO2C    ', N'ZM0M7', N'81 White Fabien Blvd.', N'0722160059', N'45491')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (87, N'Santiago', N'Ramiro', CAST(N'1973-09-18' AS Date), N'PO00L5   ', N'R8IP8I37XGWE3', N'572 Hague Avenue', N'8295095917', N'82419')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (88, N'O''Connor', N'Tyrone', CAST(N'1996-01-27' AS Date), N'9A1JCOT  ', N'TTRA7ZQ5D067XF', N'50 Rocky New Parkway', N'3369779924', N'80059')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (89, N'Herrera', N'Walter', CAST(N'1998-05-23' AS Date), N'EIOI     ', N'', N'95 White New Boulevard', N'4647629297', N'79990')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (90, N'Tucker', N'Sally', CAST(N'1968-07-31' AS Date), N'WH158MU  ', N'KJUVQSM1GLNIM', N'532 Hague Parkway', N'8147167250', N'76962')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (91, N'Underwood', N'Nora', CAST(N'1973-07-12' AS Date), N'NMH3W16  ', N'ZUA8T5', N'628 West White Hague Avenue', N'7152656232', N'95720')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (92, N'Berger', N'Alma', CAST(N'1990-01-18' AS Date), N'ZBY      ', N'QF', N'22 South Green Cowley St.', N'5580728684', N'34572')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (93, N'Villa', N'Summer', CAST(N'2003-12-29' AS Date), N'1V1      ', N'ELVII1LO7SWD', N'22 Green Fabien Drive', N'1753818010', N'59264')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (94, N'Madden', N'Eduardo', CAST(N'1988-11-03' AS Date), N'944S     ', N'7D17QU', N'687 Green Milton Avenue', N'2288025084', N'70886')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (95, N'Chen', N'Craig', CAST(N'1973-04-06' AS Date), N'         ', N'C8JR0C', N'929 New Parkway', N'8834755789', N'36175')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (96, N'Peterson', N'Jay', CAST(N'2004-10-14' AS Date), NULL, N'P', N'63 Oak Road', N'4045734986', N'34149')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (97, N'Davis', N'Leticia', CAST(N'1959-02-08' AS Date), N'F        ', N'TAT3MG', N'57 North Green Nobel Street', N'7147720339', N'80752')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (98, N'Wu', N'Marcy', CAST(N'1963-07-24' AS Date), N'         ', N'W4IEZYATPMA2U', N'708 White Clarendon Road', N'4584025119', N'27373')
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (99, N'Edwards', N'Kelvin', CAST(N'1968-05-25' AS Date), N'3E8N     ', N'X4W', N'917 Fabien Way', N'0019429369', N'20941')
GO
INSERT [dbo].[person] ([id], [last_name], [first_name], [date_of_birth], [ssn], [gender], [street_address], [phone], [zipcode]) VALUES (100, N'Silva', N'Amie', CAST(N'1970-10-02' AS Date), N'S        ', N'W6', N'176 West Second Boulevard', N'1787063727', N'07570')
SET IDENTITY_INSERT [dbo].[person] OFF
SET IDENTITY_INSERT [dbo].[specialty] ON 

INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (1, N'YNN3E7Y5O0J65XMWW5SCVJLX3JZ49J', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (2, N'91O532LTL506WRTUHA4DF1IIF1QZV7UV5Z95GRITBB77UCO5AO', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (3, N'T55L8J5Q2CLYEA51XIODQRA23', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (4, N'AO2CKP6P', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (5, N'PZE0MB0GGPDTWPBRMLBR1U3IE8GOPRWSOAF1IH21QBTCP0EZRK', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (6, N'3U', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (7, N'YVW', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (8, N'MDUCQ', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (9, N'TL4M9985JA1Q0QS', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (10, N'UHW4TSXRCK4MVO6DK4J4WRPHCSKKV7U', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (11, N'38JDFLV1NDAP5L9V3N5W6NH2SFS08DV4PYIN4TYY8', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (12, N'GIHZCQIOG82YZGQHK0TUSAH5', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (13, N'', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (14, N'2MQAP6NO6ZKS21IJWN2RY2WN8Y5EP50B05NVX6IV', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (15, N'B9RWSXRC9EU3780Q31Q19Y0Y8SXEMMQ46HM', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (16, N'5QF0D1GR58', 5)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (17, N'WN5T4ST1D8', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (18, N'N0ZDQNOQW', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (19, N'M7KDLQN7I9S0Z', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (20, N'RGSLCCG9KC2F10BT3FB2AFKGJ26TUZ0N0ZM9U3EKACN8A5OMW', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (21, N'5DPXQBVB2A6MEKB', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (22, N'F2E2Y00RRXSC6DDJX5TNX28BDJ14', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (23, N'NX2XUQM8UQ5DY5TIJ5OWMO8RNHCT3OF', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (24, N'', 5)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (25, N'D3ZQFB', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (26, N'QB3FOAZXFSTDC7QYOB9', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (27, N'ET45A6HK1TS4T26BLT2DHFEBU1NNM4AE', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (28, N'Y7W6X4ISFVL0PK90FDV8VVZETA9IUXXIDYUUA4NOKK', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (29, N'KSA5HDM7RF5A38HDNVZYHY3MQQFQAP6OBSFMI5S57Q537OQ', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (30, N'SR0TLMKMPOEQYVW28HY', 5)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (31, N'SVUH3TQRSZE2ZSYJOD3P8TWUQ17CT3VPPFT', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (32, N'WJPR', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (33, N'TTQ9CR', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (34, N'WDDUE92ZY0Q2MEXP3PCKY2N5OCTEZ6KEA1FGP1BGCU', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (35, N'VS', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (36, N'4HV4MKZ66UQ862GNZ', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (37, N'FCRLYGZ2DW7', 5)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (38, N'4RD07CJVK0E3ULQHU90PU6GFVIIE5J72Z2QYU5U3447F', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (39, N'ORD', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (40, N'H83WI9YBX5OT4', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (41, N'0TB4SVRNOEWKQY', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (42, N'I7R5OOB36HSRNX05A0E7LLKZIYUJP0XJZAFYWOF1OQ5NZ33PO', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (43, N'MKCRFWMSNPUSE6J9RDH29LKCIVFXZEV4VGED68', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (44, N'IB31Q7W', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (45, N'Z3QBP7LZ0ZZ8JGPT8UPXXS52IIZR5KU5M', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (46, N'GT825W9GDD60B1MASVHYE7Y', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (47, N'S78UUF5UL00VK6PT', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (48, N'HERVI7X4USYNN48UK', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (49, N'XNEMX8CEA1QPM5NBWS7SAZAPZN67YVR10WR5', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (50, N'VGJJ3XWE56TZC8GNRZYDPMA15GE9PPQEH21BN9', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (51, N'2DAUHD7LNBD9WTSJ96HENINPGGFHA64ZHTWZERTOX', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (52, N'QYBFTKP', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (53, N'S56VJJQLE0YPBG7DR3XT5HDT', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (54, N'TRPD0MUSREYTLAC9TDSP8I9QYOQ', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (55, N'VDARCFPR17EE4WJ18', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (56, N'5SKKB3K38AIYFCV7WE47G6', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (57, N'K8MZELBZ7IEIX2B16696F9', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (58, N'R1IW04X13Y80CP46IXAAG0UX4KDX0704B5UXVOBUAHBJP2Z', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (59, N'20Q94ZMR7KSFR00VY4P6V6BTLG0ZPA82L1', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (60, N'0GQZBJ', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (61, N'QAWW29GFKKCTGVOWNOZN2WCPTQ50E74DNSG0XPEQI9QNPRK', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (62, N'', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (63, N'K2BCV0TY62C4F0CGZ6NEOZYA94S6PZ255O', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (64, N'4T1RRN2', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (65, N'N2L28D7QLXLM', 5)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (66, N'412R8N9606YQ57NXEVRM7', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (67, N'7N1JSH9G8K2A0RY0JZTKMVMB35KS71T0DTT', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (68, N'POURXJXEOV7VYECSTNOC0PGMXG97', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (69, N'1X6YJBU41N3X', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (70, N'N7YOUSP17P4HFZ88TGAQNNY0XF3HNRZLES28O8M', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (71, N'IPU71G4BMW77S7L09XREP7DFQJ2', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (72, N'W0JLTT8XSRYGBRVQJS', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (73, N'662ZQG7RAC', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (74, N'HIDGFLCMDZZN7HZB3YCNWXRWGT1T4M', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (75, N'YLD9G2UC9EXFT7JVHR54TXOIJRH0LKJHRW02T7I88M39YIY', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (76, N'WYJ2ZH91WVQPKTQ', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (77, N'UFOW6G298WW7TFJ1', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (78, N'S3N0HI9NZ', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (79, N'XHTOEVEEJT1IGWAT2K27GBOVRP3NDWE86A4RE8HBE1', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (80, N'8RANRQNFPLSPMTXWPSR1MFTB6RJEU3QSFBG4H2BXPGPNEKHXGB', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (81, N'IN0DSYZHZ7', 10)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (82, N'LLUZAADTFMGTB5Q6WL9LYIB74EXN6HLCPGV3SE', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (83, N'7KNW52TP72R2VPMA3AMVVDPMX144UAMDIB20', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (84, N'L55BPPLEEPM36RS6JETU0Y4XPUXFEKKML0H5', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (85, N'K6N48ICI0OIT7YX969N18LUS6ZU', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (86, N'ZI6ANPZ76QSFRFO6EL7LMDFQU38YBUX8O7III86HZP2F', 6)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (87, N'79TWOEKS9IM2FGKH0WCSKRJW6O', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (88, N'FPMXBZ8MUE2NFCFFPWF2SM0YSQMXGPWQZ852MLA36T', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (89, N'2Y9WF4BU0QMDTP', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (90, N'4LCB64HCN77DS4LCV', 2)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (91, N'W', 9)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (92, N'ZJT', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (93, N'T4VWZDUCCZGPQVMLLMMO8RJQFEREXSOLR5I28LCAC', 1)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (94, N'0TNVMZC', 3)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (95, N'CDW4X2K4GLLFFKAVYKDJCZ9BCEQP3JRR2MGA', 4)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (96, N'M8GH34ROWFFIRX1M', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (97, N'XC3LSJBV1X', 7)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (98, N'UDS4Z7BCX', 8)
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (99, N'9UINFZB7BMQ49P372TO4M27YTIMAIJLPPQOHKXCK0NQA2Q33', 10)
GO
INSERT [dbo].[specialty] ([id], [specialty], [doctor_id]) VALUES (100, N'S5INSE7NKTWD0OS10FI1LM4H44YBWV3FJ9QE31WCHU04F60Z', 5)
SET IDENTITY_INSERT [dbo].[specialty] OFF
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (16, CAST(N'2007-01-26' AS Date), CAST(N'2007-01-29' AS Date), 11, 0, N'commodo sodales lacus velit, Nunc amet faucibus. fames ac volutpat. sollicitudin. et sapien. pharetra')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (13, CAST(N'2005-09-27' AS Date), CAST(N'2005-09-27' AS Date), 12, 1, N'faucibus. dui sodales ipsum primis Pellentesque sed. enim, fermentum orci viverra ipsum sapien. porta lacinia.')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (14, CAST(N'2000-10-30' AS Date), CAST(N'2000-11-05' AS Date), 12, 0, N'adipiscing sapien. velit Ut maximus Sed consectetur sollicitudin. condimentum dolor Ut amet dui justo, justo,')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (11, CAST(N'2003-06-02' AS Date), CAST(N'2003-06-07' AS Date), 10, 0, N'interdum aliquet. ac faucibus. Nunc ac, dui dui consectetur nisl, nec lacinia. Nunc Aliquam maximus rhoncus')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (4, CAST(N'2006-12-21' AS Date), CAST(N'2006-12-23' AS Date), 6, 0, N'nec aliquet nisl, vehicula eros, Aliquam elit. vitae. urna adipiscing sodales eget, amet consectetur')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (2, CAST(N'2001-03-03' AS Date), CAST(N'2001-03-03' AS Date), 10, 1, N'urna condimentum adipiscing sed. lobortis vehicula congue ac sed. tincidunt dui consectetur Pellentesque tortor,')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (12, CAST(N'2003-08-21' AS Date), CAST(N'2003-08-28' AS Date), 13, 1, N'interdum Ut metus erat Interdum enim, in scelerisque sodales Pellentesque Sed non. eget.

Suspendisse')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (1, CAST(N'2001-07-15' AS Date), CAST(N'2001-07-20' AS Date), 8, 1, N'sit et ipsum, id ac volutpat. consectetur ac enim, primis dui dui et erat volutpat. velit, non. primis et')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (17, CAST(N'2007-09-06' AS Date), CAST(N'2007-09-06' AS Date), 14, 0, N'et in posuere auctor consectetur commodo metus Ut fames maximus metus consectetur in urna orci volutpat.')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (7, CAST(N'2005-03-25' AS Date), CAST(N'2005-03-25' AS Date), 7, NULL, N'ac, neque. Nam enim orci Interdum urna aliquet lobortis orci congue velit, fermentum Aliquam malesuada nec viverra Aliquam')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (6, CAST(N'2001-03-12' AS Date), CAST(N'2001-03-19' AS Date), 7, 1, N'purus. lobortis congue Donec orci consectetur dui mauris vehicula vel enim tincidunt ipsum, adipiscing Aliquam')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (5, CAST(N'2006-02-10' AS Date), CAST(N'2006-02-14' AS Date), 9, 0, N'Pellentesque dolor volutpat. sodales eget.

Suspendisse ac orci Aliquam lacus. ac malesuada lacinia. metus')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (8, CAST(N'2006-07-20' AS Date), CAST(N'2006-07-24' AS Date), 10, 0, N'scelerisque ipsum volutpat Aliquam orci ipsum metus sit fermentum sed. amet, aliquet Phasellus ac Proin')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (9, CAST(N'2003-03-25' AS Date), CAST(N'2003-04-01' AS Date), 9, 1, N'sollicitudin. rhoncus Sed auctor velit vel, Ut aliquet. erat viverra ac eget sapien. maximus metus eget.

Suspendisse')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (15, CAST(N'2003-02-25' AS Date), CAST(N'2003-02-25' AS Date), 14, 1, N'dolor Aliquam maximus ac metus Sed malesuada Nunc congue consectetur in ac eget ullamcorper dui mauris')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (10, CAST(N'2005-12-28' AS Date), CAST(N'2005-12-30' AS Date), 1, 0, N'fermentum ipsum, felis. Nunc enim consectetur ac viverra convallis facilisis Pellentesque non. consectetur pulvinar tincidunt')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (3, CAST(N'2006-01-28' AS Date), CAST(N'2006-01-29' AS Date), 13, 1, N'porta justo, Nunc posuere aliquet ac et volutpat urna pretium ac rhoncus sodales velit maximus orci aliquet sodales')
INSERT [dbo].[test] ([visit_id], [date_performed], [date_available], [test_code_id], [abnormal_result], [result]) VALUES (18, CAST(N'2003-04-08' AS Date), NULL, 14, 0, N'tortor, tincidunt ipsum pretium lacinia. orci erat urna volutpat Proin enim, viverra pulvinar in interdum metus')
SET IDENTITY_INSERT [dbo].[test_code] ON 

INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (1, N'CBC', N'Complete Blood Count')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (5, N'PT', N'Prothrombin Time')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (6, N'BMP', N'Basic Metabolic Panel')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (7, N'CMP', N'Comprehensive Metabolic Panel')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (8, N'LP', N'Lipid Panel')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (9, N'LVP', N'Liver Panel')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (10, N'TSH', N'Thyroid Stimulating Hormone')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (11, N'HA1C', N'Hemoglobin A1C')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (12, N'URINE', N'Urinalysis')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (13, N'FLU', N'Influenza')
INSERT [dbo].[test_code] ([id], [code], [description]) VALUES (14, N'STREP', N'Strep Culture')
SET IDENTITY_INSERT [dbo].[test_code] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (1, N'Cassandra68', N'RD198R17MC97DPFVA911XBEMQ1LKPJMISAWDFHZY4', 73)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (2, N'Diane35', N'K7Y75YY4W9R59GYEJ76GH3PRE3T2GT92WM', 82)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (3, N'Jonathan64', N'7NIVMMKMDQM1F', 77)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (4, N'Dale', N'0YRSOTHH7S24VO2ZO9MQRR0BJUXGC0R', 55)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (5, N'Mary', N'DOFVIA8S8QGQTHQWKD2DEPM9XG8TW04700Q786HD1TH0AAI2', 20)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (6, N'Hilary2', N'0WZXENO16X11EW7M9PSQJNDVOCK7MYNX6PV459MC1529G', 56)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (7, N'Chrystal', N'MX9E1KPBKDI3913HE7A3VO03H02GODL4FC', 92)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (8, N'Darin050', N'NX8X28V5IM10K9', 43)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (9, N'Eric', N'RUYCGXW6W1I9M6RDNWCGK6', 98)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (10, N'Justin', N'7V0JIGF0I64MR53WRQQBVKZ9YQ8D38T0LJR', 26)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (11, N'Chadwick07', N'GEEPH1Z2HK08K0KPTUFMVQKR81', 29)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (12, N'Joanna', N'9D407', 46)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (13, N'Elisabeth3', N'MFDB1UUKWREQ0T3O37Q34LPUNHF4PP', 63)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (14, N'Angelo874', N'JSTYK7ER0L2ZZ6078TL9XA3A1PINJEPU', 45)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (15, N'Julie818', N'EUX6VIGPFQI2LQONA7B3GF9OJXUOQ8LV7SKB20DA5', 99)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (16, N'Jerrod455', N'HJL7FZU096DRQYK9NYOSY6', 3)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (17, N'Tony', N'NVT5CK9U1YVYQ3BHUUPZEIF1MRTDELCLBDXCLUIG0CB', 86)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (18, N'Karen2', N'U0U5BGTY97Q', 100)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (19, N'Teresa321', N'FRJLQVFFMAMC5ZW0B8Z26N6LXO2YSEB3NSXTAXP4XV5', 66)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (20, N'Misty379', N'DHZBJSM08OYRKXN2SGN8YJ', 30)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (21, N'Chadwick73', N'D22QEIU5AIM7FO', 80)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (22, N'Craig09', N'F0RBVYT58C9N', 83)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (23, N'Barry42', N'G8XLURM8H27HDJN9YQ8E11NGNNRJWTD5V', 97)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (24, N'Dina487', N'O2K1DN2IXXJTIE6WAM08AEKH', 4)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (25, N'Leslie8', N'60', 67)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (26, N'Christy9', N'BNO2LVULPXCKCJ3PWT5CD0JR4M79H326MY6A9H8MJK7DAG', 49)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (27, N'Margarita2', N'RBVK', 91)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (28, N'Darrin5', N'1OPB4WXZNL4LU5XDCTFELISST5HOQGYLIX5Y9V6CK8Z', 64)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (29, N'Corey71', N'F', 50)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (30, N'Shane5', N'I4IJEIF5JIVWHYF887MI', 8)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (31, N'Hugh709', N'W0Y4HM2UCJUC8MC661G5DDN3CD8XB0SCXIM4JEWVDB7Z1J9', 17)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (32, N'Jenifer2', N'22155CPJDVS4E5ICRHFP08MR5LS26N1S3X', 40)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (33, N'Latanya1', N'8YM6KT3', 27)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (34, N'Samuel', N'NMSH7SV7J4KA', 96)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (35, N'Eduardo48', N'GA0KKNCP', 60)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (36, N'Joanna', N'Z0HA9E4B', 72)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (37, N'Floyd27', N'VXHY5D', 2)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (38, N'Abel4', N'K9BGINJM1SOMM06Q2UMR0XIH289OCCH5MGZD18BCHU9HP', 35)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (39, N'Alisa97', N'PUP7F4IL3NQUDAEV9OAJZ51SP', 32)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (40, N'Darren', N'JAA5O1RKI', 93)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (41, N'Scot', N'Y5XDM0DCM7V0XLKK66IJTXILL7BXZP', 47)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (42, N'Roderick1', N'SRZW4RXWZSO5IYIDOL3VK2ZL1NBSFPGDX328XOGT9AJR4R', 69)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (43, N'Nora', N'N2TNCVTJQSEVGF4GABB8EV9GZ49M9J7G9NNPM13H3KBGITZD4U', 11)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (44, N'Clinton', N'FSJLRSDN7L797KYMTREU88U4TKTX64WHEASNQ1', 23)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (45, N'Luke0', N'X8EV', 87)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (46, N'Lakeisha8', N'VA4VJ7', 75)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (47, N'Cherie', N'LP007YER7YGH3PQUXSBVSVHLTCY8IGXDZYASE9KOB9', 31)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (48, N'Melissa', N'YSXS55F638BEQ8F', 41)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (49, N'Latoya01', N'VZ58Q12H5FYGN8MKI6ISWJS329U5OKJJZ2OP50YXQ', 13)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (50, N'Vincent14', N'NQ7ZIVMQVKPM9B626H6XTKVEHLJXE', 19)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (51, N'Deborah3', N'7L2HW2W3QZIXOZUDSDI3UGQSL', 38)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (52, N'Sherry438', N'VSIXBOCEC3JSF462R7EWWVK3S6FBNQUAVT73LSNUKAMQU0X', 70)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (53, N'Norman7', N'WSPJEO6Z8E4590RL98WLW2HYJKBL9T9', 58)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (54, N'Ross00', N'81EU1AW6N8', 44)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (55, N'Nelson6', N'6OHKKJ0', 15)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (56, N'Dana0', N'L3BHUAR0UDKPF4CX8MWKYCPYO7', 85)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (57, N'Bridgette398', N'A1ZR28COPWJKK9A2T3IF2BKCYNGJ8DDSM0HY', 79)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (58, N'Lindsey3', N'LIH3GN0', 68)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (59, N'Caroline3', N'1CANAWV6R8YGNTFS', 84)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (60, N'Christina', N'GBJRXJSC7', 59)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (61, N'Timmy44', N'K0CMOKNWB5VXHHMUSIH7S2PAZBGX3SHB2OA5FM9', 53)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (62, N'Norma7', N'ZW3MX', 16)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (63, N'Sean526', N'U153R9U0FIB2MD3QSINKUT7GF', 89)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (64, N'testNurse', N'test', 88)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (65, N'Joy6', N'PYSHF', 7)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (66, N'Jana', N'SKFM26CSYRD4ZUGK3CF769O9LNV03AC3J9UGE1LEOHUT5', 76)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (67, N'Michael224', N'P9F4VF18XIW61EACPOEAKQZ061Q0IPEV4GXLLZEW1ACC', 12)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (68, N'Kristie01', N'8074CS6EUJZ9FYUP0P7301', 54)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (69, N'Jordan36', N'HORQ9I8AENGX1JW6X8H9X', 74)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (70, N'Clyde22', N'B6', 18)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (71, N'Jami', N'K70K48J6FPFK1XVM9LMY0T64JAVJSNJDLPPB7P9FWQMTHLVBL', 95)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (72, N'Matthew5', N'NCP7ZQ1W1UC0DR62ZC7', 36)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (73, N'Terra37', N'FJC61A6CMXEKX606NDPY9', 52)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (74, N'Brandi218', N'NE3WCUMFLJ30730J5PKOA4GR27R0EMN8A4WX', 61)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (75, N'testAdmin', N'test', 71)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (76, N'Mia12', N'ENUP4DYQAS835BZM6WP2N786NWQD1OW9SQL8', 6)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (77, N'Joshua', N'0YU4PQY0UXHLNYC5QM7EN28NKPLWYAFQQM5YVYYG96SZ8SEPJ4', 57)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (78, N'Herbert', N'3ETCYQ6J0421JIRU0SE9SOQ5H99ESAVCU9BBXA77OEYB748G', 51)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (79, N'Harold', N'YDW5U9FNOUOHSRP9P7A6FXQL6L', 9)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (80, N'Serena549', N'QFYC0SXUWY7ZZVN8GIQVN82IXYA10NB', 90)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (81, N'Elizabeth582', N'9V', 14)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (82, N'Trenton008', N'8QHOPVXSAH7AASO', 34)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (83, N'Anita38', N'3FPQHCFE2HWT9N9Q36EIYU10PFR0QN08BD8I', 37)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (84, N'Gilbert9', N'57WA2L7Y3JN7H73D6B8EO02', 24)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (85, N'Bridgett980', N'EOEHNHVFQ6YZI8V8U1MV', 48)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (86, N'Harry', N'S9GWV51Z4V44AVE6QBLN7HA84UYG0KME6HMFYKRCTGMBU', 33)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (87, N'Esther', N'7CH13Q0', 78)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (88, N'Carrie192', N'WBY8R07LYK8QYT9Y85K9URVYEANLYYGWEYKAGQT', 65)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (89, N'Traci', N'48H123WE3JTY', 62)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (90, N'Janet', N'QD4G0THDMMZ4CCZ8ZHICS4M9TVAD8IF5HQNLFTGWBD', 42)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (91, N'Thomas52', N'LHXQRW541BMDLRVN4J3436UM', 94)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (92, N'Krystal4', N'OES51L0EM0SV5IH3DEU', 10)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (93, N'Kerrie44', N'D1TK6B', 25)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (94, N'Harry433', N'79EENB43ICY0PLYZR2RZ0M1QSZQ8MK8', 28)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (95, N'Ray50', N'P', 5)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (96, N'Shirley693', N'S57L4K0FYQEE49F22HECCL7OMNKWGX4ZAHSSR5Y', 21)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (97, N'Melisa', N'YLOBBDUGTKIQKCV7YIZGZ4Y0MF3NHMAWJ7DQWWD8', 81)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (98, N'Glen646', N'32VFEFXMLT', 1)
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (99, N'Bill', N'6H7UNNPVA7Z6AL6CZ4B24QOW12K7Z50VS0Q20', 22)
GO
INSERT [dbo].[users] ([id], [username], [password], [person_id]) VALUES (100, N'Andy460', N'387HYK4WLU72YH9R4GTBSK3', 39)
SET IDENTITY_INSERT [dbo].[users] OFF
SET IDENTITY_INSERT [dbo].[visit] ON 

INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (1, CAST(N'1995-08-06T07:07:30.120' AS DateTime), CAST(819301698000000000 AS Decimal(18, 0)), 68, 173, CAST(98 AS Decimal(18, 0)), 182, N'your Enter your text here here Enter here here Enter text text your your text text Enter your your here text', N'trepicandor bono nomen brevens, bono egreddior quorum et Id venit. regit, gravis quad gravum nomen vobis', 10, 6, N'scelerisque sed. fermentum orci vehicula Nam eget, et aliquet scelerisque eget.

Suspendisse id primis', N'consectetur tincidunt pulvinar urna Donec faucibus. lobortis congue velit et primis eget.

Suspendisse tortor,')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (2, CAST(N'1958-06-20T09:25:37.917' AS DateTime), CAST(686218571000000000 AS Decimal(18, 0)), 196, 54, CAST(101 AS Decimal(18, 0)), 172, N'your Enter text Enter here text your text Enter text here text Enter text here your Enter Enter your', N'Id regit, vobis gravum nomen nomen dolorum quad gravis quo e nomen vobis Id et transit. trepicandor imaginator', 2, 10, N'eget ac vel, facilisis lacus. vehicula malesuada rhoncus eget, rhoncus pretium interdum dui ullamcorper ipsum,', NULL)
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (3, CAST(N'1974-09-25T02:15:32.650' AS DateTime), CAST(793115898000000000 AS Decimal(18, 0)), 98, 38, CAST(106 AS Decimal(18, 0)), 118, N'text text here Enter Enter your text here Enter Enter Enter your text Enter here your your here Enter', N'glavans Versus et in nomen gravis cognitio, quartu Sed et quo, homo, rarendum non quo funem. egreddior', 10, 12, N'fermentum fames sit sollicitudin. fames vitae Nunc sollicitudin. Nam velit, dui eget Pellentesque consectetur', N'orci ac pharetra congue consectetur tincidunt vitae convallis elit. tincidunt mauris interdum vitae fermentum')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (4, CAST(N'1959-10-25T08:05:46.090' AS DateTime), CAST(550781936000000000 AS Decimal(18, 0)), 153, 196, CAST(95 AS Decimal(18, 0)), 81, N'your your text here text text text Enter Enter here Enter text your text text text Enter text here your text Enter', N'bono si homo, novum quis fecit. in nomen venit. quartu venit. nomen et vantis. manifestum quad et brevens,', 6, 3, N'enim, malesuada consectetur faucibus. congue Aliquam viverra mauris adipiscing vehicula nisl, Nam mauris viverra', N'pharetra porta volutpat adipiscing enim, in pulvinar porta urna viverra adipiscing rhoncus commodo malesuada')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (5, CAST(N'1998-12-18T06:53:31.693' AS DateTime), CAST(738658130000000000 AS Decimal(18, 0)), 38, 128, CAST(93 AS Decimal(18, 0)), 109, N'text Enter Enter text your Enter Enter Enter Enter text Enter Enter here text text here text here Enter your Enter', N'delerium. regit, fecit, et fecundio, bono et non sed trepicandor vobis quad funem. habitatio in funem.', 5, 8, N'Pellentesque urna eget eget nisl, ac faucibus. ac malesuada adipiscing Ut non. ac nec libero nec vitae.', N'sed. pulvinar ac vitae. aliquet velit interdum aliquet. enim Donec fermentum amet rhoncus adipiscing')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (6, CAST(N'1994-10-27T15:13:22.047' AS DateTime), CAST(508180773000000000 AS Decimal(18, 0)), 76, 51, CAST(94 AS Decimal(18, 0)), 0, N'your your text here text Enter here here text text here text text your text here here text Enter here', N'linguens si quo Quad Multum transit. vantis. trepicandor eggredior. quad quo, vantis. venit. regit, linguens', 6, 5, N'Aliquam Donec pretium sodales libero Donec enim faucibus. velit ac urna in vel, volutpat dui eget, lacus. aliquet.', N'mauris interdum interdum Lorem eget tortor, sodales facilisis Proin facilisis convallis consectetur ante')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (7, CAST(N'2001-08-31T07:59:22.453' AS DateTime), CAST(780955456000000000 AS Decimal(18, 0)), 46, 136, CAST(94 AS Decimal(18, 0)), 115, N'your your Enter your text your text text Enter here text here text your Enter text Enter your here here', NULL, 8, 4, N'viverra faucibus. viverra Aliquam adipiscing sed. fringilla mauris consectetur libero eget.

Suspendisse enim, vel mauris aliquet', N'orci volutpat convallis consectetur nec interdum enim sollicitudin. consectetur id non. et urna enim, lacus. elit.')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (8, CAST(N'1973-03-01T20:50:22.583' AS DateTime), CAST(370001353000000000 AS Decimal(18, 0)), 175, 75, CAST(106 AS Decimal(18, 0)), 75, N'text your text here your your Enter your here here here Enter Enter here here text text Enter here Enter', N'fecit. homo, linguens vobis cognitio, plorum quo quad homo, quad eudis vobis e volcans et sed sed dolorum', 3, 11, N'Donec Donec primis vitae pretium felis. sed. purus. sodales sed. aliquet volutpat Pellentesque pretium', N'vitae convallis neque. lacinia. commodo eros, enim, vehicula Ut eros, consectetur metus id fringilla')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (9, CAST(N'1953-12-28T03:24:02.800' AS DateTime), CAST(265415766000000000 AS Decimal(18, 0)), 78, 103, CAST(102 AS Decimal(18, 0)), 152, N'your text Enter text Enter here your your text your Enter Enter here here here your your your here text', N'esset plurissimum essit. non et si Longam, ut Sed Id quartu novum dolorum fecit. linguens Tam venit. Sed', 8, 7, N'felis. tincidunt vitae. nisl, velit Interdum ante ac aliquet. consectetur vitae. ac tortor, mauris Ut Aliquam', N'congue vel sollicitudin. sapien. velit neque. purus. Aliquam faucibus. volutpat Lorem ipsum fames dui')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (10, CAST(N'1978-02-20T19:49:10.717' AS DateTime), CAST(194569564000000000 AS Decimal(18, 0)), 113, 187, CAST(96 AS Decimal(18, 0)), 134, N'Enter Enter here here your your Enter here text Enter Enter text Enter your here text your Enter your here', N'gravis regit, quo gravis gravis si linguens quorum quo, gravum quantare funem. manifestum nomen venit.', 5, 1, N'pretium ac Nunc dolor velit fringilla ac Lorem Ut aliquet maximus viverra lacus ipsum, Ut posuere consectetur', N'adipiscing Donec vitae. velit faucibus. maximus ipsum et ipsum dolor ac tortor, primis tincidunt non.')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (11, CAST(N'1974-03-14T02:55:54.217' AS DateTime), CAST(858885825000000000 AS Decimal(18, 0)), 119, 66, CAST(93 AS Decimal(18, 0)), 161, N'text text Enter your Enter Enter Enter your here Enter text Enter Enter your Enter here text text Enter', N'fecit, et egreddior nomen Longam, novum esset si venit. non Longam, non bono glavans linguens quad e', 5, 9, N'dolor Lorem metus commodo consectetur vehicula sodales purus. felis. ac ac ipsum vehicula ac pretium', N'ac fringilla orci elit. ac lobortis orci fringilla metus vehicula ac nisl, consectetur vitae sodales')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (12, CAST(N'1959-07-13T21:35:11.427' AS DateTime), CAST(680152267000000000 AS Decimal(18, 0)), 92, 48, CAST(92 AS Decimal(18, 0)), 161, N'Enter Enter Enter your here your Enter here here Enter text here your here text your text Enter your', N'non e non habitatio quad novum quo plorum parte quo, nomen quad fecundio, travissimantor cognitio, in', 3, 17, N'condimentum aliquet pharetra in Sed nec consectetur velit faucibus. nec convallis vel, lacus ipsum ante', N'non. auctor vel, pulvinar orci ac sapien. nec Nam orci fermentum consectetur urna et Ut metus faucibus.')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (13, CAST(N'1989-10-09T08:32:43.293' AS DateTime), CAST(43507702000000000 AS Decimal(18, 0)), 146, 84, CAST(93 AS Decimal(18, 0)), 159, N'here Enter your Enter Enter Enter Enter your your your your here text text Enter text your text your here', N'estis non Pro imaginator imaginator Versus sed trepicandor egreddior delerium. egreddior eudis non manifestum Id', 9, 15, N'sodales metus Aliquam Aliquam viverra condimentum fringilla facilisis ac eget, pharetra non. ac, posuere ipsum', N'rhoncus Phasellus rhoncus Nam vitae. consectetur eget.

Suspendisse nec vitae enim, sed. velit lacus.')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (14, CAST(N'1987-07-15T03:33:21.610' AS DateTime), CAST(668422066000000000 AS Decimal(18, 0)), 37, 142, CAST(95 AS Decimal(18, 0)), 150, N'your text text here here Enter here text Enter text Enter Enter your here text Enter Enter here your text', N'quo linguens et esset imaginator et vobis quorum funem. Sed non fecit, vobis in funem. gravum quad linguens', 3, 13, N'amet ac ac, ipsum maximus dolor fames justo, Proin vel, ante consectetur nec lobortis aliquet faucibus.', N'ac sit tortor, Nam volutpat ac sapien. fermentum faucibus. aliquet ipsum, aliquet. malesuada justo, eget tortor, Donec faucibus.')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (15, CAST(N'1991-12-02T09:46:54.177' AS DateTime), CAST(107543353000000000 AS Decimal(18, 0)), 162, 102, CAST(95 AS Decimal(18, 0)), 182, N'text text your text here Enter Enter here text text Enter text here text text your Enter here text text', N'fecundio, Sed in sed quad fecundio, e travissimantor regit, quo plorum cognitio, quantare Sed quad dolorum vantis. imaginator', 8, 16, N'sed. lacinia. Aliquam urna sed. non. velit, Aliquam Phasellus pretium ullamcorper adipiscing dui ac,', N'ac, tincidunt viverra Ut interdum dui in congue lacinia. facilisis erat dolor lacus. vel ipsum sodales consectetur')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (16, CAST(N'1968-03-28T21:38:16.533' AS DateTime), CAST(526101138000000000 AS Decimal(18, 0)), 30, 155, CAST(98 AS Decimal(18, 0)), 4, N'here text your Enter Enter here your your text your your text here Enter here text Enter Enter here text', N'esset et plorum Tam quo gravum glavans si ut Sed sed plurissimum Longam, et ut si novum vantis. pars egreddior gravis habitatio', 7, 14, N'commodo sed. lobortis fermentum aliquet. justo, vehicula Nam dui sodales scelerisque nec et consectetur condimentum', N'sit sodales velit Nunc Donec Aliquam ac, Proin libero Nam rhoncus faucibus. consectetur eget, amet, eget.

Suspendisse')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (17, CAST(N'1958-08-25T12:33:09.797' AS DateTime), CAST(943389106000000000 AS Decimal(18, 0)), 73, 157, CAST(95 AS Decimal(18, 0)), 125, N'Enter text here text Enter here text here text your Enter here Enter here Enter here your here Enter text your Enter text here', N'trepicandor fecit, transit. quo fecundio, delerium. plorum non Pro Versus eggredior. nomen gravis gravum', 2, 18, N'neque. Donec aliquet purus. eget rhoncus tincidunt enim Donec felis. Sed velit Aliquam lacus convallis', N'vehicula aliquet. viverra fames sapien. auctor sed. consectetur condimentum purus. in neque. dui libero ante')
INSERT [dbo].[visit] ([id], [visit_datetime], [weight], [bp_systolic], [bp_diastolic], [body_temp], [pulse], [symptoms], [checkup_info], [nurse_id], [appointment_id], [initial_diagnosis], [final_diagnosis]) VALUES (18, CAST(N'1955-07-21T15:59:35.880' AS DateTime), CAST(286386808000000000 AS Decimal(18, 0)), 182, 105, CAST(94 AS Decimal(18, 0)), 154, N'text here here Enter text Enter text text here here text text Enter here your text text your here text your Enter Enter', N'sed quo Versus si plorum e gravum quo Quad eggredior. transit. habitatio e in in nomen linguens in quantare nomen pladior Et funem. gravis Id vobis linguens si', 8, 2, N'justo, Aliquam nisl, non. interdum Nam ullamcorper lacus amet, vitae consectetur vehicula purus. eget nisl, in', N'Aliquam metus sapien. mauris urna tincidunt Ut primis viverra eget, ipsum, tincidunt interdum ante sed.')
SET IDENTITY_INSERT [dbo].[visit] OFF
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'00255', N'Nashville', N'WA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'01136', N'Lincoln', N'VA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'04541', N'Arlington', N'VT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'05217', N'Kansas', N'CT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'06522', N'Santa Ana', N'IL')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07189', N'Anchorage', N'DE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07570', N'Rochester', N'AZ')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07679', N'Garland', N'RI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07683', N'Albuquerque', N'IL')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07778', N'Glendale', N'GA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'07843', N'Oakland', N'MN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'10461', N'Memphis', N'MT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'11062', N'Jackson', N'UT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'13956', N'Newark', N'LA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'17998', N'Colorado', N'CO')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'18913', N'New York', N'AR')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'19228', N'Portland', N'TX')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'19863', N'Long Beach', N'MD')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'20941', N'Tampa', N'VA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'23927', N'Honolulu', N'CT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'25837', N'Washington', N'TX')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'27121', N'Austin', N'HI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'27373', N'Birmingham', N'WV')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'27490', N'Long Beach', N'NE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'27787', N'Norfolk', N'MT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'28433', N'Austin', N'NY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'32419', N'Fresno', N'NY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'32848', N'Cleveland', N'MI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'34149', N'Mesa', N'ME')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'34572', N'Toledo', N'RI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'35421', N'Raleigh', N'AZ')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'35718', N'Akron', N'KY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'35829', N'Jackson', N'SD')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'36175', N'Stockton', N'IN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'37525', N'Stockton', N'TX')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'37685', N'Jackson', N'VA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'38290', N'Des Moines', N'NE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'38296', N'Madison', N'FL')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'38686', N'Wichita', N'WY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'38916', N'Dayton', N'MA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'40330', N'Akron', N'MT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'41005', N'Albuquerque', N'AK')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'42244', N'Sacramento', N'UT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'43915', N'Santa Ana', N'KY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'44283', N'Riverside', N'MT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'44935', N'New York', N'NY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'45491', N'San Diego', N'MI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'46741', N'Riverside', N'VA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'47420', N'Shreveport', N'KS')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'50611', N'Chicago', N'MA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'51405', N'Anchorage', N'TN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'57391', N'Columbus', N'NM')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'59264', N'Tampa', N'TX')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'60040', N'Columbus', N'NV')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'60234', N'Fort Worth', N'MO')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'60346', N'Jacksonville', N'OK')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'60697', N'Greensboro', N'CA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'60733', N'Dallas', N'GA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'61104', N'Cleveland', N'PA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'61187', N'Long Beach', N'FL')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'61442', N'Fort Wayne', N'NV')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'61611', N'Chicago', N'OK')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'63152', N'Tampa', N'MS')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'64731', N'St. Louis', N'SC')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'67128', N'Greensboro', N'WY')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'67677', N'Lubbock', N'DE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'70886', N'Columbus', N'TX')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'71946', N'Santa Ana', N'MA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'72295', N'Akron', N'SD')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'72950', N'Phoenix', N'MN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'73108', N'Nashville', N'IN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'74380', N'Virginia Beach', N'VT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'74920', N'San Antonio', N'DE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'75054', N'Fremont', N'WI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'75592', N'Minneapolis', N'MN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'76829', N'San Francisco', N'IN')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'76962', N'San Francisco', N'UT')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'77937', N'Kansas', N'ME')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'78739', N'Colorado', N'WI')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'79990', N'Des Moines', N'AZ')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'80059', N'Tampa', N'OR')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'80694', N'Los Angeles', N'GA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'80752', N'Jersey', N'NJ')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'82419', N'Colorado', N'WV')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'82996', N'New Orleans', N'MO')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'84209', N'Bakersfield', N'OR')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'85607', N'Fresno', N'FL')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'85813', N'Arlington', N'KS')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'86855', N'Colorado', N'ND')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'89380', N'Aurora', N'NE')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'91510', N'Fresno', N'OK')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'92233', N'Louisville', N'PA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'93873', N'New Orleans', N'OH')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'95720', N'Dallas', N'VA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'96100', N'San Diego', N'AR')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'96771', N'Greensboro', N'LA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'98234', N'Mobile', N'MA')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'98371', N'Phoenix', N'NJ')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'99541', N'Yonkers', N'MO')
INSERT [dbo].[zipcode] ([zipcode], [city], [state]) VALUES (N'99823', N'Phoenix', N'MI')
GO
/****** Object:  Index [IX_administrator]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_administrator] ON [dbo].[administrator]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_administrator_1]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_administrator_1] ON [dbo].[administrator]
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_appointment]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_appointment] ON [dbo].[appointment]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_doctor]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_doctor] ON [dbo].[doctor]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_doctor_1]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_doctor_1] ON [dbo].[doctor]
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_nurse]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_nurse] ON [dbo].[nurse]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_nurse_1]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_nurse_1] ON [dbo].[nurse]
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_patient]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_patient] ON [dbo].[patient]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [patient_personal_information_unique]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [patient_personal_information_unique] ON [dbo].[patient]
(
	[personal_information_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_personal_information]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_personal_information] ON [dbo].[person]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_specialty]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE NONCLUSTERED INDEX [IX_specialty] ON [dbo].[specialty]
(
	[specialty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_test]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_test] ON [dbo].[test]
(
	[visit_id] ASC,
	[test_code_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_test_code]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_test_code] ON [dbo].[test_code]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [id]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [id] ON [dbo].[users]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_users]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_users] ON [dbo].[users]
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_visit]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_visit] ON [dbo].[visit]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_visit_1]    Script Date: 3/12/2019 2:20:28 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_visit_1] ON [dbo].[visit]
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_zipcode]    Script Date: 3/12/2019 2:20:28 PM ******/
ALTER TABLE [dbo].[zipcode] ADD  CONSTRAINT [IX_zipcode] UNIQUE NONCLUSTERED 
(
	[zipcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[administrator]  WITH CHECK ADD  CONSTRAINT [FK_administrator_person] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[administrator] CHECK CONSTRAINT [FK_administrator_person]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_doctor] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctor] ([id])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_doctor]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_patient] FOREIGN KEY([patient_id])
REFERENCES [dbo].[patient] ([id])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_patient]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_person] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_person]
GO
ALTER TABLE [dbo].[nurse]  WITH CHECK ADD  CONSTRAINT [FK_nurse_person] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[nurse] CHECK CONSTRAINT [FK_nurse_person]
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK_patient_personal_information] FOREIGN KEY([personal_information_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK_patient_personal_information]
GO
ALTER TABLE [dbo].[person]  WITH CHECK ADD  CONSTRAINT [FK_personal_information_zipcode] FOREIGN KEY([zipcode])
REFERENCES [dbo].[zipcode] ([zipcode])
GO
ALTER TABLE [dbo].[person] CHECK CONSTRAINT [FK_personal_information_zipcode]
GO
ALTER TABLE [dbo].[specialty]  WITH CHECK ADD  CONSTRAINT [FK_specialty_doctor] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctor] ([id])
GO
ALTER TABLE [dbo].[specialty] CHECK CONSTRAINT [FK_specialty_doctor]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_test_test_code] FOREIGN KEY([test_code_id])
REFERENCES [dbo].[test_code] ([id])
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_test_test_code]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_test_visit] FOREIGN KEY([visit_id])
REFERENCES [dbo].[visit] ([id])
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_test_visit]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_employees_personal_information] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_employees_personal_information]
GO
ALTER TABLE [dbo].[visit]  WITH CHECK ADD  CONSTRAINT [FK_visit_appointment] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[appointment] ([id])
GO
ALTER TABLE [dbo].[visit] CHECK CONSTRAINT [FK_visit_appointment]
GO
ALTER TABLE [dbo].[visit]  WITH CHECK ADD  CONSTRAINT [FK_visit_nurse] FOREIGN KEY([nurse_id])
REFERENCES [dbo].[nurse] ([id])
GO
ALTER TABLE [dbo].[visit] CHECK CONSTRAINT [FK_visit_nurse]
GO
/****** Object:  StoredProcedure [dbo].[sp_mostPerformedTestDuringDates]    Script Date: 3/12/2019 2:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chris Childress
-- Create date: 2/26/2017
-- Description:	Retrieves all tests performed at least twice between two dates and returns test code,
--  test name, number of times the test was performed, total number of tests performed, percentage of tests, 
-- number of normal results, number of abnormal results, percentage of patients in specified ranges.
-- =============================================
CREATE PROCEDURE [dbo].[sp_mostPerformedTestDuringDates]
	-- Add the parameters for the stored procedure here
	@startDate date = GETDATE, 
	@endDate date = GETDATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @totalCount int;
	SET @totalCount = 0;


    -- Insert statements for procedure here

	-- get total count
	SELECT @totalCount = COUNT(t.test_code_id) 
		FROM test t
		WHERE t.visit_id = t.visit_id AND t.date_performed <= @endDate AND t.date_performed >= @startDate;

	SELECT 
		tc.code,
		COUNT(tc.id) AS num_tests_performed,
		@totalCount AS total_tests_performed,
		COUNT(tc.id) / CAST(@totalCount AS DECIMAL(4, 2)) * 100 AS percentage_of_total_tests_performed,
		SUM(CASE WHEN t.abnormal_result = 1 THEN 1 ELSE 0 END) as num_normal_tests,
		SUM(CASE WHEN t.abnormal_result = 0 THEN 1 ELSE 0 END) as num_abnormal_tests,
		SUM(CASE WHEN (DATEDIFF(year, phi.date_of_birth, t.date_performed) BETWEEN 18 AND 39) THEN 1 ELSE 0 END) / CAST(COUNT(*) AS DECIMAL(4, 2)) * 100 AS percentage_between_18_and_29,
		SUM(CASE WHEN (DATEDIFF(year, phi.date_of_birth, t.date_performed) BETWEEN 30 and 39) THEN 1 ELSE 0 END) / CAST(COUNT(*) AS DECIMAL(4, 2)) * 100 AS percentage_between_30_and_39,
		SUM(CASE WHEN (DATEDIFF(year, phi.date_of_birth, t.date_performed) BETWEEN 40 and 49) THEN 1 ELSE 0 END) / CAST(COUNT(*) AS DECIMAL(4, 2)) * 100 AS percentage_between_40_and_49,
		SUM(CASE WHEN (DATEDIFF(year, phi.date_of_birth, t.date_performed) BETWEEN 50 and 59) THEN 1 ELSE 0 END) / CAST(COUNT(*) AS DECIMAL(4, 2)) * 100 AS percentage_between_50_and_59
	FROM test t
		LEFT JOIN test_code tc ON t.test_code_id = tc.id AND t.date_performed >= @startDate AND t.date_performed <= @endDate
		LEFT JOIN visit v ON t.visit_id = v.id
		LEFT JOIN appointment a ON a.id = v.appointment_id
		LEFT JOIN patient p ON p.id = a.patient_id
		LEFT JOIN person phi ON p.personal_information_id = phi.id
	GROUP BY tc.id, tc.code
	HAVING COUNT(tc.id) >= 2
	ORDER BY COUNT(tc.id) DESC, tc.id DESC;
END
GO
USE [master]
GO
ALTER DATABASE [CS6232_g3] SET  READ_WRITE 
GO

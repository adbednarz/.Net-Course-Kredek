USE [master]
GO
/****** Object:  Database [ArtDB]    Script Date: 6/6/2021 9:25:11 PM ******/
CREATE DATABASE [ArtDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ArtDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ArtDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ArtDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ArtDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ArtDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ArtDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ArtDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ArtDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ArtDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ArtDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ArtDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ArtDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ArtDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ArtDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ArtDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ArtDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ArtDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ArtDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ArtDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ArtDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ArtDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ArtDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ArtDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ArtDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ArtDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ArtDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ArtDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ArtDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ArtDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ArtDB] SET  MULTI_USER 
GO
ALTER DATABASE [ArtDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ArtDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ArtDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ArtDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ArtDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ArtDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ArtDB', N'ON'
GO
ALTER DATABASE [ArtDB] SET QUERY_STORE = OFF
GO
USE [ArtDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/6/2021 9:25:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artists]    Script Date: 6/6/2021 9:25:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArtWorks]    Script Date: 6/6/2021 9:25:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtWorks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[MuseumId] [int] NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ArtWorks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Museums]    Script Date: 6/6/2021 9:25:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Museums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Museums] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210604105817_Initial', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Artists] ON 

INSERT [dbo].[Artists] ([Id], [Name], [Surname], [Description]) VALUES (1, N'Jacek', N'Malczewski', N'polski malarz, jeden z głównych przedstawicieli symbolizmu przełomu XIX i XX wieku')
INSERT [dbo].[Artists] ([Id], [Name], [Surname], [Description]) VALUES (2, N'Isaak', N'Lewitan', N'malarz-pejzażysta rosyjski pochodzenia żydowskiego')
INSERT [dbo].[Artists] ([Id], [Name], [Surname], [Description]) VALUES (3, N'Auguste', N'Renoir', N'Francuski malarz i rzeźbiarz, współtwórca i jeden z czołowych przedstawicieli impresjonizmu.')
SET IDENTITY_INSERT [dbo].[Artists] OFF
GO
SET IDENTITY_INSERT [dbo].[ArtWorks] ON 

INSERT [dbo].[ArtWorks] ([Id], [Name], [Year], [MuseumId], [ArtistId], [Description]) VALUES (2, N'Jesienny dzień', 1879, 1, 2, N'Postać kobiety idącej polną ścieżką w lesie o barwach jesiennych')
INSERT [dbo].[ArtWorks] ([Id], [Name], [Year], [MuseumId], [ArtistId], [Description]) VALUES (3, N'Parasolki', 1881, 3, 3, N'Obraz przestawia ówczesną modę, na obrazie widocznie głównie kobiety z parasolkami.')
INSERT [dbo].[ArtWorks] ([Id], [Name], [Year], [MuseumId], [ArtistId], [Description]) VALUES (4, N'Hamlet polski', 1903, 2, 1, N'Alegoryczne przedstawienie Polski')
SET IDENTITY_INSERT [dbo].[ArtWorks] OFF
GO
SET IDENTITY_INSERT [dbo].[Museums] ON 

INSERT [dbo].[Museums] ([Id], [Name], [Year], [City], [Description]) VALUES (1, N'Galeria Tretiakowska', 1856, N'Moskwa', N'gromadząca obecnie jedną z największych na świecie kolekcji dzieł rosyjskich sztuk pięknych')
INSERT [dbo].[Museums] ([Id], [Name], [Year], [City], [Description]) VALUES (2, N'Muzeum Narodowe w Warszawie', 1862, N'Warszawa', N'jedno z największych muzeów w Polsce i największe w Warszawie')
INSERT [dbo].[Museums] ([Id], [Name], [Year], [City], [Description]) VALUES (3, N'National Gallery', 1824, N'Londyn', N'Jest to galeria państwowa, prezentująca kolekcję 2300 dzieł malarstwa.')
SET IDENTITY_INSERT [dbo].[Museums] OFF
GO
/****** Object:  Index [IX_ArtWorks_ArtistId]    Script Date: 6/6/2021 9:25:11 PM ******/
CREATE NONCLUSTERED INDEX [IX_ArtWorks_ArtistId] ON [dbo].[ArtWorks]
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ArtWorks_MuseumId]    Script Date: 6/6/2021 9:25:11 PM ******/
CREATE NONCLUSTERED INDEX [IX_ArtWorks_MuseumId] ON [dbo].[ArtWorks]
(
	[MuseumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ArtWorks]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorks_Artists_ArtistId] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArtWorks] CHECK CONSTRAINT [FK_ArtWorks_Artists_ArtistId]
GO
ALTER TABLE [dbo].[ArtWorks]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorks_Museums_MuseumId] FOREIGN KEY([MuseumId])
REFERENCES [dbo].[Museums] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArtWorks] CHECK CONSTRAINT [FK_ArtWorks_Museums_MuseumId]
GO
USE [master]
GO
ALTER DATABASE [ArtDB] SET  READ_WRITE 
GO

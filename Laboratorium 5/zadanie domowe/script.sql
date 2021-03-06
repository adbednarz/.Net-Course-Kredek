USE [master]
GO
/****** Object:  Database [PolishBattlesDB]    Script Date: 5/30/2021 10:16:51 PM ******/
CREATE DATABASE [PolishBattlesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PolishBattlesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PolishBattlesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PolishBattlesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PolishBattlesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PolishBattlesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PolishBattlesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PolishBattlesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PolishBattlesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PolishBattlesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PolishBattlesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PolishBattlesDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PolishBattlesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PolishBattlesDB] SET  MULTI_USER 
GO
ALTER DATABASE [PolishBattlesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PolishBattlesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PolishBattlesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PolishBattlesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PolishBattlesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PolishBattlesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PolishBattlesDB', N'ON'
GO
ALTER DATABASE [PolishBattlesDB] SET QUERY_STORE = OFF
GO
USE [PolishBattlesDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/30/2021 10:16:51 PM ******/
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
/****** Object:  Table [dbo].[Ages]    Script Date: 5/30/2021 10:16:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[YearOfStart] [nvarchar](max) NOT NULL,
	[YearOfEnd] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Ages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Battles]    Script Date: 5/30/2021 10:16:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Battles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[AgeId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[CommanderId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Battles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commanders]    Script Date: 5/30/2021 10:16:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commanders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Commanders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 5/30/2021 10:16:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TotalWinnerBattles] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210529071829_Initial', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Ages] ON 

INSERT [dbo].[Ages] ([Id], [Name], [YearOfStart], [YearOfEnd]) VALUES (1, N'Średniowiecze', N'476', N'1492')
INSERT [dbo].[Ages] ([Id], [Name], [YearOfStart], [YearOfEnd]) VALUES (2, N'Nowożytność', N'1492', N'1914')
INSERT [dbo].[Ages] ([Id], [Name], [YearOfStart], [YearOfEnd]) VALUES (3, N'Współczesność', N'1914', N'-')
SET IDENTITY_INSERT [dbo].[Ages] OFF
GO
SET IDENTITY_INSERT [dbo].[Battles] ON 

INSERT [dbo].[Battles] ([Id], [Name], [Year], [AgeId], [CountryId], [CommanderId], [Description]) VALUES (2, N'Bitwa pod Cedynią', 972, 1, 1, 1, N'Ekspansja niemiecka na tereny polskie')
INSERT [dbo].[Battles] ([Id], [Name], [Year], [AgeId], [CountryId], [CommanderId], [Description]) VALUES (3, N'Bitwa pod Wiedniem', 1683, 2, 3, 2, N'Powstrzymanie natarcia Imperium Osmańskiego na Europę')
INSERT [dbo].[Battles] ([Id], [Name], [Year], [AgeId], [CountryId], [CommanderId], [Description]) VALUES (4, N'Bitwa Warszawska', 1920, 3, 2, 3, N'Zatrzymanie bolszewików, utrzymanie niepodegłości Polski')
SET IDENTITY_INSERT [dbo].[Battles] OFF
GO
SET IDENTITY_INSERT [dbo].[Commanders] ON 

INSERT [dbo].[Commanders] ([Id], [Name], [Surname], [Description]) VALUES (1, N'Mieszko', N'I', N'Twórca państwowości polskiej')
INSERT [dbo].[Commanders] ([Id], [Name], [Surname], [Description]) VALUES (2, N'Jan', N'III Sobieski', N'Elekcyjny król Polski')
INSERT [dbo].[Commanders] ([Id], [Name], [Surname], [Description]) VALUES (3, N'Józef', N'Piłsudski', N'Jeden z ojców niepodlegości Polski')
SET IDENTITY_INSERT [dbo].[Commanders] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name], [TotalWinnerBattles]) VALUES (1, N'Niemcy', 425)
INSERT [dbo].[Countries] ([Id], [Name], [TotalWinnerBattles]) VALUES (2, N'Turcja', 210)
INSERT [dbo].[Countries] ([Id], [Name], [TotalWinnerBattles]) VALUES (3, N'Rosja', 491)
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
/****** Object:  Index [IX_Battles_AgeId]    Script Date: 5/30/2021 10:16:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Battles_AgeId] ON [dbo].[Battles]
(
	[AgeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Battles_CommanderId]    Script Date: 5/30/2021 10:16:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Battles_CommanderId] ON [dbo].[Battles]
(
	[CommanderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Battles_CountryId]    Script Date: 5/30/2021 10:16:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Battles_CountryId] ON [dbo].[Battles]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Battles]  WITH CHECK ADD  CONSTRAINT [FK_Battles_Ages_AgeId] FOREIGN KEY([AgeId])
REFERENCES [dbo].[Ages] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Battles] CHECK CONSTRAINT [FK_Battles_Ages_AgeId]
GO
ALTER TABLE [dbo].[Battles]  WITH CHECK ADD  CONSTRAINT [FK_Battles_Commanders_CommanderId] FOREIGN KEY([CommanderId])
REFERENCES [dbo].[Commanders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Battles] CHECK CONSTRAINT [FK_Battles_Commanders_CommanderId]
GO
ALTER TABLE [dbo].[Battles]  WITH CHECK ADD  CONSTRAINT [FK_Battles_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Battles] CHECK CONSTRAINT [FK_Battles_Countries_CountryId]
GO
USE [master]
GO
ALTER DATABASE [PolishBattlesDB] SET  READ_WRITE 
GO

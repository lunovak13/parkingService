USE [Garaza]
GO
ALTER TABLE [dbo].[Auto] DROP CONSTRAINT [FK_Auto_Vlasnik]
GO
ALTER TABLE [dbo].[Auto] DROP CONSTRAINT [FK_Auto_Radnik]
GO
ALTER TABLE [dbo].[Auto] DROP CONSTRAINT [FK_Auto_Mesto]
GO
ALTER TABLE [dbo].[Auto] DROP CONSTRAINT [FK_Auto_Marka]
GO
/****** Object:  Table [dbo].[Vlasnik]    Script Date: 19.2.2018. 09.31.26 ******/
DROP TABLE [dbo].[Vlasnik]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 19.2.2018. 09.31.26 ******/
DROP TABLE [dbo].[Radnik]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 19.2.2018. 09.31.26 ******/
DROP TABLE [dbo].[Mesto]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 19.2.2018. 09.31.26 ******/
DROP TABLE [dbo].[Marka]
GO
/****** Object:  Table [dbo].[Auto]    Script Date: 19.2.2018. 09.31.26 ******/
DROP TABLE [dbo].[Auto]
GO
USE [master]
GO
/****** Object:  Database [Garaza]    Script Date: 19.2.2018. 09.31.26 ******/
DROP DATABASE [Garaza]
GO
/****** Object:  Database [Garaza]    Script Date: 19.2.2018. 09.31.26 ******/
CREATE DATABASE [Garaza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Garaza', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Garaza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Garaza_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Garaza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Garaza] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Garaza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Garaza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Garaza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Garaza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Garaza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Garaza] SET ARITHABORT OFF 
GO
ALTER DATABASE [Garaza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Garaza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Garaza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Garaza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Garaza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Garaza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Garaza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Garaza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Garaza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Garaza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Garaza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Garaza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Garaza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Garaza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Garaza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Garaza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Garaza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Garaza] SET RECOVERY FULL 
GO
ALTER DATABASE [Garaza] SET  MULTI_USER 
GO
ALTER DATABASE [Garaza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Garaza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Garaza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Garaza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Garaza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Garaza] SET QUERY_STORE = OFF
GO
USE [Garaza]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Garaza]
GO
/****** Object:  Table [dbo].[Auto]    Script Date: 19.2.2018. 09.31.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auto](
	[IDauto] [int] NOT NULL,
	[Vlasnik] [int] NOT NULL,
	[Marka] [int] NOT NULL,
	[Boja] [nvarchar](50) NOT NULL,
	[Mesto] [int] NOT NULL,
	[Radnik] [int] NOT NULL,
 CONSTRAINT [PK_Auto] PRIMARY KEY CLUSTERED 
(
	[IDauto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 19.2.2018. 09.31.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[IDMarka] [int] NOT NULL,
	[Ime_Marke] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[IDMarka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 19.2.2018. 09.31.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesto](
	[IDMesta] [int] NOT NULL,
	[Red] [int] NOT NULL,
	[Kolona] [int] NOT NULL,
	[Mesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mesto] PRIMARY KEY CLUSTERED 
(
	[IDMesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 19.2.2018. 09.31.27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[IDRadnik] [int] NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Smena] [int] NOT NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[IDRadnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vlasnik]    Script Date: 19.2.2018. 09.31.27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vlasnik](
	[IDVlasnik] [int] NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Godina] [int] NOT NULL,
 CONSTRAINT [PK_Vlasnik] PRIMARY KEY CLUSTERED 
(
	[IDVlasnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Auto] ([IDauto], [Vlasnik], [Marka], [Boja], [Mesto], [Radnik]) VALUES (1, 3, 2, N'crvena', 2, 3)
INSERT [dbo].[Auto] ([IDauto], [Vlasnik], [Marka], [Boja], [Mesto], [Radnik]) VALUES (5, 3, 1, N'plava', 3, 3)
INSERT [dbo].[Auto] ([IDauto], [Vlasnik], [Marka], [Boja], [Mesto], [Radnik]) VALUES (7, 2, 3, N'zelena', 2, 1)
INSERT [dbo].[Auto] ([IDauto], [Vlasnik], [Marka], [Boja], [Mesto], [Radnik]) VALUES (13, 1, 1, N'zelena', 2, 1)
INSERT [dbo].[Marka] ([IDMarka], [Ime_Marke]) VALUES (1, N'Mercedes')
INSERT [dbo].[Marka] ([IDMarka], [Ime_Marke]) VALUES (2, N'Honda')
INSERT [dbo].[Marka] ([IDMarka], [Ime_Marke]) VALUES (3, N'Toyota')
INSERT [dbo].[Mesto] ([IDMesta], [Red], [Kolona], [Mesto]) VALUES (1, 1, 1, N'Levo')
INSERT [dbo].[Mesto] ([IDMesta], [Red], [Kolona], [Mesto]) VALUES (2, 2, 2, N'Desno')
INSERT [dbo].[Mesto] ([IDMesta], [Red], [Kolona], [Mesto]) VALUES (3, 3, 3, N'Sredina')
INSERT [dbo].[Radnik] ([IDRadnik], [Ime], [Prezime], [Smena]) VALUES (1, N'Luka', N'Novakovic', 1)
INSERT [dbo].[Radnik] ([IDRadnik], [Ime], [Prezime], [Smena]) VALUES (2, N'Nemanja', N'Jokic', 2)
INSERT [dbo].[Radnik] ([IDRadnik], [Ime], [Prezime], [Smena]) VALUES (3, N'Dimitrije', N'Krstic', 3)
INSERT [dbo].[Vlasnik] ([IDVlasnik], [Ime], [Prezime], [Godina]) VALUES (1, N'Nikola', N'Kodzic', 1997)
INSERT [dbo].[Vlasnik] ([IDVlasnik], [Ime], [Prezime], [Godina]) VALUES (2, N'Predrag', N'Jelicic', 1998)
INSERT [dbo].[Vlasnik] ([IDVlasnik], [Ime], [Prezime], [Godina]) VALUES (3, N'Andrija', N'Solunac', 1996)
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_Marka] FOREIGN KEY([Marka])
REFERENCES [dbo].[Marka] ([IDMarka])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_Marka]
GO
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_Mesto] FOREIGN KEY([Mesto])
REFERENCES [dbo].[Mesto] ([IDMesta])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_Mesto]
GO
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_Radnik] FOREIGN KEY([Radnik])
REFERENCES [dbo].[Radnik] ([IDRadnik])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_Radnik]
GO
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_Vlasnik] FOREIGN KEY([Vlasnik])
REFERENCES [dbo].[Vlasnik] ([IDVlasnik])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_Vlasnik]
GO
USE [master]
GO
ALTER DATABASE [Garaza] SET  READ_WRITE 
GO

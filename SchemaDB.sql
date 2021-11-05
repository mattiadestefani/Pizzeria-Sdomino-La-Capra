USE [master]
GO
/****** Object:  Database [PizzeriaCapra]    Script Date: 05/11/2021 15:57:59 ******/
CREATE DATABASE [PizzeriaCapra]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PizzeriaCapra', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\PizzeriaCapra.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PizzeriaCapra_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\PizzeriaCapra_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PizzeriaCapra] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PizzeriaCapra].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PizzeriaCapra] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET ARITHABORT OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PizzeriaCapra] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PizzeriaCapra] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PizzeriaCapra] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PizzeriaCapra] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PizzeriaCapra] SET  MULTI_USER 
GO
ALTER DATABASE [PizzeriaCapra] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PizzeriaCapra] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PizzeriaCapra] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PizzeriaCapra] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PizzeriaCapra] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PizzeriaCapra] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PizzeriaCapra] SET QUERY_STORE = OFF
GO
USE [PizzeriaCapra]
GO
/****** Object:  Table [dbo].[Pizza]    Script Date: 05/11/2021 15:58:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizza](
	[IdPizza] [int] IDENTITY(1,1) NOT NULL,
	[Base] [varchar](50) NOT NULL,
	[Impasto] [varchar](50) NOT NULL,
	[Aggiunta] [text] NULL,
	[Prezzo] [decimal](18, 2) NOT NULL,
	[IdScontrino] [int] NOT NULL,
 CONSTRAINT [PK_Pizza] PRIMARY KEY CLUSTERED 
(
	[IdPizza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scontrino]    Script Date: 05/11/2021 15:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scontrino](
	[IdScontrino] [int] IDENTITY(1,1) NOT NULL,
	[Totale] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Scontrini] PRIMARY KEY CLUSTERED 
(
	[IdScontrino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pizza] ADD  CONSTRAINT [DF_Pizza_Impasto]  DEFAULT ('normale') FOR [Impasto]
GO
ALTER TABLE [dbo].[Pizza] ADD  CONSTRAINT [DF_Pizza_Prezzo]  DEFAULT ((0)) FOR [Prezzo]
GO
ALTER TABLE [dbo].[Scontrino] ADD  CONSTRAINT [DF_Scontrini_Totale]  DEFAULT ((0)) FOR [Totale]
GO
USE [master]
GO
ALTER DATABASE [PizzeriaCapra] SET  READ_WRITE 
GO

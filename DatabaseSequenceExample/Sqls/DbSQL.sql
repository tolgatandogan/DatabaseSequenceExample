USE [master]
GO
/****** Object:  Database [SequenceExample]    Script Date: 1/16/2022 2:10:56 PM ******/
CREATE DATABASE [SequenceExample]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SequenceExample', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SequenceExample.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SequenceExample_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SequenceExample_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SequenceExample] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SequenceExample].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SequenceExample] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SequenceExample] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SequenceExample] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SequenceExample] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SequenceExample] SET ARITHABORT OFF 
GO
ALTER DATABASE [SequenceExample] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SequenceExample] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SequenceExample] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SequenceExample] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SequenceExample] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SequenceExample] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SequenceExample] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SequenceExample] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SequenceExample] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SequenceExample] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SequenceExample] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SequenceExample] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SequenceExample] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SequenceExample] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SequenceExample] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SequenceExample] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SequenceExample] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SequenceExample] SET RECOVERY FULL 
GO
ALTER DATABASE [SequenceExample] SET  MULTI_USER 
GO
ALTER DATABASE [SequenceExample] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SequenceExample] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SequenceExample] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SequenceExample] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SequenceExample] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SequenceExample] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SequenceExample', N'ON'
GO
ALTER DATABASE [SequenceExample] SET QUERY_STORE = OFF
GO
USE [SequenceExample]
GO
USE [SequenceExample]
GO
/****** Object:  Sequence [dbo].[Seq_Company_Id]    Script Date: 1/16/2022 2:10:56 PM ******/
CREATE SEQUENCE [dbo].[Seq_Company_Id] 
 AS [int]
 START WITH 100011
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [SequenceExample]
GO
/****** Object:  Sequence [dbo].[Seq_Customer_Id]    Script Date: 1/16/2022 2:10:56 PM ******/
CREATE SEQUENCE [dbo].[Seq_Customer_Id] 
 AS [bigint]
 START WITH 49100000000000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[Company]    Script Date: 1/16/2022 2:10:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](64) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/16/2022 2:10:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](64) NULL,
	[Surname] [nvarchar](64) NULL,
	[Phone] [nvarchar](18) NULL,
	[CreatedDatetime] [datetime] NULL,
	[CreatedUser] [nvarchar](50) NULL,
	[ModifiedDatetime] [datetime] NULL,
	[ModifiedUser] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([Id], [Name], [Surname], [Phone], [CreatedDatetime], [CreatedUser], [ModifiedDatetime], [ModifiedUser]) VALUES (49100000000004, N'Tolga', N'Tandoğan', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Surname], [Phone], [CreatedDatetime], [CreatedUser], [ModifiedDatetime], [ModifiedUser]) VALUES (49100000000005, N'Tolga', N'Tandoğan', NULL, CAST(N'2022-01-14T11:54:59.000' AS DateTime), NULL, CAST(N'2022-01-14T11:54:59.000' AS DateTime), NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Surname], [Phone], [CreatedDatetime], [CreatedUser], [ModifiedDatetime], [ModifiedUser]) VALUES (49100000000006, N'Tolga', N'Tandoğan', NULL, CAST(N'2022-01-16T14:05:12.000' AS DateTime), NULL, CAST(N'2022-01-16T14:05:12.000' AS DateTime), NULL)
GO
USE [master]
GO
ALTER DATABASE [SequenceExample] SET  READ_WRITE 
GO

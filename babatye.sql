USE [master]
GO
/****** Object:  Database [babatye]    Script Date: 2019-09-02 03:45:17 ******/
CREATE DATABASE [babatye]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'babatie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\babatie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'babatie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\babatie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [babatye] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [babatye].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [babatye] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [babatye] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [babatye] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [babatye] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [babatye] SET ARITHABORT OFF 
GO
ALTER DATABASE [babatye] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [babatye] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [babatye] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [babatye] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [babatye] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [babatye] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [babatye] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [babatye] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [babatye] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [babatye] SET  DISABLE_BROKER 
GO
ALTER DATABASE [babatye] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [babatye] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [babatye] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [babatye] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [babatye] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [babatye] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [babatye] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [babatye] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [babatye] SET  MULTI_USER 
GO
ALTER DATABASE [babatye] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [babatye] SET DB_CHAINING OFF 
GO
ALTER DATABASE [babatye] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [babatye] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [babatye] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [babatye] SET QUERY_STORE = OFF
GO
USE [babatye]
GO
/****** Object:  Table [dbo].[tbl_cloths]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cloths](
	[SKU] [nvarchar](30) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Size] [nvarchar](25) NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_tbl_cloths] PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_cloths] ADD  CONSTRAINT [DF_tbl_cloths_Count]  DEFAULT ((1)) FOR [Count]
GO
/****** Object:  StoredProcedure [dbo].[AddCloths]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCloths]

  @SKUNumber nvarchar(30),
  @Name nvarchar (150),
  @Size nvarchar (25),
  @Color nvarchar (50)
AS 

  BEGIN 
  
    IF EXISTS (SELECT * FROM tbl_cloths WHERE tbl_cloths.SKU = @SKUNumber)
       UPDATE tbl_cloths SET Count = Count + 1 WHERE tbl_cloths.SKU = @SKUNumber
    ELSE 
    INSERT INTO tbl_cloths (SKU,Name,Size,Color) VALUES (@SKUNumber,@Name,@Size,@Color) 
  END
GO
/****** Object:  StoredProcedure [dbo].[AddNewItem]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewItem]

  @SKUNumber nvarchar(30),
  @Name nvarchar (150),
  @Size nvarchar (25),
  @Color nvarchar (50)
AS 
  BEGIN 
       INSERT INTO tbl_cloths (SKU,Name,Size,Color) VALUES (@SKUNumber,@Name,@Size,@Color) 
  END
GO
/****** Object:  StoredProcedure [dbo].[GetName]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetName]
  @SKUNumber nvarchar(30)
AS 
  BEGIN 
       SELECT tbl_cloths.Name FROM tbl_cloths Where SKU =  @SKUNumber;
  END
GO
/****** Object:  StoredProcedure [dbo].[InsertClothes]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertClothes]

  @SKUNumber nvarchar(30)
AS 
  BEGIN 
       UPDATE tbl_cloths SET Count = Count + 1 WHERE tbl_cloths.SKU = @SKUNumber
  END
GO
/****** Object:  StoredProcedure [dbo].[ViewProducts]    Script Date: 2019-09-02 03:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewProducts]
AS 
  BEGIN 
       SELECT * FROM tbl_cloths;
  END
GO
USE [master]
GO
ALTER DATABASE [babatye] SET  READ_WRITE 
GO

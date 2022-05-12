USE [master]
GO

/****** Object:  Database [BookDB]    Script Date: 2022/5/12 16:03:18 ******/
CREATE DATABASE [BookDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookDB', FILENAME = N'F:\1_hode\SQL_Serve2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookDB_log', FILENAME = N'F:\1_hode\SQL_Serve2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BookDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BookDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BookDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BookDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BookDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [BookDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BookDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BookDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BookDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BookDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BookDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BookDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BookDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BookDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BookDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BookDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BookDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BookDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BookDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BookDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BookDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BookDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BookDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BookDB] SET  MULTI_USER 
GO

ALTER DATABASE [BookDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BookDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BookDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BookDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BookDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BookDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BookDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BookDB] SET  READ_WRITE 
GO



USE [master]
GO
/****** Object:  Database [Alumnos]    Script Date: 15/10/15 5:20:29 p.m. ******/
CREATE DATABASE [Alumnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Alumnos', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Alumnos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Alumnos_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Alumnos_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Alumnos] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Alumnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Alumnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Alumnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Alumnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Alumnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Alumnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Alumnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Alumnos] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Alumnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Alumnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Alumnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Alumnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Alumnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Alumnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Alumnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Alumnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Alumnos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Alumnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Alumnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Alumnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Alumnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Alumnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Alumnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Alumnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Alumnos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Alumnos] SET  MULTI_USER 
GO
ALTER DATABASE [Alumnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Alumnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Alumnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Alumnos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Alumnos]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 15/10/15 5:20:30 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[CodAlumno] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[CodAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Matricula]    Script Date: 15/10/15 5:20:30 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matricula](
	[CodMatricula] [int] IDENTITY(1,1) NOT NULL,
	[CodAlumno] [int] NOT NULL,
	[ValorMatricula] [int] NOT NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[CodMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Alumno] FOREIGN KEY([CodAlumno])
REFERENCES [dbo].[Alumno] ([CodAlumno])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Alumno]
GO
USE [master]
GO
ALTER DATABASE [Alumnos] SET  READ_WRITE 
GO

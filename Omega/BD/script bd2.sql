/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [Omega]    Script Date: 14/9/2018 10:11:18 ******/
CREATE DATABASE [Omega]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Omega', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Omega.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Omega_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Omega_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Omega] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Omega].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Omega] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Omega] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Omega] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Omega] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Omega] SET ARITHABORT OFF 
GO
ALTER DATABASE [Omega] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Omega] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Omega] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Omega] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Omega] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Omega] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Omega] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Omega] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Omega] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Omega] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Omega] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Omega] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Omega] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Omega] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Omega] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Omega] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Omega] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Omega] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Omega] SET  MULTI_USER 
GO
ALTER DATABASE [Omega] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Omega] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Omega] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Omega] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Omega] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Omega] SET QUERY_STORE = OFF
GO
USE [Omega]
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
USE [Omega]
GO
/****** Object:  Table [dbo].[Dificultad]    Script Date: 14/9/2018 10:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dificultad](
	[IdDificultad] [int] NOT NULL,
	[NombreDificultad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Dificultad_1] PRIMARY KEY CLUSTERED 
(
	[IdDificultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imagen]    Script Date: 14/9/2018 10:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imagen](
	[NombreImagen] [varchar](50) NOT NULL,
	[IdJuego] [int] NULL,
	[IdDificultad] [int] NULL,
 CONSTRAINT [PK_Imagen] PRIMARY KEY CLUSTERED 
(
	[NombreImagen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Juego]    Script Date: 14/9/2018 10:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Juego](
	[IdJuego] [int] NOT NULL,
	[NombreJuego] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Juego] PRIMARY KEY CLUSTERED 
(
	[IdJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JuegoDificultad]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JuegoDificultad](
	[IdJuego] [int] NOT NULL,
	[IdDificultad] [int] NOT NULL,
 CONSTRAINT [PK_JuegoDificultad_1] PRIMARY KEY CLUSTERED 
(
	[IdJuego] ASC,
	[IdDificultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[Puntuacion] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Jugador] [varchar](50) NOT NULL,
	[IdJuego] [int] NOT NULL,
	[IdDificultad] [int] NOT NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[FechaBloqueo] [datetime] NULL,
	[Eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Imagen]  WITH CHECK ADD  CONSTRAINT [FK_Imagen_Imagen] FOREIGN KEY([NombreImagen])
REFERENCES [dbo].[Imagen] ([NombreImagen])
GO
ALTER TABLE [dbo].[Imagen] CHECK CONSTRAINT [FK_Imagen_Imagen]
GO
ALTER TABLE [dbo].[JuegoDificultad]  WITH CHECK ADD  CONSTRAINT [FK_DificultadJuego_Juego] FOREIGN KEY([IdJuego])
REFERENCES [dbo].[Juego] ([IdJuego])
GO
ALTER TABLE [dbo].[JuegoDificultad] CHECK CONSTRAINT [FK_DificultadJuego_Juego]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_JuegoDificultad] FOREIGN KEY([IdJuego], [IdDificultad])
REFERENCES [dbo].[JuegoDificultad] ([IdJuego], [IdDificultad])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_JuegoDificultad]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUsuarios]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_BuscarUsuarios]
@nombre varchar(50)
as
select IdUsuario,NombreUsuario,Contraseña,isnull(FechaBloqueo,0) as FechaBloqueo,Eliminado from Usuario where NombreUsuario = @nombre
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarBloqueo]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertarBloqueo]
@fecha datetime, @id int
as
update Usuario set FechaBloqueo = @fecha where IdUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarDificultades]    Script Date: 14/9/2018 10:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_ListarDificultades]
as
select * from Dificultad
GO
USE [master]
GO
ALTER DATABASE [Omega] SET  READ_WRITE 
GO

insert into Usuario(NombreUsuario,Contraseña,FechaBloqueo,Eliminado) values ('Cami','81dc9bdb52d04dc20036dbd8313ed055',null,0)--la contraseña es 1234

insert into Dificultad values (1,'Fácil') 
insert into Dificultad values (2,'Intermedio') 
insert into Dificultad values (3,'Difícil') 

insert into Juego values (1,'Resta','Resta de numeros')
insert into Juego values (2,'Suma','Suma de numeros')
insert into Juego values (3,'Cantidades','Reconocimiento de numeros')
insert into Juego values (4,'Sopa de letras','Sopa de letras')
insert into Juego values (5,'Completar palabras','Completar palabras con imagenes')
insert into Juego values (6,'Memotest','Memotest')
insert into Juego values (7,'Rompecabezas','Rompecabezas')
insert into Juego values (8,'Colorear','Colorear')

insert into Imagen values ('Menos',1, null)
insert into Imagen values ('Mas',2, null)
insert into Imagen values ('_1',null, null)
insert into Imagen values ('_2',null, null)
insert into Imagen values ('_3',null, null)
insert into Imagen values ('_4',null, null)
insert into Imagen values ('_5',null, null)
insert into Imagen values ('_6',null, null)
insert into Imagen values ('_7',null, null)
insert into Imagen values ('_8',null, null)
insert into Imagen values ('_9',null, null)
insert into Imagen values ('_0',null, null)
insert into Imagen values ('Conejos',3, null)
insert into Imagen values ('Gatos',3, null)
insert into Imagen values ('Loros',3, null)
insert into Imagen values ('Peces',3, null)
insert into Imagen values ('Perros',3, null)

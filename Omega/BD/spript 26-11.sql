
CREATE DATABASE [Omega]

CREATE TABLE [dbo].[Dificultad](
	[IdDificultad] [int] NOT NULL,
	[NombreDificultad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Dificultad_1] PRIMARY KEY CLUSTERED 
(
	[IdDificultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imagen]    Script Date: 26/11/2018 15:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imagen](
	[NombreImagen] [varchar](50) NULL,
	[DescripcionImagen] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Juego]    Script Date: 26/11/2018 15:47:09 ******/
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
/****** Object:  Table [dbo].[JuegoDificultad]    Script Date: 26/11/2018 15:47:09 ******/
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
/****** Object:  Table [dbo].[Movimiento]    Script Date: 26/11/2018 15:47:09 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/11/2018 15:47:09 ******/
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
ALTER TABLE [dbo].[JuegoDificultad]  WITH CHECK ADD  CONSTRAINT [FK_DificultadJuego_Juego] FOREIGN KEY([IdJuego])
REFERENCES [dbo].[Juego] ([IdJuego])
GO
ALTER TABLE [dbo].[JuegoDificultad] CHECK CONSTRAINT [FK_DificultadJuego_Juego]
GO
ALTER TABLE [dbo].[JuegoDificultad]  WITH CHECK ADD  CONSTRAINT [FK_JuegoDificultad_Dificultad] FOREIGN KEY([IdDificultad])
REFERENCES [dbo].[Dificultad] ([IdDificultad])
GO
ALTER TABLE [dbo].[JuegoDificultad] CHECK CONSTRAINT [FK_JuegoDificultad_Dificultad]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Movimiento_JuegoDificultad] FOREIGN KEY([IdJuego], [IdDificultad])
REFERENCES [dbo].[JuegoDificultad] ([IdJuego], [IdDificultad])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK_Movimiento_JuegoDificultad]
GO
/****** Object:  StoredProcedure [dbo].[ListarJuegoDificultad]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarJuegoDificultad]
as
select j.IdJuego, NombreJuego,Descripcion,d.IdDificultad, NombreDificultad from Juego j inner join JuegoDificultad jd on (jd.IdJuego = j.IdJuego) inner join 
Dificultad d on (d.IdDificultad = jd.IdDificultad)
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarImagen]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BuscarImagen]
@nombre varchar(50)
as
select * from Imagen where NombreImagen = @nombre
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUsuarios]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_BuscarUsuarios]
@nombre varchar(50)
as
select IdUsuario,NombreUsuario,Contraseña,isnull(FechaBloqueo,0) as FechaBloqueo,Eliminado from Usuario where NombreUsuario = @nombre and Eliminado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarUsuario]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_EliminarUsuario]
@id int
as
update Usuario set Eliminado = 1 where IdUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarBloqueo]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertarBloqueo]
@fecha datetime, @id int
as
update Usuario set FechaBloqueo = @fecha where IdUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarMovimiento]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarMovimiento]
@puntuacion int, @fecha datetime, @jugador varchar(50), @idJuego int, @idDificultad int
as
insert into Movimiento(Puntuacion,Fecha,Jugador,IdJuego,IdDificultad)
values(@puntuacion,@fecha,@jugador,@idJuego, @idDificultad)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuario]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarUsuario]
@nombre varchar(50), @contraseña varchar(50)
as
insert into Usuario(NombreUsuario,Contraseña,FechaBloqueo,Eliminado)
values(@nombre,@contraseña,null,0)
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarDificultades]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_ListarDificultades]
as
select * from Dificultad
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarImagen]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ListarImagen]
as
select * from Imagen
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarMovimientos]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ListarMovimientos]
as
select Jugador,NombreJuego as Juego, NombreDificultad as Dificultad, Puntuacion, Fecha from Juego  j
inner join JuegoDificultad jd on(j.IdJuego = jd.IdJuego)
inner join Dificultad d on(d.IdDificultad = jd.IdDificultad)
inner join Movimiento m on (m.IdJuego = jd.IdJuego and m.IdDificultad = jd.IdDificultad)
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarUsuario]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ModificarUsuario]
@id int, @contraseña varchar(50)
as
update Usuario set Contraseña = @contraseña where IdUsuario = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_NuevoMovimiento]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_NuevoMovimiento]
@puntuacion int, @fecha datetime, @jugador varchar(50), @idJuego int, @idDificultad int
as
insert into Movimiento(Puntuacion,Fecha,Jugador,IdJuego,IdDificultad) 
values (@puntuacion,@fecha,@jugador,@idJuego,@idDificultad)
GO
/****** Object:  StoredProcedure [dbo].[st_ListarPalabras]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_ListarPalabras]
as 
select * from Palabras
GO
/****** Object:  StoredProcedure [dbo].[st_ListarPersonas]    Script Date: 26/11/2018 15:47:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_ListarPersonas]
as
select IdUsuario as Id ,NombreUsuario as Usuario from Usuario where Eliminado = 0
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

insert into Imagen values ('1', 'AJI')
insert into Imagen values ('2', 'ARDILLA')
insert into Imagen values ('3', 'MUNDO')
insert into Imagen values ('4', 'CHOCLO')
insert into Imagen values ('5', 'TIGRE')
insert into Imagen values ('6', 'CUTTER')
insert into Imagen values ('7', 'ESCUADRA')
insert into Imagen values ('8', 'AUCAUCIL')
insert into Imagen values ('9', 'ARMADILLO')
insert into Imagen values ('10', 'AVIONETA')
insert into Imagen values ('11', 'BANANA')
insert into Imagen values ('12', 'COCODRILO')
insert into Imagen values ('13', 'CRAYONES')
insert into Imagen values ('14', 'BERENJENA')
insert into Imagen values ('15', 'ELEFANTE')
insert into Imagen values ('16', 'GOMA')
insert into Imagen values ('17', 'BROCOLI')
insert into Imagen values ('18', 'HIENA')
insert into Imagen values ('19', 'LAPICES')
insert into Imagen values ('20', 'CALABAZA')
insert into Imagen values ('21', 'HIPOPOTAMO')
insert into Imagen values ('23', 'CEBOLLA')
insert into Imagen values ('24', 'JIRAFA')
insert into Imagen values ('25', 'GORRO')
insert into Imagen values ('26', 'PERA')
insert into Imagen values ('27', 'ZORRILLO')
insert into Imagen values ('28', 'LAPIZ')
insert into Imagen values ('29', 'ZANAHORIA')
insert into Imagen values ('30', 'OSO')
insert into Imagen values ('31', 'SACAPUNTAS')
insert into Imagen values ('32', 'PEPINO')
insert into Imagen values ('33', 'PUERCOESPIN')
insert into Imagen values ('34', 'LIBRO')
insert into Imagen values ('35', 'UVA')
insert into Imagen values ('36', 'MAPACHE')
insert into Imagen values ('37', 'LIBRO')
insert into Imagen values ('38', 'TOMATE')
insert into Imagen values ('39', 'PELICANO')
insert into Imagen values ('40', 'MOCHILA')
insert into Imagen values ('41', 'MORRON')
insert into Imagen values ('42', 'SERPIENTE')
insert into Imagen values ('43', 'REGLA')
insert into Imagen values ('44', 'PALTA')
insert into Imagen values ('45', 'AVESTRUZ')
insert into Imagen values ('46', 'PELOTA')
insert into Imagen values ('47', 'RABANITO')
insert into Imagen values ('49', 'REMOLACHA')
insert into Imagen values ('50', 'SILLA')
insert into Imagen values ('51', 'TIJERA')
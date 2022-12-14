USE [master]
GO
/****** Object:  Database [Ecommerce]    Script Date: 19/10/2022 18:57:12 ******/
CREATE DATABASE [Ecommerce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ecommerce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ESCDIRECTASQL\MSSQL\DATA\Ecommerce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ecommerce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ESCDIRECTASQL\MSSQL\DATA\Ecommerce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ecommerce] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ecommerce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ecommerce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ecommerce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ecommerce] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ecommerce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ecommerce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ecommerce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ecommerce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ecommerce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ecommerce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ecommerce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ecommerce] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ecommerce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ecommerce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ecommerce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ecommerce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ecommerce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ecommerce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ecommerce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ecommerce] SET RECOVERY FULL 
GO
ALTER DATABASE [Ecommerce] SET  MULTI_USER 
GO
ALTER DATABASE [Ecommerce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ecommerce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ecommerce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ecommerce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ecommerce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ecommerce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ecommerce', N'ON'
GO
ALTER DATABASE [Ecommerce] SET QUERY_STORE = OFF
GO
USE [Ecommerce]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[id] [int] NOT NULL,
	[nombreMarca] [nvarchar](50) NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[id] [int] NOT NULL,
	[nombreTipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temporada]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporada](
	[id] [int] NOT NULL,
	[nombreTemporada] [nvarchar](50) NULL,
 CONSTRAINT [PK_Temporada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[id] [int] NOT NULL,
	[nombreSexo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[id] [int] NOT NULL,
	[nombreColor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Talle]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Talle](
	[id] [int] NOT NULL,
	[medida] [nvarchar](50) NULL,
 CONSTRAINT [PK_Talle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promocion]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promocion](
	[id] [int] NOT NULL,
	[nombrePromocion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Promocion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calificacion](
	[id] [int] NOT NULL,
	[valoracion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo] [nvarchar](50) NOT NULL,
	[nombreProducto] [nvarchar](50) NULL,
	[descripcion] [nvarchar](250) NULL,
	[precio] [decimal](18, 2) NULL,
	[stock] [int] NULL,
	[fechaDeAlta] [nvarchar](50) NULL,
	[idMarca] [int] NULL,
	[idTipo] [int] NULL,
	[idTemporada] [int] NULL,
	[idSexo] [int] NULL,
	[idColor] [int] NULL,
	[idTalle] [int] NULL,
	[idPromocion] [int] NULL,
	[idCalificacion] [int] NULL,
	[imagen] [nvarchar](250) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1Producto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1Producto]
AS
SELECT        dbo.Marca.id, dbo.Tipo.id AS Expr1, dbo.Sexo.id AS Expr2, dbo.Color.id AS Expr3, dbo.Talle.id AS Expr4, dbo.Promocion.id AS Expr5, dbo.Calificacion.id AS Expr6
FROM            dbo.Calificacion INNER JOIN
                         dbo.Producto INNER JOIN
                         dbo.Temporada ON dbo.Producto.idTemporada = dbo.Temporada.id INNER JOIN
                         dbo.Marca ON dbo.Producto.idMarca = dbo.Marca.id INNER JOIN
                         dbo.Tipo ON dbo.Producto.idTipo = dbo.Tipo.id INNER JOIN
                         dbo.Sexo ON dbo.Producto.idSexo = dbo.Sexo.id INNER JOIN
                         dbo.Color ON dbo.Producto.idColor = dbo.Color.id INNER JOIN
                         dbo.Talle ON dbo.Producto.idTalle = dbo.Talle.id INNER JOIN
                         dbo.Promocion ON dbo.Producto.idPromocion = dbo.Promocion.id ON dbo.Calificacion.id = dbo.Producto.idCalificacion
GO
/****** Object:  StoredProcedure [dbo].[actualizarProductos]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarProductos]
@codigo nvarchar(50),
@nombreProducto nvarchar(50),
@descripcion nvarchar(250),
@precio decimal(18,2),
@stock integer,
@fechaDeAlta nvarchar(50),
@idMarca integer,
@idTipo integer,
@idTemporada integer,
@idSexo integer,
@idColor integer,
@idTalle integer,
@idPromocion integer,
@idCalificacion integer,
@imagen nvarchar(250)
as
	update Producto set codigo=@codigo,
						nombreProducto=@nombreProducto,
						descripcion=@descripcion,
						precio=@precio,
						stock=@stock,
						fechaDeAlta=@fechaDeAlta,
						idMarca=@idMarca,
						idTipo=@idTipo,
						idTemporada=@idTemporada,
						idSexo=@idSexo,
						idColor=@idColor,
						idTalle=@idTalle,
						idPromocion=@idPromocion,
						idCalificacion=@idCalificacion,
						imagen=@imagen
					where codigo=@codigo;
GO
/****** Object:  StoredProcedure [dbo].[eliminaProducto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminaProducto]
@codigo nvarchar(50)
AS DELETE FROM Producto WHERE codigo=@codigo
RETURN
GO
/****** Object:  StoredProcedure [dbo].[insertarProducto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarProducto] 
@codigo nvarchar(50),
@nombreProducto nvarchar(50),
@descripcion nvarchar(250),
@precio decimal(18,2),
@stock integer,
@fechaDeAlta nvarchar(50),
@idMarca integer,
@idTipo integer,
@idTemporada integer,
@idSexo integer,
@idColor integer,
@idTalle integer,
@idPromocion integer,
@idCalificacion integer,
@imagen nvarchar(250)
as 
insert into Producto (codigo,nombreProducto,descripcion,precio,stock,fechaDeAlta,idMarca,idTipo,idTemporada,idSexo,idColor,idTalle,idPromocion,idCalificacion,imagen) 
values (@codigo,@nombreProducto,@descripcion,@precio,@stock,@fechaDeAlta,@idMarca,@idTipo,@idTemporada,@idSexo,@idColor,@idTalle,@idPromocion,@idCalificacion,@imagen)
GO
/****** Object:  StoredProcedure [dbo].[modificaProducto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modificaProducto]
@codigo nvarchar(50),
@nombreProducto nvarchar(50),
@descripcion nvarchar(250),
@precio decimal(18,2),
@stock integer,
@fechaDeAlta nvarchar(50),
@idMarca integer,
@idTipo integer,
@idTemporada integer,
@idSexo integer,
@idColor integer,
@idTalle integer,
@idPromocion integer,
@idCalificacion integer,
@imagen nvarchar(250)
AS
UPDATE Producto SET codigo=@codigo,nombreProducto=@nombreProducto,descripcion=@descripcion,precio=@precio,stock=@stock,
					fechaDeAlta=@fechaDeAlta,idMarca=@idMarca,idTipo=@idTipo,idTemporada=@idTemporada,	
					idSexo=@idSexo,idColor=@idColor,idTalle=@idTalle,idPromocion=@idPromocion,
					idCalificacion=@idCalificacion,imagen=@imagen
WHERE codigo=@codigo
GO
/****** Object:  StoredProcedure [dbo].[mostrarProducto]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrarProducto]
as
select codigo,nombreProducto,descripcion,precio,stock,Marca.nombreMarca,Tipo.nombreTipo,Temporada.nombreTemporada,Sexo.nombreSexo,
Color.nombreColor,Talle.medida,Promocion.nombrePromocion,Calificacion.valoracion,imagen

from Producto 
inner join Marca on Producto.idMarca=Marca.id 
inner join Temporada on Producto.idTemporada=Temporada.id 
inner join Tipo on Producto.idTipo=Tipo.id
inner join Sexo on Producto.idSexo=Sexo.id
inner join Color on Producto.idColor=Color.id
inner join Talle on Producto.idTalle=Talle.id
inner join Promocion on Producto.idPromocion=Promocion.id
inner join Calificacion on Producto.idCalificacion=Calificacion.id

order by Marca.nombreMarca,Tipo.nombreTipo,Temporada.nombreTemporada,Sexo.nombreSexo,Color.nombreColor,Talle.medida,Promocion.nombrePromocion,Calificacion.valoracion;
GO
/****** Object:  StoredProcedure [dbo].[obtenerProductos]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[obtenerProductos]
as
begin
	select * from Producto
end
GO
/****** Object:  StoredProcedure [dbo].[seleccionProductos]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[seleccionProductos]
as
begin
	select	codigo 'Codigo',
 			nombreProducto 'NombreProducto',
			descripcion 'Descripcion',
			precio 'Precio',
			stock 'Stock',
			fechaDeAlta 'FechaDeAlta',
			idMarca 'IdMarca'	,
			idTipo 'IdTipo',
			idTemporada 'IdTemporada',
			idSexo 'IdSexo',
			idColor 'IdColor',
			idTalle 'IdTalle',
			idPromocion 'IdPromocion',
			idCalificacion 'IdCalificacion',
			imagen 'Imagen'
	from Producto
end
GO
/****** Object:  StoredProcedure [dbo].[SPSProductos]    Script Date: 19/10/2022 18:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPSProductos]
as
begin
	select	codigo 'Codigo',
 			nombreProducto 'NombreProducto',
			descripcion 'Descripcion',
			precio 'Precio',
			stock 'Stock',
			nombreMarca 'Marca'	,
			nombreTipo 'Tipo',
			nombreTemporada 'Temporada',
			nombreSexo 'Sexo',
			nombreColor 'Color',
			medida 'Talle',
			nombrePromocion 'Promocion',
			valoracion 'Calificacion',
			imagen 'Imagen'
	from Producto
		inner join Marca on Producto.idMarca=Marca.id 
		inner join Temporada on Producto.idTemporada=Temporada.id 
		inner join Tipo on Producto.idTipo=Tipo.id
		inner join Sexo on Producto.idSexo=Sexo.id
		inner join Color on Producto.idColor=Color.id
		inner join Talle on Producto.idTalle=Talle.id
		inner join Promocion on Producto.idPromocion=Promocion.id
		inner join Calificacion on Producto.idCalificacion=Calificacion.id

		order by Marca.nombreMarca,Tipo.nombreTipo,Temporada.nombreTemporada,
		Sexo.nombreSexo,Color.nombreColor,Talle.medida,Promocion.nombrePromocion,
		Calificacion.valoracion;
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[74] 4[4] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Calificacion"
            Begin Extent = 
               Top = 345
               Left = 433
               Bottom = 441
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Color"
            Begin Extent = 
               Top = 199
               Left = 87
               Bottom = 295
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Marca"
            Begin Extent = 
               Top = 0
               Left = 437
               Bottom = 96
               Right = 607
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Producto"
            Begin Extent = 
               Top = 9
               Left = 761
               Bottom = 332
               Right = 931
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Promocion"
            Begin Extent = 
               Top = 326
               Left = 270
               Bottom = 422
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sexo"
            Begin Extent = 
               Top = 132
               Left = 35
               Bottom = 228
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Talle"
            Begin Extent = 
               Top = 267
               Left = 188
               Bottom = 363
               Right = 358
            End
            DisplayFlags = 280
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1Producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'           TopColumn = 0
         End
         Begin Table = "Temporada"
            Begin Extent = 
               Top = 34
               Left = 44
               Bottom = 130
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tipo"
            Begin Extent = 
               Top = 12
               Left = 228
               Bottom = 108
               Right = 398
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1Producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1Producto'
GO
USE [master]
GO
ALTER DATABASE [Ecommerce] SET  READ_WRITE 
GO

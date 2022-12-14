USE [master]
GO
/****** Object:  Database [bd_inventario]    Script Date: 27/08/2022 9:07:49 ******/
CREATE DATABASE [bd_inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_inventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_inventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_inventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_inventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd_inventario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_inventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_inventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_inventario] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_inventario] SET  MULTI_USER 
GO
ALTER DATABASE [bd_inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_inventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_inventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_inventario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_inventario', N'ON'
GO
ALTER DATABASE [bd_inventario] SET QUERY_STORE = OFF
GO
USE [bd_inventario]
GO
/****** Object:  Table [dbo].[detalle_entradas]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_entradas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NOT NULL,
	[identrada] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [money] NULL,
 CONSTRAINT [PK_detalleentradas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_salidas]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_salidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NULL,
	[idsalida] [int] NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [money] NULL,
 CONSTRAINT [PK_detalle_salidas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entradas]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[proovedor] [varchar](50) NULL,
	[usuario] [varchar](10) NULL,
	[codigoingreso] [int] NULL,
 CONSTRAINT [PK_entradas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio] [money] NULL,
	[idunidad] [int] NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salidas]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[cliente] [varchar](50) NULL,
	[usuario] [varchar](20) NULL,
	[codigo_salida] [varchar](10) NULL,
	[tipo_pago] [varchar](20) NULL,
 CONSTRAINT [PK_salidas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidades]    Script Date: 27/08/2022 9:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[abreviacion] [varchar](5) NULL,
 CONSTRAINT [PK_unidades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalle_entradas]  WITH CHECK ADD  CONSTRAINT [FK_detalleentradas_entradas] FOREIGN KEY([identrada])
REFERENCES [dbo].[entradas] ([id])
GO
ALTER TABLE [dbo].[detalle_entradas] CHECK CONSTRAINT [FK_detalleentradas_entradas]
GO
ALTER TABLE [dbo].[detalle_entradas]  WITH CHECK ADD  CONSTRAINT [FK_detalleentradas_productos] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([id])
GO
ALTER TABLE [dbo].[detalle_entradas] CHECK CONSTRAINT [FK_detalleentradas_productos]
GO
ALTER TABLE [dbo].[detalle_salidas]  WITH CHECK ADD  CONSTRAINT [FK_detalle_salidas_productos] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([id])
GO
ALTER TABLE [dbo].[detalle_salidas] CHECK CONSTRAINT [FK_detalle_salidas_productos]
GO
ALTER TABLE [dbo].[detalle_salidas]  WITH CHECK ADD  CONSTRAINT [FK_detalle_salidas_salidas] FOREIGN KEY([idsalida])
REFERENCES [dbo].[salidas] ([id])
GO
ALTER TABLE [dbo].[detalle_salidas] CHECK CONSTRAINT [FK_detalle_salidas_salidas]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_unidades] FOREIGN KEY([idunidad])
REFERENCES [dbo].[unidades] ([id])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_unidades]
GO
USE [master]
GO
ALTER DATABASE [bd_inventario] SET  READ_WRITE 
GO

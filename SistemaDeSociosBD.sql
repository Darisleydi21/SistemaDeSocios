USE [master]
GO
/****** Object:  Database [ProyectoAdmin]    Script Date: 12/4/2022 8:32:37 p. m. ******/
CREATE DATABASE [ProyectoAdmin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoAdmin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\ProyectoAdmin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoAdmin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\ProyectoAdmin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProyectoAdmin] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoAdmin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoAdmin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectoAdmin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoAdmin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoAdmin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoAdmin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoAdmin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoAdmin] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoAdmin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoAdmin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoAdmin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoAdmin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoAdmin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoAdmin] SET QUERY_STORE = OFF
GO
USE [ProyectoAdmin]
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 12/4/2022 8:32:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socios](
	[IdSocio] [int] IDENTITY(1,1) NOT NULL,
	[NombreSocio] [varchar](max) NOT NULL,
	[CedulaSocio] [varchar](13) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[TipoMembresia] [varchar](15) NOT NULL,
	[NombreContacto] [varchar](max) NOT NULL,
	[TelefonoContacto] [varchar](12) NOT NULL,
	[MembresiaEmitida] [date] NULL,
	[PagarAntesDe] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Socios] ON 
GO
INSERT [dbo].[Socios] ([IdSocio], [NombreSocio], [CedulaSocio], [Direccion], [Telefono], [TipoMembresia], [NombreContacto], [TelefonoContacto], [MembresiaEmitida], [PagarAntesDe]) VALUES (29, N'Darisleydi Santana', N'402-2952013-6', N'Calle D, Casa 47', N'829-965-8854', N'Gold', N'Rosa Sanchez', N'829-852-8521', CAST(N'2022-04-12' AS Date), CAST(N'2022-05-12' AS Date))
GO
INSERT [dbo].[Socios] ([IdSocio], [NombreSocio], [CedulaSocio], [Direccion], [Telefono], [TipoMembresia], [NombreContacto], [TelefonoContacto], [MembresiaEmitida], [PagarAntesDe]) VALUES (53, N'Jose Perez', N'40215421024', N'Colinas del Ozama', N' 8296251425', N'Plata', N'Maria Perez', N'8496526521', CAST(N'2022-04-12' AS Date), CAST(N'2022-05-12' AS Date))
GO
INSERT [dbo].[Socios] ([IdSocio], [NombreSocio], [CedulaSocio], [Direccion], [Telefono], [TipoMembresia], [NombreContacto], [TelefonoContacto], [MembresiaEmitida], [PagarAntesDe]) VALUES (54, N'Maria Lopez', N'40228654102', N'Calle C, Esq 3ra, Casa #1', N' 8296065482', N'Basica', N'Rosa Lopez', N'8295214758', CAST(N'2022-04-12' AS Date), CAST(N'2022-05-12' AS Date))
GO
INSERT [dbo].[Socios] ([IdSocio], [NombreSocio], [CedulaSocio], [Direccion], [Telefono], [TipoMembresia], [NombreContacto], [TelefonoContacto], [MembresiaEmitida], [PagarAntesDe]) VALUES (55, N'Rosa Garcia', N'40251478465', N'Calle 2da Esq 3ra', N' 8095622352', N'Basica', N'Juan Garcia', N'8496525412', CAST(N'2022-04-12' AS Date), CAST(N'2022-05-12' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Socios] OFF
GO
ALTER TABLE [dbo].[Socios] ADD  DEFAULT (getdate()) FOR [MembresiaEmitida]
GO
/****** Object:  Trigger [dbo].[PagarAntes]    Script Date: 12/4/2022 8:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[PagarAntes] on [dbo].[Socios]
after insert, update
as 
begin

 declare @IdSocio int;
 Declare @NombreSocio varchar(max);
 Declare @CedulaSocio varchar(13);
 Declare @Direccion varchar(max);
 declare @Telefono varchar(12);
  declare @TipoMembresia varchar(15);
 declare @NombreContacto varchar(max);
 declare @TelefonoContacto varchar(12);
 declare @MembresiaEmitida  Date;
 declare @PagarAntesDe Date;

 Select @IdSocio=IdSocio,@NombreSocio=NombreSocio,@CedulaSocio=CedulaSocio,
 @Direccion=Direccion, @Telefono=Telefono, @TipoMembresia=TipoMembresia,@NombreContacto=NombreContacto,
 @TelefonoContacto=TelefonoContacto,@MembresiaEmitida=MembresiaEmitida,@PagarAntesDe=PagarAntesDe from inserted;

Set @PagarAntesDe = DATEADD(MONTH, 1, @MembresiaEmitida)
update Socios set PagarAntesDe=@PagarAntesDe where IdSocio=@IdSocio;
end
GO
ALTER TABLE [dbo].[Socios] ENABLE TRIGGER [PagarAntes]
GO
USE [master]
GO
ALTER DATABASE [ProyectoAdmin] SET  READ_WRITE 
GO

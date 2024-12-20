USE [master]
GO
/****** Object:  Database [BiblioDB]    Script Date: 05/12/2024 20:18:14 ******/
CREATE DATABASE [BiblioDB]
GO
ALTER DATABASE [BiblioDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BiblioDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BiblioDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BiblioDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BiblioDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BiblioDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BiblioDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BiblioDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BiblioDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BiblioDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BiblioDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BiblioDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BiblioDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BiblioDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BiblioDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BiblioDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BiblioDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BiblioDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BiblioDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BiblioDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BiblioDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BiblioDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BiblioDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BiblioDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BiblioDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BiblioDB] SET  MULTI_USER 
GO
ALTER DATABASE [BiblioDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BiblioDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BiblioDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BiblioDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BiblioDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BiblioDB] SET QUERY_STORE = OFF
GO
USE [BiblioDB]
GO
/****** Object:  Table [dbo].[Livre]    Script Date: 05/12/2024 20:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livre](
	[CodeL] [varchar](10) NOT NULL,
	[Titre] [varchar](100) NOT NULL,
	[Auteur] [varchar](100) NULL,
	[NbExemplaires] [int] NULL,
	[CodeTh] [int] NULL,
 CONSTRAINT [PK_Livre] PRIMARY KEY CLUSTERED 
(
	[CodeL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[table_Virtuelle]    Script Date: 05/12/2024 20:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--table virtuelle = preparation des données
CREATE VIEW [dbo].[table_Virtuelle]
AS 
 SELECT * FROM Livre
 WHERE auteur = 'Mohamed'
GO
/****** Object:  Table [dbo].[Adherent]    Script Date: 05/12/2024 20:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adherent](
	[CodeA] [varchar](4) NOT NULL,
	[NomA] [varchar](100) NULL,
	[Adresse] [varchar](200) NULL,
	[DateInscription] [datetime] NULL,
 CONSTRAINT [PK_Adherent] PRIMARY KEY CLUSTERED 
(
	[CodeA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emprunt]    Script Date: 05/12/2024 20:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emprunt](
	[CodeA] [varchar](4) NOT NULL,
	[CodeL] [varchar](10) NOT NULL,
	[dateEmprunt] [datetime] NULL,
	[dateRetour] [datetime] NULL,
 CONSTRAINT [PK_Emprunt] PRIMARY KEY CLUSTERED 
(
	[CodeA] ASC,
	[CodeL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Theme]    Script Date: 05/12/2024 20:18:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Theme](
	[CodeTh] [int] IDENTITY(1,1) NOT NULL,
	[IntituleTh] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeTh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Adherent] ([CodeA], [NomA], [Adresse], [DateInscription]) VALUES (N'A01', N'Mohamed', N'adresse Mohamed', CAST(N'2021-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Adherent] ([CodeA], [NomA], [Adresse], [DateInscription]) VALUES (N'A02', N'Said', N'adresse Said', CAST(N'2022-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Adherent] ([CodeA], [NomA], [Adresse], [DateInscription]) VALUES (N'A03', N'Serroukh', N'adr serroukh', CAST(N'2024-11-22T20:59:35.000' AS DateTime))
INSERT [dbo].[Adherent] ([CodeA], [NomA], [Adresse], [DateInscription]) VALUES (N'A04', N'ali', N'adresse de ali', CAST(N'2024-11-26T19:17:15.540' AS DateTime))
GO
INSERT [dbo].[Emprunt] ([CodeA], [CodeL], [dateEmprunt], [dateRetour]) VALUES (N'A01', N'L01', CAST(N'2024-11-21T00:00:00.000' AS DateTime), CAST(N'2024-11-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Emprunt] ([CodeA], [CodeL], [dateEmprunt], [dateRetour]) VALUES (N'A01', N'L03', CAST(N'2024-11-26T00:00:00.000' AS DateTime), CAST(N'2024-11-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Emprunt] ([CodeA], [CodeL], [dateEmprunt], [dateRetour]) VALUES (N'A02', N'L04', CAST(N'2024-11-26T21:11:33.407' AS DateTime), CAST(N'2024-11-27T21:11:45.000' AS DateTime))
GO
INSERT [dbo].[Livre] ([CodeL], [Titre], [Auteur], [NbExemplaires], [CodeTh]) VALUES (N'L01', N'Intro Math', N'Mohamed', 100, 3)
INSERT [dbo].[Livre] ([CodeL], [Titre], [Auteur], [NbExemplaires], [CodeTh]) VALUES (N'L02', N'Physique facile', N'Mohamed', 50, 3)
INSERT [dbo].[Livre] ([CodeL], [Titre], [Auteur], [NbExemplaires], [CodeTh]) VALUES (N'L03', N'Init Windows', N'Moad', 40, 2)
INSERT [dbo].[Livre] ([CodeL], [Titre], [Auteur], [NbExemplaires], [CodeTh]) VALUES (N'L04', N'Intro Economie', N'Fanni ', 60, 1)
GO
SET IDENTITY_INSERT [dbo].[Theme] ON 

INSERT [dbo].[Theme] ([CodeTh], [IntituleTh]) VALUES (1, N'Economie')
INSERT [dbo].[Theme] ([CodeTh], [IntituleTh]) VALUES (2, N'Informatique')
INSERT [dbo].[Theme] ([CodeTh], [IntituleTh]) VALUES (3, N'Mathematiques')
SET IDENTITY_INSERT [dbo].[Theme] OFF
GO
ALTER TABLE [dbo].[Emprunt]  WITH CHECK ADD  CONSTRAINT [FK_Emprunt_Emprunt] FOREIGN KEY([CodeA])
REFERENCES [dbo].[Adherent] ([CodeA])
GO
ALTER TABLE [dbo].[Emprunt] CHECK CONSTRAINT [FK_Emprunt_Emprunt]
GO
ALTER TABLE [dbo].[Emprunt]  WITH CHECK ADD  CONSTRAINT [FK_Emprunt_Livre] FOREIGN KEY([CodeL])
REFERENCES [dbo].[Livre] ([CodeL])
GO
ALTER TABLE [dbo].[Emprunt] CHECK CONSTRAINT [FK_Emprunt_Livre]
GO
ALTER TABLE [dbo].[Livre]  WITH CHECK ADD FOREIGN KEY([CodeTh])
REFERENCES [dbo].[Theme] ([CodeTh])
GO
USE [master]
GO
ALTER DATABASE [BiblioDB] SET  READ_WRITE 
GO

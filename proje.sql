USE [master]
GO
/****** Object:  Database [YzmSnmProje]    Script Date: 21.12.2018 10:15:09 ******/
CREATE DATABASE [YzmSnmProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YzmSnmProje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014EXPRESS\MSSQL\DATA\YzmSnmProje.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YzmSnmProje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014EXPRESS\MSSQL\DATA\YzmSnmProje_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YzmSnmProje] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YzmSnmProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YzmSnmProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YzmSnmProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YzmSnmProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YzmSnmProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YzmSnmProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [YzmSnmProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YzmSnmProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YzmSnmProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YzmSnmProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YzmSnmProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YzmSnmProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YzmSnmProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YzmSnmProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YzmSnmProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YzmSnmProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YzmSnmProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YzmSnmProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YzmSnmProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YzmSnmProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YzmSnmProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YzmSnmProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YzmSnmProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YzmSnmProje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YzmSnmProje] SET  MULTI_USER 
GO
ALTER DATABASE [YzmSnmProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YzmSnmProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YzmSnmProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YzmSnmProje] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YzmSnmProje] SET DELAYED_DURABILITY = DISABLED 
GO
USE [YzmSnmProje]
GO
/****** Object:  Table [dbo].[DepartmanTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmanTBL](
	[DepID] [int] IDENTITY(1,1) NOT NULL,
	[DepIsim] [nvarchar](250) NULL,
 CONSTRAINT [PK_DepartmanTBL] PRIMARY KEY CLUSTERED 
(
	[DepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KategoriTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KategoriTBL](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[Kategori] [nvarchar](250) NULL,
 CONSTRAINT [PK_KategoriTBL] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MarkaTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MarkaTBL](
	[MarkaID] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [nvarchar](150) NULL,
 CONSTRAINT [PK_MarkaTBL] PRIMARY KEY CLUSTERED 
(
	[MarkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelTBL](
	[PerID] [int] IDENTITY(1,1) NOT NULL,
	[PerIsim] [nvarchar](250) NULL,
	[PerSoyisim] [nvarchar](250) NULL,
	[PerTelefon] [nvarchar](50) NULL,
	[PerAdres] [nvarchar](250) NULL,
	[PerDepID] [int] NULL,
 CONSTRAINT [PK_PersonelTBL] PRIMARY KEY CLUSTERED 
(
	[PerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleTBL](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](150) NULL,
 CONSTRAINT [PK_RoleTBL] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokDurumTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokDurumTBL](
	[StokDurumID] [int] IDENTITY(1,1) NOT NULL,
	[StokDurum] [nvarchar](50) NULL,
 CONSTRAINT [PK_StokDurumTBL] PRIMARY KEY CLUSTERED 
(
	[StokDurumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokHareketleriTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokHareketleriTBL](
	[StokHareketID] [int] IDENTITY(1,1) NOT NULL,
	[StokID] [int] NULL,
	[StokHareketTipiID] [int] NULL,
	[Tarih] [nvarchar](50) NULL,
	[UserID] [int] NULL,
	[KimdenID] [int] NULL,
	[KimeID] [int] NULL,
 CONSTRAINT [PK_StokHareketleriTBL] PRIMARY KEY CLUSTERED 
(
	[StokHareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokHareketTipiTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokHareketTipiTBL](
	[StokHareketTipiID] [int] NOT NULL,
	[StokHareketTip] [nvarchar](150) NULL,
 CONSTRAINT [PK_StokHareketTipiTBL] PRIMARY KEY CLUSTERED 
(
	[StokHareketTipiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StokTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokTBL](
	[StokID] [int] IDENTITY(1,1) NOT NULL,
	[UrunID] [int] NULL,
	[AlisFiyati] [nvarchar](50) NULL,
	[TedarikciID] [int] NULL,
	[FaturaTarihi] [nvarchar](50) NULL,
	[FaturaNo] [nvarchar](50) NULL,
	[StokDurumID] [int] NULL,
	[ZimmetliID] [int] NULL,
 CONSTRAINT [PK_StokTBL] PRIMARY KEY CLUSTERED 
(
	[StokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TedarikciTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TedarikciTBL](
	[TedarikciID] [int] IDENTITY(1,1) NOT NULL,
	[TedarikciIsim] [nvarchar](250) NULL,
	[TedarikciAdres] [nvarchar](250) NULL,
 CONSTRAINT [PK_TedarikciTBL] PRIMARY KEY CLUSTERED 
(
	[TedarikciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunTBL](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunIsim] [nvarchar](250) NULL,
	[UrunMarkaID] [int] NULL,
	[UrunKategoriID] [int] NULL,
 CONSTRAINT [PK_UrunTBL] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserHareketTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHareketTBL](
	[UserHareketID] [int] IDENTITY(1,1) NOT NULL,
	[PerID] [int] NULL,
	[UserID] [int] NULL,
	[Tarih] [nvarchar](50) NULL,
	[IslemLog] [nvarchar](250) NULL,
 CONSTRAINT [PK_UserHareketeTBL] PRIMARY KEY CLUSTERED 
(
	[UserHareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTBL]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTBL](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[PerID] [int] NOT NULL,
	[UserName] [nvarchar](150) NULL,
	[PassWord] [nvarchar](150) NULL,
	[RoleID] [int] NULL,
	[Aktif] [int] NULL,
 CONSTRAINT [PK_UserTBL_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AtiktakilerView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AtiktakilerView]
AS
SELECT        UrunID, COUNT(StokDurumID) AS ATIK
FROM            dbo.StokTBL
WHERE        (StokDurumID = 3)
GROUP BY UrunID
GO
/****** Object:  View [dbo].[DepodakilerView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DepodakilerView]
AS
SELECT        UrunID, COUNT(StokDurumID) AS DEPO
FROM            dbo.StokTBL
WHERE        (StokDurumID = 1)
GROUP BY UrunID
GO
/****** Object:  View [dbo].[ZimmettekilerView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ZimmettekilerView]
AS
SELECT        UrunID, COUNT(StokDurumID) AS ZIMMET
FROM            dbo.StokTBL
WHERE        (StokDurumID = 2)
GROUP BY UrunID
GO
/****** Object:  View [dbo].[StockView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StockView]
AS
SELECT        dbo.UrunTBL.UrunID, dbo.KategoriTBL.Kategori, dbo.MarkaTBL.Marka, dbo.UrunTBL.UrunIsim, ISNULL(dbo.DepodakilerView.DEPO, 0) AS DEPO, ISNULL(dbo.ZimmettekilerView.ZIMMET, 0) AS ZIMMET, 
                         ISNULL(dbo.AtiktakilerView.ATIK, 0) AS ATIK
FROM            dbo.AtiktakilerView FULL OUTER JOIN
                         dbo.UrunTBL ON dbo.AtiktakilerView.UrunID = dbo.UrunTBL.UrunID FULL OUTER JOIN
                         dbo.DepodakilerView ON dbo.UrunTBL.UrunID = dbo.DepodakilerView.UrunID FULL OUTER JOIN
                         dbo.ZimmettekilerView ON dbo.UrunTBL.UrunID = dbo.ZimmettekilerView.UrunID INNER JOIN
                         dbo.KategoriTBL ON dbo.UrunTBL.UrunKategoriID = dbo.KategoriTBL.KategoriID INNER JOIN
                         dbo.MarkaTBL ON dbo.UrunTBL.UrunMarkaID = dbo.MarkaTBL.MarkaID
GO
/****** Object:  View [dbo].[StokHareketView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StokHareketView]
AS
SELECT        dbo.StokHareketleriTBL.Tarih, PersonelTBL_1.PerIsim AS Fad, PersonelTBL_1.PerSoyisim AS Fsoyad, dbo.StokHareketTipiTBL.StokHareketTip, dbo.PersonelTBL.PerIsim AS Tad, 
                         dbo.PersonelTBL.PerSoyisim AS Tsoyad, dbo.StokHareketleriTBL.StokID, dbo.StokHareketleriTBL.StokHareketID, dbo.UserTBL.PerID, PersonelTBL_2.PerIsim, PersonelTBL_2.PerSoyisim, 
                         dbo.StokHareketTipiTBL.StokHareketTipiID
FROM            dbo.StokHareketleriTBL INNER JOIN
                         dbo.StokHareketTipiTBL ON dbo.StokHareketleriTBL.StokHareketTipiID = dbo.StokHareketTipiTBL.StokHareketTipiID INNER JOIN
                         dbo.UserTBL ON dbo.StokHareketleriTBL.UserID = dbo.UserTBL.UserID INNER JOIN
                         dbo.PersonelTBL AS PersonelTBL_2 ON dbo.UserTBL.PerID = PersonelTBL_2.PerID LEFT OUTER JOIN
                         dbo.PersonelTBL ON dbo.StokHareketleriTBL.KimeID = dbo.PersonelTBL.PerID LEFT OUTER JOIN
                         dbo.PersonelTBL AS PersonelTBL_1 ON dbo.StokHareketleriTBL.KimdenID = PersonelTBL_1.PerID
GO
/****** Object:  View [dbo].[ZimmetView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ZimmetView]
AS
SELECT        dbo.StokHareketView.*, dbo.UrunTBL.UrunIsim
FROM            dbo.StokHareketView INNER JOIN
                         dbo.StokTBL ON dbo.StokHareketView.StokID = dbo.StokTBL.StokID INNER JOIN
                         dbo.UrunTBL ON dbo.StokTBL.UrunID = dbo.UrunTBL.UrunID
GO
/****** Object:  View [dbo].[PersonelView_1]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PersonelView_1]
AS
SELECT        dbo.PersonelTBL.*, dbo.UserTBL.UserID, dbo.UserTBL.UserName, dbo.UserTBL.PassWord, dbo.UserTBL.RoleID AS Expr1, dbo.UserTBL.Aktif, dbo.RoleTBL.RoleName, dbo.DepartmanTBL.DepIsim
FROM            dbo.DepartmanTBL INNER JOIN
                         dbo.PersonelTBL ON dbo.DepartmanTBL.DepID = dbo.PersonelTBL.PerDepID LEFT OUTER JOIN
                         dbo.RoleTBL INNER JOIN
                         dbo.UserTBL ON dbo.RoleTBL.RoleID = dbo.UserTBL.RoleID ON dbo.PersonelTBL.PerID = dbo.UserTBL.PerID
GO
/****** Object:  View [dbo].[UrunlerView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UrunlerView]
AS
SELECT        dbo.UrunTBL.UrunID, dbo.KategoriTBL.Kategori, dbo.MarkaTBL.Marka, dbo.UrunTBL.UrunIsim, dbo.UrunTBL.UrunMarkaID, dbo.UrunTBL.UrunKategoriID
FROM            dbo.UrunTBL INNER JOIN
                         dbo.MarkaTBL ON dbo.UrunTBL.UrunMarkaID = dbo.MarkaTBL.MarkaID INNER JOIN
                         dbo.KategoriTBL ON dbo.UrunTBL.UrunKategoriID = dbo.KategoriTBL.KategoriID
GO
/****** Object:  View [dbo].[UserHareketleriView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserHareketleriView]
AS
SELECT        dbo.PersonelTBL.PerIsim, dbo.PersonelTBL.PerSoyisim, dbo.UserHareketTBL.Tarih, dbo.UserHareketTBL.IslemLog, dbo.UserHareketTBL.PerID
FROM            dbo.UserTBL INNER JOIN
                         dbo.UserHareketTBL ON dbo.UserTBL.UserID = dbo.UserHareketTBL.UserID INNER JOIN
                         dbo.PersonelTBL ON dbo.UserTBL.PerID = dbo.PersonelTBL.PerID
GO
/****** Object:  View [dbo].[UserView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserView]
AS
SELECT        dbo.PersonelTBL.PerID, dbo.PersonelTBL.PerIsim, dbo.PersonelTBL.PerSoyisim, ISNULL(dbo.UserTBL.UserID, '') AS UserID, ISNULL(dbo.UserTBL.UserName, '') AS UserName, ISNULL(dbo.UserTBL.PassWord, 
                         '') AS PassWord, ISNULL(dbo.UserTBL.Aktif, '') AS Aktif, ISNULL(dbo.RoleTBL.RoleName, '') AS RoleName, dbo.DepartmanTBL.DepIsim, ISNULL(dbo.UserTBL.RoleID, '') AS RoleID, 
                         dbo.PersonelTBL.PerDepID
FROM            dbo.DepartmanTBL INNER JOIN
                         dbo.PersonelTBL ON dbo.DepartmanTBL.DepID = dbo.PersonelTBL.PerDepID LEFT OUTER JOIN
                         dbo.RoleTBL INNER JOIN
                         dbo.UserTBL ON dbo.RoleTBL.RoleID = dbo.UserTBL.RoleID ON dbo.PersonelTBL.PerID = dbo.UserTBL.PerID
GO
/****** Object:  View [dbo].[ZimmetliStockView]    Script Date: 21.12.2018 10:15:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ZimmetliStockView]
AS
SELECT        dbo.StokTBL.StokID, dbo.UrunTBL.UrunIsim, dbo.KategoriTBL.Kategori, dbo.MarkaTBL.Marka, dbo.PersonelTBL.PerIsim, dbo.PersonelTBL.PerSoyisim, dbo.StokTBL.StokDurumID, 
                         ISNULL(dbo.PersonelTBL.PerID, 0) AS PersonelID, ISNULL(dbo.PersonelTBL.PerDepID, 0) AS DepID
FROM            dbo.StokTBL INNER JOIN
                         dbo.UrunTBL ON dbo.StokTBL.UrunID = dbo.UrunTBL.UrunID INNER JOIN
                         dbo.KategoriTBL ON dbo.UrunTBL.UrunKategoriID = dbo.KategoriTBL.KategoriID INNER JOIN
                         dbo.MarkaTBL ON dbo.UrunTBL.UrunMarkaID = dbo.MarkaTBL.MarkaID LEFT OUTER JOIN
                         dbo.PersonelTBL ON dbo.StokTBL.ZimmetliID = dbo.PersonelTBL.PerID
GO
SET IDENTITY_INSERT [dbo].[DepartmanTBL] ON 

INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (1, N'SATIŞ')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (2, N'PAZARLAMA')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (3, N'MUHASEBE')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (4, N'HUKUK')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (5, N'LOJİSTİK')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (6, N'GÜVENLİK')
INSERT [dbo].[DepartmanTBL] ([DepID], [DepIsim]) VALUES (9, N'Test Departman')
SET IDENTITY_INSERT [dbo].[DepartmanTBL] OFF
SET IDENTITY_INSERT [dbo].[KategoriTBL] ON 

INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (1, N'ANAKARTLAR')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (2, N'BELLEKLER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (3, N'BİLGİSAYAR')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (4, N'BİLGİSAYAR KASALARI')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (5, N'DVD VE BLU-RAY')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (6, N'EKRAN KARTLARI')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (7, N'GÜÇ KAYNAKLARI')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (8, N'HARD DİSK')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (9, N'HARDDİSK KUTULARI')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (10, N'HARİCİ DİSKLER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (11, N'İŞLEMCİLER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (12, N'KLAVYELER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (13, N'MONİTÖRLER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (14, N'MOUSE')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (15, N'MULTİMEDYA KARTLAR')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (16, N'OEM TAVSİYE SİSTEMLER')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (17, N'OEM ÜRÜNLERİ')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (18, N'SOĞUTMA SİSTEMLERİ')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (19, N'SOLİD STATE DİSK')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (20, N'USB BELLEK')
INSERT [dbo].[KategoriTBL] ([KategoriID], [Kategori]) VALUES (23, N'TEST KATEGORİ')
SET IDENTITY_INSERT [dbo].[KategoriTBL] OFF
SET IDENTITY_INSERT [dbo].[MarkaTBL] ON 

INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (1, N'A4 TECH')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (2, N'ACER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (3, N'AMD')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (4, N'AOC')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (5, N'APPLE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (6, N'ASUS')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (7, N'BEATS')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (8, N'BENQ')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (9, N'COOLER MASTER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (10, N'CORSAIR')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (11, N'CRUCIAL')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (12, N'DELL')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (13, N'EVEREST')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (14, N'EVERPAD')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (15, N'EVGA')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (16, N'EXPER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (17, N'FRISBY')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (18, N'GIGABYTE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (19, N'GSKILL')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (20, N'HOMETECH')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (21, N'HP')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (22, N'INCA')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (23, N'INTEL')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (24, N'KINGSTON')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (25, N'LENOVO')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (26, N'LG')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (27, N'LOGITECH')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (28, N'MICROSOFT')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (29, N'MSI')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (30, N'OCZ')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (31, N'OEM')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (32, N'PHILLIPS')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (33, N'PIONEER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (34, N'PNY')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (35, N'RAMPAGE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (36, N'RAZER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (37, N'REEDER')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (38, N'SAMSUNG')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (39, N'SANDISK')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (40, N'SAPPHIRE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (41, N'SEAGEATE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (42, N'S-LINK')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (43, N'THERMALTAKE')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (44, N'TOSHIBA')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (45, N'TRANSCEND')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (46, N'TRUST')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (47, N'VIEWSONIC')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (48, N'WD')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (49, N'XIGMATEK')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (50, N'ZALMAN')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (51, N'ZOTAC')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (52, N'ZYXEL')
INSERT [dbo].[MarkaTBL] ([MarkaID], [Marka]) VALUES (56, N'TEST MARKA')
SET IDENTITY_INSERT [dbo].[MarkaTBL] OFF
SET IDENTITY_INSERT [dbo].[PersonelTBL] ON 

INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (1, N'ORÇUN', N'ÖZDİL', N'2245', N'KARABAĞLAR İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (2, N'ERGEN', N'ALTIPARMAK', N'2206', N'GAZİEMİR İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (3, N'MURAT', N'CANDAN', N'2185', N'KONAK İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (4, N'AYŞE ', N'HANDAN', N'3245', N'TURGUTLU MANİSA', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (5, N'FERİT', N'KÖROĞLU', N'1147', N'KARŞIYAKA İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (6, N'İLHAN', N'YÜKSEL
', N'4126', N'BORNOVA İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (7, N'BARIŞ', N'KOCATAŞ', N'4124', N'URLA İZMİR', 3)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (8, N'MEHMET', N'GÜNEY', N'4450', N'ÇANKAYA ANKARA', 4)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (9, N'SERAP', N'KILIÇÇIOĞLU', N'2790', N'MERKEZ MANİSA', 5)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (10, N'BARIŞ', N'ERGEZER', N'3237', N'KARŞIYAKA İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (11, N'NİHAL', N'YILMAZ', N'3251', N'BORNOVA İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (12, N'HAMZA', N'SUNGUR', N'4452', N'BEYLİKDÜZÜ İSTANBUL', 3)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (13, N'MERVE', N'MARAŞ', N'4726', N'ATAŞEHİR İSTANBUL', 4)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (14, N'ERDAL', N'AKÇAMLI', N'3585', N'KADIKÖY İSTANBUL', 5)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (15, N'AHMET', N'BARIŞ', N'4612', N'BAYRAKLI İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (16, N'EMİNE', N'KORKMAZ', N'2423', N'MERKEZ ANTALYA', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (17, N'ŞENAY', N'ATILGAN', N'6472', N'KOCAELİ İZMİT', 3)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (18, N'FATMA', N'BİLGİLİ', N'4440', N'BAĞCILAR İSTANBUL', 4)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (19, N'BÜLENT', N'AY', N'4314', N'MERKEZ AYDIN', 5)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (20, N'ERDEM', N'YILDIZ', N'3265', N'KARABAĞLAR İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (21, N'TEMEL', N'YILMAZ', N'3211', N'KARABAĞLAR İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (22, N'ESMA', N'ŞENGÜL', N'4315', N'BORNOVA İZMİR', 3)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (23, N'MUSTAFA', N'EZER', N'1345', N'ÇANKAYA ANKARA', 4)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (24, N'İRFAN', N'KINACI', N'1565', N'BAYRAKLI İZMİR', 5)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (25, N'AHMET', N'GÖK', N'3278', N'BORNOVA İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (26, N'FİLİZ', N'BABADAĞ', N'3265', N'BAYRAKLI İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (27, N'İSMAİL', N'SAYGULU', N'1122', N'KARABAĞLAR İZMİR', 3)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (28, N'SUPHİ', N'AKKOYUN', N'3212', N'BORNOVA İZMİR', 4)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (29, N'ÖZGE', N'İŞÇİ', N'4524', N'BAYRAKLI İZMİR', 5)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (30, N'EMİR', N'ÖZER', N'2655', N'BAYRAKLI İZMİR', 1)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (31, N'AHMET', N'TAŞÇI', N'4163', N'BORNOVA İZMİR', 2)
INSERT [dbo].[PersonelTBL] ([PerID], [PerIsim], [PerSoyisim], [PerTelefon], [PerAdres], [PerDepID]) VALUES (35, N'Test Ad', N'Test Soyad', N'1234', N'Test İzmir', 9)
SET IDENTITY_INSERT [dbo].[PersonelTBL] OFF
SET IDENTITY_INSERT [dbo].[RoleTBL] ON 

INSERT [dbo].[RoleTBL] ([RoleID], [RoleName]) VALUES (1, N'ADMİN')
INSERT [dbo].[RoleTBL] ([RoleID], [RoleName]) VALUES (2, N'SATIN ALMA GÖREVLİSİ')
INSERT [dbo].[RoleTBL] ([RoleID], [RoleName]) VALUES (3, N'BÖLÜM ŞEFİ')
SET IDENTITY_INSERT [dbo].[RoleTBL] OFF
SET IDENTITY_INSERT [dbo].[StokDurumTBL] ON 

INSERT [dbo].[StokDurumTBL] ([StokDurumID], [StokDurum]) VALUES (1, N'STOKTA')
INSERT [dbo].[StokDurumTBL] ([StokDurumID], [StokDurum]) VALUES (2, N'ZİMMETLİ')
INSERT [dbo].[StokDurumTBL] ([StokDurumID], [StokDurum]) VALUES (3, N'ATIK')
SET IDENTITY_INSERT [dbo].[StokDurumTBL] OFF
SET IDENTITY_INSERT [dbo].[StokHareketleriTBL] ON 

INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (31, 14, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (32, 15, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (33, 16, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (34, 14, 2, N'14.12.2018', 1, NULL, 1)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (35, 14, 3, N'14.12.2018', 1, 1, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (36, 14, 2, N'14.12.2018', 1, NULL, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (37, 14, 3, N'14.12.2018', 1, 2, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (38, 14, 2, N'14.12.2018', 1, NULL, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (39, 14, 3, N'14.12.2018', 1, 2, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (40, 17, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (41, 18, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (42, 19, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (43, 20, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (44, 21, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (45, 22, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (46, 23, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (47, 24, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (48, 25, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (49, 26, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (50, 27, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (51, 28, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (52, 29, 1, N'14.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (53, 27, 2, N'14.12.2018', 1, NULL, 3)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (54, 27, 3, N'14.12.2018', 1, 3, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (55, 15, 2, N'14.12.2018', 1, NULL, 3)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (56, 15, 3, N'14.12.2018', 1, 3, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (57, 15, 2, N'14.12.2018', 1, NULL, 3)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (58, 16, 2, N'14.12.2018', 1, NULL, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (59, 15, 3, N'14.12.2018', 1, 3, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (60, 15, 2, N'14.12.2018', 1, NULL, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (61, 17, 2, N'14.12.2018', 1, NULL, 1)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (62, 16, 3, N'14.12.2018', 1, 2, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (63, 15, 3, N'14.12.2018', 1, 2, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (64, 15, 2, N'14.12.2018', 1, NULL, 1)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (65, 15, 3, N'14.12.2018', 1, 1, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (66, 17, 3, N'14.12.2018', 1, 1, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (67, 15, 2, N'14.12.2018', 1, NULL, 3)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (68, 16, 2, N'14.12.2018', 1, NULL, 1)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (69, 16, 2, N'14.12.2018', 1, 1, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (70, 16, 2, N'15.12.2018', 1, 2, 3)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (71, 27, 2, N'15.12.2018', 1, NULL, 2)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1040, 15, 2, N'19.12.2018', 1, 3, 1)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1041, 1017, 1, N'19.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1042, 1018, 1, N'19.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1043, 1019, 1, N'19.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1044, 1020, 1, N'19.12.2018', 1, NULL, NULL)
INSERT [dbo].[StokHareketleriTBL] ([StokHareketID], [StokID], [StokHareketTipiID], [Tarih], [UserID], [KimdenID], [KimeID]) VALUES (1045, 1021, 1, N'19.12.2018', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[StokHareketleriTBL] OFF
INSERT [dbo].[StokHareketTipiTBL] ([StokHareketTipiID], [StokHareketTip]) VALUES (1, N'Tedarikçiden Depoya')
INSERT [dbo].[StokHareketTipiTBL] ([StokHareketTipiID], [StokHareketTip]) VALUES (2, N'Depodan kisiye')
INSERT [dbo].[StokHareketTipiTBL] ([StokHareketTipiID], [StokHareketTip]) VALUES (3, N'Kişiden depoya')
INSERT [dbo].[StokHareketTipiTBL] ([StokHareketTipiID], [StokHareketTip]) VALUES (4, N'Kişiden atığa')
SET IDENTITY_INSERT [dbo].[StokTBL] ON 

INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (14, 1, N'1250', 1, N'14.12.2018', N'a123456', 3, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (15, 1, N'1250', 1, N'14.12.2018', N'a123456', 2, 1)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (16, 1, N'1250', 1, N'14.12.2018', N'a123456', 2, 3)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (17, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (18, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (19, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (20, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (21, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (22, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (23, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (24, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (25, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (26, 3, N'15', 4, N'14.12.2018', N'F 012545', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (27, 12, N'1755', 5, N'14.12.2018', N'F 124578', 2, 2)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (28, 12, N'1755', 5, N'14.12.2018', N'F 124578', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (29, 12, N'1755', 5, N'14.12.2018', N'F 124578', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (1017, 3, N'15', 1, N'19.12.2018', N'F Deneme123', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (1018, 3, N'15', 1, N'19.12.2018', N'F Deneme123', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (1019, 3, N'15', 1, N'19.12.2018', N'F Deneme123', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (1020, 3, N'15', 1, N'19.12.2018', N'F Deneme123', 1, NULL)
INSERT [dbo].[StokTBL] ([StokID], [UrunID], [AlisFiyati], [TedarikciID], [FaturaTarihi], [FaturaNo], [StokDurumID], [ZimmetliID]) VALUES (1021, 3, N'15', 1, N'19.12.2018', N'F Deneme123', 1, NULL)
SET IDENTITY_INSERT [dbo].[StokTBL] OFF
SET IDENTITY_INSERT [dbo].[TedarikciTBL] ON 

INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (1, N'AYBERK BÜRO MAKİNALARI', N'KARABAĞLAR İZMİR')
INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (2, N'PRİNTCOM BİLGİSAYAR', N'KARŞIYAKA İZMİR')
INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (3, N'MBC BİLGİSAYAR GÜVENLİK KAMERA SİSTEMLERİ', N'KONAK İZMİR')
INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (4, N'NECİP BİLGİSAYAR', N'KONAK İZMİR')
INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (5, N'VENTA GÜVENLİK VE BİLGİSAYAR SİSTEMLERİ', N'BORNOVA İZMİR')
INSERT [dbo].[TedarikciTBL] ([TedarikciID], [TedarikciIsim], [TedarikciAdres]) VALUES (7, N'TEST FİRMA', N'TEST ADRES')
SET IDENTITY_INSERT [dbo].[TedarikciTBL] OFF
SET IDENTITY_INSERT [dbo].[UrunTBL] ON 

INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (1, N'HP 15-BS008NT 2BT14EA Intel i3', 21, 3)
INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (2, N'Apple MacBook Pro MPXR2TU/A Intel i5 ', 5, 3)
INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (3, N'Inca IWM-331RS Silent Wireles Mouse (Sessiz Mouse)', 22, 14)
INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (7, N'Test Urun', 1, 1)
INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (11, N'Test ürün2', 56, 23)
INSERT [dbo].[UrunTBL] ([UrunID], [UrunIsim], [UrunMarkaID], [UrunKategoriID]) VALUES (12, N'DELL PC', 12, 3)
SET IDENTITY_INSERT [dbo].[UrunTBL] OFF
SET IDENTITY_INSERT [dbo].[UserHareketTBL] ON 

INSERT [dbo].[UserHareketTBL] ([UserHareketID], [PerID], [UserID], [Tarih], [IslemLog]) VALUES (15, 3, 1, N'14.12.2018', N'Yeni Kayıt')
INSERT [dbo].[UserHareketTBL] ([UserHareketID], [PerID], [UserID], [Tarih], [IslemLog]) VALUES (16, 4, 1, N'14.12.2018', N'Yeni Kayıt')
INSERT [dbo].[UserHareketTBL] ([UserHareketID], [PerID], [UserID], [Tarih], [IslemLog]) VALUES (17, 5, 1, N'14.12.2018', N'Yeni Kayıt')
INSERT [dbo].[UserHareketTBL] ([UserHareketID], [PerID], [UserID], [Tarih], [IslemLog]) VALUES (18, 5, 1, N'14.12.2018', N'fkoroglu 123 3 1-->fkoroglu 123 3 0')
INSERT [dbo].[UserHareketTBL] ([UserHareketID], [PerID], [UserID], [Tarih], [IslemLog]) VALUES (19, 5, 1, N'14.12.2018', N'fkoroglu 123 3 0-->fkoroglu 123 3 1')
SET IDENTITY_INSERT [dbo].[UserHareketTBL] OFF
SET IDENTITY_INSERT [dbo].[UserTBL] ON 

INSERT [dbo].[UserTBL] ([UserID], [PerID], [UserName], [PassWord], [RoleID], [Aktif]) VALUES (1, 1, N'oozdil', N'123', 1, 1)
INSERT [dbo].[UserTBL] ([UserID], [PerID], [UserName], [PassWord], [RoleID], [Aktif]) VALUES (2, 2, N'ealtiparmak', N'123', 1, 1)
INSERT [dbo].[UserTBL] ([UserID], [PerID], [UserName], [PassWord], [RoleID], [Aktif]) VALUES (9, 3, N'mcandan', N'123', 2, 1)
INSERT [dbo].[UserTBL] ([UserID], [PerID], [UserName], [PassWord], [RoleID], [Aktif]) VALUES (10, 4, N'ahandan', N'123', 3, 1)
INSERT [dbo].[UserTBL] ([UserID], [PerID], [UserName], [PassWord], [RoleID], [Aktif]) VALUES (11, 5, N'fkoroglu', N'123', 3, 1)
SET IDENTITY_INSERT [dbo].[UserTBL] OFF
ALTER TABLE [dbo].[PersonelTBL]  WITH CHECK ADD  CONSTRAINT [FK_PersonelTBL_DepartmanTBL] FOREIGN KEY([PerDepID])
REFERENCES [dbo].[DepartmanTBL] ([DepID])
ON UPDATE SET NULL
GO
ALTER TABLE [dbo].[PersonelTBL] CHECK CONSTRAINT [FK_PersonelTBL_DepartmanTBL]
GO
ALTER TABLE [dbo].[StokHareketleriTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleriTBL_PersonelTBL] FOREIGN KEY([UserID])
REFERENCES [dbo].[PersonelTBL] ([PerID])
ON UPDATE SET NULL
GO
ALTER TABLE [dbo].[StokHareketleriTBL] CHECK CONSTRAINT [FK_StokHareketleriTBL_PersonelTBL]
GO
ALTER TABLE [dbo].[StokHareketleriTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleriTBL_StokHareketTipiTBL] FOREIGN KEY([StokHareketTipiID])
REFERENCES [dbo].[StokHareketTipiTBL] ([StokHareketTipiID])
GO
ALTER TABLE [dbo].[StokHareketleriTBL] CHECK CONSTRAINT [FK_StokHareketleriTBL_StokHareketTipiTBL]
GO
ALTER TABLE [dbo].[StokHareketleriTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokHareketleriTBL_StokTBL] FOREIGN KEY([StokID])
REFERENCES [dbo].[StokTBL] ([StokID])
GO
ALTER TABLE [dbo].[StokHareketleriTBL] CHECK CONSTRAINT [FK_StokHareketleriTBL_StokTBL]
GO
ALTER TABLE [dbo].[StokTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokTBL_PersonelTBL] FOREIGN KEY([ZimmetliID])
REFERENCES [dbo].[PersonelTBL] ([PerID])
ON UPDATE SET NULL
GO
ALTER TABLE [dbo].[StokTBL] CHECK CONSTRAINT [FK_StokTBL_PersonelTBL]
GO
ALTER TABLE [dbo].[StokTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokTBL_StokDurumTBL] FOREIGN KEY([StokDurumID])
REFERENCES [dbo].[StokDurumTBL] ([StokDurumID])
ON UPDATE SET NULL
GO
ALTER TABLE [dbo].[StokTBL] CHECK CONSTRAINT [FK_StokTBL_StokDurumTBL]
GO
ALTER TABLE [dbo].[StokTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokTBL_TedarikciTBL] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[TedarikciTBL] ([TedarikciID])
GO
ALTER TABLE [dbo].[StokTBL] CHECK CONSTRAINT [FK_StokTBL_TedarikciTBL]
GO
ALTER TABLE [dbo].[StokTBL]  WITH CHECK ADD  CONSTRAINT [FK_StokTBL_UrunTBL] FOREIGN KEY([UrunID])
REFERENCES [dbo].[UrunTBL] ([UrunID])
GO
ALTER TABLE [dbo].[StokTBL] CHECK CONSTRAINT [FK_StokTBL_UrunTBL]
GO
ALTER TABLE [dbo].[UrunTBL]  WITH CHECK ADD  CONSTRAINT [FK_UrunTBL_KategoriTBL] FOREIGN KEY([UrunKategoriID])
REFERENCES [dbo].[KategoriTBL] ([KategoriID])
GO
ALTER TABLE [dbo].[UrunTBL] CHECK CONSTRAINT [FK_UrunTBL_KategoriTBL]
GO
ALTER TABLE [dbo].[UrunTBL]  WITH CHECK ADD  CONSTRAINT [FK_UrunTBL_MarkaTBL] FOREIGN KEY([UrunMarkaID])
REFERENCES [dbo].[MarkaTBL] ([MarkaID])
GO
ALTER TABLE [dbo].[UrunTBL] CHECK CONSTRAINT [FK_UrunTBL_MarkaTBL]
GO
ALTER TABLE [dbo].[UserTBL]  WITH CHECK ADD  CONSTRAINT [FK_UserTBL_RoleTBL] FOREIGN KEY([RoleID])
REFERENCES [dbo].[RoleTBL] ([RoleID])
GO
ALTER TABLE [dbo].[UserTBL] CHECK CONSTRAINT [FK_UserTBL_RoleTBL]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "StokTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AtiktakilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AtiktakilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "StokTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DepodakilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DepodakilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "PersonelTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 178
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserTBL"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "RoleTBL"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DepartmanTBL"
            Begin Extent = 
               Top = 168
               Left = 323
               Bottom = 264
               Right = 493
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
      Begin ColumnWidths = 23
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin Colum' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PersonelView_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nWidths = 11
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PersonelView_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PersonelView_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[4] 2[29] 3) )"
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
         Begin Table = "AtiktakilerView"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UrunTBL"
            Begin Extent = 
               Top = 6
               Left = 486
               Bottom = 136
               Right = 672
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DepodakilerView"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ZimmettekilerView"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KategoriTBL"
            Begin Extent = 
               Top = 102
               Left = 710
               Bottom = 198
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MarkaTBL"
            Begin Extent = 
               Top = 6
               Left = 710
               Bottom = 102
               Right = 896
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[66] 4[4] 2[6] 3) )"
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
         Begin Table = "StokHareketleriTBL"
            Begin Extent = 
               Top = 11
               Left = 0
               Bottom = 200
               Right = 184
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StokHareketTipiTBL"
            Begin Extent = 
               Top = 87
               Left = 733
               Bottom = 183
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserTBL"
            Begin Extent = 
               Top = 246
               Left = 133
               Bottom = 376
               Right = 303
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL_2"
            Begin Extent = 
               Top = 235
               Left = 377
               Bottom = 365
               Right = 547
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL"
            Begin Extent = 
               Top = 186
               Left = 640
               Bottom = 316
               Right = 810
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL_1"
            Begin Extent = 
               Top = 0
               Left = 437
               Bottom = 130
               Right = 607
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
      Begin ColumnWidths = 12
         Width = 284
         Width' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StokHareketView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1500
         Width = 1500
         Width = 1500
         Width = 2625
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StokHareketView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StokHareketView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "UrunTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MarkaTBL"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KategoriTBL"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UrunlerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UrunlerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "UserTBL"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserHareketTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 169
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL"
            Begin Extent = 
               Top = 5
               Left = 521
               Bottom = 135
               Right = 691
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 3180
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserHareketleriView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserHareketleriView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "DepartmanTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "RoleTBL"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserTBL"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 136
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[4] 2[23] 3) )"
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
         Begin Table = "StokTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 209
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UrunTBL"
            Begin Extent = 
               Top = 5
               Left = 314
               Bottom = 178
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KategoriTBL"
            Begin Extent = 
               Top = 6
               Left = 522
               Bottom = 102
               Right = 692
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MarkaTBL"
            Begin Extent = 
               Top = 6
               Left = 730
               Bottom = 102
               Right = 900
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonelTBL"
            Begin Extent = 
               Top = 222
               Left = 218
               Bottom = 352
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1545
         Width = 1500
         Width = 2715
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmetliStockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmetliStockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmetliStockView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "StokTBL"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmettekilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmettekilerView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "StokHareketView"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "StokTBL"
            Begin Extent = 
               Top = 6
               Left = 260
               Bottom = 136
               Right = 430
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UrunTBL"
            Begin Extent = 
               Top = 6
               Left = 468
               Bottom = 136
               Right = 638
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
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmetView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ZimmetView'
GO
USE [master]
GO
ALTER DATABASE [YzmSnmProje] SET  READ_WRITE 
GO

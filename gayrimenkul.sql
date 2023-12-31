USE [master]
GO
/****** Object:  Database [gayrimenkul]    Script Date: 29.12.2023 01:50:28 ******/
CREATE DATABASE [gayrimenkul]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gayrimenkul', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\gayrimenkul.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gayrimenkul_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\gayrimenkul_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [gayrimenkul] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gayrimenkul].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gayrimenkul] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gayrimenkul] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gayrimenkul] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gayrimenkul] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gayrimenkul] SET ARITHABORT OFF 
GO
ALTER DATABASE [gayrimenkul] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gayrimenkul] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gayrimenkul] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gayrimenkul] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gayrimenkul] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gayrimenkul] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gayrimenkul] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gayrimenkul] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gayrimenkul] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gayrimenkul] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gayrimenkul] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gayrimenkul] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gayrimenkul] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gayrimenkul] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gayrimenkul] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gayrimenkul] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gayrimenkul] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gayrimenkul] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gayrimenkul] SET  MULTI_USER 
GO
ALTER DATABASE [gayrimenkul] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gayrimenkul] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gayrimenkul] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gayrimenkul] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gayrimenkul] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gayrimenkul] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [gayrimenkul] SET QUERY_STORE = ON
GO
ALTER DATABASE [gayrimenkul] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [gayrimenkul]
GO
/****** Object:  Table [dbo].[alicibilgileri]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alicibilgileri](
	[aliciID] [int] NOT NULL,
	[aliciAd] [nchar](20) NOT NULL,
	[aliciSoyad] [nchar](20) NOT NULL,
	[aliciGsm] [nchar](20) NOT NULL,
 CONSTRAINT [PK_iletisimbilgileri] PRIMARY KEY CLUSTERED 
(
	[aliciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saticibilgileri]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saticibilgileri](
	[saticiID] [int] NOT NULL,
	[saticiAd] [nchar](20) NOT NULL,
	[saticiSoyad] [nchar](20) NOT NULL,
	[saticiGsm] [nchar](20) NOT NULL,
 CONSTRAINT [PK_saticibilgileri] PRIMARY KEY CLUSTERED 
(
	[saticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sitebilgileri]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sitebilgileri](
	[siteID] [int] NOT NULL,
	[siteAdi] [nchar](20) NOT NULL,
	[satKira] [nchar](20) NOT NULL,
	[odaSayisi] [nchar](20) NOT NULL,
	[metrekare] [nchar](20) NOT NULL,
	[fiyat] [nchar](20) NOT NULL,
	[blok] [nchar](20) NOT NULL,
	[numara] [nchar](20) NOT NULL,
 CONSTRAINT [PK_sitebilgileri] PRIMARY KEY CLUSTERED 
(
	[siteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_aliciEkle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_aliciEkle](
@aliciID int,
@aliciAd nchar(20),
@aliciSoyad nchar(20),
@aliciGsm nchar(20)
)
as
begin
insert into alicibilgileri (aliciID, aliciAd, aliciSoyad, aliciGsm) values (@aliciID, @aliciAd, @aliciSoyad, @aliciGsm)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_aliciGuncelle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_aliciGuncelle](
@id int,
@aliciAd nchar(20),
@aliciSoyad nchar(20),
@aliciGsm nchar(20)
)
as
begin
update alicibilgileri set aliciAd = @aliciAd, aliciSoyad = @aliciSoyad, aliciGsm = @aliciGsm where aliciID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_aliciSil]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_aliciSil](
@id int
)
as
begin
delete from alicibilgileri where aliciID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_saticiEkle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_saticiEkle](
@saticiID int,
@saticiAd nchar(20),
@saticiSoyad nchar(20),
@saticiGsm nchar(20)
)
as
begin
insert into saticibilgileri (saticiID, saticiAd, SaticiSoyad, SaticiGsm) values (@saticiID, @saticiAd, @saticiSoyad, @saticiGsm)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_saticiGuncelle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_saticiGuncelle](
@id int,
@saticiAd nchar(20),
@saticiSoyad nchar(20),
@saticiGsm nchar(20)
)
as
begin
update saticibilgileri set saticiAd = @saticiAd, saticiSoyad = @saticiSoyad, saticiGsm = @saticiGsm where saticiID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_saticiSil]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_saticiSil](
@id int
)
as
begin
delete from saticibilgileri where saticiID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_siteEkle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_siteEkle](
@siteID int,
@siteAdi nchar(20),
@satKira nchar(20),
@odaSayisi nchar(20),
@metrekare nchar(20),
@fiyat nchar(20),
@blok nchar(20),
@numara nchar(20)
)
as
begin
insert into sitebilgisi (siteID, siteAdi, satKira, odaSayisi, metrekare, fiyat, blok, numara)
values (@siteID, @siteAdi, @satKira, @odaSayisi, @metrekare, @fiyat, @blok, @numara)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_siteGuncelle]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_siteGuncelle](
@id int,
@siteAdi nchar(20),
@satKira nchar(20),
@odaSayisi nchar(20),
@metrekare nchar(20),
@fiyat nchar(20),
@blok nchar(20),
@numara nchar(20)
)
as
begin
update sitebilgisi set siteAdi = @siteAdi, satKira = @satKira, odaSayisi = @odaSayisi, metrekare = @metrekare, fiyat = @fiyat, blok = @blok, numara = @numara where siteID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_siteSil]    Script Date: 29.12.2023 01:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_siteSil](
@id int
)
as
begin
delete from sitebilgisi where siteID = @id
end
GO
USE [master]
GO
ALTER DATABASE [gayrimenkul] SET  READ_WRITE 
GO

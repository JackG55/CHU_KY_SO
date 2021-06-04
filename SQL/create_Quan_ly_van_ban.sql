USE [master]
GO
/****** Object:  Database [Quan_ly_van_ban]    Script Date: 04/06/2021 07:56 AM ******/
CREATE DATABASE [Quan_ly_van_ban]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quan_ly_van_ban', FILENAME = N'F:\SQL server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quan_ly_van_ban.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quan_ly_van_ban_log', FILENAME = N'F:\SQL server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quan_ly_van_ban_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quan_ly_van_ban] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quan_ly_van_ban].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quan_ly_van_ban] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quan_ly_van_ban] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quan_ly_van_ban] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Quan_ly_van_ban] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quan_ly_van_ban] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET RECOVERY FULL 
GO
ALTER DATABASE [Quan_ly_van_ban] SET  MULTI_USER 
GO
ALTER DATABASE [Quan_ly_van_ban] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quan_ly_van_ban] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quan_ly_van_ban] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quan_ly_van_ban] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quan_ly_van_ban] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quan_ly_van_ban', N'ON'
GO
ALTER DATABASE [Quan_ly_van_ban] SET QUERY_STORE = OFF
GO
USE [Quan_ly_van_ban]
GO
/****** Object:  Table [dbo].[CHU_KY]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHU_KY](
	[Ma_chu_ky] [char](10) NOT NULL,
	[Ma_user] [char](10) NULL,
	[Thoi_gian_cap] [datetime] NULL,
	[Thoi_gian_het_han] [datetime] NULL,
	[Duong_dan_chu_ky] [nvarchar](1000) NULL,
	[Ten_chu_ky] [nvarchar](50) NULL,
	[Duong_dan_anh] [nvarchar](1000) NULL,
	[Kieu_chu_ky] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_chu_ky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUC_VU]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUC_VU](
	[Ma_chuc_vu] [char](10) NOT NULL,
	[Ten_chuc_vu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_chuc_vu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CO_QUAN]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CO_QUAN](
	[Ma_co_quan] [char](10) NOT NULL,
	[Ten_co_quan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_co_quan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GUI_NHAN]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GUI_NHAN](
	[Ma_gui_nhan] [char](10) NOT NULL,
	[Nguoi_gui] [char](10) NULL,
	[Nguoi_nhan] [char](10) NULL,
	[Trang_thai] [int] NULL,
	[Duong_dan] [nvarchar](500) NOT NULL,
	[Tieu_de] [nvarchar](500) NULL,
	[Thoi_gian] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_gui_nhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[Ma_user] [char](10) NOT NULL,
	[Ten_user] [nvarchar](100) NULL,
	[Ma_chuc_vu] [char](10) NULL,
	[Ma_co_quan] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAI_KHOAN]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_KHOAN](
	[Ma_user] [char](10) NOT NULL,
	[Ten_dang_nhap] [char](20) NULL,
	[Mat_khau] [char](20) NULL,
	[Email] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (N'1         ', N'1         ', CAST(N'2020-05-05T00:00:00.000' AS DateTime), CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'chu-ky-ten-huong.jpg', N'Chữ ký tên', N'chu-ky-ten-huong.jpg', 1)
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (N'2         ', N'1         ', CAST(N'2020-05-01T00:00:00.000' AS DateTime), CAST(N'2021-05-01T00:00:00.000' AS DateTime), NULL, N'Chữ ký phòng', NULL, 2)
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (N'3         ', N'1         ', CAST(N'2021-06-02T15:26:13.300' AS DateTime), CAST(N'2022-06-02T15:26:13.300' AS DateTime), N'CHU_KY_MOI.jpg', N'CHU_KY_MOI', N'chu-ky-ten-huong.jpg', 1)
GO
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (N'1         ', N'Trưởng phòng')
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (N'2         ', N'Thư ký')
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (N'3         ', N'Giám đốc')
GO
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (N'1         ', N'Phòng kế toán')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (N'2         ', N'Phòng đào tạo')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (N'3         ', N'Phòng khảo thí')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (N'4         ', N'Phòng khoa học quân sự')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (N'5         ', N'Phòng khảo thí')
GO
INSERT [dbo].[NGUOI_DUNG] ([Ma_user], [Ten_user], [Ma_chuc_vu], [Ma_co_quan]) VALUES (N'1         ', N'Nguyễn Văn Kiên', N'1         ', N'1         ')
GO
INSERT [dbo].[TAI_KHOAN] ([Ma_user], [Ten_dang_nhap], [Mat_khau], [Email]) VALUES (N'1         ', N'user1               ', N'12345               ', N'kiennguyen@gmail.com')
GO
ALTER TABLE [dbo].[CHU_KY]  WITH CHECK ADD FOREIGN KEY([Ma_user])
REFERENCES [dbo].[NGUOI_DUNG] ([Ma_user])
GO
ALTER TABLE [dbo].[GUI_NHAN]  WITH CHECK ADD FOREIGN KEY([Nguoi_gui])
REFERENCES [dbo].[NGUOI_DUNG] ([Ma_user])
GO
ALTER TABLE [dbo].[GUI_NHAN]  WITH CHECK ADD FOREIGN KEY([Nguoi_nhan])
REFERENCES [dbo].[NGUOI_DUNG] ([Ma_user])
GO
ALTER TABLE [dbo].[NGUOI_DUNG]  WITH CHECK ADD FOREIGN KEY([Ma_chuc_vu])
REFERENCES [dbo].[CHUC_VU] ([Ma_chuc_vu])
GO
ALTER TABLE [dbo].[NGUOI_DUNG]  WITH CHECK ADD FOREIGN KEY([Ma_co_quan])
REFERENCES [dbo].[CO_QUAN] ([Ma_co_quan])
GO
/****** Object:  StoredProcedure [dbo].[SUA_CHU_KY]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUA_CHU_KY](@ma_chu_ky CHAR(10),@ten_chu_ky NVARCHAR(50))
AS
BEGIN
   UPDATE dbo.CHU_KY SET
   Ten_chu_ky = @ten_chu_ky
   WHERE Ma_chu_ky = @ma_chu_ky
END
GO
/****** Object:  StoredProcedure [dbo].[THEM_CHU_KY]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEM_CHU_KY](@ma_chu_ky CHAR(10), @ma_user CHAR(10), @thoi_gian_cap DATETIME, @thoi_gian_het_han DATETIME, @duong_dan_chu_ky NVARCHAR(1000),
@ten_chu_ky NVARCHAR(50), @duong_dan_anh NVARCHAR(1000), @kieu_chu_ky INT)
AS
BEGIN
    INSERT dbo.CHU_KY
    (
        Ma_chu_ky,
        Ma_user,
        Thoi_gian_cap,
        Thoi_gian_het_han,
        Duong_dan_chu_ky,
        Ten_chu_ky,
        Duong_dan_anh,
        Kieu_chu_ky
    )
    VALUES
    (   @ma_chu_ky,        -- Ma_chu_ky - char(10)
        @ma_user,        -- Ma_user - char(10)
        @thoi_gian_cap, -- Thoi_gian_cap - datetime
        @thoi_gian_het_han, -- Thoi_gian_het_han - datetime
        @duong_dan_chu_ky,       -- Duong_dan_chu_ky - nvarchar(1000)
        @ten_chu_ky,       -- Ten_chu_ky - nvarchar(50)
        @duong_dan_anh,       -- Duong_dan_anh - nvarchar(1000)
        @kieu_chu_ky          -- Kieu_chu_ky - int
        )
END
GO
/****** Object:  StoredProcedure [dbo].[XOA_CHU_KY]    Script Date: 04/06/2021 07:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOA_CHU_KY](@ma_chu_ky CHAR(10))
AS
BEGIN
    DELETE dbo.CHU_KY WHERE Ma_chu_ky = @ma_chu_ky
END
GO
USE [master]
GO
ALTER DATABASE [Quan_ly_van_ban] SET  READ_WRITE 
GO

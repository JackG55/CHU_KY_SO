USE [master]
GO
/****** Object:  Database [Quan_ly_van_ban]    Script Date: 18/06/2021 09:15 AM ******/
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
/****** Object:  Table [dbo].[CHU_KY]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHU_KY](
	[Ma_chu_ky] [int] NOT NULL,
	[Ma_user] [int] NULL,
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
/****** Object:  Table [dbo].[CHUC_VU]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUC_VU](
	[Ma_chuc_vu] [int] NOT NULL,
	[Ten_chuc_vu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_chuc_vu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CO_QUAN]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CO_QUAN](
	[Ma_co_quan] [int] NOT NULL,
	[Ten_co_quan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_co_quan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GUI_NHAN]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GUI_NHAN](
	[Ma_gui_nhan] [int] NOT NULL,
	[Nguoi_gui] [int] NULL,
	[Nguoi_nhan] [int] NULL,
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
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[Ma_user] [int] NOT NULL,
	[Ten_user] [nvarchar](100) NULL,
	[Ma_chuc_vu] [int] NULL,
	[Ma_co_quan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAI_KHOAN]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_KHOAN](
	[Ma_user] [int] NOT NULL,
	[Ten_dang_nhap] [char](20) NULL,
	[Mat_khau] [nchar](20) NULL,
	[Email] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAN_BAN]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAN_BAN](
	[Ma_VB] [int] NOT NULL,
	[Ten_VB] [nvarchar](100) NULL,
	[Duong_dan] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_VB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (1, 1, CAST(N'2020-05-05T00:00:00.000' AS DateTime), CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'chu-ky-ten-huong.jpg', N'Chữ ký tên', N'chu-ky-ten-huong.jpg', 1)
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (2, 1, CAST(N'2020-05-01T00:00:00.000' AS DateTime), CAST(N'2021-05-01T00:00:00.000' AS DateTime), NULL, N'Chữ ký phòng', NULL, 2)
INSERT [dbo].[CHU_KY] ([Ma_chu_ky], [Ma_user], [Thoi_gian_cap], [Thoi_gian_het_han], [Duong_dan_chu_ky], [Ten_chu_ky], [Duong_dan_anh], [Kieu_chu_ky]) VALUES (3, 1, CAST(N'2021-06-02T15:26:13.300' AS DateTime), CAST(N'2022-06-02T15:26:13.300' AS DateTime), N'CHU_KY_MOI.jpg', N'CHU_KY_MOI', N'chu-ky-ten-huong.jpg', 1)
GO
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (1, N'Trưởng phòng')
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (2, N'Giám đốc')
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (3, N'Kế Toán')
INSERT [dbo].[CHUC_VU] ([Ma_chuc_vu], [Ten_chuc_vu]) VALUES (4, N'Thư ký')
GO
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (1, N'Phòng tài chính')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (2, N'Phòng hậu cần')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (3, N'Phòng đào tạo')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (4, N'Trung tâm công nghệ thông tin ')
INSERT [dbo].[CO_QUAN] ([Ma_co_quan], [Ten_co_quan]) VALUES (5, N'Phòng hành chính')
GO
INSERT [dbo].[NGUOI_DUNG] ([Ma_user], [Ten_user], [Ma_chuc_vu], [Ma_co_quan]) VALUES (1, N'Nguyễn Văn Kiên', 1, 1)
GO
INSERT [dbo].[TAI_KHOAN] ([Ma_user], [Ten_dang_nhap], [Mat_khau], [Email]) VALUES (1, N'kien                ', N'123                 ', N'kiennguyen@gmail.com')
INSERT [dbo].[TAI_KHOAN] ([Ma_user], [Ten_dang_nhap], [Mat_khau], [Email]) VALUES (2, N'khanh               ', N'123                 ', N'khanhnguyen@gmail.com')
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
/****** Object:  StoredProcedure [dbo].[LAY_THONG_TIN_USER]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LAY_THONG_TIN_USER] (@Ma_user INT, @Ma_chu_ky INT)
AS
BEGIN
    SELECT Ten_user, Ten_co_quan,Thoi_gian_cap, Thoi_gian_het_han FROM dbo.CHU_KY JOIN dbo.NGUOI_DUNG ON NGUOI_DUNG.Ma_user = CHU_KY.Ma_user
JOIN dbo.CHUC_VU ON CHUC_VU.Ma_chuc_vu = NGUOI_DUNG.Ma_chuc_vu
JOIN dbo.CO_QUAN ON CO_QUAN.Ma_co_quan = NGUOI_DUNG.Ma_co_quan
WHERE Ma_chu_ky = @Ma_chu_ky AND CHU_KY.Ma_user = @Ma_user

END
GO
/****** Object:  StoredProcedure [dbo].[SUA_CHU_KY]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUA_CHU_KY](@ma_chu_ky INT,@duong_dan_chu_ky NVARCHAR(1000),
@ten_chu_ky NVARCHAR(50), @duong_dan_anh NVARCHAR(1000), @kieu_chu_ky INT)
AS
BEGIN
   UPDATE dbo.CHU_KY SET
   Duong_dan_chu_ky = @duong_dan_chu_ky, 
   Duong_dan_anh = @duong_dan_anh, 
   Ten_chu_ky = @ten_chu_ky, 
   Kieu_chu_ky = @kieu_chu_ky
   WHERE Ma_chu_ky = @ma_chu_ky
END

GO
/****** Object:  StoredProcedure [dbo].[THEM_CHU_KY]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEM_CHU_KY](@ma_chu_ky INT, @ma_user INT, @thoi_gian_cap DATETIME, @thoi_gian_het_han DATETIME, @duong_dan_chu_ky NVARCHAR(1000),
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
/****** Object:  StoredProcedure [dbo].[XOA_CHU_KY]    Script Date: 18/06/2021 09:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOA_CHU_KY](@ma_chu_ky INT)
AS
BEGIN
    DELETE dbo.CHU_KY WHERE Ma_chu_ky = @ma_chu_ky
END
GO
USE [master]
GO
ALTER DATABASE [Quan_ly_van_ban] SET  READ_WRITE 
GO

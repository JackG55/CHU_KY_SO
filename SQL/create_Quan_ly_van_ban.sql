CREATE DATABASE Quan_ly_van_ban
GO

USE Quan_ly_van_ban
GO

CREATE TABLE CHUC_VU(
	Ma_chuc_vu CHAR(10) PRIMARY KEY, 
	Ten_chuc_vu NVARCHAR(100)
)

CREATE TABLE CO_QUAN(
	Ma_co_quan CHAR(10) PRIMARY KEY, 
	Ten_co_quan NVARCHAR(100)
)

CREATE TABLE TAI_KHOAN(
	Ma_user CHAR(10) PRIMARY KEY, 
	Ten_dang_nhap CHAR(20), 
	Mat_khau CHAR(20)
)


CREATE TABLE NGUOI_DUNG(
	Ma_user CHAR(10) PRIMARY KEY, 
	Ten_user NVARCHAR(100), 
	Ma_chuc_vu CHAR(10), 
	Ma_co_quan CHAR(10), 
	FOREIGN KEY (Ma_chuc_vu) REFERENCES dbo.CHUC_VU(Ma_chuc_vu), 
	FOREIGN KEY (Ma_co_quan) REFERENCES dbo.CO_QUAN(Ma_co_quan)
)


CREATE TABLE VAN_BAN(
	Ma_VB CHAR(10) PRIMARY KEY, 
	Ten_VB NVARCHAR(100), 
	Duong_dan NVARCHAR(500)
)

CREATE TABLE CHU_KY(
	Ma_chu_ky CHAR(10) PRIMARY KEY, 
	Ma_user CHAR(10), 
	Thoi_gian_cap DATETIME, 
	Thoi_gian_het_han DATETIME, 

	FOREIGN KEY(Ma_user) REFERENCES dbo.NGUOI_DUNG(Ma_user)
)

CREATE TABLE GUI_NHAN(
	Ma_VB NVARCHAR(100), 
	Nguoi_gui CHAR(10), 
	Nguoi_nhan CHAR(10), 
	Trang_thai INT, 
	Duong_dan NVARCHAR(500) NOT NULL, 
	CONSTRAINT PK PRIMARY KEY(Ma_VB,Nguoi_gui, Nguoi_nhan), 
	FOREIGN KEY(Nguoi_gui) REFERENCES dbo.NGUOI_DUNG(Ma_user), 
	FOREIGN KEY(Nguoi_nhan) REFERENCES dbo.NGUOI_DUNG(Ma_user)
)

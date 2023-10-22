CREATE DATABASE QuanLyCuaHangBangDia
GO

USE QuanLyCuaHangBangDia
go

-- Account
-- MemberInfo
-- CompactDisc
-- Bill
-- BillInfo
-- 
-- 

create table Account
(
	userName nvarchar(100) primary key,
	userPassWord nvarchar(1000) not null default N'uneti',
	displayName nvarchar (100) not null default N'HaiHaMediaStudio',
)
go

create table memberInfo
(
	id int identity primary key,
	accountName nvarchar (100) not null,
	gender nvarchar (5) not null,
	phoneNumber bigint not NULL UNIQUE,
	userAddress nvarchar (300) not null,
	identify bigint not NULL UNIQUE,
)
go

create table CompactDisc -- Thông tin đĩa
(	
	id int identity primary key,
	cdName nvarchar (100) not null,
	rentalPrice float not null default 0,
	quantity int not null,										-- Max 5 đĩa mỗi loại
	remainCd int not null,
	productionComp nvarchar (300) not null,
	note nvarchar (300) not null,									-- Mới || Cũ || Hỏng
	idCategory int not null,

	foreign key (idCategory) references dbo.CompactDiscCategory(id)
)
go

create table CompactDiscCategory
(
	id int identity primary key,
	cateName nvarchar (100) not null,
)
go

create table Bill -- Thông tin 1 loại đĩa được thuê
(
	id int identity primary key,
	idCustomer int not null,
	foreign key (idCustomer) references dbo.memberInfo
)
go

create table BillInfo -- Thông tin đơn tất cả đĩa của khách hàng đã thuê
(
	id int identity primary key,
	idBill int not null,
	idCd int not null,
	quantity int not null,
	borrowDay int not null,

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idCd) references dbo.CompactDisc(id)
)
go

CREATE PROC USP_getAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE @userName = userName
END
GO	

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE userName COLLATE Latin1_General_CS_AS = @userName 
	AND userPassWord COLLATE Latin1_General_CS_AS = @passWord
END
GO

CREATE PROC USP_getMemberInfo
AS
	SELECT id AS ID, accountName AS "Thành Viên",
	gender AS "Giới Tính", phoneNumber AS "Số Phone",
	userAddress AS "Địa Chỉ", identify AS "Số CCCD"
	FROM dbo.memberInfo
GO

CREATE PROC USP_getCdInfo
AS
	SELECT id AS ID, cdName AS "Tên Đĩa", rentalPrice AS "Giá Thuê",
	quantity AS "Số Lượng", remainCd AS "Còn Lại", productionComp AS "Nhà SX",
	note AS "Ghi Chú", idCategory AS "Thể Loại"
	FROM dbo.CompactDisc
GO

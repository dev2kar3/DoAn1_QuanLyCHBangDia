create database QuanLyCuaHangBangDia
go

use QuanLyCuaHangBangDia
go

-- Account
-- MemberInfo
-- CompactDisc
-- Bill
-- BillInfo
-- CDRentedInfo		(View)
-- CDGiveBackStatus (View)

create table Account
(
	userName nvarchar(100) primary key,
	userPassWord nvarchar(1000) not null default 0,
	displayName nvarchar (100) not null default N'Totem',
)
go

create table memberInfo
(
	id int identity primary key,
	accountName nvarchar (100) not null,
	gender nvarchar (5),
	phoneNumber bigint,
	userAddress nvarchar (300),
	identify bigint not null,
)
go

create table CompactDisc -- Thông tin đĩa
(	
	id int identity primary key,
	cdName nvarchar (100) not null,
	rentalPrice float not null default 0,
	quantity int not null, -- Max 5 đĩa mỗi loại
	remainCd int not null,
	cdStatus nvarchar (30) not null default N'Có Sẵn',		-- Có Sẵn || Đã Thuê
	productionComp nvarchar (300),
	note nvarchar (300),									-- Mới || Cũ || Hỏng
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
	idCd int not null,
	cdStatus nvarchar (30),									-- Khi đĩa được trả lại bị cũ hỏng hóc cần tăng tiền
	quantity int not null,
	borrowDay int not null,

	foreign key (idCd) references dbo.CompactDisc(id)
)
go

create table BillInfo -- Thông tin đơn tất cả đĩa của khách hàng đã thuê
(
	id int identity primary key,
	idBill int not null,

	foreign key (idBill) references dbo.Bill(id)
)
go





create database QuanLyCuaHangBangDia
go

use QuanLyCuaHangBangDia
go

-- Account
-- CompactDisc
-- Bill
-- BillInfo
-- CDRentedInfo		(View)
-- CDGiveBackStatus (View)

create table Account
(
	id int identity primary key not null,
	accountName nvarchar (100),
	gender nvarchar (5),
	phoneNumber bigint,
	userAddress nvarchar (300),
	identify bigint,
)
go

create table CompactDisc
(	
	id int identity primary key not null,
	cdName nvarchar (100),
	genre nvarchar (30),
	cdStatus nvarchar (30),
	productionComp nvarchar (300),
	note nvarchar (300),
)
go

create table Bill
(
	id int identity primary key not null,
	cdName nvarchar (100),
	genre nvarchar (30),
	cdStatus nvarchar (30),
	quantity int,
	borrowDay int,
)
go

create table BillInfo
()
go





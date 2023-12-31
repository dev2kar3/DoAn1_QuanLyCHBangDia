﻿CREATE DATABASE QuanLyCuaHangBangDia
GO

USE QuanLyCuaHangBangDia
GO

-- Account
-- MemberInfo
-- CompactDisc
-- Bill
-- BillInfo
-- 
-- 

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	userPassWord NVARCHAR(1000) NOT NULL DEFAULT N'uneti',
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
	status int not null default 0							-- 0 || Chưa Thuê, 1 || Đang Thuê
)
go

create table CompactDisc -- Thông tin đĩa
(	
	id int identity primary key,
	cdName nvarchar (100) not null,
	rentalPrice float not null default 0,
	quantity int not null,											-- Số đĩa hiện đang có trong cửa hàng
																		-- (Không kể đang thuê và chưa thuê)
																		-- Chắc déo cần đụng đến dcm
	remainCd int not null,											-- Số đĩa còn lại để cho thuê
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

create table Bill -- Bill và iD khách hàng
(
	id int identity primary key,
	idCustomer int not null,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	dateCheckOut DATE NOT NULL

	foreign key (idCustomer) references dbo.memberInfo
)
GO
-- Bill sẽ thêm bớt đĩa được như món ăn ( Mục cho thuê ), sau đó add vào CSDL như add thành viên và đĩa

create table BillInfo -- Thông tin của Bill đó
(
	id int identity primary key,
	idBill int not null,
	idCd int not null,
	quantity int not null

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idCd) references dbo.CompactDisc(id)
)
GO
-- Ý tưởng là cho thuê và add các đĩa vào
-- Sau đó chuyển sang form thanh toán, nhấn vào là hiện lên listview đĩa tài khoản đó đang thuê
-- Sau đó thanh toán thì xóa đi là xong

CREATE TABLE revenueTB
(
	id INT IDENTITY PRIMARY KEY,
	nameMember NVARCHAR(100) NOT NULL,
	revenue FLOAT NOT NULL DEFAULT 0,
	dateCheckIn DATE NOT NULL,
	dateCheckOut DATE NOT NULL,
	discount INT NOT NULL
)
GO	

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
BEGIN
	SELECT id AS ID, accountName AS "Thành Viên",
	gender AS "Giới Tính", phoneNumber AS "Số Phone",
	userAddress AS "Địa Chỉ", identify AS "Số CCCD"
	FROM dbo.memberInfo
END
GO

ALTER PROC USP_getMemberInfoForRent
AS
BEGIN
	SELECT DISTINCT dbo.memberInfo.id AS ID, accountName AS "Thành Viên", gender AS "Giới Tính",
	phoneNumber AS "Số Phone", userAddress AS "Địa Chỉ"
	FROM dbo.memberInfo
	WHERE dbo.memberInfo.status = 0
END
GO	

ALTER PROC dbo.USP_getCdInfo
AS
BEGIN
	SELECT dbo.CompactDisc.id AS ID, cdName AS "Tên Đĩa", rentalPrice AS "Giá Thuê",
	remainCd AS "Số Lượng", productionComp AS "Nhà SX",
	note AS "Ghi Chú", dbo.CompactDiscCategory.cateName AS "Thể Loại"
	FROM dbo.CompactDisc, dbo.CompactDiscCategory
	WHERE dbo.CompactDisc.idCategory = dbo.CompactDiscCategory.id
END
GO

CREATE PROC USP_getRentingMemberInfo
AS
BEGIN
	SELECT DISTINCT dbo.memberInfo.id AS "ID", dbo.memberInfo.accountName AS "Họ Tên", 
	dbo.memberInfo.gender AS "Giới Tính",
	dbo.memberInfo.identify AS "Số CCCD", dbo.memberInfo.phoneNumber AS "Số Phone"
	FROM dbo.memberInfo, dbo.Bill, dbo.BillInfo
	WHERE dbo.memberInfo.id = dbo.Bill.idCustomer AND dbo.Bill.id = dbo.BillInfo.idBill
END
GO	

ALTER PROC	USP_getBillMenuList
@idcustomer INT
AS
BEGIN	
	SELECT cdName AS "Tên Đĩa", cateName AS "Thể Loại", note AS "Tình Trạng",
	rentalPrice AS "Giá Thuê", BillInfo.quantity AS "Số Lượng", 
	dateCheckIn AS "Ngày Mượn", dateCheckOut AS "Ngày Trả",
	(rentalPrice * BillInfo.quantity * (ABS(DATEDIFF(DAY, dateCheckOut, dateCheckIn)) + 1)) AS "Thành Tiền"
	FROM dbo.BillInfo, dbo.Bill, dbo.memberInfo, dbo.CompactDisc, dbo.CompactDiscCategory
	WHERE dbo.BillInfo.idBill = dbo.Bill.id AND dbo.BillInfo.idCd = dbo.CompactDisc.id 
	AND dbo.CompactDisc.idCategory = dbo.CompactDiscCategory.id AND dbo.Bill.idCustomer = dbo.memberInfo.id
	AND dbo.Bill.idCustomer = @idcustomer
END
GO	

ALTER PROC	USP_getRentMenuList
@idcustomer INT
AS
BEGIN	
	SELECT cdName AS "Tên Đĩa", cateName AS "Thể Loại", note AS "Tình Trạng",
	rentalPrice AS "Giá Thuê", BillInfo.quantity AS "Số Lượng", 
	dateCheckIn AS "Ngày Mượn", dateCheckOut AS "Ngày Trả",
	(50000 * BillInfo.quantity) AS "Giá Cọc"
	FROM dbo.BillInfo, dbo.Bill, dbo.memberInfo, dbo.CompactDisc, dbo.CompactDiscCategory
	WHERE dbo.BillInfo.idBill = dbo.Bill.id AND dbo.BillInfo.idCd = dbo.CompactDisc.id 
	AND dbo.CompactDisc.idCategory = dbo.CompactDiscCategory.id AND dbo.Bill.idCustomer = dbo.memberInfo.id
	AND dbo.Bill.idCustomer = @idcustomer AND dbo.memberInfo.status = 0
END
GO


CREATE PROC USP_insertBill
@idCustomer INT
AS
BEGIN
	INSERT INTO	 dbo.Bill
	(
	    idCustomer,
	    dateCheckIn,
	    dateCheckOut
	)
	VALUES
	(   @idCustomer,       -- idCustomer - int
	    DEFAULT, -- dateCheckIn - date
	    NULL     -- dateCheckOut - date
	    )  
END
GO

ALTER PROC USP_insertBillInfo
@idBill INT, @idCd INT, @quantity INT
AS
BEGIN
		DECLARE @isExitsBillInfo INT 
		DECLARE @CdQuantity INT = 1

		SELECT @isExitsBillInfo = id, @CdQuantity = dbo.BillInfo.quantity FROM dbo.BillInfo
			WHERE @idBill = idBill AND @idCd = idCd

		IF (@isExitsBillInfo > 0 AND @quantity != 0)
		BEGIN
			DECLARE @newQuantity INT = @CdQuantity + @quantity
			IF (@newQuantity > 0)
				UPDATE dbo.BillInfo SET quantity = @CdQuantity + @quantity
					WHERE @idCd = idCd AND dbo.BillInfo.idBill = @idBill AND dbo.BillInfo.idCd = @idCd
				--Dành cho cả trường hợp âm, nếu thêm thì sẽ bớt đi
			ELSE	
				DELETE dbo.BillInfo WHERE @idBill = idBill AND @idCd = idCd
		END
		ELSE
		BEGIN
			IF (@quantity > 0)
			BEGIN
				INSERT INTO dbo.BillInfo
			  (
				  idBill,
				 idCd,
				 quantity
			 )
			 VALUES
			 (   @idBill, -- idBill - int
				  @idCd, -- idCd - int
				 @quantity  -- quantity - int
			  ) 
			END
		END   
END
GO	

ALTER PROC USP_getCurrentRemainQuantity
@idCd int
AS
BEGIN	
	SELECT dbo.CompactDisc.remainCd 
	FROM dbo.CompactDisc
	WHERE @idCd = dbo.CompactDisc.id
END
GO	

DELETE FROM dbo.Bill WHERE id = 1021
DELETE FROM dbo.BillInfo WHERE id = 1076
GO

ALTER PROC USP_getBillIdByCustomerId
@idCustomer INT
AS
BEGIN
	SELECT dbo.Bill.id 
	FROM dbo.Bill, dbo.memberInfo
	WHERE dbo.Bill.idCustomer = dbo.memberInfo.id AND @idCustomer = dbo.Bill.idCustomer
END
GO

CREATE PROC USP_deleteAllBillInfoByBillId
@idBill INT
AS
BEGIN	
	DELETE FROM dbo.BillInfo WHERE dbo.BillInfo.idBill = @idBill
END
GO	

CREATE PROC USP_changeStatusToRent
@idCustomer INT
AS
BEGIN
	UPDATE dbo.memberInfo SET status = 1
	WHERE id = @idCustomer
END
GO

ALTER PROC USP_changeStatusToNoRent
@idCustomer INT
AS
BEGIN
	UPDATE dbo.memberInfo SET status = 0
	WHERE id = @idCustomer
END
GO	

CREATE PROC USP_changeStatusToNoRent
@idCustomer INT
AS
BEGIN
	UPDATE dbo.memberInfo SET status = 0
	WHERE id = @idCustomer
END
GO	

CREATE PROC USP_updateRentDay
@idCustomer INT, @date DATETIME
AS
BEGIN
	UPDATE dbo.Bill SET dateCheckOut = @date
	WHERE dbo.Bill.idCustomer = @idCustomer
END
GO	

CREATE PROC USP_getMemberInfoById
@idCustomer INT
AS
BEGIN	
	SELECT id AS "ID", accountName AS "Thành Viên", gender AS "Giới Tính",
	userAddress AS "Địa Chỉ", phoneNumber AS "Số Phone", identify AS "Số CCCD",
	status AS "Trạng Thái"
	FROM dbo.memberInfo
	WHERE id = @idCustomer
END
GO

CREATE PROC USP_insertRevenue
@name NVARCHAR(100), @revenue FLOAT, @dateIn DATETIME, @dateOut DATETIME, @discount INT
AS
BEGIN
	INSERT INTO dbo.revenueTB
	(
	    nameMember,
	    revenue,
	    dateCheckIn,
	    dateCheckOut,
	    discount
	)
	VALUES
	(   @name,       -- nameMember - nvarchar(100)
	    @revenue,   -- revenue - float
	    @dateIn, -- dateCheckIn - date
	    @dateOut, -- dateCheckOut - date
	    @discount          -- discount - int
	    )
END
GO                  

CREATE PROC USP_getRevenueByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT nameMember AS "Thành Viên", revenue AS "Doanh Thu", 
		dateCheckIn AS "Ngày Mượn", dateCheckOut AS "Ngày Trả",
		discount AS "Giảm Giá"
	FROM dbo.revenueTB
	WHERE dateCheckIn >= @checkIn AND dateCheckOut <= @checkOut
END
GO

ALTER PROC USP_updateQuantityForRent
@idCd INT, @quantity INT --quantity này là ở billinfo
AS
BEGIN
	UPDATE dbo.CompactDisc SET dbo.CompactDisc.remainCd = dbo.CompactDisc.remainCd - @quantity
	WHERE dbo.CompactDisc.id = @idCd
END
GO

CREATE PROC USP_updateRemainCdAfterPay
@idCd INT, @quantity INT --quantity này ở billinfo
AS
BEGIN
	UPDATE dbo.CompactDisc SET	dbo.CompactDisc.remainCd = dbo.CompactDisc.remainCd + @quantity
	WHERE dbo.CompactDisc.id = @idCd
END
GO

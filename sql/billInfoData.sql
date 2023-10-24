USE QuanLyCuaHangBangDia
GO	

--Cách để 1 bill info chứa nhiều đĩa ? Khả năng là insert nhiều bill info vào chung 1 idBill

INSERT INTO dbo.BillInfo
(
    idBill,
    idCd,
    quantity
)
VALUES
(   1, -- idBill - int
    3, -- idCd - int
    1  -- quantity - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idCd,
    quantity
)
VALUES
(   1, -- idBill - int
    8, -- idCd - int
    1  -- quantity - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idCd,
    quantity
)
VALUES
(   2, -- idBill - int
    1, -- idCd - int
    2  -- quantity - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idCd,
    quantity
)
VALUES
(   3, -- idBill - int
    2, -- idCd - int
    1  -- quantity - int
    )

INSERT INTO dbo.BillInfo
(
    idBill,
    idCd,
    quantity
)
VALUES
(   3, -- idBill - int
    5, -- idCd - int
    1  -- quantity - int
    )

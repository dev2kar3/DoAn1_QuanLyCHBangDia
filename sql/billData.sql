USE QuanLyCuaHangBangDia
GO

INSERT INTO dbo.Bill
(
    idCustomer,
    dateCheckIn,
    dateCheckOut
)
VALUES
(   1,       -- idCustomer - int
    GETDATE(), -- dateCheckIn - date
    NULL     -- dateCheckOut - date
    )

INSERT INTO dbo.Bill
(
    idCustomer,
    dateCheckIn,
    dateCheckOut
)
VALUES
(   2,       -- idCustomer - int
    GETDATE(), -- dateCheckIn - date
    '2023-10-29'     -- dateCheckOut - date
    )

INSERT INTO dbo.Bill
(
    idCustomer,
    dateCheckIn,
    dateCheckOut
)
VALUES
(   3,       -- idCustomer - int
    DEFAULT, -- dateCheckIn - date
    NULL     -- dateCheckOut - date
    )


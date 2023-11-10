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

INSERT INTO dbo.Bill
(
    idCustomer,
    dateCheckIn,
    dateCheckOut
)
VALUES
(   10,       -- idCustomer - int
    '2023-10-25', -- dateCheckIn - date
    '2023-10-26'     -- dateCheckOut - date
    )

INSERT INTO dbo.Bill
(
    idCustomer,
    dateCheckIn,
    dateCheckOut
)
VALUES
(   6,       -- idCustomer - int
    '2022-9-15', -- dateCheckIn - date
    '2022-9-25'     -- dateCheckOut - date
    )

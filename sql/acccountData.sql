use QuanLyCuaHangBangDia
go

INSERT INTO	dbo.Account
(
    userName,
    userPassWord,
    displayName
)
VALUES
(   N'admin',     -- userName - nvarchar(100)
    N'123456', -- userPassWord - nvarchar(1000)
    DEFAULT  -- displayName - nvarchar(100)
    )
GO	

INSERT INTO dbo.Account
(
    userName,
    userPassWord,
    displayName
)
VALUES
(   N'staff',     -- userName - nvarchar(100)
    N'1', -- userPassWord - nvarchar(1000)
    DEFAULT  -- displayName - nvarchar(100)
    )
GO	
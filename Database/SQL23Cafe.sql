/*
Post-Deployment Script Template
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
 Use SQLCMD syntax to include a file in the post-deployment script.
 Example:      :r .\myfile.sql
 Use SQLCMD syntax to reference a variable in the post-deployment script.
 Example:      :setvar TableName MyTable
               SELECT * FROM [$(TableName)]
--------------------------------------------------------------------------------------
*/


	CREATE DATABASE QuanLy23Cafe
GO -- Thực thi câu lệnh phía sau

USE QuanLy23Cafe
GO

-- Food
-- TableFood
-- FoodCategory
-- Account
-- Bill
-- BillInfo


        /**
        * Tạo bảng TableFood
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'TableFood')
  BEGIN
	CREATE TABLE TableFood
	(
		id INT IDENTITY PRIMARY KEY,
		table_name NVARCHAR(100) NOT NULL  DEFAULT N'Bàn chưa đặt tên',
		status_table INT NOT NULL  DEFAULT 0 --0: Trống || 1: Có người
	)
	END
GO
        /**
        * Tạo bảng Account
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Account')
  BEGIN
	CREATE TABLE Account
	(
		username NVARCHAR(100) NOT NULL PRIMARY KEY,
		display_name NVARCHAR(100) NOT NULL DEFAULT N'Nguoi Dung',
		password NVARCHAR(200) NOT NULL DEFAULT 0,
		phone NVARCHAR(10) NOT NULL,
		basic_salary INT NOT NULL,
		role INT  NOT NULL DEFAULT 0 -- 1: admin && 0: staff
	)
	END
GO
        /**
        * Tạo bảng FoodCategory
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'FoodCategory')
  BEGIN
	CREATE TABLE FoodCategory
	(
		id INT IDENTITY PRIMARY KEY,
		name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	)
	END
GO
        /**
        * Tạo bảng Food
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Food')
  BEGIN
	CREATE TABLE Food
	(
		stt INT IDENTITY,
		id VARCHAR(20) PRIMARY KEY,
		food_name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
		id_category INT NOT NULL,
		price FLOAT NOT NULL DEFAULT 0
		FOREIGN KEY (id_category) REFERENCES dbo.FoodCategory(id)
	)
	END
GO
        /**
        * Tạo bảng Bill
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Bill')
  BEGIN
	CREATE TABLE Bill
	(
		id INT IDENTITY PRIMARY KEY,
		date_checkout DATE NOT NULL DEFAULT GETDATE(),
		id_table INT NOT NULL,
		status_bill INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
		total_price FLOAT NOT NULL DEFAULT 0
		FOREIGN KEY (id_table) REFERENCES dbo.TableFood(id)
	)
	END
GO
        /**
        * Tạo bảng BillInfo
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BillInfo')
  BEGIN
	CREATE TABLE BillInfo
	(
		id INT IDENTITY PRIMARY KEY,
		id_bill INT NOT NULL,
		id_food VARCHAR(20) NOT NULL,
		amount INT NOT NULL DEFAULT 0,
                price FLOAT NOT NULL DEFAULT 0
		FOREIGN KEY (id_bill) REFERENCES dbo.Bill(id),
		FOREIGN KEY (id_food) REFERENCES dbo.Food(id)
	)
	END
GO
		/**
        * Tạo bảng Timekeeping
        */
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Timekeeping')
  BEGIN
	CREATE TABLE Timekeeping
	(
		id INT IDENTITY PRIMARY KEY,
		username NVARCHAR(100) NOT NULL,
		total_time float,
		month_timekeeping DATE,
		FOREIGN KEY (username) REFERENCES dbo.Account(username)
	)
	END
GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'HistoryTimekeeping')
  BEGIN
	CREATE TABLE HistoryTimekeeping
	(
		id INT IDENTITY PRIMARY KEY,
		username NVARCHAR(100) NOT NULL,
		checkin_time DATE NOT NULL DEFAULT  GETDATE(),
		checkout_time DATE,
		FOREIGN KEY (username) REFERENCES dbo.Account(username)
	)
	END
GO


USE QuanLy23Cafe
        /**
        * Thêm dữ liệu vào bảng FoodCategory
        */
INSERT dbo.FoodCategory (name)  VALUES  ( N'Cà phê' ) --1
INSERT dbo.FoodCategory (name)  VALUES  ( N'Nước ép' ) --2
INSERT dbo.FoodCategory (name)  VALUES  ( N'Sinh tố' ) --3
INSERT dbo.FoodCategory (name)  VALUES  ( N'Đồ ăn vặt' ) --4
INSERT dbo.FoodCategory (name)  VALUES  ( N'Sữa chua' ) --5
INSERT dbo.FoodCategory (name)  VALUES  ( N'Đồ nóng' ) --6
INSERT dbo.FoodCategory (name)  VALUES  ( N'Trà' ) --7
INSERT dbo.FoodCategory (name)  VALUES  ( N'Đồ đặc biệt' ) --8
INSERT dbo.FoodCategory (name)  VALUES  ( N'Cốt dừa' ) --9
INSERT dbo.FoodCategory (name)  VALUES  ( N'Đồ đá xay' ) --10
INSERT dbo.FoodCategory (name)  VALUES  ( N'Đồ truyền thống' ) --11

        /**
        * Thêm dữ liệu vào bảng Food - Cà phê
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CF01', N'Cà phê đen', 1, 20000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CF02', N'Cà phê nâu', 1, 25000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CF03', N'Bạc sỉu', 1, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CF04', N'Cà phê cốt dừa', 1, 40000)

        /**
        * Thêm dữ liệu vào bảng Food - Nước Ép
        */

INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'NE01', N'Dứa ép', 2, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'NE02', N'Dưa hấu ép', 2, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'NE03', N'Cam ép', 2, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'NE04', N'Chanh leo ép', 2, 30000)

        /**
        * Thêm dữ liệu vào bảng Food - Sinh tố
        */

INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'ST01', N'Sinh tố xoài', 3, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'ST02', N'Sinh tố dưa hấu', 3, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'ST03', N'Sinh tố bơ', 3, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'ST04', N'Sinh tố dứa dừa', 3, 35000)

        /**
        * Thêm dữ liệu vào bảng Food - Đồ ăn vặt
        */

INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV01', N'Bim bim', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV02', N'Mì tôm trẻ em', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV03', N'Xúc xích', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV04', N'Cánh gà', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV05', N'Chân gà', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV06', N'Hạt mix', 4, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'AV07', N'Thịt hổ', 4, 35000)
		/**
        * Thêm dữ liệu vào bảng Food - Sữa chua
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC01', N'Sữa chua nha đam', 5, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC02', N'Sữa chua đánh đá', 5, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC03', N'Sữa chua thạch hoa quả', 5, 45000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC04', N'Sữa chua trà xanh', 5, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC05', N'Sữa chua cacao', 5, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC06', N'Sữa chua cà phê', 5, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'SC07', N'Sữa chua thạch lá nếp', 5, 30000)
		/**
        * Thêm dữ liệu vào bảng Food - Đồ nóng
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N01', N'Trà hoa cúc cam đào', 6, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N02', N'Trà hoa cúc quế gừng', 6, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N03', N'Trà gừng xí muội', 6, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N04', N'Cacao hạt dẻ', 6, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N05', N'Trà mật ong chanh đào', 6, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'N06', N'Cacao quế', 6, 35000)
		/**
        * Thêm dữ liệu vào bảng Food - Trà
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'T01', N'Trà olong ổi hồng', 7, 39000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'T02', N'Gạo rang dưa hấu', 7, 35000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'T03', N'Trà đào cam sả ', 7, 39000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'T04', N'Trà vải dưa hấu', 7, 35000)
		/**
        * Thêm dữ liệu vào bảng Food - Đồ đặc biệt
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DB01', N'Socola dừa kem chuối', 8, 45000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DB02', N'Cà phê socola dừa kem chuối', 8, 47000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DB03', N'Matcha kem chuối', 8, 45000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DB04', N'Matcha sữa dừa hoàng kim', 8, 45000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DB05', N'Hokkaido đường đen', 8, 45000)
		/**
        * Thêm dữ liệu vào bảng Food - Cốt dừa
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CD01', N'Cốt dừa cốm xanh', 9, 42000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CD02', N'Cốt dừa trà xanh', 9, 39000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CD03', N'Cốt dừa cacao', 9, 39000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'CD04', N'Cốt dừa dâu tây', 9, 40000)
		/**
        * Thêm dữ liệu vào bảng Food - Đồ đồ đá xay
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DX01', N'Cà phê socola đá xay', 10, 40000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DX02', N'Cà phê caramen đá xay', 10, 40000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DX03', N'Bánh quy socola đá xay', 10, 45000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DX04', N'Socola bạc hà đá xay', 10, 40000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'DX05', N'Trà xanh đá xay', 10, 40000)
		/**
        * Thêm dữ liệu vào bảng Food - Đồ truyền thống
        */
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'TT01', N'Cacao đá lắc', 11, 30000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'TT02', N'Bột đậu xanh', 11, 25000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'TT03', N'Bột sắn dây', 11, 25000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'TT04', N'Me đá', 11, 25000)
INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ( 'TT05', N'Sữa tươi', 11, 25000)

		/**
		* Thêm dữ liệu vào bảng TableFood

INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 1', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 2', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 3', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 4', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 5', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 6', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 7', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 8', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 9', 0)
INSERT dbo.TableFood (id, table_name, status_table) VALUES (null, N'Bàn 10', 0)
*/

USE QuanLy23Cafe
DECLARE @i INT = 1
WHILE @I <= 15
BEGIN
    INSERT dbo.TableFood (table_name) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
    SET @i = @i + 1
END
GO

        /**
        * Thêm dữ liệu vào bảng Bill

INSERT  dbo.Bill (  date_checkout , id_table , status_bill ) VALUES  ( GETDATE(), 3 , 0 )
INSERT  dbo.Bill ( date_checkout , id_table , status_bill ) VALUES  ( GETDATE(), 4 , 0 )
INSERT  dbo.Bill (  date_checkout , id_table , status_bill ) VALUES  ( GETDATE(), 5 , 0 )
*/

GO

/*
USE QuanLy23Cafe

        /**
        * Thêm dữ liệu vào bảng BillInfo
        */
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 1, 1, 2 )
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 1, 3, 4 )
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 1, 5, 1 )
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 1, 1, 2 )
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 3, 6, 2 )
INSERT  dbo.BillInfo ( id_bill, id_food, amount ) VALUES  ( 3, 5, 2 )

GO*/

USE QuanLy23Cafe
        /**
        * Thêm dữ liệu vào bảng Account
        */
INSERT INTO dbo.Account
    (
    username,
    display_name,
    password,
    role,
	phone,
	basic_salary
    )
VALUES (N'admin', N'Hồng Quang Văn Minh Tiến', N'admin', 1, N'0912345678', 30),
		(N'staff', N'Trần Thị Ngọc Trinh', N'123', 0, N'0912345677', 17)
GO
		/**
        * Tạo thủ tục USP_CreateFood
        */
CREATE PROC USP_CreateFood
@id varchar(20), @foodName nvarchar(100), @idCategory int, @price float
AS
BEGIN
	INSERT dbo.Food VALUES(@id, @foodName, @idCategory, @price)
END
GO

EXEC dbo.USP_CreateFood @id = N'AV09', @foodName = N'Khô heo cháy tỏi', @idCategory = 4, @price = 50000
GO
		/**
        * Tạo thủ tục USP_UpdateFood
        */
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'USP_UpdateFood')
BEGIN
	DROP PROC USP_UpdateFood
END
GO

CREATE PROC USP_UpdateFood
@id varchar(20), @foodName nvarchar(100), @idCategory int, @price float
AS
BEGIN
	IF NULLIF(@foodName, '') IS NULL
	BEGIN
		IF NULLIF(@idCategory, '') IS NULL
			BEGIN
				-- Cập nhật giá
			UPDATE dbo.Food SET price = @price WHERE id = @id;
			END
		ELSE
		BEGIN
			IF NULLIF(@price, '') IS NULL
			BEGIN
				--Cập nhật id_cate
				UPDATE dbo.Food SET id_category = @idCategory WHERE id = @id
			END
			ELSE
			BEGIN
				-- Cập nhật id_cate & giá
				UPDATE dbo.Food SET price = @price, id_category = @idCategory WHERE id = @id
			END
		END
	END
	ELSE
		IF NULLIF(@idCategory, '') IS NULL
		BEGIN
			IF NULLIF(@price, '') IS NULL
				--Cập nhật tên
				UPDATE Food SET food_name = @foodName WHERE id = @id
			ELSE
				-- Cập nhật tên & giá
				UPDATE dbo.Food SET price = @price, food_name = @foodName WHERE id = @id
		END
		ELSE
		BEGIN
			IF NULLIF(@price, '') IS NULL
				--Cập nhật id_cate & tên
				UPDATE dbo.Food SET id_category = @idCategory, food_name = @foodName WHERE id = @id
			ELSE
				-- Cập nhật id_cate & giá & tên
				UPDATE dbo.Food SET price = @price, id_category = @idCategory, food_name = @foodName WHERE id = @id
		END
END
GO

EXEC dbo.USP_UpdateFood @id = N'AV09', @foodName = N'', @idCategory = 4, @price = 50000
GO

		/**
        * Tạo thủ tục USP_DeleteFood
        */
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'USP_DeleteFood')
BEGIN
	DROP PROC USP_DeleteFood
END
GO

CREATE PROC USP_DeleteFood
@id varchar(20)
AS
BEGIN
	DELETE dbo.Food WHERE id = @id
END
GO

EXEC dbo.USP_DeleteFood @id = N'AV09'
GO
        /**
        * Tạo thủ tục USP_GetAccountByUserName
        */
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE username = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'admin'
GO

        /**
        * Tạo thủ tục USP_Login
        */
CREATE PROC USP_Login
@userName nvarchar(100),
@passWord nvarchar(100)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE username = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO


        /**
        * Tạo Thủ tục USP_UpdateAccount
        */
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
    DECLARE @isRightPass INT = 0

    SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE username = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS

    IF (@isRightPass = 1)
    BEGIN
        UPDATE dbo.Account SET password = @newPassword WHERE username = @userName
    END
END
GO


        /**
        * Tạo thủ tục USP_GetTableList
        */
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

EXEC dbo.USP_GetTableList
GO

        /**
        * Tạo thủ tục USP_InsertBill
        */
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
    INSERT dbo.Bill
            ( date_checkout,
            id_table,
            status_bill
            )
    VALUES ( GETDATE(),
            @idTable,
            0
            )
END
GO
        /**
        * Tạo thủ tục USP_Insert_UpdateBillInfo
        */
CREATE PROC USP_Insert_UpdateBillInfo
@idBill INT, @idFood VARCHAR(20), @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT;
    DECLARE @foodCount INT = 1;
    SELECT @isExitsBillInfo = id
    --, @foodCount = b.amount
    FROM dbo.BillInfo AS b
    WHERE id_bill = @idBill AND id_food = @idFood
    IF (@isExitsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @count
        IF (@newCount > 0)
            UPDATE dbo.BillInfo SET amount = @count WHERE id_food = @idFood
        ELSE
            DELETE dbo.BillInfo WHERE id_bill = @idBill AND id_food = @idFood
    END
    ELSE
    BEGIN
        INSERT dbo.BillInfo
            (id_bill,
            id_food,
            amount
            )
    VALUES ( @idBill,
            @idFood,
            @count
            )
    END
END
GO

--exec USP_InsertBill @idTable = 1
--GO
--exec USP_Insert_UpdateBillInfo @idBill = 1, @idFood = 'AV02', @count = 4
--GO

        /**
        * Tạo Trigger UTG_UpdateBillInfo (Table status)
        */
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id_bill FROM Inserted

    DECLARE @idTable INT

    SELECT @idTable = id_table FROM dbo.Bill WHERE id = @idBill AND status_bill = 0

    DECLARE @count INT
    SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE id_bill = @idBill

    IF (@count > 0)
    BEGIN

        PRINT @idTable
        PRINT @idBill
        PRINT @count

        UPDATE dbo.TableFood SET status_table = 1 WHERE id = @idTable

    END
    ELSE
    BEGIN
        PRINT @idTable
        PRINT @idBill
        PRINT @count
        UPDATE dbo.TableFood SET status_table = 0 WHERE id = @idTable
    end

END
GO
 /**
        * Tạo Trigger UTG_InsertPriceBillInfo (PriceBillInfo)
        */
CREATE TRIGGER UTG_InsertPriceBillInfo
ON dbo.BillInfo FOR INSERT
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id_bill FROM Inserted

    DECLARE @idFood VARCHAR(20)

    SELECT @idFood = id_food FROM Inserted

    DECLARE @amount INT

    SELECT @amount = amount FROM Inserted

    DECLARE @price FLOAT

    SELECT @price = price FROM dbo.Food WHERE id = @idFood

    IF (@amount > 0)
    BEGIN

        PRINT @price
        PRINT @idFood
        PRINT @amount

        DECLARE @billInfo_price FLOAT = @amount * @price

        DECLARE @bill_price FLOAT
        SELECT @bill_price = @billInfo_price + SUM(price*amount) FROM dbo.BillInfo WHERE id_bill = @idBill
        PRINT @bill_price

        UPDATE dbo.BillInfo SET price = @billInfo_price WHERE id_bill = @idBill AND id_food = @idFood
        UPDATE dbo.Bill SET total_price = @bill_price WHERE id = @idBill

    END
END
GO

 /**
        * Tạo Trigger UTG_UpdatePriceBillInfo (PriceBillInfoAndBill)
        */
CREATE TRIGGER UTG_UpdatePriceBillInfo
ON dbo.BillInfo FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id_bill FROM Inserted

    DECLARE @idFood VARCHAR(20)

    SELECT @idFood = id_food FROM Inserted

    DECLARE @amount INT

    SELECT @amount = amount FROM Inserted

    DECLARE @price FLOAT

    SELECT @price = price FROM dbo.Food WHERE id = @idFood

    IF (@amount > 0)
    BEGIN

        DECLARE @billInfo_price FLOAT = @amount * @price
        UPDATE dbo.BillInfo SET price = @billInfo_price WHERE id_bill = @idBill AND id_food = @idFood

        DECLARE @bill_price FLOAT 
        SELECT @bill_price = SUM(price) FROM dbo.BillInfo WHERE id_bill = @idBill      
        UPDATE dbo.Bill SET total_price = @bill_price WHERE id = @idBill

    END
END
GO

 /**
        * Tạo Trigger UTG_DeleteBillInfo (PriceBill)
        */
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id_bill FROM Inserted

    IF (@amount > 0)
    BEGIN

        DECLARE @bill_price FLOAT 
        SELECT @bill_price = SUM(price) FROM dbo.BillInfo WHERE id_bill = @idBill      
        UPDATE dbo.Bill SET total_price = @bill_price WHERE id = @idBill

    END
END
GO

        /**
        * Tạo Trigger UTG_UpdateBill (Payment)
        */
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id FROM Inserted

    DECLARE @idTable INT

    SELECT @idTable = id_table FROM dbo.Bill WHERE id = @idBill

    DECLARE @count int = 0

    SELECT @count = COUNT(*) FROM dbo.Bill WHERE id_table = @idTable AND status_bill = 0

    IF (@count = 0)
        UPDATE dbo.TableFood SET status_table = 0 WHERE id = @idTable
END
GO

        /**
        * Tạo Trigger UTG_DeleteBill (Delete)
        */
CREATE TRIGGER UTG_DeleteBill
ON dbo.Bill FOR DELETE
AS
BEGIN
    DECLARE @idBill INT

    SELECT @idBill = id FROM Inserted

    DECLARE @idTable INT

    SELECT @idTable = id_table FROM dbo.Bill WHERE id = @idBill

    DECLARE @count int = 0

    SELECT @count = COUNT(*) FROM dbo.Bill WHERE id_table = @idTable AND status_bill = 0

    DECLARE @countBillInfo INT = 0
    SELECT @countBillInfo = COUNT(*) FROM dbo.BillInfo WHERE id_bill = @idBill

    IF (@count = 0)
    BEGIN
        UPDATE dbo.TableFood SET status_table = 0 WHERE id = @idTable
        
    END

END
GO


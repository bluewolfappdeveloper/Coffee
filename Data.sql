CREATE DATABASE cafe
GO

USE cafe
GO

CREATE FUNCTION [dbo].[convertstring] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput 
	IF @strInput = '' RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 

END
GO 

--Đăng nhập
CREATE TABLE login
(
  id INT IDENTITY NOT NULL PRIMARY KEY,
  name NVARCHAR(255) NOT NULL,
  username NVARCHAR(255) NOT NULL,
  password NVARCHAR(255) NOT NULL,
  ngaysinh DATE NOT NULL,
  diacchi NVARCHAR(255),
  dienthoai NVARCHAR(255),
  status INT,
)
GO

CREATE PROC USP_Login
@username NVARCHAR(255) ,@password NVARCHAR(255)
AS
BEGIN
 SELECT name,status FROM dbo.login WHERE username = @username AND password = @password
END
GO


CREATE PROC USP_Employee
@num int, @id int, @name NVARCHAR(255), @username NVARCHAR(255), @password NVARCHAR(255),
@ngaysinh DATE, @diacchi NVARCHAR(255), @dienthoai NVARCHAR(255),@status INT
AS 
BEGIN
 IF @num = 1  INSERT dbo.login (name, username, password,ngaysinh ,diacchi ,dienthoai, status ) 
                VALUES (@name, @username, @password,@ngaysinh ,@diacchi ,@dienthoai, @status)   
  ELSE IF @num = 2 DELETE dbo.login WHERE id = @id 
   ELSE IF @num = 3 UPDATE dbo.login 
           SET name = @name, username = @username,password = @password,ngaysinh=@ngaysinh ,diacchi=@diacchi ,dienthoai=@dienthoai, status = @status WHERE  id = @id
    ELSE SELECT * FROM dbo.login ORDER BY name;
END
GO 

--1:Admin
--2:User

--Insert dữ liệu
INSERT dbo.login(name,username,password,ngaysinh,diacchi,dienthoai,status)
VALUES  (N'Võ Nhật Tân','1','2','2002/02/24',N'9 Phước Long','01284087855',1 )

INSERT dbo.login(name,username,password,ngaysinh,diacchi,dienthoai,status)
VALUES  (N'Tiger','tiger','ho','2006/03/03',N'9 Lê Hồng Phong','156324586',0 )

SELECT * FROM dbo.login

--Nhập hàng
CREATE TABLE drink
(
  id INT IDENTITY PRIMARY KEY NOT NULL,
  name NVARCHAR(255) NOT NULL ,
  price INT DEFAULT 0 NOT NULL,
)
GO


CREATE PROC USP_Item
@num int, @id int, @name NVARCHAR(255), @price INT
AS 
BEGIN
 IF @num = 1  INSERT dbo.drink(name,price) VALUES (@name, @price)   
  ELSE IF @num = 2 DELETE dbo.drink WHERE id = @id 
   ELSE IF @num = 3 UPDATE dbo.drink SET name = @name, price = @price WHERE  id = @id
    ELSE SELECT * FROM dbo.drink ORDER BY name;
END
GO 

EXEC USP_Item 1,2,N'Cafe đen', 7000
GO

EXEC USP_Item 1,2,N'Cafe sữa', 8000
GO

SELECT * FROM dbo.drink


CREATE TABLE customer
(
	id INT IDENTITY NOT NULL,
	name NVARCHAR(255) NOT NULL,
	donvi NVARCHAR(555),
)

INSERT dbo.customer(name, donvi) VALUES  (N'Cô hương',N'Mặt trận')
INSERT dbo.customer(name, donvi) VALUES  (N'Tân',N'NT')


--ghi trong datagridview
CREATE TABLE tablebill
(
  id INT IDENTITY PRIMARY KEY NOT NULL,
  namedrink NVARCHAR(255) NOT NULL,
  price FLOAT NOT NULL ,
  quantify INT DEFAULT 0,
  total FLOAT NOT NULL,
)
GO

CREATE PROC USP_bill
@num int, @id int, @namedrink NVARCHAR(255), @price FLOAT, @quantify int,@total MONEY
AS
BEGIN
 IF @num = 1  INSERT dbo.tablebill(namedrink,price,quantify,total) VALUES (@namedrink,@price,@quantify,@total)   
  ELSE IF @num = 2 DELETE dbo.tablebill WHERE id = @id 
   ELSE IF @num = 3 UPDATE dbo.tablebill SET namedrink=@namedrink,price=@price,quantify=@quantify,total=@total WHERE  id = @id
    ELSE SELECT * FROM dbo.tablebill ;
END
GO


EXEC USP_Bill 1 , 0 , N'Cafe đen' , 7000 , 1 , 7000


--thông tin hóa đơn
CREATE TABLE bill_info
(
 id INT IDENTITY PRIMARY KEY NOT NULL,
 tenkhach NVARCHAR(255),
 typekhach INT,
 ngaymua DATE,
 giomua TIME,
 sukien NVARCHAR(255),
 tongtien INT,
 status INT,
)
GO

--Lưu trữ các hóa đơn
CREATE TABLE bill
(
  id INT IDENTITY PRIMARY KEY NOT NULL,
  idtable INT ,
  namedrink NVARCHAR(255) NOT NULL,
  price FLOAT NOT NULL ,
  quantify INT DEFAULT 0,
  total FLOAT NOT NULL,
  FOREIGN KEY (idtable) REFERENCES dbo.bill_info(id)
)
GO


DBCC CHECKIDENT (bill, RESEED, 0)
DBCC CHECKIDENT (bill_info, RESEED, 0)


SELECT * FROM dbo.bill_info
SELECT * FROM bill

--Khách quen: Tên khách = idkhach ; typekhach = 1
--Khách lạ: Tên khách = tên khách ; typekhach = 0


SELECT dbo.tablebill.namedrink,dbo.tablebill.price, SUM(quantify), SUM(dbo.tablebill.total)  FROM dbo.tablebill
GROUP BY dbo.tablebill.namedrink, price ORDER BY namedrink


SELECT tenkhach,typekhach,SUM(tongtien),COUNT(status)
FROM dbo.bill_info WHERE STATUS = 0
GROUP BY tenkhach,typekhach,status

SELECT name FROM dbo.customer WHERE id =''

SELECT dbo.tablebill.namedrink,dbo.tablebill.price, SUM(quantify), SUM(dbo.tablebill.total)  FROM dbo.tablebill
GROUP BY dbo.tablebill.namedrink, price ORDER BY namedrink

SELECT id,ngaymua,sukien,tongtien FROM dbo.bill_info WHERE tenkhach ='Tân'


SELECT tenkhach,SUM(tongtien),COUNT(*),typekhach FROM dbo.bill_info  
WHERE STATUS = 0 AND dbo.convertstring(tenkhach) like N'%' + dbo.convertstring(N'happy') + '%' 
GROUP BY tenkhach,typekhach,status



SELECT b.tenkhach,SUM(tongtien),COUNT(*),typekhach FROM dbo.bill_info AS b,dbo.customer AS c
WHERE (b.STATUS = 0 AND dbo.convertstring(b.tenkhach) like N'%'+dbo.convertstring(N'tan')+'%' )
or   (dbo.convertstring(c.name) like N'%'+dbo.convertstring(N'tan')+'%'  AND CAST(c.id AS NVARCHAR)= b.tenkhach AND b.status =0 )
GROUP BY tenkhach,typekhach,status

SELECT * FROM dbo.bill_info


SELECT id,ngaymua,giomua,sukien,tongtien FROM dbo.bill_info 
WHERE tenkhach =N'2' and status = 0 AND ngaymua <= '2018-05-11'
GO 


CREATE PROC USP_SellBill
@num int, @id int, @idtable int, @namedrink NVARCHAR(255), @price FLOAT, @quantify int,@total MONEY
AS
BEGIN
 IF @num = 1  INSERT dbo.bill(idtable,namedrink,price,quantify,total) VALUES (@idtable,@namedrink,@price,@quantify,@total)   
  ELSE IF @num = 2 DELETE dbo.bill WHERE id = @id 
   ELSE IF @num = 3 UPDATE dbo.bill SET namedrink=@namedrink,price=@price,quantify=@quantify,total=@total WHERE  id = @id
    ELSE SELECT * FROM dbo.tablebill ;
END


SELECT dbo.bill.namedrink,dbo.bill.price, SUM(quantify), SUM(dbo.bill.total) FROM dbo.bill 
WHERE idtable = 6
GROUP BY dbo.bill.namedrink, price ORDER BY namedrink

SELECT * FROM dbo.bill ORDER BY idtable



SELECT dbo.bill.namedrink,dbo.bill.price, SUM(quantify), SUM(dbo.bill.total) FROM dbo.bill 
WHERE idtable = 6 GROUP BY dbo.bill.namedrink, price ORDER BY namedrink

--SELECT COUNT(*) FROM dbo.bill

SELECT dbo.bill.namedrink,dbo.bill.price, SUM(quantify), SUM(dbo.bill.total) FROM dbo.bill WHERE idtable = 6 GROUP BY dbo.bill.namedrink, price ORDER BY namedrink


CREATE TABLE billsave
(
  id INT IDENTITY PRIMARY KEY NOT NULL,
  idtable INT ,
  namedrink NVARCHAR(255) NOT NULL,
  price FLOAT NOT NULL ,
  quantify INT DEFAULT 0,
  total FLOAT NOT NULL,
  FOREIGN KEY (idtable) REFERENCES dbo.bill_info(id)
)
GO


CREATE PROCEDURE USP_ResetBill
AS
BEGIN
		DBCC CHECKIDENT (billsave, RESEED, 0)
		DELETE FROM dbo.billsave
		INSERT INTO dbo.billsave(idtable,namedrink,price,quantify,total)
		SELECT idtable,dbo.bill.namedrink,dbo.bill.price, SUM(quantify) AS quantify , SUM(dbo.bill.total) AS total  
		FROM dbo.bill 
		GROUP BY dbo.bill.namedrink, price,idtable ORDER BY  idtable


		DELETE FROM dbo.bill
		DBCC CHECKIDENT (bill, RESEED, 0)
		INSERT INTO dbo.bill(idtable,namedrink,price,quantify,total)
		SELECT idtable,namedrink,price,quantify,total FROM dbo.billsave

		SELECT * FROM dbo.bill
END
GO 
--EXEC dbo.USP_ResetBill


CREATE VIEW kiemtra 
AS 
SELECT namedrink,COUNT(quantify) AS 'quantify', SUM(total) AS 'total' FROM dbo.bill GROUP BY namedrink,price 
GO 


SELECT b.namedrink,SUM(b.quantify) AS qualify, SUM(b.total) AS 'total' FROM dbo.bill AS b,dbo.bill_info AS i
 WHERE b.idtable = i.id AND i.ngaymua <= '2018-03-04' AND i.ngaymua >= '2018-03-01' 
 GROUP BY b.namedrink, b.price


SELECT SUM(b.quantify) FROM dbo.bill AS b,dbo.bill_info AS i 
WHERE b.idtable = i.id AND i.ngaymua <= '2018-05-18' AND i.ngaymua >= '2018-05-14'
GROUP BY b.namedrink, b.price 

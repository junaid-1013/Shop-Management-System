CREATE DATABASE  DBProject;

--------------------------------------------------------
--Admin Login 
CREATE TABLE ADMIN(AD_NAME VARCHAR(20) PRIMARY KEY,
                   AD_PW VARCHAR(20) NOT NULL)
				   
INSERT INTO ADMIN VALUES ('junaid', '123') 

select * from ADMIN
---------------------------------------------------------

--Employee Table
create table EMPLOYEE(
EMP_ID varchar(6) PRIMARY KEY,
EMP_Name varchar (30),
EMP_BirthDay DATE,
EMP_Cit varchar(30),
EMP_Login varchar(20),
EMP_Password varchar(20),
EMP_Salary int
);

select * from EMPLOYEE

----------------------------------------------------------

--Employee History Table
create table Employee_History(
EMP_History_Id int IDENTITY(1,1) PRIMARY KEY,
EMP_History_Details varchar (1000) NOT NULL
);

select * from Employee_History

---------------------------------------------------------
----------------Employee Triggers------------------------
---------------------------------------------------------
--Insert Trigger
----------------
create TRIGGER tr_Employee_ForInsert
ON EMPLOYEE
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = EMP_ID from inserted
 
 insert into Employee_History 
 values('New employee with Id  = ' + Cast(@Id as varchar(6)) + ' is added at ' + cast(Getdate() as varchar(20)))
END
----------------
--Delete Trigger
----------------
create TRIGGER tr_Employee_ForDelete
ON EMPLOYEE
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = EMP_ID from deleted
 
 insert into Employee_History 
 values('An existing employee with Id  = ' + Cast(@Id as varchar(6)) + ' is deleted at ' + cast(Getdate() as varchar(20)))
END

---------------------------
-----Update Trigger--------
---------------------------
create trigger tr_Employee_ForUpdate
on EMPLOYEE
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(30), @NewName varchar(30)
	  Declare @OldBirthday Date, @NewBirthday Date
      Declare @OldCity varchar(30), @NewCity varchar(30)
      Declare @OldLogin varchar(20), @NewLogin varchar(20)
	  Declare @OldPassword varchar(20), @NewPassword varchar(20)
      Declare @OldSalary int, @NewSalary int
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select EMP_ID from #TempTable))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = EMP_ID, @NewName = EMP_Name,
			@NewBirthday = EMP_BirthDay,  
            @NewCity = EMP_City, @NewLogin = EMP_Login,
			@NewPassword = EMP_Password,
			@NewSalary = EMP_Salary
            from #TempTable
           
            -- Select the corresponding row from deleted table
            Select @OldName = EMP_Name, @OldBirthday = EMP_BirthDay,  
            @OldCity = EMP_City, @OldLogin = EMP_Login,
			@OldPassword = EMP_Password,
			@OldSalary = EMP_Salary
            from deleted where EMP_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Employee with Id = ' + Cast(@Id as varchar(4)) + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldBirthday <> @NewBirthday)
                  Set @HistoryString = @HistoryString + ' Birth Date from ' + Cast(@OldBirthday as varchar(10)) + ' to ' + Cast(@NewBirthday as varchar(10))
                 
            if(@OldCity <> @NewCity)
                  Set @HistoryString = @HistoryString + ' City from ' + @OldCity + ' to ' + @NewCity

			if(@OldLogin <> @NewLogin)
                  Set @HistoryString = @HistoryString + ' Login from ' + @OldLogin + ' to ' + @NewLogin

			if(@OldPassword <> @NewPassword)
                  Set @HistoryString = @HistoryString + ' Password from ' + @OldPassword + ' to ' + @NewPassword

            if(@OldSalary <> @NewSalary)
                  Set @HistoryString = @HistoryString + ' SALARY from ' + Cast(@OldSalary as varchar(10))+ ' to ' + Cast(@NewSalary as varchar(10))
           
            insert into Employee_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable where EMP_ID = @Id
      End
End


------------------------------------------------------------------------------------------------------------------------------------------------------

--Customer Table

create table CUSTOMER (
CUST_ID varchar(6) Primary key,
CUST_Name varchar(30),
CUST_RegDate Date,
CUST_City varchar(30),
CUST_Contact varchar(20)
);

select * from CUSTOMER
----------------------------------------------------------

--Customer History Table
create table Customer_History(
CUST_History_Id int IDENTITY(1,1) PRIMARY KEY,
CUST_History_Details varchar (1000) NOT NULL
);

select * from Customer_History

---------------------------------------------------------
----------------Employee Triggers------------------------
---------------------------------------------------------
--Insert Trigger
----------------
create TRIGGER tr_Customer_ForInsert
ON CUSTOMER
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = CUST_ID from inserted
 
 insert into Customer_History
 values('New Customer with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END
----------------
--Delete Trigger
----------------
create TRIGGER tr_Customer_ForDelete
ON CUSTOMER
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = CUST_ID from deleted
 
 insert into Customer_History
 values('An existing customer with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END

---------------------------
-----Update Trigger--------
---------------------------
create trigger tr_Customer_ForUpdate
on CUSTOMER
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(30), @NewName varchar(30)
	  Declare @OldRegdate Date, @NewRegdate Date
      Declare @OldCity varchar(30), @NewCity varchar(30)
      Declare @OldContact varchar(20), @NewContact varchar(20)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable1
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select CUST_ID from #TempTable1))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = CUST_ID, @NewName = CUST_Name,
			@NewRegdate = CUST_RegDate,  
            @NewCity = CUST_City, @NewContact = CUST_Contact
            from #TempTable1
           
            -- Select the corresponding row from deleted table
            Select @OldName = CUST_Name, @OldRegdate = CUST_RegDate,  
            @OldCity = CUST_City, @OldContact= CUST_Contact
            from deleted where CUST_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Customer with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldRegdate <> @NewRegdate)
                  Set @HistoryString = @HistoryString + ' Registration Date from ' + Cast(@OldRegdate as varchar(10)) + ' to ' + Cast(@NewRegdate as varchar(10))
                 
            if(@OldCity <> @NewCity)
                  Set @HistoryString = @HistoryString + ' City from ' + @OldCity + ' to ' + @NewCity

			if(@OldContact <> @NewContact)
                  Set @HistoryString = @HistoryString + ' Contact from ' + @OldContact + ' to ' + @NewContact

            insert into Employee_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable1 where CUST_ID = @Id
      End
End


------------------------------------------------------------------------------------------------------------------------------------------------------

--Supplier Table
create table SUPPLIER (
SUPP_ID varchar(6) PRIMARY KEY,
SUPP_Name varchar(50),
SUPP_Address varchar(50),
SUPP_Phone varchar(13),
SUPP_Email varchar(50)
);

SELECT * FROM SUPPLIER 

INSERT INTO SUPPLIER VALUES ('S001','Sohail Plaza','Anarkali Bazar Lahore', '090078601','sohail@gmail.com') 
------------------------------------------------------------------------------------------------------------

--Supplier History Table
create table Supplier_History(
SUPP_History_Id int IDENTITY(1,1) PRIMARY KEY,
SUPP_History_Details varchar (1000) NOT NULL
);

select * from Supplier_History

---------------------------------------------------------
----------------Supplier Triggers------------------------
---------------------------------------------------------
--Insert Trigger
----------------
create TRIGGER tr_Supplier_ForInsert
ON SUPPLIER
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = SUPP_ID from inserted
 
 insert into Supplier_History
 values('New Supplier with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END
----------------
--Delete Trigger
----------------
create TRIGGER tr_Supplier_ForDelete
ON SUPPLIER
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = SUPP_ID from deleted
 
 insert into Supplier_History
 values('An existing supplier with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END

---------------------------
-----Update Trigger--------
---------------------------
create trigger tr_Supplier_ForUpdate
on SUPPLIER
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(50), @NewName varchar(50)
	  Declare @OldAddress varchar(50), @NewAddress varchar(50)
      Declare @OldPhone varchar(13), @NewPhone varchar(13)
      Declare @OldEmail varchar(50), @NewEmail varchar(50)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable2
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select SUPP_ID from #TempTable2))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = SUPP_ID, @NewName = SUPP_Name,
			@NewAddress = SUPP_Address,  
            @NewPhone = SUPP_Phone, @NewEmail = SUPP_Email
            from #TempTable2
           
            -- Select the corresponding row from deleted table
            Select @OldName = SUPP_Name, @OldAddress = SUPP_Address,  
            @OldPhone = SUPP_Phone, @OldEmail= SUPP_Email
            from deleted where SUPP_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Supplier with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldAddress <> @NewAddress)
                  Set @HistoryString = @HistoryString + ' Address from ' + @OldAddress  + ' to ' + @NewAddress
                 
            if(@OldPhone <> @NewPhone)
                  Set @HistoryString = @HistoryString + ' Phone from ' + @OldPhone + ' to ' + @NewPhone

			if(@OldEmail <> @NewEmail)
                  Set @HistoryString = @HistoryString + ' Email from ' + @OldEmail + ' to ' + @NewEmail

            insert into Supplier_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable2 where SUPP_ID = @Id
      End
End


------------------------------------------------------------------------------------------------------------------------------------------------------
--Item Table
-------------
create table ITEM (
ITEM_ID varchar(6) PRIMARY KEY,
SUPP_ID varchar(6) ,
ITEM_Name varchar(50),
ITEM_PurchaseUnitPrice INT,
ITEM_RetailUnitPrice INT,
ITEM_Qty INT,
ITEM_BatchID varchar(6),
ITEM_BatchDate DATE
);

SELECT * FROM ITEM
---------------------------------------------------------
----------------Item Triggers----------------------------
---------------------------------------------------------

--ITEM History Table
create table ITEM_History(
ITEM_History_Id int IDENTITY(1,1) PRIMARY KEY,
ITEM_History_Details varchar (1000) NOT NULL
);

select * from ITEM_History

----------------
--Insert Trigger
----------------
create TRIGGER tr_Item_ForInsert
ON ITEM
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = ITEM_ID from inserted
 
 insert into ITEM_History
 values('New Item with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END
----------------
--Delete Trigger
----------------
create TRIGGER tr_Item_ForDelete
ON ITEM
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = ITEM_ID from deleted
 
 insert into ITEM_History
 values('An existing Item with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END

---------------------------
-----Update Trigger--------
---------------------------
create trigger tr_Item_ForUpdate
on ITEM
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
	  Declare @OldSUPP_Id varchar(6), @NewSUPP_Id varchar(6)
      Declare @OldName varchar(50), @NewName varchar(50)
	  Declare @OldPurchaseUP int, @NewPurchaseUP int
	  Declare @OldRetailUP int, @NewRetailUP int
      Declare @OldQty int, @NewQty int
	  Declare @OldBatchId varchar(6), @NewBatchId varchar(6)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable4
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select ITEM_ID from #TempTable4))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = ITEM_ID,@NewSUPP_Id = SUPP_ID, @NewName = ITEM_Name,
			@NewPurchaseUP = ITEM_PurchaseUnitPrice,@NewRetailUP = ITEM_RetailUnitPrice,  
            @NewQty = ITEM_Qty, @NewBatchId = ITEM_BatchID
            from #TempTable4
           
            -- Select the corresponding row from deleted table
            Select @OldName = ITEM_Name, @OldPurchaseUP = ITEM_PurchaseUnitPrice,  
            @OldRetailUP = ITEM_RetailUnitPrice, @OldQty= ITEM_Qty,
			@OldBatchId = ITEM_BatchID,@OldSUPP_Id = SUPP_ID
            from deleted where ITEM_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Item with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldPurchaseUP <> @NewPurchaseUP)
                  Set @HistoryString = @HistoryString + ' Purchase Unit Price from ' + @OldPurchaseUP  + ' to ' + @NewPurchaseUP
                 
            if(@OldRetailUP <> @NewRetailUP)
                  Set @HistoryString = @HistoryString + ' Retail Unit Price from ' + @OldRetailUP + ' to ' + @NewRetailUP

			if(@OldQty <> @NewQty)
                  Set @HistoryString = @HistoryString + ' Quantity from ' + @OldQty + ' to ' + @NewQty
			
			if(@OldBatchId <> @NewBatchId)
                  Set @HistoryString = @HistoryString + ' Batch Id from ' + @OldBatchId + ' to ' + @NewBatchId
			
			if(@OldSUPP_Id <> @NewSUPP_Id)
                  Set @HistoryString = @HistoryString + ' Supplier Id from ' + @OldSUPP_Id + ' to ' + @NewSUPP_Id

            insert into Supplier_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable4 where ITEM_ID = @Id
      End
End

---------------------------
--Instead of delete Trigger
----------------------------
create trigger tr_insteadOfDelete_Item
on ITEM
instead of delete
as 
begin
	declare @itemId varchar(6) 
	select @itemId =  ITEM_ID from deleted
delete from ORDER_DETAILS where ITEM_ID = @itemId
delete from ITEM where ITEM_ID = @itemId
END
---------------------------------------------------------------

--Counting Data From Custmers table

select count(CUST_ID) from CUSTOMER

-----------------------------------------------------------------

--Procedure for updating Item Quantity in stock

drop Procedure Update_Qty

create procedure Update_Qty
@qty int, @key varchar(6)
AS
Begin
update ITEM 
SET ITEM_QTY = ITEM_QTY - @qty 
where ITEM_ID = @key
END

exec Update_Qty 2,'I001'

---------------------------------------------------------------------
Select ITEM_QTY from ITEM as int where ITEM_ID = 'I001' 




insert into ITEM values ('I001','S001','black Shirt',200,350,50,'B001','2021-12-10')
insert into ITEM values ('I002','S001','White Shirt',200,350,50,'B001','2021-12-10')
insert into ITEM values ('I003','S001','black Trouser',400,550,50,'B001','2021-12-10')


------------------------------------------------------------------------

--Orders Table
drop table orders

create table ORDERS(
ORDER_ID  varchar (6) PRIMARY KEY,
ORDER_Date DATE NOT NULL,
ORDER_Time TIME NOT NULL,
CUST_ID varchar (6) FOREIGN KEY REFERENCES CUSTOMER(CUST_ID)  NOT NULL,
BILL int 
);


------------------------------------------------------------------------

--Procedure for entering data in Orders Table

drop procedure place_order

CREATE PROCEDURE PLACE_ORDER
@ORDER_ID varchar(6) ,@ORDER_DATE DATE, @ORDER_Time TIME, @CUST_ID varchar (6), @Bill int
AS
BEGIN
INSERT INTO ORDERS VALUES (@ORDER_ID,@ORDER_DATE, @ORDER_Time, @CUST_ID, @Bill);
END

EXEC PLACE_ORDER 'K001','2021-12-22', '03:12:01','C001',5000;

------------------------------------------------------------------------------------------------

--Rough Work

delete  from order_details where order_id = 'K005'
delete  from orders where order_id = 'K006'


select * from ORDERS
SELECT * FROM ORDER_DETAILS

select Max(ORDER_ID) from ORDERS

------------------------------------------------------------------------------------------------

--Orders Details Table

drop table order_details

create table ORDER_DETAILS(
ORDER_ID varchar (6) FOREIGN KEY REFERENCES ORDERS(ORDER_ID) NOT NULL,
ITEM_ID varchar(6) FOREIGN KEY REFERENCES ITEM(ITEM_ID) NOT NULL,
ORDER_QTY int NOT NULL,
Total_Price int NOT NULL,
CONSTRAINT ORD PRIMARY KEY (ORDER_ID,ITEM_ID)
);

-------------------------------------------------------------------------------------

--Rough Work

SELECT max(RIGHT(Order_id, 3)) AS ExtractString
FROM ORDERS;

select count(*) from EMPLOYEE where EMP_ID='E001'



Select ITEM_QTY from ITEM where ITEM_ID = 'I001'

select count(CUST_ID) as general from CUSTOMER
select count(ORDER_ID) as general from ORDERS
SELECT SUM(ORDER_QTY) FROM ORDER_DETAILS
select sum(BILL) as general from ORDERS
select count(*) as general from ITEM where ITEM_Qty = 0
----------------------------------------------------------------------------------------
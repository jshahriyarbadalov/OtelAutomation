create proc prc_Staffs_Select
as 
select*from Staffs

go

create proc prc_Staffs_Insert
@Name nvarchar(50),
@Surname nvarchar (50),
@IDCARDNo char(11),
@PhoneNo char(15),
@Address nvarchar(250),
@BirthdayDate date,
@DateOfEntry datetime,
@Salary money,
@Username nvarchar(50),
@Password nvarchar (50),
@IS_ACTIVE bit
as
insert Staffs 
values(@Name,@Surname,@IDCARDNo,@PhoneNo,@Address,@BirthdayDate,@DateOfEntry,@Salary,@Username, @Password, @IS_ACTIVE)

go

create proc prc_Staffs_Enter
@un nvarchar(50),
@pas nvarchar(16)
as
select*from Staffs where [Username]=@un and [Password]=@pas
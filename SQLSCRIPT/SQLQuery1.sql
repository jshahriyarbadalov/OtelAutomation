create proc prc_Category_Insert
@Name nvarchar(50),
@IS_ACTIVE bit
as
insert  Category values (@Name,@IS_ACTIVE)

go

create proc prc_Category_Select
as
select*from Category

go

create proc prc_Products_Select
as
select*from Products

go

create proc prc_Products_Insert
@Name nvarchar(50),
@Price money,
@Quantity float,
@CategoryID int,
@UnitTypeID int,
@IS_ACTIVE bit
as
insert Products values(@Name,@Price,@Quantity,@CategoryID,@UnitTypeID,@IS_ACTIVE)

go

create proc prc_RoomTur_Insert
@Name nvarchar(50),
@Description nvarchar(500),
@IS_ACTIVE bit
as
insert  RoomTur values (@Name,@Description,@IS_ACTIVE)

go

create proc prc_RoomTur_Select
as
select*from RoomTur




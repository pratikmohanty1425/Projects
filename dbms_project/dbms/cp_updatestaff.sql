create procedure st_updateStaff
@name varchar(50),
@uname varchar(50),
@password nvarchar(50),
@phone varchar(15),
@address nvarchar(150),
@roleID int,
@id int
as
update staff
set
s_name=@name,
s_username=@uname,
s_password=@password,
s_phone=@phone,
s_roleID=@roleID,
s_address=@address
where
s_id=@id
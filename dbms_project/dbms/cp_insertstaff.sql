create procedure st_insertStaff
@name varchar(50),
@uname varchar(50),
@password nvarchar(50),
@phone varchar(15),
@address nvarchar(150),
@roleID int
as
insert into staff values (@name,@uname,@password,@phone,@address,@roleID)

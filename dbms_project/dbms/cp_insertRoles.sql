create procedure st_insertRoles
@name varchar(50)
as
insert into Roles values(@name)
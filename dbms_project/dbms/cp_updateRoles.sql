create procedure st_updateRoles
@name varchar(50),
@id int
as
update roles
set
r_name=@name
where
r_id=@id
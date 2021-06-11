create procedure st_deleteRoles
@id int
as
delete from roles where r_id=@id

create procedure st_getRoles
as
select r.r_id as 'ID',r.r_name as 'Role' from roles r

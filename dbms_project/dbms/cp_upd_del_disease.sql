create procedure st_updateDisease
@disease varchar(100),
@did int
as
update diseases
set d_name=@disease
where
d_id=@did


create procedure st_deleteDisease
@did int
as
delete from diseases where d_id=@did
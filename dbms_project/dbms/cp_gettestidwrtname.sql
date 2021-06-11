create procedure st_getTestIDWRTName
@name varchar(100)
as
select t.t_id as 'ID' from tests t where t.t_name=@name

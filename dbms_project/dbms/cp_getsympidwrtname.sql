create procedure st_getSymptomIDWRTName
@name varchar(100)
as
select sy.sy_id as 'ID' from symptoms sy where sy.sy_name=@name
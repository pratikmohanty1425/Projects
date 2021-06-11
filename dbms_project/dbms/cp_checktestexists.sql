create procedure st_checkTestExists
@name varchar(100)
as
select * from tests t
where t.t_name=@name
create procedure st_checkSymptomExists2
@name varchar(100)
as
select * from symptoms sy
where sy.sy_name=@name
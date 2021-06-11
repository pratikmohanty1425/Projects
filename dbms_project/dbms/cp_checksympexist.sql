create procedure st_checkSymptomsExists
@name varchar(100)
as
select * from symptoms sy
where sy.sy_name=@name 
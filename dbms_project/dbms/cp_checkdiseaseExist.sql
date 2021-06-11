create procedure st_checkDiseaseExist
@name varchar(100)
as
select * from diseases sy where sy.d_name=@name
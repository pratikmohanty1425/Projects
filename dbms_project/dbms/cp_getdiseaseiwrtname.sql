create procedure st_getDiseaseIDWRTName
@name varchar(100)
as
select d.d_id as 'ID' from diseases d where d.d_name=@name

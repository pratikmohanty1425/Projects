create procedure st_getDiseases
as
select d.d_id as 'ID',d.d_name as 'Disease' from diseases d order by d.d_name asc
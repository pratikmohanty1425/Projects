create procedure st_getLastTestID
as
select top 1 t.t_id as 'ID' from tests t
order by t.t_id desc

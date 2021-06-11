create procedure st_getLastSymptomID
as
select top 1 sy.sy_id as 'ID' from symptoms sy
order by sy.sy_id desc
create procedure st_getLastDiseaseID
as
select top 1 d.d_id as 'ID' from diseases d
order by d.d_id desc
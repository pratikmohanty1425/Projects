create procedure st_getLastMedicineID
as
select top 1 m.m_id as 'ID' from medicine m
order by m.m_id desc

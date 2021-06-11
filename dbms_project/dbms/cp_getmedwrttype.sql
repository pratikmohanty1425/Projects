create procedure st_getMedicineWRTType
@type tinyint
as
select
m.m_id as 'ID',
m.m_name as 'Medicine'
from medicine m
where m.m_type=@type
order by m.m_name asc
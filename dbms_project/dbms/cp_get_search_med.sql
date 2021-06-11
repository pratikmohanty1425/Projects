create procedure st_getMedicine
as
select
m.m_id as 'ID',
m.m_name as 'Medicine',
case when(m.m_type=0) then 'Internal' else 'External' end as 'Type',
m.m_company as 'Company',
m.m_cost as 'Cost'
from medicine m
order by m.m_name asc

create procedure st_searchMedicine
@data varchar(100)
as
select
m.m_id as 'ID',
m.m_name as 'Medicine',
case when(m.m_type=0) then 'Internal' else 'External' end as 'Type',
m.m_company as 'Company',
m.m_cost as 'Cost'
from medicine m
where (m.m_name like '%'+@data+'%') or (m.m_company like '%'+@data+'%') or ((case when(m.m_type=0) then 'Internal' else 'External' end) like '%'+@data+'%')
order by m.m_name asc
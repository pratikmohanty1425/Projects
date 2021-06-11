create procedure st_getdoctors
as
select
s.s_id as 'ID',
s.s_name as 'Doctor'
from staff s
inner join roles r
on r.r_id=s.s_roleID
where
r.r_name='Doctor'
order by s.s_name asc
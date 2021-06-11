create procedure st_deleteStaff
@id int
as
delete from staff where s_id=@id

create procedure st_getStaff
as
select
s.s_id as 'ID',
s.s_name as 'Staff',
s.s_username as 'Username',
s.s_password as 'Password',
s.s_phone as 'Phone',
s.s_address as 'Address',
r.r_id as 'Role'
from staff s
inner join roles r
on r.r_id=s.s_roleID
order by s.s_name asc

create procedure st_getStaffWRTRole
@roleID int
as
select
s.s_id as 'ID',
s.s_name as 'Staff',
s.s_username as 'Username',
s.s_password as 'Password',
s.s_phone as 'Phone',
s.s_address as 'Address',
r.r_id as 'Role' from staff s
inner join roles r
on r.r_id=s.s_roleID
where
r.r_id=@roleID
order by s.s_name asc
create procedure st_getAuthenticationDetails
@username varchar(50),
@pass varchar(50)
as
select
s.s_id as 'ID',
s.s_name as 'Name',
s.s_roleID as 'Role Id',
r.r_name as 'Role'
from staff s
inner join roles r
on r.r_id=s.s_roleID
where s.s_username=@username and s.s_password=@pass
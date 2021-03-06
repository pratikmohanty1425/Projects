USE [cms]
GO
/****** Object:  StoredProcedure [dbo].[st_getStaff]    Script Date: 18-02-2020 09:21:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_getStaff]
as
select
s.s_id as 'ID',
s.s_name as 'Staff',
s.s_username as 'Username',
s.s_password as 'Password',
s.s_phone as 'Phone',
s.s_address as 'Address',
r.r_id as 'ID',
r.r_name as 'Role'
from staff s
inner join roles r
on r.r_id=s.s_roleID
order by s.s_name asc
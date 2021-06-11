create procedure st_getMedicineIDWRTName
@name varchar(100)
as
select m.m_id as 'ID' from medicine m where m.m_name=@name

create procedure st_checkMedicineExists
@name varchar(100),
@type tinyint
as
select * from medicine m
where m.m_name=@name
and m.m_type=@type
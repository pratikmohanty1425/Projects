create procedure st_insertMedicine
@name varchar(100),
@comp varchar(100),
@type tinyint,
@cost int
as
insert into Medicine values (@name,@comp,@type,@cost)

create procedure st_updateMedicine
@name varchar(100),
@comp varchar(100),
@type tinyint,
@cost int,
@id int
as
update medicine
set
m_name=@name,
m_company=@comp,
m_type=@type,
m_cost=@cost
where m_id=@id

create procedure st_deleteMedicine
@id int
as
delete from medicine where m_id=@id


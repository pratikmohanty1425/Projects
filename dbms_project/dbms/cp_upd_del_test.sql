create procedure st_updateTests
@name varchar(100),
@price money,
@prec varchar(150),
@id int
as
update tests
set
t_name=@name,
t_price=@price,
t_precautions=@prec
where
t_id=@id

create procedure st_deleteTest
@id int
as
delete from tests where t_id=@id

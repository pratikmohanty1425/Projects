create procedure st_insertTests
@name varchar(100),
@price money,
@prec varchar(150)
as
insert into tests values(@name,@price,@prec)

create procedure st_insertTests2
@name varchar(100)
as
insert into tests (t_name) values(@name)


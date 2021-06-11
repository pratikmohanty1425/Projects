create table tests
(
t_id int not null primary key identity,
t_name varchar(100) not null,
t_price money not null default 0,
t_precautions varchar(150) not null default 'None'
)
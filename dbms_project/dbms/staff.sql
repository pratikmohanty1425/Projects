create table Staff
(
s_id int not null primary key identity,
s_name varchar(50) not null,
s_username varchar(50) not null unique,
s_password nvarchar(50) not null,
s_phone varchar(15) not null,
s_address nvarchar(150) not null,
s_roleID int not null foreign key references roles(r_id) on delete cascade on update cascade
)
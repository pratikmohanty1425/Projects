create table medicine
(
m_id int not null identity primary key,
m_name varchar(100) not null,
m_company varchar(100),
m_type tinyint not null,
m_cost int not null
)



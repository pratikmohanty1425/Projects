create table PatientReg
(
pr_id bigint not null identity primary key,
pr_name varchar(100) not null,
pr_guardian varchar(100),
pr_age float not null,
pr_gender varchar(10) not null,
pr_phone varchar(15) not null
)
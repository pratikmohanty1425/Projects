create procedure st_insertPatientReg
@name varchar(100),
@age float,
@guard varchar(100),
@gender varchar(10),
@phone varchar(15)
as
insert into patientRegistration values (@name,@age,@guard,@gender,@phone)


create procedure st_updatePatientReg
@name varchar(100),
@age float,
@guard varchar(100),
@gender varchar(10),
@phone varchar(15),
@id bigint
as
update patientRegistration
set
pr_name=@name,
pr_age=@age,
pr_guardian=@guard,
pr_gender=@gender,
pr_phone=@phone
where
pr_id=@id


create procedure st_deletePatientReg
@id bigint
as
delete from patientRegistration where pr_id=@id


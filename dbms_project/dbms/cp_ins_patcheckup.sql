create procedure st_insertpatientCheckUp
@appId bigint,
@rem varchar(1000),
@fees money
as
insert into patientCheckup values (@appID,@rem,@fees)
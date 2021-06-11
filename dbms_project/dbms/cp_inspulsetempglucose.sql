create procedure st_insertPulseGlucoseTemp
@appID bigint,
@pulse varchar(10),
@temp varchar(10),
@glucose varchar(10)
as
insert into patientPulseTempGlucose values (@appID,@pulse,@temp,@glucose)

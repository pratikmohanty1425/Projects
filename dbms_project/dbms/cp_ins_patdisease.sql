create procedure st_insertPatientDisease
@appID bigint,
@diseaseID int
as
insert into PatientDisease values(@appID,@diseaseID)
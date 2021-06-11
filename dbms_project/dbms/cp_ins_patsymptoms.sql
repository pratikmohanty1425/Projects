create procedure st_insertPatientSymptoms
@appID bigint,
@symID bigint
as
insert into PatientSymptoms values (@appID,@symID)

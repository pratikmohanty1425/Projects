create procedure st_updatePatientStatus
@status tinyint,
@appID bigint
as
update patientAppointment
set pa_status=@status
where
pa_id=@appID
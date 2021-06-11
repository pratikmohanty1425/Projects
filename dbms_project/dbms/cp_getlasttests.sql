create procedure st_getLastTests
@appID bigint
as
select s.t_id as 'ID',s.t_name as 'Test' from patientAppointment pa
left join PatientTests pp
on pa.pa_id=pp.pd_appointmentID
inner join tests s
on s.t_id=pp.pd_testID
where
pa.pa_id=@appID
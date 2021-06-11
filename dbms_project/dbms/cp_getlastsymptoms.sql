create procedure st_getLastSymptoms
@appID bigint
as
select sy.sy_id as 'ID',sy.sy_name as 'Symptom' from patientAppointment pa
left join PatientSymptoms pp
on pa.pa_id=pp.ps_appointmentID
inner join symptoms sy
on sy.sy_id=pp.ps_symptomID
where
pa.pa_id=@appID
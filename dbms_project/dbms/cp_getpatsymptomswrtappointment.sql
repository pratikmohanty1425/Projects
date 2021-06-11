create procedure st_getPatientSymptomsWRTAppointment
@appID bigint
as
select sy.sy_name as 'Symptoms' from PatientSymptoms ps
left join symptoms sy
on sy.sy_id=ps.ps_symptomID
where ps.ps_appointmentID=@appID

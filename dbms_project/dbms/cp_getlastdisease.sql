create procedure st_getLastDisease
@appID bigint
as
select d.d_id as 'ID',d.d_name as 'Disease' from patientAppointment pa
left join PatientDisease pp
on pa.pa_id=pp.pd_appointmentID
inner join diseases d
on d.d_id=pp.pd_diseaseID
where
pa.pa_id=@appID
create procedure st_getLastPrescribedMedicine
@type tinyint,
@appID bigint
as
select m.m_id as 'ID',m.m_name as 'Medicine' from patientAppointment pa
left join PatientPrescription pp
on pa.pa_id=pp.pip_appointmentID
inner join medicine m
on m.m_id=pp.pip_medicineID
where
pa.pa_id=@appID
and
m.m_type=@type
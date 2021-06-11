create procedure st_getLastRemarks
@appID bigint
as
select pp.pcu_remarks as 'Remarks'from patientAppointment pa
left join patientCheckUp pp
on pa.pa_id=pp.pcu_appID
where
pa.pa_id=@appID

create procedure st_getPatientTestWRTAppointment
@appID bigint
as
select t.t_name as 'Tests' from PatientTests pt
left join tests t
on t.t_id=pt.pd_testID
where pt.pd_appointmentID=@appID
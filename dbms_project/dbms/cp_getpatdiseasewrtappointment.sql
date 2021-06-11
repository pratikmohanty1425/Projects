create procedure st_getPatientDiseaseWRTAppointment
@appID bigint
as
select d.d_name as 'Disease' from PatientDisease pd
left join diseases d
on d.d_id=pd.pd_diseaseID
where pd.pd_appointmentID=@appID

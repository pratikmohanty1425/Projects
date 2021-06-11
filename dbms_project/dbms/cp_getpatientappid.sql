create procedure st_getPatientAppointmentID
@patID bigint,
@day int,@month int,@year int
as
select top 1 pa.pa_id as 'AppointmentID' from patientAppointment pa
where pa.pa_patientID=@patID
and day(pa.pa_date)=@day and month(pa.pa_date)=@month and year(pa.pa_date)=@year
order by pa.pa_id desc

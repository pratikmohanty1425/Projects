create procedure st_getLastTokenNo
@day int,
@month int,
@year int
as
select top 1 pa.pa_turnNumber,format(pa.pa_date,'dd-MMM-yyyy hh:mm tt') from patientAppointment pa
where
day(pa.pa_date)=@day and
MONTH(pa.pa_date)=@month and
year(pa.pa_date)=@year
order by pa.pa_id desc
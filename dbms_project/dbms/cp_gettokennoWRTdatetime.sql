create procedure st_getTokenNoWRTDateTime
@day int,
@month int,
@year int,
@hours int,
@min int
as
select pa.pa_turnNumber,format(pa.pa_date,'dd-MMM-yyyy hh:mm') as 'Date' from patientAppointment pa
where
day(pa.pa_date)=@day and
MONTH(pa.pa_date)=@month and
year(pa.pa_date)=@year and
DATEPART(HH,pa.pa_date)=@hours and
DATEPART(MINUTE,pa.pa_date)=@min
order by pa.pa_id desc
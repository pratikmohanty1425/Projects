create procedure st_getTurnNumberWRTpatientWRTToday
@day int,
@month int,
@year int,
@patID bigint
as
select
pa.pa_turnNumber as 'Turn #'
from PatientReg pg
inner join patientAppointment pa
on pg.pr_id=pa.pa_patientID
where day(pa.pa_date)=@day and month(pa.pa_date)=@month and YEAR(pa.pa_date)=@year
and pa.pa_status=0
and pg.pr_id=@patID

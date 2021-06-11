create procedure st_getTodaysPatients
@day int,
@month int,
@year int
as
select
pg.pr_id as 'Patient ID',
pg.pr_name as 'Patient'
from PatientReg pg
inner join patientAppointment pa
on pg.pr_id=pa.pa_patientID
where day(pa.pa_date)=@day and month(pa.pa_date)=@month and YEAR(pa.pa_date)=@year
and pa.pa_status=0
order by pa.pa_turnNumber asc
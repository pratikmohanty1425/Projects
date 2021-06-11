create procedure st_getPatientAppointmentRegistration
as
select
pa.pa_turnNumber as 'Turn',
pr.pr_id as 'ID',
pr.pr_name as 'Patient',
pr.pr_guardian as 'Guardian',
pr.pr_gender as 'Gender',
format(pa.pa_date,'dd-MMM-yyyy hh:mm tt') as 'AppointmentDate',
pr.pr_age as 'Age',
s.s_name as 'Doctor',
s.s_id as 'Doctor ID',
case when (pa.pa_status=0) then 'Not Consulted' else
case when (pa.pa_status=1) then 'Consulted' else
case when (pa.pa_status=2) then 'completed' end end end as 'Status',
pa.pa_id as 'AppointmentID',
pr.pr_phone as 'Phone'
from patientRegistration pr
inner join patientAppointment pa
on pr.pr_id=pa.pa_patientID
inner join staff s
on s.s_id=pa.pa_doctorID
where pa.pa_status=0
order by pa.pa_id desc
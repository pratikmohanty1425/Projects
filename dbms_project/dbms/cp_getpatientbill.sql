create procedure st_getPatientBill
@appID bigint
as
select distinct
pa.pa_id as 'Appointment Id',
pr.pr_name as 'Patient',
pr.pr_guardian as 'Guardian',
pr.pr_age as 'Age',
format(pa.pa_date,'dd-MMM-yyyy hh:mm') as 'Appointment Date',
case when(pa.pa_status=0) then 'Not Consulted' else case when (pa.pa_status=1) then 'Consulted' else case when(pa.pa_status=2) then 'Completed' end end end as 'Status',
s.s_name as 'Doctor'
from patientAppointment pa
inner join patientReg pr
on pr.pr_id=pa.pa_patientID
inner join staff s
on s.s_id=pa.pa_doctorID
where pa.pa_id=@appID

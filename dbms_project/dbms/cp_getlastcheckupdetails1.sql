create procedure st_getLastCheckupDetails1
@status tinyint,
@patientID bigint
as
select
distinct
(select top 1 s.s_name as 'Doctor' from patientAppointment pa inner join staff s on s.s_id=pa.pa_doctorID where pa.pa_status=@status and pa.pa_patientID=@patientID order by pa.pa_id desc) as 'Doctor',
(select top 1 format(pa.pa_date,'dd-MMM-yyyy hh:mm tt') as 'Doctor' from patientAppointment pa inner join staff s on s.s_id=pa.pa_doctorID where pa.pa_status=@status and pa.pa_patientID=@patientID order by pa.pa_id desc) as 'AppointmentDate',
(select top 1 ptg.pp_temp from patientPulseTempGlucose ptg where ptg.pp_appointmentID=p.pa_id order by ptg.pp_id desc) as 'Temperature',
(select top 1 ptg.pp_Glucose from patientPulseTempGlucose ptg where ptg.pp_appointmentID=p.pa_id order by ptg.pp_id desc) as 'Glucose',
(select top 1 ptg.pp_pulse from patientPulseTempGlucose ptg where ptg.pp_appointmentID=p.pa_id order by ptg.pp_id desc) as 'Pulse',
(select top 1 pa.pa_id from patientAppointment pa where pa.pa_patientID=@patientID and pa.pa_status=@status order by pa.pa_id desc) as 'AppointID'
from
patientAppointment p
where p.pa_patientID=@patientID
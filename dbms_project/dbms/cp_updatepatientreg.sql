USE [cms]
GO
/****** Object:  StoredProcedure [dbo].[st_checkPatientRegistrationExist]    Script Date: 19-02-2020 08:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_checkPatientRegistrationExist]
@phone varchar(15)
as
select top 1
pr.pr_id as 'PatientID',
pr.pr_name as 'Patient',
pr.pr_guardian as 'Guardian',
pr.pr_gender as 'Gender',
format(pa.pa_date,'dd-MMM-yyyy hh:mm tt') as 'Last Appointment',
pr.pr_age as 'Age',
s.s_name as 'Doctor',
s.s_id as 'Doctor ID',
case when (pa.pa_status=0) then 'Not Consulted' else
case when (pa.pa_status=1) then 'Consulted' else
case when (pa.pa_status=2) then 'completed' end end end as 'Status'
from PatientReg pr
inner join patientAppointment pa
on pr.pr_id=pa.pa_patientID
inner join staff s
on s.s_id=pa.pa_doctorID
where pr.pr_phone=@phone
order by pa.pa_id desc
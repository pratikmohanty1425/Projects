create procedure st_getPulseTemperatureDiabetes
@appID bigint
as
select
ppg.pp_pulse as 'Pulse',
ppg.pp_temp as 'Temp',
ppg.pp_Glucose as 'Glucose'
from patientPulseTempGlucose ppg
where
ppg.pp_appointmentID=@appID 
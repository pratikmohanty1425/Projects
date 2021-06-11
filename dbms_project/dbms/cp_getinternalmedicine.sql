create procedure st_getInternalMedicine
@appID bigint
as
select m.m_name as 'Medicine1',
(case when(pp.pip_dosageID=0) then 'Morning' else
case when(pp.pip_dosageID=1) then 'Morning+Evening' else
case when(pp.pip_dosageID=2) then 'Morning+Afternoon+Night' else
case when(pp.pip_dosageID=3) then 'Before Meal' else
case when(pp.pip_dosageID=4) then 'At night before sleep' else
case when(pp.pip_dosageID=5) then 'Once a day' else
case when(pp.pip_dosageID=6) then pp.pip_others
end end end end end end end) as 'Dosage Internal' from PatientPrescription pp
left join medicine m
on m.m_id=pp.pip_medicineID
where pp.pip_appointmentID=@appID and m.m_type=0
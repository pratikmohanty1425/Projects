create procedure st_insertPatientMedicine
@appID bigint,
@medicineID int,
@dosage tinyint
as
insert into PatientPrescription(pip_appointmentID,pip_medicineID,pip_dosageID) values (@appID,@medicineID,@dosage)

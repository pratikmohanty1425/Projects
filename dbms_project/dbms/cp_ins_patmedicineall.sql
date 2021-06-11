create procedure st_insertPatientMedicineAll
@appID bigint,
@medicineID int,
@dosage tinyint,
@other varchar(100)
as
insert into PatientPrescription values (@appID,@medicineID,@dosage,@other)

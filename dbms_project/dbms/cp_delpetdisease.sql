create procedure st_deletepatientdisease
@pdid int
as
delete from PatientDisease where pd_id=@pdid;
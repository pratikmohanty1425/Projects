create procedure st_insertPatientTests
@appID bigint,
@testID int
as
insert into PatientTests values (@appID,@testID)

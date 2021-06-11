create procedure st_getPatientGuardianAndAge
@id bigint
as
select pr.pr_guardian as 'Guardian',
pr.pr_age as 'Age'
from patientReg pr
where
pr.pr_id=@id
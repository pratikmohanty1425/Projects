create procedure st_getSymptoms
as
select
sy.sy_id as 'SymptomID',
sy.sy_name as 'Symptom'
from symptoms sy
order by sy.sy_name asc
create procedure st_updateSymptom
@symptom varchar(100),
@syid bigint
as
update symptoms
set sy_name=@symptom
where
sy_id=@syid
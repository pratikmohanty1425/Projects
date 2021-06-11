create procedure st_insertSymptoms
@symptom varchar(100)
as
insert into symptoms values (@symptom)
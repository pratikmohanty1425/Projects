create procedure st_deleteSymptom
@syid int
as
delete from symptoms where sy_id=@syid

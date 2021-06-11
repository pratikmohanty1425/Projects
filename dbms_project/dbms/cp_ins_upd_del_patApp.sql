create procedure st_insertAppointment
@date datetime,
@doctorId int,
@patientID int,
@status tinyint,
@day int,@month int,@year int
as
declare @turnNUmber tinyint
set @turnNUmber=isnull((select top 1 pa.pa_turnNumber from patientAppointment pa where day(pa.pa_date)=@day and month(pa.pa_date)=@month and year(pa.pa_date)=@year  order by pa.pa_date desc),0)+1
insert into patientAppointment values (@date,@turnNUmber,@doctorID,@patientID,@status)


create procedure st_updateAppointment
@date datetime,
@doctorID int,
@patientID int,
@status tinyint,
@id bigint
as
update patientAppointment
set
pa_date=@date,
pa_doctorID=@doctorID,
pa_patientID=@patientID,
pa_status=@status
where
pa_id=@id

create procedure st_deleteAppointment
@id bigint
as
delete from patientAppointment where pa_id=@id
create procedure st_checkDisease
@disease varchar(100)
as
select * from diseases d where d.d_name=@disease

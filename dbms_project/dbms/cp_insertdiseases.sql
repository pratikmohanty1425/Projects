create procedure st_insertDisease
@disease varchar(100)
as
insert into diseases values (@disease)
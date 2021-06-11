USE [cms]
GO
/****** Object:  StoredProcedure [dbo].[st_insertPatientReg]    Script Date: 19-02-2020 09:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_insertPatientReg]
@name varchar(100),
@age float,
@guard varchar(100),
@gender varchar(10),
@phone varchar(15)
as
insert into PatientReg values (@name,@age,@guard,@gender,@phone)

USE [cms]
GO
/****** Object:  StoredProcedure [dbo].[st_deletePatientReg]    Script Date: 19-02-2020 09:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_deletePatientReg]
@id bigint
as
delete from PatientReg where pr_id=@id
USE [cms]
GO
/****** Object:  StoredProcedure [dbo].[st_getLastPatientID]    Script Date: 19-02-2020 09:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_getLastPatientID]
as
select top 1 pr.pr_id as 'ID' from PatientReg pr order by pr.pr_id desc


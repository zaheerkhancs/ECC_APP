USE [ECCMS]
GO
/****** Object:  StoredProcedure [dbo].[Admin_Search]    Script Date: 10/16/2010 09:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[Admin_Search]
@CaseNo nvarchar(50), 
@BitName nvarchar(50),
@caseProName nvarchar(50),
@ProvNameEng nvarchar(50),
@Resp_OfficeName nvarchar(50),
@RespType_Name nvarchar(50),
@SanctionName nvarchar(50),
@Comp_Name nvarchar(50),
@StatusName nvarchar(50)
AS
BEGIN
SELECT     dbo.tblComplain.CaseID, dbo.tblComplain.CaseNo, dbo.tblComplain.Sub_Date, dbo.lkpBit.BitName, dbo.lkpCasepriority.caseProName, 
                      dbo.tblComplain.Tri_Date, dbo.lkpPollingCenter.PolCen_Code, dbo.lkpDistrict.District_Name, dbo.lkpProvince.ProvNameEng, 
                      dbo.lkpCandidate.Cand_No, dbo.lkpResponsibleOffice.Resp_OfficeName, dbo.tblComplain.IsDeleted, dbo.lkpRespondanttype.RespType_Name, 
                      dbo.lkpSanction.SacntionName, dbo.lkpStatus.StatusName, dbo.lkpComplainanttype.Comp_Name
FROM         dbo.tblComplain INNER JOIN
                      dbo.lkpPollingCenter ON dbo.tblComplain.PolCen_ID = dbo.lkpPollingCenter.PolCen_Id INNER JOIN
                      dbo.lkpDistrict ON dbo.lkpPollingCenter.District_Code = dbo.lkpDistrict.District_Code INNER JOIN
                      dbo.lkpBit ON dbo.tblComplain.Kuchi = dbo.lkpBit.BitID INNER JOIN
                      dbo.lkpCasepriority ON dbo.tblComplain.caseProID = dbo.lkpCasepriority.caseProID INNER JOIN
                      dbo.lkpCandidate ON dbo.tblComplain.Comp_Cand_ID = dbo.lkpCandidate.Cand_ID INNER JOIN
                      dbo.lkpResponsibleOffice ON dbo.tblComplain.Resp_OfficeID = dbo.lkpResponsibleOffice.Resp_OfficeID INNER JOIN
                      dbo.lkpRespondanttype ON dbo.tblComplain.Resp_TypeID = dbo.lkpRespondanttype.RespType_ID INNER JOIN
                      dbo.lkpSanction ON dbo.tblComplain.SanctionID = dbo.lkpSanction.SacntionID INNER JOIN
                      dbo.lkpStatus ON dbo.tblComplain.StatusID = dbo.lkpStatus.StatusId INNER JOIN
                      dbo.lkpComplainanttype ON dbo.tblComplain.Comp_TypeID = dbo.lkpComplainanttype.Comp_TypeID FULL OUTER JOIN
                      dbo.lkpProvince ON dbo.tblComplain.ProvID = dbo.lkpProvince.ProvId
WHERE     (dbo.tblComplain.IsDeleted = 0) And(
                      (dbo.tblComplain.CaseNo = @CaseNo) OR
                      (dbo.lkpBit.BitName = @BitName) OR
                      (dbo.lkpCasepriority.caseProName = @caseProName) OR
                      (dbo.lkpProvince.ProvNameEng = @ProvNameEng) OR
                      (dbo.lkpResponsibleOffice.Resp_OfficeName = @Resp_OfficeName) OR
                      (dbo.lkpRespondanttype.RespType_Name = @RespType_Name) OR
                      (dbo.lkpSanction.SacntionName = @SanctionName ) OR
                      (dbo.lkpStatus.StatusName = @StatusName) OR
                      (dbo.lkpComplainanttype.Comp_Name = @Comp_Name))
END





USE [ECCMS]
GO
/****** Object:  StoredProcedure [dbo].[_Complain_DeleteLogically]    Script Date: 10/12/2010 08:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_Complain_DeleteLogically]
@CaseID bigint 
AS
BEGIN
update tblComplain set isDeleted= 1 where CaseID= @CaseID
END


GO
/****** Object:  StoredProcedure [dbo].[_ComplainList]    Script Date: 10/12/2010 08:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[_ComplainList]
	
AS
BEGIN
SELECT     dbo.tblComplain.CaseID,dbo.tblComplain.CaseNo, dbo.tblComplain.Sub_Date, dbo.tblComplain.Kuchi, dbo.lkpBit.BitName, dbo.tblComplain.caseProID, 
                      dbo.lkpCasepriority.caseProName, dbo.tblComplain.Tri_Date, dbo.tblComplain.PolCen_ID, dbo.lkpPollingCenter.PolCen_Code, 
                      dbo.lkpDistrict.District_Name, dbo.lkpProvince.ProvNameEng, dbo.tblComplain.Comp_Cand_ID, dbo.lkpCandidate.Cand_No, 
                      dbo.tblComplain.Resp_OfficeID, dbo.lkpResponsibleOffice.Resp_OfficeName, dbo.lkpProvince.ProvId, dbo.tblComplain.IsDeleted
FROM         dbo.tblComplain INNER JOIN
                      dbo.lkpPollingCenter ON dbo.tblComplain.PolCen_ID = dbo.lkpPollingCenter.PolCen_Id INNER JOIN
                      dbo.lkpDistrict ON dbo.lkpPollingCenter.District_Code = dbo.lkpDistrict.District_Code INNER JOIN
                      dbo.lkpBit ON dbo.tblComplain.Kuchi = dbo.lkpBit.BitID INNER JOIN
                      dbo.lkpCasepriority ON dbo.tblComplain.caseProID = dbo.lkpCasepriority.caseProID INNER JOIN
                      dbo.lkpCandidate ON dbo.tblComplain.Comp_Cand_ID = dbo.lkpCandidate.Cand_ID INNER JOIN
                      dbo.lkpResponsibleOffice ON dbo.tblComplain.Resp_OfficeID = dbo.lkpResponsibleOffice.Resp_OfficeID FULL OUTER JOIN
                      dbo.lkpProvince ON dbo.tblComplain.ProvID = dbo.lkpProvince.ProvId
WHERE     (dbo.tblComplain.IsDeleted = 0)
END







GO
/****** Object:  StoredProcedure [dbo].[_ComplainListByProv]    Script Date: 10/12/2010 08:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[_ComplainListByProv]
	@ProvID int 
AS
BEGIN
SELECT     dbo.tblComplain.CaseID,dbo.tblComplain.CaseNo, dbo.tblComplain.Sub_Date, dbo.tblComplain.Kuchi, dbo.lkpBit.BitName, dbo.tblComplain.caseProID, 
                      dbo.lkpCasepriority.caseProName, dbo.tblComplain.Tri_Date, dbo.tblComplain.PolCen_ID, dbo.lkpPollingCenter.PolCen_Code, 
                      dbo.lkpDistrict.District_Name, dbo.lkpProvince.ProvNameEng, dbo.tblComplain.Comp_Cand_ID, dbo.lkpCandidate.Cand_No, 
                      dbo.tblComplain.Resp_OfficeID, dbo.lkpResponsibleOffice.Resp_OfficeName, dbo.lkpProvince.ProvId, dbo.tblComplain.IsDeleted
FROM         dbo.tblComplain INNER JOIN
                      dbo.lkpPollingCenter ON dbo.tblComplain.PolCen_ID = dbo.lkpPollingCenter.PolCen_Id INNER JOIN
                      dbo.lkpDistrict ON dbo.lkpPollingCenter.District_Code = dbo.lkpDistrict.District_Code INNER JOIN
                      dbo.lkpBit ON dbo.tblComplain.Kuchi = dbo.lkpBit.BitID INNER JOIN
                      dbo.lkpCasepriority ON dbo.tblComplain.caseProID = dbo.lkpCasepriority.caseProID INNER JOIN
                      dbo.lkpCandidate ON dbo.tblComplain.Comp_Cand_ID = dbo.lkpCandidate.Cand_ID INNER JOIN
                      dbo.lkpResponsibleOffice ON dbo.tblComplain.Resp_OfficeID = dbo.lkpResponsibleOffice.Resp_OfficeID INNER JOIN
                      dbo.lkpProvince ON dbo.tblComplain.ProvID = dbo.lkpProvince.ProvId
WHERE     (dbo.tblComplain.IsDeleted = 0) AND (dbo.tblComplain.ProvID = @ProvID)
END






GO
/****** Object:  StoredProcedure [dbo].[_ComplainListByUser]    Script Date: 10/12/2010 08:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[_ComplainListByUser]
@UserID UniqueIdentifier 
AS
BEGIN
SELECT    dbo.tblComplain.CaseID, dbo.tblComplain.CaseNo, dbo.tblComplain.Sub_Date, dbo.tblComplain.Kuchi, dbo.lkpBit.BitName, dbo.tblComplain.caseProID, 
                      dbo.lkpCasepriority.caseProName, dbo.tblComplain.Tri_Date, dbo.tblComplain.PolCen_ID, dbo.lkpPollingCenter.PolCen_Code, 
                      dbo.lkpDistrict.District_Name, dbo.lkpProvince.ProvNameEng, dbo.tblComplain.Comp_Cand_ID, dbo.lkpCandidate.Cand_No, 
                      dbo.tblComplain.Resp_OfficeID, dbo.lkpResponsibleOffice.Resp_OfficeName, dbo.lkpProvince.ProvId, dbo.tblComplain.IsDeleted, 
                      dbo.tblComplain.CreatedBy
FROM         dbo.tblComplain INNER JOIN
                      dbo.lkpPollingCenter ON dbo.tblComplain.PolCen_ID = dbo.lkpPollingCenter.PolCen_Id INNER JOIN
                      dbo.lkpDistrict ON dbo.lkpPollingCenter.District_Code = dbo.lkpDistrict.District_Code INNER JOIN
                      dbo.lkpBit ON dbo.tblComplain.Kuchi = dbo.lkpBit.BitID INNER JOIN
                      dbo.lkpCasepriority ON dbo.tblComplain.caseProID = dbo.lkpCasepriority.caseProID INNER JOIN
                      dbo.lkpCandidate ON dbo.tblComplain.Comp_Cand_ID = dbo.lkpCandidate.Cand_ID INNER JOIN
                      dbo.lkpResponsibleOffice ON dbo.tblComplain.Resp_OfficeID = dbo.lkpResponsibleOffice.Resp_OfficeID INNER JOIN
                      dbo.lkpProvince ON dbo.tblComplain.ProvID = dbo.lkpProvince.ProvId
WHERE     (dbo.tblComplain.IsDeleted = 0) AND (dbo.tblComplain.CreatedBy = @UserID)
END



GO
/****** Object:  StoredProcedure [dbo].[_ComplainListByUser_ByProv]    Script Date: 10/12/2010 08:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[_ComplainListByUser_ByProv] 
@ProvID int,
@UserID UniqueIdentifier 
AS
BEGIN
SELECT    dbo.tblComplain.CaseID, dbo.tblComplain.CaseNo, dbo.tblComplain.Sub_Date, dbo.tblComplain.Kuchi, dbo.lkpBit.BitName, dbo.tblComplain.caseProID, 
                      dbo.lkpCasepriority.caseProName, dbo.tblComplain.Tri_Date, dbo.tblComplain.PolCen_ID, dbo.lkpPollingCenter.PolCen_Code, 
                      dbo.lkpDistrict.District_Name, dbo.lkpProvince.ProvNameEng, dbo.tblComplain.Comp_Cand_ID, dbo.lkpCandidate.Cand_No, 
                      dbo.tblComplain.Resp_OfficeID, dbo.lkpResponsibleOffice.Resp_OfficeName, dbo.lkpProvince.ProvId, dbo.tblComplain.IsDeleted, 
                      dbo.tblComplain.CreatedBy
FROM         dbo.tblComplain INNER JOIN
                      dbo.lkpPollingCenter ON dbo.tblComplain.PolCen_ID = dbo.lkpPollingCenter.PolCen_Id INNER JOIN
                      dbo.lkpDistrict ON dbo.lkpPollingCenter.District_Code = dbo.lkpDistrict.District_Code INNER JOIN
                      dbo.lkpBit ON dbo.tblComplain.Kuchi = dbo.lkpBit.BitID INNER JOIN
                      dbo.lkpCasepriority ON dbo.tblComplain.caseProID = dbo.lkpCasepriority.caseProID INNER JOIN
                      dbo.lkpCandidate ON dbo.tblComplain.Comp_Cand_ID = dbo.lkpCandidate.Cand_ID INNER JOIN
                      dbo.lkpResponsibleOffice ON dbo.tblComplain.Resp_OfficeID = dbo.lkpResponsibleOffice.Resp_OfficeID INNER JOIN
                      dbo.lkpProvince ON dbo.tblComplain.ProvID = dbo.lkpProvince.ProvId
WHERE     (dbo.tblComplain.IsDeleted = 0) AND (dbo.tblComplain.CreatedBy = @UserID) AND (dbo.tblComplain.ProvID = @ProvID)
END





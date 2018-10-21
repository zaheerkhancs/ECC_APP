using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IOM.ECCMS.ECCDB
{
  public   class Complain: IDisposable 
    {
        private ECCMS  objDB = null;
        private bool IsDisposed = false;

        public Complain()
        {
            objDB = new ECCMS();
        }

        public void Dispose()
        {
            if (null != objDB)
            {
                objDB.Dispose();
                IsDisposed = true;
            }
        }

        public ECCMS    ObjectDB
        {
            get
            {
                return objDB;
            }
        }

        public Int32 getMaxCaseNo(int ProvID)
        {
            DataTable dtCaseNo = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_CaseCount", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = ProvID ;
            dtCaseNo = objDB.CreateDataTable(cmdSelect);
            return Convert.ToInt32( dtCaseNo.Rows[0][0]);
        }

        public DataTable getComplainList()
        {
            DataTable _dtComplainList = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_ComplainList", true));
            _dtComplainList = objDB.CreateDataTable(cmdSelect);
            return _dtComplainList;
        }

        public DataTable getComplainListByProv(int prov_ID)
        {
            DataTable _dtComplainListProv = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_ComplainListByProv", true));
            cmdSelect.Parameters.Add("@ProvID", SqlDbType.Int).Value = prov_ID;
            _dtComplainListProv = objDB.CreateDataTable(cmdSelect);
            return _dtComplainListProv;
        }

        public DataTable getComplainListbyUser(Guid UserID)
        {
            DataTable _dtComplainListUser = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_ComplainListByUser", true));
            cmdSelect.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier ).Value = UserID;
            _dtComplainListUser = objDB.CreateDataTable(cmdSelect);
            return _dtComplainListUser;
        }

        public DataTable getComplainListByUser_rov(int prov_ID,Guid UserID)
        {
            DataTable _dtComplainListUserProv = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_ComplainListByUser_ByProv", true));
            cmdSelect.Parameters.Add("@ProvID", SqlDbType.Int).Value = prov_ID;
            cmdSelect.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier ).Value = UserID ;
            _dtComplainListUserProv = objDB.CreateDataTable(cmdSelect);
            return _dtComplainListUserProv;
        }

        public DataTable _Complain_DeleteLogically(string _CaseID)
        {
            DataTable _dtComplainList = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complain_DeleteLogically", true));
            cmdSelect.Parameters.Add("@CaseID", SqlDbType.BigInt).Value = _CaseID;
            _dtComplainList = objDB.CreateDataTable(cmdSelect);
            return _dtComplainList;
        }
        public DataTable getByComplaintProirity(int prov_ID)
        {
            DataTable _ComplainPriority = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Proirity", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainPriority = objDB.CreateDataTable(cmdSelect);
            return _ComplainPriority;
        }

        public DataTable getByComplaintStatus(int prov_ID)
        {
            DataTable _ComplainStatus = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Status", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainStatus = objDB.CreateDataTable(cmdSelect);
            return _ComplainStatus;
        }

        public DataTable getByComplaintStatusA(int prov_ID,int Status_ID)
        {
            DataTable _ComplainStatusA = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Status_A", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            cmdSelect.Parameters.Add("@StatusID", SqlDbType.Int).Value = Status_ID;
            _ComplainStatusA = objDB.CreateDataTable(cmdSelect);
            return _ComplainStatusA;
        }

        public DataTable getByComplaintRespondent(int prov_ID)
        {
            DataTable _ComplainRespondent = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Respondent", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainRespondent = objDB.CreateDataTable(cmdSelect);
            return _ComplainRespondent;
        }

        public DataTable getByComplainAllegation(int prov_ID)
        {
            DataTable _ComplainAllegation = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Allegation", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainAllegation = objDB.CreateDataTable(cmdSelect);
            return _ComplainAllegation;
        }

        public DataTable getByComplainType(int prov_ID)
        {
            DataTable _ComplainType = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Type", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainType = objDB.CreateDataTable(cmdSelect);
            return _ComplainType;
        }
        


        public DataTable getByComplainSanction(int prov_ID)
        {
            DataTable _ComplainSanction = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Sanction", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainSanction = objDB.CreateDataTable(cmdSelect);
            return _ComplainSanction;
        }

        public DataTable getByComplainGender(int prov_ID)
        {
            DataTable _ComplainGender = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Gender", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _ComplainGender = objDB.CreateDataTable(cmdSelect);
            return _ComplainGender;
        }

        public DataTable getByRespondentGender(int prov_ID)
        {
            DataTable _RespondentGender = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Respondent_Gender", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _RespondentGender = objDB.CreateDataTable(cmdSelect);
            return _RespondentGender;
        }

        public DataTable getByCandidate(int prov_ID)
        {
            DataTable _Candidate = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_Complaint_Candidate", true));
            cmdSelect.Parameters.Add("@provID", SqlDbType.Int).Value = prov_ID;
            _Candidate = objDB.CreateDataTable(cmdSelect);
            return _Candidate;
        }

        public DataTable getStaticReport()
        {
            DataTable _dtComplainReport = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_StaticReport", true));
            _dtComplainReport = objDB.CreateDataTable(cmdSelect);
            return _dtComplainReport;
        }

        public DataTable getStaticReport_Compalint()
        {
            DataTable _dtComplainReport_1 = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_StaticReport_Complaint", true));
            _dtComplainReport_1 = objDB.CreateDataTable(cmdSelect);
            return _dtComplainReport_1;
        }

        public DataTable getStaticReport_Respond()
        {
            DataTable _dtComplainReport_2 = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_StaticReport_Respond", true));
            _dtComplainReport_2 = objDB.CreateDataTable(cmdSelect);
            return _dtComplainReport_2;
        }

        public DataTable getStaticReport_Sanction()
        {
            DataTable _dtComplainReport_3 = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_StaticReport_Sanction", true));
            _dtComplainReport_3 = objDB.CreateDataTable(cmdSelect);
            return _dtComplainReport_3;
        }

        public DataTable getStaticReport_Status()
        {
            DataTable _dtComplainReport_4 = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_StaticReport_Status", true));
            _dtComplainReport_4 = objDB.CreateDataTable(cmdSelect);
            return _dtComplainReport_4;
        }
        public DataTable get_PECCRpt(int ProvID)
        {
            DataTable _dt_PECC = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_DecisionRpt", true));
            cmdSelect.Parameters.Add("@ProvID", SqlDbType.Int).Value = ProvID ;
            _dt_PECC = objDB.CreateDataTable(cmdSelect);
            return _dt_PECC;
        }
        public DataTable getHQ_Rpt(int ProvID)
        {
            DataTable _dtHQ = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("_DecisionRptHQ", true));
            cmdSelect.Parameters.Add("@ProvID", SqlDbType.Int).Value = ProvID;
            _dtHQ = objDB.CreateDataTable(cmdSelect);
            return _dtHQ;
        }

        public DataTable getAdmin_Search(string CaseNo,string BitName,string caseProName,string ProvNameEng,string Resp_OfficeName,string RespType_Name,string SanctionName,string StatusName,string Comp_Name)
        {
            DataTable _dtAdminSearch = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("Admin_Search", true));
            cmdSelect.Parameters.Add("@CaseNo", SqlDbType.NVarChar).Value = CaseNo ;
            cmdSelect.Parameters.Add("@BitName", SqlDbType.NVarChar).Value = BitName;
            cmdSelect.Parameters.Add("@caseProName", SqlDbType.NVarChar).Value = caseProName;
            cmdSelect.Parameters.Add("@ProvNameEng", SqlDbType.NVarChar).Value = ProvNameEng;
            cmdSelect.Parameters.Add("@Resp_OfficeName", SqlDbType.NVarChar).Value = Resp_OfficeName;
            cmdSelect.Parameters.Add("@RespType_Name", SqlDbType.NVarChar).Value = RespType_Name;
            cmdSelect.Parameters.Add("@SanctionName", SqlDbType.NVarChar).Value = SanctionName;
            cmdSelect.Parameters.Add("@StatusName", SqlDbType.NVarChar).Value = StatusName;
            cmdSelect.Parameters.Add("@Comp_Name", SqlDbType.NVarChar).Value = Comp_Name;
            _dtAdminSearch = objDB.CreateDataTable(cmdSelect);
            return _dtAdminSearch;
        }

        public DataTable getUser_Search(string CaseNo, string BitName, string caseProName, string ProvNameEng, string Resp_OfficeName, string RespType_Name, string SanctionName, string StatusName, string Comp_Name,Guid UserID)
        {
            DataTable _dtAdminSearch = new DataTable();
            SqlCommand cmdSelect = ((SqlCommand)objDB.CreateCommand("User_Search", true));
            cmdSelect.Parameters.Add("@CaseNo", SqlDbType.NVarChar).Value = CaseNo;
            cmdSelect.Parameters.Add("@BitName", SqlDbType.NVarChar).Value = BitName;
            cmdSelect.Parameters.Add("@caseProName", SqlDbType.NVarChar).Value = caseProName;
            cmdSelect.Parameters.Add("@ProvNameEng", SqlDbType.NVarChar).Value = ProvNameEng;
            cmdSelect.Parameters.Add("@Resp_OfficeName", SqlDbType.NVarChar).Value = Resp_OfficeName;
            cmdSelect.Parameters.Add("@RespType_Name", SqlDbType.NVarChar).Value = RespType_Name;
            cmdSelect.Parameters.Add("@SanctionName", SqlDbType.NVarChar).Value = SanctionName;
            cmdSelect.Parameters.Add("@StatusName", SqlDbType.NVarChar).Value = StatusName;
            cmdSelect.Parameters.Add("@Comp_Name", SqlDbType.NVarChar).Value = Comp_Name;
            cmdSelect.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier ).Value = UserID ;
            _dtAdminSearch = objDB.CreateDataTable(cmdSelect);
            return _dtAdminSearch;
        }
    }
}

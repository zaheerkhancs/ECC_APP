// <fileinfo name="tblComplainRow_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;

namespace IOM.ECCMS.ECCDB
{
	/// <summary>
	/// The base class for <see cref="tblComplainRow"/> that 
	/// represents a record in the <c>tblComplain</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblComplainRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblComplainRow_Base
	{
		private long _caseID;
		private string _caseNo;
		private System.DateTime _sub_Date;
		private bool _sub_DateNull = true;
		private int _kuchi;
		private bool _kuchiNull = true;
		private int _caseProID;
		private bool _caseProIDNull = true;
		private System.DateTime _tri_Date;
		private bool _tri_DateNull = true;
		private int _provID;
		private bool _provIDNull = true;
		private int _polCen_ID;
		private bool _polCen_IDNull = true;
		private string _ps;
		private int _comp_GenderID;
		private bool _comp_GenderIDNull = true;
		private int _comp_Cand_ID;
		private bool _comp_Cand_IDNull = true;
		private int _comp_TypeID;
		private bool _comp_TypeIDNull = true;
		private int _resp_GenderID;
		private bool _resp_GenderIDNull = true;
		private int _resp_TypeID;
		private bool _resp_TypeIDNull = true;
		private int _allagType_ID;
		private bool _allagType_IDNull = true;
		private string _allegationSummary;
		private int _resp_OfficeID;
		private bool _resp_OfficeIDNull = true;
		private int _statusID;
		private bool _statusIDNull = true;
		private string _decision;
		private int _sanctionID;
		private bool _sanctionIDNull = true;
		private int _appeal;
		private bool _appealNull = true;
		private string _ecc_HQ_Decision;
		private bool _isDeleted;
		private bool _isDeletedNull = true;
		private System.Guid _createdBy;
		private System.DateTime _createdTime;
		private System.Guid _updatedBy;
		private System.DateTime _updatedTime;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblComplainRow_Base"/> class.
		/// </summary>
		public tblComplainRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>CaseID</c> column value.
		/// </summary>
		/// <value>The <c>CaseID</c> column value.</value>
		public long CaseID
		{
			get { return _caseID; }
			set { _caseID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CaseNo</c> column value.
		/// </summary>
		/// <value>The <c>CaseNo</c> column value.</value>
		public string CaseNo
		{
			get { return _caseNo; }
			set { _caseNo = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Sub_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sub_Date</c> column value.</value>
		public System.DateTime Sub_Date
		{
			get
			{
				if(IsSub_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _sub_Date;
			}
			set
			{
				_sub_DateNull = false;
				_sub_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Sub_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsSub_DateNull
		{
			get { return _sub_DateNull; }
			set { _sub_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Kuchi</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Kuchi</c> column value.</value>
		public int Kuchi
		{
			get
			{
				if(IsKuchiNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _kuchi;
			}
			set
			{
				_kuchiNull = false;
				_kuchi = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Kuchi"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsKuchiNull
		{
			get { return _kuchiNull; }
			set { _kuchiNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>caseProID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>caseProID</c> column value.</value>
		public int CaseProID
		{
			get
			{
				if(IsCaseProIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _caseProID;
			}
			set
			{
				_caseProIDNull = false;
				_caseProID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="CaseProID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCaseProIDNull
		{
			get { return _caseProIDNull; }
			set { _caseProIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Tri_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Tri_Date</c> column value.</value>
		public System.DateTime Tri_Date
		{
			get
			{
				if(IsTri_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _tri_Date;
			}
			set
			{
				_tri_DateNull = false;
				_tri_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Tri_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsTri_DateNull
		{
			get { return _tri_DateNull; }
			set { _tri_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ProvID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProvID</c> column value.</value>
		public int ProvID
		{
			get
			{
				if(IsProvIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _provID;
			}
			set
			{
				_provIDNull = false;
				_provID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="ProvID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsProvIDNull
		{
			get { return _provIDNull; }
			set { _provIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PolCen_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PolCen_ID</c> column value.</value>
		public int PolCen_ID
		{
			get
			{
				if(IsPolCen_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _polCen_ID;
			}
			set
			{
				_polCen_IDNull = false;
				_polCen_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="PolCen_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPolCen_IDNull
		{
			get { return _polCen_IDNull; }
			set { _polCen_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PS</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PS</c> column value.</value>
		public string PS
		{
			get { return _ps; }
			set { _ps = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Comp_GenderID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comp_GenderID</c> column value.</value>
		public int Comp_GenderID
		{
			get
			{
				if(IsComp_GenderIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _comp_GenderID;
			}
			set
			{
				_comp_GenderIDNull = false;
				_comp_GenderID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Comp_GenderID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsComp_GenderIDNull
		{
			get { return _comp_GenderIDNull; }
			set { _comp_GenderIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Comp_Cand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comp_Cand_ID</c> column value.</value>
		public int Comp_Cand_ID
		{
			get
			{
				if(IsComp_Cand_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _comp_Cand_ID;
			}
			set
			{
				_comp_Cand_IDNull = false;
				_comp_Cand_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Comp_Cand_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsComp_Cand_IDNull
		{
			get { return _comp_Cand_IDNull; }
			set { _comp_Cand_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Comp_TypeID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comp_TypeID</c> column value.</value>
		public int Comp_TypeID
		{
			get
			{
				if(IsComp_TypeIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _comp_TypeID;
			}
			set
			{
				_comp_TypeIDNull = false;
				_comp_TypeID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Comp_TypeID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsComp_TypeIDNull
		{
			get { return _comp_TypeIDNull; }
			set { _comp_TypeIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Resp_GenderID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Resp_GenderID</c> column value.</value>
		public int Resp_GenderID
		{
			get
			{
				if(IsResp_GenderIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _resp_GenderID;
			}
			set
			{
				_resp_GenderIDNull = false;
				_resp_GenderID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Resp_GenderID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsResp_GenderIDNull
		{
			get { return _resp_GenderIDNull; }
			set { _resp_GenderIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Resp_TypeID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Resp_TypeID</c> column value.</value>
		public int Resp_TypeID
		{
			get
			{
				if(IsResp_TypeIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _resp_TypeID;
			}
			set
			{
				_resp_TypeIDNull = false;
				_resp_TypeID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Resp_TypeID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsResp_TypeIDNull
		{
			get { return _resp_TypeIDNull; }
			set { _resp_TypeIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AllagType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AllagType_ID</c> column value.</value>
		public int AllagType_ID
		{
			get
			{
				if(IsAllagType_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _allagType_ID;
			}
			set
			{
				_allagType_IDNull = false;
				_allagType_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="AllagType_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsAllagType_IDNull
		{
			get { return _allagType_IDNull; }
			set { _allagType_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AllegationSummary</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AllegationSummary</c> column value.</value>
		public string AllegationSummary
		{
			get { return _allegationSummary; }
			set { _allegationSummary = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Resp_OfficeID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Resp_OfficeID</c> column value.</value>
		public int Resp_OfficeID
		{
			get
			{
				if(IsResp_OfficeIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _resp_OfficeID;
			}
			set
			{
				_resp_OfficeIDNull = false;
				_resp_OfficeID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Resp_OfficeID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsResp_OfficeIDNull
		{
			get { return _resp_OfficeIDNull; }
			set { _resp_OfficeIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>StatusID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StatusID</c> column value.</value>
		public int StatusID
		{
			get
			{
				if(IsStatusIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _statusID;
			}
			set
			{
				_statusIDNull = false;
				_statusID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="StatusID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsStatusIDNull
		{
			get { return _statusIDNull; }
			set { _statusIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Decision</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Decision</c> column value.</value>
		public string Decision
		{
			get { return _decision; }
			set { _decision = value; }
		}

		/// <summary>
		/// Gets or sets the <c>SanctionID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SanctionID</c> column value.</value>
		public int SanctionID
		{
			get
			{
				if(IsSanctionIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _sanctionID;
			}
			set
			{
				_sanctionIDNull = false;
				_sanctionID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="SanctionID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsSanctionIDNull
		{
			get { return _sanctionIDNull; }
			set { _sanctionIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Appeal</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Appeal</c> column value.</value>
		public int Appeal
		{
			get
			{
				if(IsAppealNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _appeal;
			}
			set
			{
				_appealNull = false;
				_appeal = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Appeal"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsAppealNull
		{
			get { return _appealNull; }
			set { _appealNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Ecc_HQ_Decision</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Ecc_HQ_Decision</c> column value.</value>
		public string Ecc_HQ_Decision
		{
			get { return _ecc_HQ_Decision; }
			set { _ecc_HQ_Decision = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsDeleted</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsDeleted</c> column value.</value>
		public bool IsDeleted
		{
			get
			{
				if(IsIsDeletedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _isDeleted;
			}
			set
			{
				_isDeletedNull = false;
				_isDeleted = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="IsDeleted"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIsDeletedNull
		{
			get { return _isDeletedNull; }
			set { _isDeletedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CreatedBy</c> column value.
		/// </summary>
		/// <value>The <c>CreatedBy</c> column value.</value>
		public System.Guid CreatedBy
		{
			get { return _createdBy; }
			set { _createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CreatedTime</c> column value.
		/// </summary>
		/// <value>The <c>CreatedTime</c> column value.</value>
		public System.DateTime CreatedTime
		{
			get { return _createdTime; }
			set { _createdTime = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UpdatedBy</c> column value.
		/// </summary>
		/// <value>The <c>UpdatedBy</c> column value.</value>
		public System.Guid UpdatedBy
		{
			get { return _updatedBy; }
			set { _updatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UpdatedTime</c> column value.
		/// </summary>
		/// <value>The <c>UpdatedTime</c> column value.</value>
		public System.DateTime UpdatedTime
		{
			get { return _updatedTime; }
			set { _updatedTime = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  CaseID=");
			dynStr.Append(CaseID);
			dynStr.Append("  CaseNo=");
			dynStr.Append(CaseNo);
			dynStr.Append("  Sub_Date=");
			dynStr.Append(IsSub_DateNull ? (object)"<NULL>" : Sub_Date);
			dynStr.Append("  Kuchi=");
			dynStr.Append(IsKuchiNull ? (object)"<NULL>" : Kuchi);
			dynStr.Append("  CaseProID=");
			dynStr.Append(IsCaseProIDNull ? (object)"<NULL>" : CaseProID);
			dynStr.Append("  Tri_Date=");
			dynStr.Append(IsTri_DateNull ? (object)"<NULL>" : Tri_Date);
			dynStr.Append("  ProvID=");
			dynStr.Append(IsProvIDNull ? (object)"<NULL>" : ProvID);
			dynStr.Append("  PolCen_ID=");
			dynStr.Append(IsPolCen_IDNull ? (object)"<NULL>" : PolCen_ID);
			dynStr.Append("  PS=");
			dynStr.Append(PS);
			dynStr.Append("  Comp_GenderID=");
			dynStr.Append(IsComp_GenderIDNull ? (object)"<NULL>" : Comp_GenderID);
			dynStr.Append("  Comp_Cand_ID=");
			dynStr.Append(IsComp_Cand_IDNull ? (object)"<NULL>" : Comp_Cand_ID);
			dynStr.Append("  Comp_TypeID=");
			dynStr.Append(IsComp_TypeIDNull ? (object)"<NULL>" : Comp_TypeID);
			dynStr.Append("  Resp_GenderID=");
			dynStr.Append(IsResp_GenderIDNull ? (object)"<NULL>" : Resp_GenderID);
			dynStr.Append("  Resp_TypeID=");
			dynStr.Append(IsResp_TypeIDNull ? (object)"<NULL>" : Resp_TypeID);
			dynStr.Append("  AllagType_ID=");
			dynStr.Append(IsAllagType_IDNull ? (object)"<NULL>" : AllagType_ID);
			dynStr.Append("  AllegationSummary=");
			dynStr.Append(AllegationSummary);
			dynStr.Append("  Resp_OfficeID=");
			dynStr.Append(IsResp_OfficeIDNull ? (object)"<NULL>" : Resp_OfficeID);
			dynStr.Append("  StatusID=");
			dynStr.Append(IsStatusIDNull ? (object)"<NULL>" : StatusID);
			dynStr.Append("  Decision=");
			dynStr.Append(Decision);
			dynStr.Append("  SanctionID=");
			dynStr.Append(IsSanctionIDNull ? (object)"<NULL>" : SanctionID);
			dynStr.Append("  Appeal=");
			dynStr.Append(IsAppealNull ? (object)"<NULL>" : Appeal);
			dynStr.Append("  Ecc_HQ_Decision=");
			dynStr.Append(Ecc_HQ_Decision);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsIsDeletedNull ? (object)"<NULL>" : IsDeleted);
			dynStr.Append("  CreatedBy=");
			dynStr.Append(CreatedBy);
			dynStr.Append("  CreatedTime=");
			dynStr.Append(CreatedTime);
			dynStr.Append("  UpdatedBy=");
			dynStr.Append(UpdatedBy);
			dynStr.Append("  UpdatedTime=");
			dynStr.Append(UpdatedTime);
			return dynStr.ToString();
		}
	} // End of tblComplainRow_Base class
} // End of namespace

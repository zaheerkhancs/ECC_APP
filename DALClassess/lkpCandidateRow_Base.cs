// <fileinfo name="lkpCandidateRow_Base.cs">
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
	/// The base class for <see cref="lkpCandidateRow"/> that 
	/// represents a record in the <c>lkpCandidate</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpCandidateRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpCandidateRow_Base
	{
		private int _cand_ID;
		private string _cand_No;
		private string _cand_Name;
		private string _cand_FName;
		private int _genderID;
		private bool _genderIDNull = true;
		private int _prov_ID;
		private bool _prov_IDNull = true;
		private bool _isDeleted;
		private bool _isDeletedNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpCandidateRow_Base"/> class.
		/// </summary>
		public lkpCandidateRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Cand_ID</c> column value.
		/// </summary>
		/// <value>The <c>Cand_ID</c> column value.</value>
		public int Cand_ID
		{
			get { return _cand_ID; }
			set { _cand_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Cand_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Cand_No</c> column value.</value>
		public string Cand_No
		{
			get { return _cand_No; }
			set { _cand_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Cand_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Cand_Name</c> column value.</value>
		public string Cand_Name
		{
			get { return _cand_Name; }
			set { _cand_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Cand_FName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Cand_FName</c> column value.</value>
		public string Cand_FName
		{
			get { return _cand_FName; }
			set { _cand_FName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GenderID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GenderID</c> column value.</value>
		public int GenderID
		{
			get
			{
				if(IsGenderIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _genderID;
			}
			set
			{
				_genderIDNull = false;
				_genderID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="GenderID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsGenderIDNull
		{
			get { return _genderIDNull; }
			set { _genderIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Prov_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Prov_ID</c> column value.</value>
		public int Prov_ID
		{
			get
			{
				if(IsProv_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _prov_ID;
			}
			set
			{
				_prov_IDNull = false;
				_prov_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Prov_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsProv_IDNull
		{
			get { return _prov_IDNull; }
			set { _prov_IDNull = value; }
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
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Cand_ID=");
			dynStr.Append(Cand_ID);
			dynStr.Append("  Cand_No=");
			dynStr.Append(Cand_No);
			dynStr.Append("  Cand_Name=");
			dynStr.Append(Cand_Name);
			dynStr.Append("  Cand_FName=");
			dynStr.Append(Cand_FName);
			dynStr.Append("  GenderID=");
			dynStr.Append(IsGenderIDNull ? (object)"<NULL>" : GenderID);
			dynStr.Append("  Prov_ID=");
			dynStr.Append(IsProv_IDNull ? (object)"<NULL>" : Prov_ID);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsIsDeletedNull ? (object)"<NULL>" : IsDeleted);
			return dynStr.ToString();
		}
	} // End of lkpCandidateRow_Base class
} // End of namespace

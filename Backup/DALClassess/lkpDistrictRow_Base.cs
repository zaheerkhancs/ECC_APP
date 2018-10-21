// <fileinfo name="lkpDistrictRow_Base.cs">
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
	/// The base class for <see cref="lkpDistrictRow"/> that 
	/// represents a record in the <c>lkpDistrict</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpDistrictRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpDistrictRow_Base
	{
		private int _district_Id;
		private string _district_Name;
		private string _district_Dari;
		private string _district_Code;
		private int _province_Id;
		private bool _province_IdNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpDistrictRow_Base"/> class.
		/// </summary>
		public lkpDistrictRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>District_Id</c> column value.
		/// </summary>
		/// <value>The <c>District_Id</c> column value.</value>
		public int District_Id
		{
			get { return _district_Id; }
			set { _district_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>District_Name</c> column value.
		/// </summary>
		/// <value>The <c>District_Name</c> column value.</value>
		public string District_Name
		{
			get { return _district_Name; }
			set { _district_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>District_Dari</c> column value.
		/// </summary>
		/// <value>The <c>District_Dari</c> column value.</value>
		public string District_Dari
		{
			get { return _district_Dari; }
			set { _district_Dari = value; }
		}

		/// <summary>
		/// Gets or sets the <c>District_Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_Code</c> column value.</value>
		public string District_Code
		{
			get { return _district_Code; }
			set { _district_Code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Province_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Province_Id</c> column value.</value>
		public int Province_Id
		{
			get
			{
				if(IsProvince_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _province_Id;
			}
			set
			{
				_province_IdNull = false;
				_province_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Province_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsProvince_IdNull
		{
			get { return _province_IdNull; }
			set { _province_IdNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  District_Id=");
			dynStr.Append(District_Id);
			dynStr.Append("  District_Name=");
			dynStr.Append(District_Name);
			dynStr.Append("  District_Dari=");
			dynStr.Append(District_Dari);
			dynStr.Append("  District_Code=");
			dynStr.Append(District_Code);
			dynStr.Append("  Province_Id=");
			dynStr.Append(IsProvince_IdNull ? (object)"<NULL>" : Province_Id);
			return dynStr.ToString();
		}
	} // End of lkpDistrictRow_Base class
} // End of namespace

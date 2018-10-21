// <fileinfo name="lkpPollingCenterRow_Base.cs">
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
	/// The base class for <see cref="lkpPollingCenterRow"/> that 
	/// represents a record in the <c>lkpPollingCenter</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpPollingCenterRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpPollingCenterRow_Base
	{
		private int _polCen_Id;
		private string _polCen_Address;
		private string _polCen_Dari_Address;
		private string _polCen_Code;
		private string _district_Code;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpPollingCenterRow_Base"/> class.
		/// </summary>
		public lkpPollingCenterRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>PolCen_Id</c> column value.
		/// </summary>
		/// <value>The <c>PolCen_Id</c> column value.</value>
		public int PolCen_Id
		{
			get { return _polCen_Id; }
			set { _polCen_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PolCen_Address</c> column value.
		/// </summary>
		/// <value>The <c>PolCen_Address</c> column value.</value>
		public string PolCen_Address
		{
			get { return _polCen_Address; }
			set { _polCen_Address = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PolCen_Dari_Address</c> column value.
		/// </summary>
		/// <value>The <c>PolCen_Dari_Address</c> column value.</value>
		public string PolCen_Dari_Address
		{
			get { return _polCen_Dari_Address; }
			set { _polCen_Dari_Address = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PolCen_Code</c> column value.
		/// </summary>
		/// <value>The <c>PolCen_Code</c> column value.</value>
		public string PolCen_Code
		{
			get { return _polCen_Code; }
			set { _polCen_Code = value; }
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
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  PolCen_Id=");
			dynStr.Append(PolCen_Id);
			dynStr.Append("  PolCen_Address=");
			dynStr.Append(PolCen_Address);
			dynStr.Append("  PolCen_Dari_Address=");
			dynStr.Append(PolCen_Dari_Address);
			dynStr.Append("  PolCen_Code=");
			dynStr.Append(PolCen_Code);
			dynStr.Append("  District_Code=");
			dynStr.Append(District_Code);
			return dynStr.ToString();
		}
	} // End of lkpPollingCenterRow_Base class
} // End of namespace

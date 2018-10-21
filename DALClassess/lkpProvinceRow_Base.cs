// <fileinfo name="lkpProvinceRow_Base.cs">
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
	/// The base class for <see cref="lkpProvinceRow"/> that 
	/// represents a record in the <c>lkpProvince</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpProvinceRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpProvinceRow_Base
	{
		private int _provId;
		private string _provNameEng;
		private string _prov_Code;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpProvinceRow_Base"/> class.
		/// </summary>
		public lkpProvinceRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ProvId</c> column value.
		/// </summary>
		/// <value>The <c>ProvId</c> column value.</value>
		public int ProvId
		{
			get { return _provId; }
			set { _provId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ProvNameEng</c> column value.
		/// </summary>
		/// <value>The <c>ProvNameEng</c> column value.</value>
		public string ProvNameEng
		{
			get { return _provNameEng; }
			set { _provNameEng = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Prov_Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Prov_Code</c> column value.</value>
		public string Prov_Code
		{
			get { return _prov_Code; }
			set { _prov_Code = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  ProvId=");
			dynStr.Append(ProvId);
			dynStr.Append("  ProvNameEng=");
			dynStr.Append(ProvNameEng);
			dynStr.Append("  Prov_Code=");
			dynStr.Append(Prov_Code);
			return dynStr.ToString();
		}
	} // End of lkpProvinceRow_Base class
} // End of namespace

// <fileinfo name="lkpGendersRow_Base.cs">
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
	/// The base class for <see cref="lkpGendersRow"/> that 
	/// represents a record in the <c>lkpGenders</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpGendersRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpGendersRow_Base
	{
		private int _genderID;
		private string _genderName;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpGendersRow_Base"/> class.
		/// </summary>
		public lkpGendersRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>GenderID</c> column value.
		/// </summary>
		/// <value>The <c>GenderID</c> column value.</value>
		public int GenderID
		{
			get { return _genderID; }
			set { _genderID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GenderName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GenderName</c> column value.</value>
		public string GenderName
		{
			get { return _genderName; }
			set { _genderName = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  GenderID=");
			dynStr.Append(GenderID);
			dynStr.Append("  GenderName=");
			dynStr.Append(GenderName);
			return dynStr.ToString();
		}
	} // End of lkpGendersRow_Base class
} // End of namespace

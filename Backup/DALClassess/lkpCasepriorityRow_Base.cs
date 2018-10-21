// <fileinfo name="lkpCasepriorityRow_Base.cs">
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
	/// The base class for <see cref="lkpCasepriorityRow"/> that 
	/// represents a record in the <c>lkpCasepriority</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpCasepriorityRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpCasepriorityRow_Base
	{
		private int _caseProID;
		private string _caseProName;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpCasepriorityRow_Base"/> class.
		/// </summary>
		public lkpCasepriorityRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>caseProID</c> column value.
		/// </summary>
		/// <value>The <c>caseProID</c> column value.</value>
		public int CaseProID
		{
			get { return _caseProID; }
			set { _caseProID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>caseProName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>caseProName</c> column value.</value>
		public string CaseProName
		{
			get { return _caseProName; }
			set { _caseProName = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  CaseProID=");
			dynStr.Append(CaseProID);
			dynStr.Append("  CaseProName=");
			dynStr.Append(CaseProName);
			return dynStr.ToString();
		}
	} // End of lkpCasepriorityRow_Base class
} // End of namespace

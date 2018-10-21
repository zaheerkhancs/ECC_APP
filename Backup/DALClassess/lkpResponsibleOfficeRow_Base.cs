// <fileinfo name="lkpResponsibleOfficeRow_Base.cs">
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
	/// The base class for <see cref="lkpResponsibleOfficeRow"/> that 
	/// represents a record in the <c>lkpResponsibleOffice</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpResponsibleOfficeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpResponsibleOfficeRow_Base
	{
		private int _resp_OfficeID;
		private string _resp_OfficeName;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpResponsibleOfficeRow_Base"/> class.
		/// </summary>
		public lkpResponsibleOfficeRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Resp_OfficeID</c> column value.
		/// </summary>
		/// <value>The <c>Resp_OfficeID</c> column value.</value>
		public int Resp_OfficeID
		{
			get { return _resp_OfficeID; }
			set { _resp_OfficeID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Resp_OfficeName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Resp_OfficeName</c> column value.</value>
		public string Resp_OfficeName
		{
			get { return _resp_OfficeName; }
			set { _resp_OfficeName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
		public bool Active
		{
			get
			{
				if(IsActiveNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _active;
			}
			set
			{
				_activeNull = false;
				_active = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Active"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsActiveNull
		{
			get { return _activeNull; }
			set { _activeNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Resp_OfficeID=");
			dynStr.Append(Resp_OfficeID);
			dynStr.Append("  Resp_OfficeName=");
			dynStr.Append(Resp_OfficeName);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpResponsibleOfficeRow_Base class
} // End of namespace

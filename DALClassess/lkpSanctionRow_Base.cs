// <fileinfo name="lkpSanctionRow_Base.cs">
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
	/// The base class for <see cref="lkpSanctionRow"/> that 
	/// represents a record in the <c>lkpSanction</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpSanctionRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpSanctionRow_Base
	{
		private int _sacntionID;
		private string _sacntionName;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpSanctionRow_Base"/> class.
		/// </summary>
		public lkpSanctionRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>SacntionID</c> column value.
		/// </summary>
		/// <value>The <c>SacntionID</c> column value.</value>
		public int SacntionID
		{
			get { return _sacntionID; }
			set { _sacntionID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>SacntionName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SacntionName</c> column value.</value>
		public string SacntionName
		{
			get { return _sacntionName; }
			set { _sacntionName = value; }
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
			dynStr.Append("  SacntionID=");
			dynStr.Append(SacntionID);
			dynStr.Append("  SacntionName=");
			dynStr.Append(SacntionName);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpSanctionRow_Base class
} // End of namespace

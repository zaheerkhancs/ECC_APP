// <fileinfo name="lkpRespondanttypeRow_Base.cs">
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
	/// The base class for <see cref="lkpRespondanttypeRow"/> that 
	/// represents a record in the <c>lkpRespondanttype</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpRespondanttypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpRespondanttypeRow_Base
	{
		private int _respType_ID;
		private string _respType_Name;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpRespondanttypeRow_Base"/> class.
		/// </summary>
		public lkpRespondanttypeRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>RespType_ID</c> column value.
		/// </summary>
		/// <value>The <c>RespType_ID</c> column value.</value>
		public int RespType_ID
		{
			get { return _respType_ID; }
			set { _respType_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RespType_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RespType_Name</c> column value.</value>
		public string RespType_Name
		{
			get { return _respType_Name; }
			set { _respType_Name = value; }
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
			dynStr.Append("  RespType_ID=");
			dynStr.Append(RespType_ID);
			dynStr.Append("  RespType_Name=");
			dynStr.Append(RespType_Name);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpRespondanttypeRow_Base class
} // End of namespace

// <fileinfo name="lkpStatusRow_Base.cs">
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
	/// The base class for <see cref="lkpStatusRow"/> that 
	/// represents a record in the <c>lkpStatus</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpStatusRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpStatusRow_Base
	{
		private int _statusId;
		private string _statusName;
		private bool _active;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpStatusRow_Base"/> class.
		/// </summary>
		public lkpStatusRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>StatusId</c> column value.
		/// </summary>
		/// <value>The <c>StatusId</c> column value.</value>
		public int StatusId
		{
			get { return _statusId; }
			set { _statusId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>StatusName</c> column value.
		/// </summary>
		/// <value>The <c>StatusName</c> column value.</value>
		public string StatusName
		{
			get { return _statusName; }
			set { _statusName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
		public bool Active
		{
			get { return _active; }
			set { _active = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  StatusId=");
			dynStr.Append(StatusId);
			dynStr.Append("  StatusName=");
			dynStr.Append(StatusName);
			dynStr.Append("  Active=");
			dynStr.Append(Active);
			return dynStr.ToString();
		}
	} // End of lkpStatusRow_Base class
} // End of namespace

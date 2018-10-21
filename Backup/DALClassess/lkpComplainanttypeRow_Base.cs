// <fileinfo name="lkpComplainanttypeRow_Base.cs">
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
	/// The base class for <see cref="lkpComplainanttypeRow"/> that 
	/// represents a record in the <c>lkpComplainanttype</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpComplainanttypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpComplainanttypeRow_Base
	{
		private int _comp_TypeID;
		private string _comp_Name;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpComplainanttypeRow_Base"/> class.
		/// </summary>
		public lkpComplainanttypeRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Comp_TypeID</c> column value.
		/// </summary>
		/// <value>The <c>Comp_TypeID</c> column value.</value>
		public int Comp_TypeID
		{
			get { return _comp_TypeID; }
			set { _comp_TypeID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Comp_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comp_Name</c> column value.</value>
		public string Comp_Name
		{
			get { return _comp_Name; }
			set { _comp_Name = value; }
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
			dynStr.Append("  Comp_TypeID=");
			dynStr.Append(Comp_TypeID);
			dynStr.Append("  Comp_Name=");
			dynStr.Append(Comp_Name);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpComplainanttypeRow_Base class
} // End of namespace

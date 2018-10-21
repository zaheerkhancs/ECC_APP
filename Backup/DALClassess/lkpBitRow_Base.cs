// <fileinfo name="lkpBitRow_Base.cs">
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
	/// The base class for <see cref="lkpBitRow"/> that 
	/// represents a record in the <c>lkpBit</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpBitRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpBitRow_Base
	{
		private int _bitID;
		private string _bitName;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpBitRow_Base"/> class.
		/// </summary>
		public lkpBitRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>BitID</c> column value.
		/// </summary>
		/// <value>The <c>BitID</c> column value.</value>
		public int BitID
		{
			get { return _bitID; }
			set { _bitID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BitName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BitName</c> column value.</value>
		public string BitName
		{
			get { return _bitName; }
			set { _bitName = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  BitID=");
			dynStr.Append(BitID);
			dynStr.Append("  BitName=");
			dynStr.Append(BitName);
			return dynStr.ToString();
		}
	} // End of lkpBitRow_Base class
} // End of namespace

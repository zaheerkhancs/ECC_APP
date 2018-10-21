// <fileinfo name="ECCMS.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			You can update this source code manually. If the file
//			already exists it will not be rewritten by the generator.
//		</remarks>
//		<generator rewritefile="False" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;
using System.Data;

namespace IOM.ECCMS.ECCDB
{
	/// <summary>
	/// Represents a connection to the <c>ECCMS</c> database.
	/// </summary>
	/// <remarks>
	/// If the <c>ECCMS</c> goes out of scope, the connection to the 
	/// database is not closed automatically. Therefore, you must explicitly close the 
	/// connection by calling the <c>Close</c> or <c>Dispose</c> method.
	/// </remarks>
	/// <example>
	/// using(ECCMS db = new ECCMS())
	/// {
	///		lkpCaseWithRow[] rows = db.lkpCaseWithTable.GetAll();
	/// }
	/// </example>
	public class ECCMS : ECCMS_Base
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ECCMS"/> class.
		/// </summary>
		public ECCMS()
		{
			// EMPTY
		}

		/// <summary>
		/// Creates a new connection to the database.
		/// </summary>
		/// <returns>An <see cref="System.Data.IDbConnection"/> object.</returns>
		protected override IDbConnection CreateConnection()
		{
            string dbConnection = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            return new System.Data.SqlClient.SqlConnection(dbConnection);

            //return new System.Data.SqlClient.SqlConnection(
            //    "Password=iomkabul;User ID=sa;Initial Catalog=ECCMS;Data Source=KB" +
            //    "L-IEC-RAJNISH");

		}
		

		/// <summary>
		/// Creates a DataTable object for the specified command.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected internal DataTable CreateDataTable(IDbCommand command)
		{
			DataTable dataTable = new DataTable();

			new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)command).Fill(dataTable);
	
			return dataTable;
		}

		/// <summary>
		/// Returns a SQL statement parameter name that is specific for the data provider.
		/// For example it returns ? for OleDb provider, or @paramName for MS SQL provider.
		/// </summary>
		/// <param name="paramName">The data provider neutral SQL parameter name.</param>
		/// <returns>The SQL statement parameter name.</returns>
		protected internal override string CreateSqlParameterName(string paramName)
		{

			return "@" + paramName;

		}

		/// <summary>
		/// Creates a .Net data provider specific parameter name that is used to
		/// create a parameter object and add it to the parameter collection of
		/// <see cref="System.Data.IDbCommand"/>.
		/// </summary>
		/// <param name="baseParamName">The base name of the parameter.</param>
		/// <returns>The full data provider specific parameter name.</returns>
		protected override string CreateCollectionParameterName(string baseParamName)
		{

			return "@" + baseParamName;

		}
	} // End of ECCMS class
} // End of namespace


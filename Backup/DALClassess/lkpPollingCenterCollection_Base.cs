// <fileinfo name="lkpPollingCenterCollection_Base.cs">
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
using System.Data;

namespace IOM.ECCMS.ECCDB
{
	/// <summary>
	/// The base class for <see cref="lkpPollingCenterCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="lkpPollingCenterCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpPollingCenterCollection_Base
	{
		// Constants
		public const string PolCen_IdColumnName = "PolCen_Id";
		public const string PolCen_AddressColumnName = "PolCen_Address";
		public const string PolCen_Dari_AddressColumnName = "PolCen_Dari_Address";
		public const string PolCen_CodeColumnName = "PolCen_Code";
		public const string District_CodeColumnName = "District_Code";

		// Instance fields
		private ECCMS _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpPollingCenterCollection_Base"/> 
		/// class with the specified <see cref="ECCMS"/>.
		/// </summary>
		/// <param name="db">The <see cref="ECCMS"/> object.</param>
		public lkpPollingCenterCollection_Base(ECCMS db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="ECCMS"/> object.</value>
		protected ECCMS Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		public virtual lkpPollingCenterRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._lkpPollingCenter_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="lkpPollingCenterRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="lkpPollingCenterRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public lkpPollingCenterRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			lkpPollingCenterRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="lkpPollingCenterRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		public lkpPollingCenterRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpPollingCenterRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		public virtual lkpPollingCenterRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[lkpPollingCenter]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="lkpPollingCenterRow"/> by the primary key.
		/// </summary>
		/// <param name="polCen_Id">The <c>PolCen_Id</c> column value.</param>
		/// <returns>An instance of <see cref="lkpPollingCenterRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual lkpPollingCenterRow GetByPrimaryKey(int polCen_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpPollingCenter_GetByPrimaryKey", true);
			AddParameter(cmd, "PolCen_Id", polCen_Id);
			lkpPollingCenterRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpPollingCenterRow"/> object to be inserted.</param>
		public virtual void Insert(lkpPollingCenterRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpPollingCenter_Insert", true);
			AddParameter(cmd, "PolCen_Id", value.PolCen_Id);
			AddParameter(cmd, "PolCen_Address", value.PolCen_Address);
			AddParameter(cmd, "PolCen_Dari_Address", value.PolCen_Dari_Address);
			AddParameter(cmd, "PolCen_Code", value.PolCen_Code);
			AddParameter(cmd, "District_Code", value.District_Code);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpPollingCenterRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(lkpPollingCenterRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpPollingCenter_Update", true);
			AddParameter(cmd, "PolCen_Address", value.PolCen_Address);
			AddParameter(cmd, "PolCen_Dari_Address", value.PolCen_Dari_Address);
			AddParameter(cmd, "PolCen_Code", value.PolCen_Code);
			AddParameter(cmd, "District_Code", value.District_Code);
			AddParameter(cmd, "PolCen_Id", value.PolCen_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>lkpPollingCenter</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>lkpPollingCenter</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((int)row["PolCen_Id"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpPollingCenterRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(lkpPollingCenterRow value)
		{
			return DeleteByPrimaryKey(value.PolCen_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>lkpPollingCenter</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="polCen_Id">The <c>PolCen_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int polCen_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpPollingCenter_DeleteByPrimaryKey", true);
			AddParameter(cmd, "PolCen_Id", polCen_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>lkpPollingCenter</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
		/// to delete <c>lkpPollingCenter</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[lkpPollingCenter]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._lkpPollingCenter_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		protected lkpPollingCenterRow[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		protected lkpPollingCenterRow[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="lkpPollingCenterRow"/> objects.</returns>
		protected virtual lkpPollingCenterRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int polCen_IdColumnIndex = reader.GetOrdinal("PolCen_Id");
			int polCen_AddressColumnIndex = reader.GetOrdinal("PolCen_Address");
			int polCen_Dari_AddressColumnIndex = reader.GetOrdinal("PolCen_Dari_Address");
			int polCen_CodeColumnIndex = reader.GetOrdinal("PolCen_Code");
			int district_CodeColumnIndex = reader.GetOrdinal("District_Code");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					lkpPollingCenterRow record = new lkpPollingCenterRow();
					recordList.Add(record);

					record.PolCen_Id = Convert.ToInt32(reader.GetValue(polCen_IdColumnIndex));
					record.PolCen_Address = Convert.ToString(reader.GetValue(polCen_AddressColumnIndex));
					record.PolCen_Dari_Address = Convert.ToString(reader.GetValue(polCen_Dari_AddressColumnIndex));
					record.PolCen_Code = Convert.ToString(reader.GetValue(polCen_CodeColumnIndex));
					if(!reader.IsDBNull(district_CodeColumnIndex))
						record.District_Code = Convert.ToString(reader.GetValue(district_CodeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (lkpPollingCenterRow[])(recordList.ToArray(typeof(lkpPollingCenterRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="lkpPollingCenterRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="lkpPollingCenterRow"/> object.</returns>
		protected virtual lkpPollingCenterRow MapRow(DataRow row)
		{
			lkpPollingCenterRow mappedObject = new lkpPollingCenterRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "PolCen_Id"
			dataColumn = dataTable.Columns["PolCen_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.PolCen_Id = (int)row[dataColumn];
			// Column "PolCen_Address"
			dataColumn = dataTable.Columns["PolCen_Address"];
			if(!row.IsNull(dataColumn))
				mappedObject.PolCen_Address = (string)row[dataColumn];
			// Column "PolCen_Dari_Address"
			dataColumn = dataTable.Columns["PolCen_Dari_Address"];
			if(!row.IsNull(dataColumn))
				mappedObject.PolCen_Dari_Address = (string)row[dataColumn];
			// Column "PolCen_Code"
			dataColumn = dataTable.Columns["PolCen_Code"];
			if(!row.IsNull(dataColumn))
				mappedObject.PolCen_Code = (string)row[dataColumn];
			// Column "District_Code"
			dataColumn = dataTable.Columns["District_Code"];
			if(!row.IsNull(dataColumn))
				mappedObject.District_Code = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>lkpPollingCenter</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "lkpPollingCenter";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("PolCen_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PolCen_Address", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PolCen_Dari_Address", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PolCen_Code", typeof(string));
			dataColumn.MaxLength = 10;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("District_Code", typeof(string));
			dataColumn.MaxLength = 4;
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual IDbDataParameter AddParameter(IDbCommand cmd, string paramName, object value)
		{
			IDbDataParameter parameter;
			switch(paramName)
			{
				case "PolCen_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "PolCen_Address":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "PolCen_Dari_Address":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PolCen_Code":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "District_Code":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of lkpPollingCenterCollection_Base class
}  // End of namespace

// <fileinfo name="lkpDistrictCollection_Base.cs">
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
	/// The base class for <see cref="lkpDistrictCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="lkpDistrictCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpDistrictCollection_Base
	{
		// Constants
		public const string District_IdColumnName = "District_Id";
		public const string District_NameColumnName = "District_Name";
		public const string District_DariColumnName = "District_Dari";
		public const string District_CodeColumnName = "District_Code";
		public const string Province_IdColumnName = "Province_Id";

		// Instance fields
		private ECCMS _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpDistrictCollection_Base"/> 
		/// class with the specified <see cref="ECCMS"/>.
		/// </summary>
		/// <param name="db">The <see cref="ECCMS"/> object.</param>
		public lkpDistrictCollection_Base(ECCMS db)
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
		/// Gets an array of all records from the <c>lkpDistrict</c> table.
		/// </summary>
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		public virtual lkpDistrictRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>lkpDistrict</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>lkpDistrict</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._lkpDistrict_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="lkpDistrictRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="lkpDistrictRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public lkpDistrictRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			lkpDistrictRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="lkpDistrictRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		public lkpDistrictRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpDistrictRow"/> objects that 
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
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		public virtual lkpDistrictRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[lkpDistrict]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="lkpDistrictRow"/> by the primary key.
		/// </summary>
		/// <param name="district_Id">The <c>District_Id</c> column value.</param>
		/// <returns>An instance of <see cref="lkpDistrictRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual lkpDistrictRow GetByPrimaryKey(int district_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpDistrict_GetByPrimaryKey", true);
			AddParameter(cmd, "District_Id", district_Id);
			lkpDistrictRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>lkpDistrict</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpDistrictRow"/> object to be inserted.</param>
		public virtual void Insert(lkpDistrictRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpDistrict_Insert", true);
			AddParameter(cmd, "District_Id", value.District_Id);
			AddParameter(cmd, "District_Name", value.District_Name);
			AddParameter(cmd, "District_Dari", value.District_Dari);
			AddParameter(cmd, "District_Code", value.District_Code);
			AddParameter(cmd, "Province_Id",
				value.IsProvince_IdNull ? DBNull.Value : (object)value.Province_Id);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>lkpDistrict</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpDistrictRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(lkpDistrictRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpDistrict_Update", true);
			AddParameter(cmd, "District_Name", value.District_Name);
			AddParameter(cmd, "District_Dari", value.District_Dari);
			AddParameter(cmd, "District_Code", value.District_Code);
			AddParameter(cmd, "Province_Id",
				value.IsProvince_IdNull ? DBNull.Value : (object)value.Province_Id);
			AddParameter(cmd, "District_Id", value.District_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>lkpDistrict</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>lkpDistrict</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["District_Id"]);
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
		/// Deletes the specified object from the <c>lkpDistrict</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpDistrictRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(lkpDistrictRow value)
		{
			return DeleteByPrimaryKey(value.District_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>lkpDistrict</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="district_Id">The <c>District_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int district_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpDistrict_DeleteByPrimaryKey", true);
			AddParameter(cmd, "District_Id", district_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>lkpDistrict</c> records that match the specified criteria.
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
		/// to delete <c>lkpDistrict</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[lkpDistrict]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>lkpDistrict</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._lkpDistrict_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		protected lkpDistrictRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		protected lkpDistrictRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="lkpDistrictRow"/> objects.</returns>
		protected virtual lkpDistrictRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int district_IdColumnIndex = reader.GetOrdinal("District_Id");
			int district_NameColumnIndex = reader.GetOrdinal("District_Name");
			int district_DariColumnIndex = reader.GetOrdinal("District_Dari");
			int district_CodeColumnIndex = reader.GetOrdinal("District_Code");
			int province_IdColumnIndex = reader.GetOrdinal("Province_Id");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					lkpDistrictRow record = new lkpDistrictRow();
					recordList.Add(record);

					record.District_Id = Convert.ToInt32(reader.GetValue(district_IdColumnIndex));
					record.District_Name = Convert.ToString(reader.GetValue(district_NameColumnIndex));
					record.District_Dari = Convert.ToString(reader.GetValue(district_DariColumnIndex));
					if(!reader.IsDBNull(district_CodeColumnIndex))
						record.District_Code = Convert.ToString(reader.GetValue(district_CodeColumnIndex));
					if(!reader.IsDBNull(province_IdColumnIndex))
						record.Province_Id = Convert.ToInt32(reader.GetValue(province_IdColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (lkpDistrictRow[])(recordList.ToArray(typeof(lkpDistrictRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="lkpDistrictRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="lkpDistrictRow"/> object.</returns>
		protected virtual lkpDistrictRow MapRow(DataRow row)
		{
			lkpDistrictRow mappedObject = new lkpDistrictRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "District_Id"
			dataColumn = dataTable.Columns["District_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.District_Id = (int)row[dataColumn];
			// Column "District_Name"
			dataColumn = dataTable.Columns["District_Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.District_Name = (string)row[dataColumn];
			// Column "District_Dari"
			dataColumn = dataTable.Columns["District_Dari"];
			if(!row.IsNull(dataColumn))
				mappedObject.District_Dari = (string)row[dataColumn];
			// Column "District_Code"
			dataColumn = dataTable.Columns["District_Code"];
			if(!row.IsNull(dataColumn))
				mappedObject.District_Code = (string)row[dataColumn];
			// Column "Province_Id"
			dataColumn = dataTable.Columns["Province_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Province_Id = (int)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>lkpDistrict</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "lkpDistrict";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("District_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("District_Name", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("District_Dari", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("District_Code", typeof(string));
			dataColumn.MaxLength = 4;
			dataColumn = dataTable.Columns.Add("Province_Id", typeof(int));
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
				case "District_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "District_Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "District_Dari":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "District_Code":
					parameter = _db.AddParameter(cmd, paramName, DbType.StringFixedLength, value);
					break;

				case "Province_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of lkpDistrictCollection_Base class
}  // End of namespace

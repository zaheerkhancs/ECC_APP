// <fileinfo name="lkpCandidateCollection_Base.cs">
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
	/// The base class for <see cref="lkpCandidateCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="lkpCandidateCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpCandidateCollection_Base
	{
		// Constants
		public const string Cand_IDColumnName = "Cand_ID";
		public const string Cand_NoColumnName = "Cand_No";
		public const string Cand_NameColumnName = "Cand_Name";
		public const string Cand_FNameColumnName = "Cand_FName";
		public const string GenderIDColumnName = "GenderID";
		public const string Prov_IDColumnName = "Prov_ID";
		public const string IsDeletedColumnName = "IsDeleted";

		// Instance fields
		private ECCMS _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpCandidateCollection_Base"/> 
		/// class with the specified <see cref="ECCMS"/>.
		/// </summary>
		/// <param name="db">The <see cref="ECCMS"/> object.</param>
		public lkpCandidateCollection_Base(ECCMS db)
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
		/// Gets an array of all records from the <c>lkpCandidate</c> table.
		/// </summary>
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		public virtual lkpCandidateRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>lkpCandidate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>lkpCandidate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._lkpCandidate_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="lkpCandidateRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="lkpCandidateRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public lkpCandidateRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			lkpCandidateRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="lkpCandidateRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		public lkpCandidateRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpCandidateRow"/> objects that 
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
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		public virtual lkpCandidateRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[lkpCandidate]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="lkpCandidateRow"/> by the primary key.
		/// </summary>
		/// <param name="cand_ID">The <c>Cand_ID</c> column value.</param>
		/// <returns>An instance of <see cref="lkpCandidateRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual lkpCandidateRow GetByPrimaryKey(int cand_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpCandidate_GetByPrimaryKey", true);
			AddParameter(cmd, "Cand_ID", cand_ID);
			lkpCandidateRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>lkpCandidate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpCandidateRow"/> object to be inserted.</param>
		public virtual void Insert(lkpCandidateRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpCandidate_Insert", true);
			AddParameter(cmd, "Cand_No", value.Cand_No);
			AddParameter(cmd, "Cand_Name", value.Cand_Name);
			AddParameter(cmd, "Cand_FName", value.Cand_FName);
			AddParameter(cmd, "GenderID",
				value.IsGenderIDNull ? DBNull.Value : (object)value.GenderID);
			AddParameter(cmd, "Prov_ID",
				value.IsProv_IDNull ? DBNull.Value : (object)value.Prov_ID);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			value.Cand_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>lkpCandidate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpCandidateRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(lkpCandidateRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpCandidate_Update", true);
			AddParameter(cmd, "Cand_No", value.Cand_No);
			AddParameter(cmd, "Cand_Name", value.Cand_Name);
			AddParameter(cmd, "Cand_FName", value.Cand_FName);
			AddParameter(cmd, "GenderID",
				value.IsGenderIDNull ? DBNull.Value : (object)value.GenderID);
			AddParameter(cmd, "Prov_ID",
				value.IsProv_IDNull ? DBNull.Value : (object)value.Prov_ID);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "Cand_ID", value.Cand_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>lkpCandidate</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>lkpCandidate</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Cand_ID"]);
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
		/// Deletes the specified object from the <c>lkpCandidate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpCandidateRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(lkpCandidateRow value)
		{
			return DeleteByPrimaryKey(value.Cand_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>lkpCandidate</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="cand_ID">The <c>Cand_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int cand_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpCandidate_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Cand_ID", cand_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>lkpCandidate</c> records that match the specified criteria.
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
		/// to delete <c>lkpCandidate</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[lkpCandidate]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>lkpCandidate</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._lkpCandidate_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		protected lkpCandidateRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		protected lkpCandidateRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="lkpCandidateRow"/> objects.</returns>
		protected virtual lkpCandidateRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int cand_IDColumnIndex = reader.GetOrdinal("Cand_ID");
			int cand_NoColumnIndex = reader.GetOrdinal("Cand_No");
			int cand_NameColumnIndex = reader.GetOrdinal("Cand_Name");
			int cand_FNameColumnIndex = reader.GetOrdinal("Cand_FName");
			int genderIDColumnIndex = reader.GetOrdinal("GenderID");
			int prov_IDColumnIndex = reader.GetOrdinal("Prov_ID");
			int isDeletedColumnIndex = reader.GetOrdinal("IsDeleted");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					lkpCandidateRow record = new lkpCandidateRow();
					recordList.Add(record);

					record.Cand_ID = Convert.ToInt32(reader.GetValue(cand_IDColumnIndex));
					if(!reader.IsDBNull(cand_NoColumnIndex))
						record.Cand_No = Convert.ToString(reader.GetValue(cand_NoColumnIndex));
					if(!reader.IsDBNull(cand_NameColumnIndex))
						record.Cand_Name = Convert.ToString(reader.GetValue(cand_NameColumnIndex));
					if(!reader.IsDBNull(cand_FNameColumnIndex))
						record.Cand_FName = Convert.ToString(reader.GetValue(cand_FNameColumnIndex));
					if(!reader.IsDBNull(genderIDColumnIndex))
						record.GenderID = Convert.ToInt32(reader.GetValue(genderIDColumnIndex));
					if(!reader.IsDBNull(prov_IDColumnIndex))
						record.Prov_ID = Convert.ToInt32(reader.GetValue(prov_IDColumnIndex));
					if(!reader.IsDBNull(isDeletedColumnIndex))
						record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (lkpCandidateRow[])(recordList.ToArray(typeof(lkpCandidateRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="lkpCandidateRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="lkpCandidateRow"/> object.</returns>
		protected virtual lkpCandidateRow MapRow(DataRow row)
		{
			lkpCandidateRow mappedObject = new lkpCandidateRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Cand_ID"
			dataColumn = dataTable.Columns["Cand_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Cand_ID = (int)row[dataColumn];
			// Column "Cand_No"
			dataColumn = dataTable.Columns["Cand_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Cand_No = (string)row[dataColumn];
			// Column "Cand_Name"
			dataColumn = dataTable.Columns["Cand_Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Cand_Name = (string)row[dataColumn];
			// Column "Cand_FName"
			dataColumn = dataTable.Columns["Cand_FName"];
			if(!row.IsNull(dataColumn))
				mappedObject.Cand_FName = (string)row[dataColumn];
			// Column "GenderID"
			dataColumn = dataTable.Columns["GenderID"];
			if(!row.IsNull(dataColumn))
				mappedObject.GenderID = (int)row[dataColumn];
			// Column "Prov_ID"
			dataColumn = dataTable.Columns["Prov_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Prov_ID = (int)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>lkpCandidate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "lkpCandidate";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Cand_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Cand_No", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Cand_Name", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Cand_FName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("GenderID", typeof(int));
			dataColumn = dataTable.Columns.Add("Prov_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
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
				case "Cand_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Cand_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Cand_Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Cand_FName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "GenderID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Prov_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of lkpCandidateCollection_Base class
}  // End of namespace

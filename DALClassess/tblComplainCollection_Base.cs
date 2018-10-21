// <fileinfo name="tblComplainCollection_Base.cs">
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
	/// The base class for <see cref="tblComplainCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblComplainCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblComplainCollection_Base
	{
		// Constants
		public const string CaseIDColumnName = "CaseID";
		public const string CaseNoColumnName = "CaseNo";
		public const string Sub_DateColumnName = "Sub_Date";
		public const string KuchiColumnName = "Kuchi";
		public const string CaseProIDColumnName = "caseProID";
		public const string Tri_DateColumnName = "Tri_Date";
		public const string ProvIDColumnName = "ProvID";
		public const string PolCen_IDColumnName = "PolCen_ID";
		public const string PSColumnName = "PS";
		public const string Comp_GenderIDColumnName = "Comp_GenderID";
		public const string Comp_Cand_IDColumnName = "Comp_Cand_ID";
		public const string Comp_TypeIDColumnName = "Comp_TypeID";
		public const string Resp_GenderIDColumnName = "Resp_GenderID";
		public const string Resp_TypeIDColumnName = "Resp_TypeID";
		public const string AllagType_IDColumnName = "AllagType_ID";
		public const string AllegationSummaryColumnName = "AllegationSummary";
		public const string Resp_OfficeIDColumnName = "Resp_OfficeID";
		public const string StatusIDColumnName = "StatusID";
		public const string DecisionColumnName = "Decision";
		public const string SanctionIDColumnName = "SanctionID";
		public const string AppealColumnName = "Appeal";
		public const string Ecc_HQ_DecisionColumnName = "Ecc_HQ_Decision";
		public const string IsDeletedColumnName = "IsDeleted";
		public const string CreatedByColumnName = "CreatedBy";
		public const string CreatedTimeColumnName = "CreatedTime";
		public const string UpdatedByColumnName = "UpdatedBy";
		public const string UpdatedTimeColumnName = "UpdatedTime";

		// Instance fields
		private ECCMS _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblComplainCollection_Base"/> 
		/// class with the specified <see cref="ECCMS"/>.
		/// </summary>
		/// <param name="db">The <see cref="ECCMS"/> object.</param>
		public tblComplainCollection_Base(ECCMS db)
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
		/// Gets an array of all records from the <c>tblComplain</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		public virtual tblComplainRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblComplain</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblComplain</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblComplain_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblComplainRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblComplainRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblComplainRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblComplainRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblComplainRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		public tblComplainRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblComplainRow"/> objects that 
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
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		public virtual tblComplainRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblComplain]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblComplainRow"/> by the primary key.
		/// </summary>
		/// <param name="caseID">The <c>CaseID</c> column value.</param>
		/// <returns>An instance of <see cref="tblComplainRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblComplainRow GetByPrimaryKey(long caseID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblComplain_GetByPrimaryKey", true);
			AddParameter(cmd, "CaseID", caseID);
			tblComplainRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>tblComplain</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblComplainRow"/> object to be inserted.</param>
		public virtual void Insert(tblComplainRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblComplain_Insert", true);
			AddParameter(cmd, "CaseNo", value.CaseNo);
			AddParameter(cmd, "Sub_Date",
				value.IsSub_DateNull ? DBNull.Value : (object)value.Sub_Date);
			AddParameter(cmd, "Kuchi",
				value.IsKuchiNull ? DBNull.Value : (object)value.Kuchi);
			AddParameter(cmd, "CaseProID",
				value.IsCaseProIDNull ? DBNull.Value : (object)value.CaseProID);
			AddParameter(cmd, "Tri_Date",
				value.IsTri_DateNull ? DBNull.Value : (object)value.Tri_Date);
			AddParameter(cmd, "ProvID",
				value.IsProvIDNull ? DBNull.Value : (object)value.ProvID);
			AddParameter(cmd, "PolCen_ID",
				value.IsPolCen_IDNull ? DBNull.Value : (object)value.PolCen_ID);
			AddParameter(cmd, "PS", value.PS);
			AddParameter(cmd, "Comp_GenderID",
				value.IsComp_GenderIDNull ? DBNull.Value : (object)value.Comp_GenderID);
			AddParameter(cmd, "Comp_Cand_ID",
				value.IsComp_Cand_IDNull ? DBNull.Value : (object)value.Comp_Cand_ID);
			AddParameter(cmd, "Comp_TypeID",
				value.IsComp_TypeIDNull ? DBNull.Value : (object)value.Comp_TypeID);
			AddParameter(cmd, "Resp_GenderID",
				value.IsResp_GenderIDNull ? DBNull.Value : (object)value.Resp_GenderID);
			AddParameter(cmd, "Resp_TypeID",
				value.IsResp_TypeIDNull ? DBNull.Value : (object)value.Resp_TypeID);
			AddParameter(cmd, "AllagType_ID",
				value.IsAllagType_IDNull ? DBNull.Value : (object)value.AllagType_ID);
			AddParameter(cmd, "AllegationSummary", value.AllegationSummary);
			AddParameter(cmd, "Resp_OfficeID",
				value.IsResp_OfficeIDNull ? DBNull.Value : (object)value.Resp_OfficeID);
			AddParameter(cmd, "StatusID",
				value.IsStatusIDNull ? DBNull.Value : (object)value.StatusID);
			AddParameter(cmd, "Decision", value.Decision);
			AddParameter(cmd, "SanctionID",
				value.IsSanctionIDNull ? DBNull.Value : (object)value.SanctionID);
			AddParameter(cmd, "Appeal",
				value.IsAppealNull ? DBNull.Value : (object)value.Appeal);
			AddParameter(cmd, "Ecc_HQ_Decision", value.Ecc_HQ_Decision);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "CreatedBy", value.CreatedBy);
			AddParameter(cmd, "CreatedTime", value.CreatedTime);
			AddParameter(cmd, "UpdatedBy", value.UpdatedBy);
			AddParameter(cmd, "UpdatedTime", value.UpdatedTime);
			value.CaseID = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblComplain</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblComplainRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblComplainRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblComplain_Update", true);
			AddParameter(cmd, "CaseNo", value.CaseNo);
			AddParameter(cmd, "Sub_Date",
				value.IsSub_DateNull ? DBNull.Value : (object)value.Sub_Date);
			AddParameter(cmd, "Kuchi",
				value.IsKuchiNull ? DBNull.Value : (object)value.Kuchi);
			AddParameter(cmd, "CaseProID",
				value.IsCaseProIDNull ? DBNull.Value : (object)value.CaseProID);
			AddParameter(cmd, "Tri_Date",
				value.IsTri_DateNull ? DBNull.Value : (object)value.Tri_Date);
			AddParameter(cmd, "ProvID",
				value.IsProvIDNull ? DBNull.Value : (object)value.ProvID);
			AddParameter(cmd, "PolCen_ID",
				value.IsPolCen_IDNull ? DBNull.Value : (object)value.PolCen_ID);
			AddParameter(cmd, "PS", value.PS);
			AddParameter(cmd, "Comp_GenderID",
				value.IsComp_GenderIDNull ? DBNull.Value : (object)value.Comp_GenderID);
			AddParameter(cmd, "Comp_Cand_ID",
				value.IsComp_Cand_IDNull ? DBNull.Value : (object)value.Comp_Cand_ID);
			AddParameter(cmd, "Comp_TypeID",
				value.IsComp_TypeIDNull ? DBNull.Value : (object)value.Comp_TypeID);
			AddParameter(cmd, "Resp_GenderID",
				value.IsResp_GenderIDNull ? DBNull.Value : (object)value.Resp_GenderID);
			AddParameter(cmd, "Resp_TypeID",
				value.IsResp_TypeIDNull ? DBNull.Value : (object)value.Resp_TypeID);
			AddParameter(cmd, "AllagType_ID",
				value.IsAllagType_IDNull ? DBNull.Value : (object)value.AllagType_ID);
			AddParameter(cmd, "AllegationSummary", value.AllegationSummary);
			AddParameter(cmd, "Resp_OfficeID",
				value.IsResp_OfficeIDNull ? DBNull.Value : (object)value.Resp_OfficeID);
			AddParameter(cmd, "StatusID",
				value.IsStatusIDNull ? DBNull.Value : (object)value.StatusID);
			AddParameter(cmd, "Decision", value.Decision);
			AddParameter(cmd, "SanctionID",
				value.IsSanctionIDNull ? DBNull.Value : (object)value.SanctionID);
			AddParameter(cmd, "Appeal",
				value.IsAppealNull ? DBNull.Value : (object)value.Appeal);
			AddParameter(cmd, "Ecc_HQ_Decision", value.Ecc_HQ_Decision);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "CreatedBy", value.CreatedBy);
			AddParameter(cmd, "CreatedTime", value.CreatedTime);
			AddParameter(cmd, "UpdatedBy", value.UpdatedBy);
			AddParameter(cmd, "UpdatedTime", value.UpdatedTime);
			AddParameter(cmd, "CaseID", value.CaseID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblComplain</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblComplain</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((long)row["CaseID"]);
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
		/// Deletes the specified object from the <c>tblComplain</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblComplainRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblComplainRow value)
		{
			return DeleteByPrimaryKey(value.CaseID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblComplain</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="caseID">The <c>CaseID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long caseID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblComplain_DeleteByPrimaryKey", true);
			AddParameter(cmd, "CaseID", caseID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>tblComplain</c> records that match the specified criteria.
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
		/// to delete <c>tblComplain</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblComplain]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblComplain</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblComplain_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		protected tblComplainRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		protected tblComplainRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblComplainRow"/> objects.</returns>
		protected virtual tblComplainRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int caseIDColumnIndex = reader.GetOrdinal("CaseID");
			int caseNoColumnIndex = reader.GetOrdinal("CaseNo");
			int sub_DateColumnIndex = reader.GetOrdinal("Sub_Date");
			int kuchiColumnIndex = reader.GetOrdinal("Kuchi");
			int caseProIDColumnIndex = reader.GetOrdinal("caseProID");
			int tri_DateColumnIndex = reader.GetOrdinal("Tri_Date");
			int provIDColumnIndex = reader.GetOrdinal("ProvID");
			int polCen_IDColumnIndex = reader.GetOrdinal("PolCen_ID");
			int psColumnIndex = reader.GetOrdinal("PS");
			int comp_GenderIDColumnIndex = reader.GetOrdinal("Comp_GenderID");
			int comp_Cand_IDColumnIndex = reader.GetOrdinal("Comp_Cand_ID");
			int comp_TypeIDColumnIndex = reader.GetOrdinal("Comp_TypeID");
			int resp_GenderIDColumnIndex = reader.GetOrdinal("Resp_GenderID");
			int resp_TypeIDColumnIndex = reader.GetOrdinal("Resp_TypeID");
			int allagType_IDColumnIndex = reader.GetOrdinal("AllagType_ID");
			int allegationSummaryColumnIndex = reader.GetOrdinal("AllegationSummary");
			int resp_OfficeIDColumnIndex = reader.GetOrdinal("Resp_OfficeID");
			int statusIDColumnIndex = reader.GetOrdinal("StatusID");
			int decisionColumnIndex = reader.GetOrdinal("Decision");
			int sanctionIDColumnIndex = reader.GetOrdinal("SanctionID");
			int appealColumnIndex = reader.GetOrdinal("Appeal");
			int ecc_HQ_DecisionColumnIndex = reader.GetOrdinal("Ecc_HQ_Decision");
			int isDeletedColumnIndex = reader.GetOrdinal("IsDeleted");
			int createdByColumnIndex = reader.GetOrdinal("CreatedBy");
			int createdTimeColumnIndex = reader.GetOrdinal("CreatedTime");
			int updatedByColumnIndex = reader.GetOrdinal("UpdatedBy");
			int updatedTimeColumnIndex = reader.GetOrdinal("UpdatedTime");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblComplainRow record = new tblComplainRow();
					recordList.Add(record);

					record.CaseID = Convert.ToInt64(reader.GetValue(caseIDColumnIndex));
					record.CaseNo = Convert.ToString(reader.GetValue(caseNoColumnIndex));
					if(!reader.IsDBNull(sub_DateColumnIndex))
						record.Sub_Date = Convert.ToDateTime(reader.GetValue(sub_DateColumnIndex));
					if(!reader.IsDBNull(kuchiColumnIndex))
						record.Kuchi = Convert.ToInt32(reader.GetValue(kuchiColumnIndex));
					if(!reader.IsDBNull(caseProIDColumnIndex))
						record.CaseProID = Convert.ToInt32(reader.GetValue(caseProIDColumnIndex));
					if(!reader.IsDBNull(tri_DateColumnIndex))
						record.Tri_Date = Convert.ToDateTime(reader.GetValue(tri_DateColumnIndex));
					if(!reader.IsDBNull(provIDColumnIndex))
						record.ProvID = Convert.ToInt32(reader.GetValue(provIDColumnIndex));
					if(!reader.IsDBNull(polCen_IDColumnIndex))
						record.PolCen_ID = Convert.ToInt32(reader.GetValue(polCen_IDColumnIndex));
					if(!reader.IsDBNull(psColumnIndex))
						record.PS = Convert.ToString(reader.GetValue(psColumnIndex));
					if(!reader.IsDBNull(comp_GenderIDColumnIndex))
						record.Comp_GenderID = Convert.ToInt32(reader.GetValue(comp_GenderIDColumnIndex));
					if(!reader.IsDBNull(comp_Cand_IDColumnIndex))
						record.Comp_Cand_ID = Convert.ToInt32(reader.GetValue(comp_Cand_IDColumnIndex));
					if(!reader.IsDBNull(comp_TypeIDColumnIndex))
						record.Comp_TypeID = Convert.ToInt32(reader.GetValue(comp_TypeIDColumnIndex));
					if(!reader.IsDBNull(resp_GenderIDColumnIndex))
						record.Resp_GenderID = Convert.ToInt32(reader.GetValue(resp_GenderIDColumnIndex));
					if(!reader.IsDBNull(resp_TypeIDColumnIndex))
						record.Resp_TypeID = Convert.ToInt32(reader.GetValue(resp_TypeIDColumnIndex));
					if(!reader.IsDBNull(allagType_IDColumnIndex))
						record.AllagType_ID = Convert.ToInt32(reader.GetValue(allagType_IDColumnIndex));
					if(!reader.IsDBNull(allegationSummaryColumnIndex))
						record.AllegationSummary = Convert.ToString(reader.GetValue(allegationSummaryColumnIndex));
					if(!reader.IsDBNull(resp_OfficeIDColumnIndex))
						record.Resp_OfficeID = Convert.ToInt32(reader.GetValue(resp_OfficeIDColumnIndex));
					if(!reader.IsDBNull(statusIDColumnIndex))
						record.StatusID = Convert.ToInt32(reader.GetValue(statusIDColumnIndex));
					if(!reader.IsDBNull(decisionColumnIndex))
						record.Decision = Convert.ToString(reader.GetValue(decisionColumnIndex));
					if(!reader.IsDBNull(sanctionIDColumnIndex))
						record.SanctionID = Convert.ToInt32(reader.GetValue(sanctionIDColumnIndex));
					if(!reader.IsDBNull(appealColumnIndex))
						record.Appeal = Convert.ToInt32(reader.GetValue(appealColumnIndex));
					if(!reader.IsDBNull(ecc_HQ_DecisionColumnIndex))
						record.Ecc_HQ_Decision = Convert.ToString(reader.GetValue(ecc_HQ_DecisionColumnIndex));
					if(!reader.IsDBNull(isDeletedColumnIndex))
						record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));
					record.CreatedBy = reader.GetGuid(createdByColumnIndex);
					record.CreatedTime = Convert.ToDateTime(reader.GetValue(createdTimeColumnIndex));
					record.UpdatedBy = reader.GetGuid(updatedByColumnIndex);
					record.UpdatedTime = Convert.ToDateTime(reader.GetValue(updatedTimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblComplainRow[])(recordList.ToArray(typeof(tblComplainRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblComplainRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblComplainRow"/> object.</returns>
		protected virtual tblComplainRow MapRow(DataRow row)
		{
			tblComplainRow mappedObject = new tblComplainRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "CaseID"
			dataColumn = dataTable.Columns["CaseID"];
			if(!row.IsNull(dataColumn))
				mappedObject.CaseID = (long)row[dataColumn];
			// Column "CaseNo"
			dataColumn = dataTable.Columns["CaseNo"];
			if(!row.IsNull(dataColumn))
				mappedObject.CaseNo = (string)row[dataColumn];
			// Column "Sub_Date"
			dataColumn = dataTable.Columns["Sub_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Sub_Date = (System.DateTime)row[dataColumn];
			// Column "Kuchi"
			dataColumn = dataTable.Columns["Kuchi"];
			if(!row.IsNull(dataColumn))
				mappedObject.Kuchi = (int)row[dataColumn];
			// Column "CaseProID"
			dataColumn = dataTable.Columns["CaseProID"];
			if(!row.IsNull(dataColumn))
				mappedObject.CaseProID = (int)row[dataColumn];
			// Column "Tri_Date"
			dataColumn = dataTable.Columns["Tri_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Tri_Date = (System.DateTime)row[dataColumn];
			// Column "ProvID"
			dataColumn = dataTable.Columns["ProvID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ProvID = (int)row[dataColumn];
			// Column "PolCen_ID"
			dataColumn = dataTable.Columns["PolCen_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.PolCen_ID = (int)row[dataColumn];
			// Column "PS"
			dataColumn = dataTable.Columns["PS"];
			if(!row.IsNull(dataColumn))
				mappedObject.PS = (string)row[dataColumn];
			// Column "Comp_GenderID"
			dataColumn = dataTable.Columns["Comp_GenderID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Comp_GenderID = (int)row[dataColumn];
			// Column "Comp_Cand_ID"
			dataColumn = dataTable.Columns["Comp_Cand_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Comp_Cand_ID = (int)row[dataColumn];
			// Column "Comp_TypeID"
			dataColumn = dataTable.Columns["Comp_TypeID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Comp_TypeID = (int)row[dataColumn];
			// Column "Resp_GenderID"
			dataColumn = dataTable.Columns["Resp_GenderID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Resp_GenderID = (int)row[dataColumn];
			// Column "Resp_TypeID"
			dataColumn = dataTable.Columns["Resp_TypeID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Resp_TypeID = (int)row[dataColumn];
			// Column "AllagType_ID"
			dataColumn = dataTable.Columns["AllagType_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.AllagType_ID = (int)row[dataColumn];
			// Column "AllegationSummary"
			dataColumn = dataTable.Columns["AllegationSummary"];
			if(!row.IsNull(dataColumn))
				mappedObject.AllegationSummary = (string)row[dataColumn];
			// Column "Resp_OfficeID"
			dataColumn = dataTable.Columns["Resp_OfficeID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Resp_OfficeID = (int)row[dataColumn];
			// Column "StatusID"
			dataColumn = dataTable.Columns["StatusID"];
			if(!row.IsNull(dataColumn))
				mappedObject.StatusID = (int)row[dataColumn];
			// Column "Decision"
			dataColumn = dataTable.Columns["Decision"];
			if(!row.IsNull(dataColumn))
				mappedObject.Decision = (string)row[dataColumn];
			// Column "SanctionID"
			dataColumn = dataTable.Columns["SanctionID"];
			if(!row.IsNull(dataColumn))
				mappedObject.SanctionID = (int)row[dataColumn];
			// Column "Appeal"
			dataColumn = dataTable.Columns["Appeal"];
			if(!row.IsNull(dataColumn))
				mappedObject.Appeal = (int)row[dataColumn];
			// Column "Ecc_HQ_Decision"
			dataColumn = dataTable.Columns["Ecc_HQ_Decision"];
			if(!row.IsNull(dataColumn))
				mappedObject.Ecc_HQ_Decision = (string)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			// Column "CreatedBy"
			dataColumn = dataTable.Columns["CreatedBy"];
			if(!row.IsNull(dataColumn))
				mappedObject.CreatedBy = (System.Guid)row[dataColumn];
			// Column "CreatedTime"
			dataColumn = dataTable.Columns["CreatedTime"];
			if(!row.IsNull(dataColumn))
				mappedObject.CreatedTime = (System.DateTime)row[dataColumn];
			// Column "UpdatedBy"
			dataColumn = dataTable.Columns["UpdatedBy"];
			if(!row.IsNull(dataColumn))
				mappedObject.UpdatedBy = (System.Guid)row[dataColumn];
			// Column "UpdatedTime"
			dataColumn = dataTable.Columns["UpdatedTime"];
			if(!row.IsNull(dataColumn))
				mappedObject.UpdatedTime = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblComplain</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblComplain";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("CaseID", typeof(long));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("CaseNo", typeof(string));
			dataColumn.MaxLength = 15;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Sub_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Kuchi", typeof(int));
			dataColumn = dataTable.Columns.Add("CaseProID", typeof(int));
			dataColumn.Caption = "caseProID";
			dataColumn = dataTable.Columns.Add("Tri_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("ProvID", typeof(int));
			dataColumn = dataTable.Columns.Add("PolCen_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("PS", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Comp_GenderID", typeof(int));
			dataColumn = dataTable.Columns.Add("Comp_Cand_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("Comp_TypeID", typeof(int));
			dataColumn = dataTable.Columns.Add("Resp_GenderID", typeof(int));
			dataColumn = dataTable.Columns.Add("Resp_TypeID", typeof(int));
			dataColumn = dataTable.Columns.Add("AllagType_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("AllegationSummary", typeof(string));
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("Resp_OfficeID", typeof(int));
			dataColumn = dataTable.Columns.Add("StatusID", typeof(int));
			dataColumn = dataTable.Columns.Add("Decision", typeof(string));
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("SanctionID", typeof(int));
			dataColumn = dataTable.Columns.Add("Appeal", typeof(int));
			dataColumn = dataTable.Columns.Add("Ecc_HQ_Decision", typeof(string));
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
			dataColumn = dataTable.Columns.Add("CreatedBy", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("CreatedTime", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("UpdatedBy", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("UpdatedTime", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
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
				case "CaseID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "CaseNo":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Sub_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Kuchi":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "CaseProID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Tri_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "ProvID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "PolCen_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "PS":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Comp_GenderID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Comp_Cand_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Comp_TypeID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Resp_GenderID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Resp_TypeID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "AllagType_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "AllegationSummary":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Resp_OfficeID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "StatusID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Decision":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "SanctionID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Appeal":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Ecc_HQ_Decision":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "CreatedBy":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "CreatedTime":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "UpdatedBy":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "UpdatedTime":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblComplainCollection_Base class
}  // End of namespace

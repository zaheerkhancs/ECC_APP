// <fileinfo name="ECCMS_Base.cs">
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
	/// The base class for the <see cref="ECCMS"/> class that 
	/// represents a connection to the <c>ECCMS</c> database. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Modify the ECCMS class
	/// if you need to add or change some functionality.
	/// </remarks>
	public abstract class ECCMS_Base : IDisposable
	{
		private IDbConnection _connection;
		private IDbTransaction _transaction;

		// Table and view fields
	
		private lkpProvinceCollection _lkpProvince;
        private lkpAllegationtypeCollection _lkpAllegationtype;
        private lkpBitCollection _lkpBit;
        private lkpCandidateCollection _lkpCandidate;
        private lkpCasepriorityCollection _lkpCasepriority;
        private lkpComplainanttypeCollection _lkpComplainanttype;
        private lkpDistrictCollection _lkpDistrict;
        private lkpGendersCollection _lkpGenders;
        private lkpPollingCenterCollection _lkpPollingCenter;
        private lkpRespondanttypeCollection _lkpRespondanttype;
        private lkpResponsibleOfficeCollection _lkpResponsibleOffice;
        private lkpSanctionCollection _lkpSanction;
        private lkpStatusCollection _lkpStatus;
		private tblComplainCollection _tblComplain;
		private tblRecentLogCollection _tblRecentLog;
        private aspnet_ApplicationsCollection _aspnet_Applications;
        private aspnet_MembershipCollection _aspnet_Membership;
        private aspnet_PathsCollection _aspnet_Paths;
        private aspnet_PersonalizationAllUsersCollection _aspnet_PersonalizationAllUsers;
        private aspnet_PersonalizationPerUserCollection _aspnet_PersonalizationPerUser;
        private aspnet_ProfileCollection _aspnet_Profile;
        private aspnet_RolesCollection _aspnet_Roles;
        private aspnet_SchemaVersionsCollection _aspnet_SchemaVersions;
        private aspnet_UsersCollection _aspnet_Users;
        private aspnet_UsersInRolesCollection _aspnet_UsersInRoles;
        private aspnet_WebEvent_EventsCollection _aspnet_WebEvent_Events;
	

		/// <summary>
		/// Initializes a new instance of the <see cref="ECCMS_Base"/> 
		/// class and opens the database connection.
		/// </summary>
		protected ECCMS_Base() : this(true)
		{
			// EMPTY
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ECCMS_Base"/> class.
		/// </summary>
		/// <param name="init">Specifies whether the constructor calls the
		/// <see cref="InitConnection"/> method to initialize the database connection.</param>
		protected ECCMS_Base(bool init)
		{
			if(init)
				InitConnection();
		}

		/// <summary>
		/// Initializes the database connection.
		/// </summary>
		protected void InitConnection()
		{
			_connection = CreateConnection();
			_connection.Open();
		}

		/// <summary>
		/// Creates a new connection to the database.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbConnection"/> object.</returns>
		protected abstract IDbConnection CreateConnection();

		/// <summary>
		/// Returns a SQL statement parameter name that is specific for the data provider.
		/// For example it returns ? for OleDb provider, or @paramName for MS SQL provider.
		/// </summary>
		/// <param name="paramName">The data provider neutral SQL parameter name.</param>
		/// <returns>The SQL statement parameter name.</returns>
		protected internal abstract string CreateSqlParameterName(string paramName);

		/// <summary>
		/// Creates <see cref="System.Data.IDataReader"/> for the specified DB command.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.IDataReader"/> object.</returns>
		protected internal virtual IDataReader ExecuteReader(IDbCommand command)
		{
			return command.ExecuteReader();
		}

		/// <summary>
		/// Adds a new parameter to the specified command. It is not recommended that 
		/// you use this method directly from your custom code. Instead use the 
		/// <c>AddParameter</c> method of the &lt;TableCodeName&gt;Collection_Base classes.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="dbType">One of the <see cref="System.Data.DbType"/> values. </param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		internal IDbDataParameter AddParameter(IDbCommand cmd, string paramName,
												DbType dbType, object value)
		{
			IDbDataParameter parameter = cmd.CreateParameter();
			parameter.ParameterName = CreateCollectionParameterName(paramName);
			parameter.DbType = dbType;
			parameter.Value = null == value ? DBNull.Value : value;
			cmd.Parameters.Add(parameter);
			return parameter;
		}
		
		/// <summary>
		/// Creates a .Net data provider specific name that is used by the 
		/// <see cref="AddParameter"/> method.
		/// </summary>
		/// <param name="baseParamName">The base name of the parameter.</param>
		/// <returns>The full data provider specific parameter name.</returns>
		protected abstract string CreateCollectionParameterName(string baseParamName);

		/// <summary>
		/// Gets <see cref="System.Data.IDbConnection"/> associated with this object.
		/// </summary>
		/// <value>A reference to the <see cref="System.Data.IDbConnection"/> object.</value>
		public IDbConnection Connection
		{
			get { return _connection; }
		}

		
		/// <summary>
		/// Gets an object that represents the <c>lkpProvince</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="lkpProvinceCollection"/> object.</value>
		public lkpProvinceCollection lkpProvinceCollection
		{
			get
			{
				if(null == _lkpProvince)
					_lkpProvince = new lkpProvinceCollection((ECCMS)this);
				return _lkpProvince;
			}
		}

		

		/// <summary>
		/// Gets an object that represents the <c>tblComplain</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblComplainCollection"/> object.</value>
		public tblComplainCollection tblComplainCollection
		{
			get
			{
				if(null == _tblComplain)
					_tblComplain = new tblComplainCollection((ECCMS)this);
				return _tblComplain;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>tblRecentLog</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="tblRecentLogCollection"/> object.</value>
		public tblRecentLogCollection tblRecentLogCollection
		{
			get
			{
				if(null == _tblRecentLog)
					_tblRecentLog = new tblRecentLogCollection((ECCMS)this);
				return _tblRecentLog;
			}
		}

        /// <summary>
        /// Gets an object that represents the <c>lkpAllegationtype</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpAllegationtypeCollection"/> object.</value>
        public lkpAllegationtypeCollection lkpAllegationtypeCollection
        {
            get
            {
                if (null == _lkpAllegationtype)
                    _lkpAllegationtype = new lkpAllegationtypeCollection((ECCMS)this);
                return _lkpAllegationtype;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpBit</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpBitCollection"/> object.</value>
        public lkpBitCollection lkpBitCollection
        {
            get
            {
                if (null == _lkpBit)
                    _lkpBit = new lkpBitCollection((ECCMS)this);
                return _lkpBit;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpCandidate</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpCandidateCollection"/> object.</value>
        public lkpCandidateCollection lkpCandidateCollection
        {
            get
            {
                if (null == _lkpCandidate)
                    _lkpCandidate = new lkpCandidateCollection((ECCMS)this);
                return _lkpCandidate;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpCasepriority</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpCasepriorityCollection"/> object.</value>
        public lkpCasepriorityCollection lkpCasepriorityCollection
        {
            get
            {
                if (null == _lkpCasepriority)
                    _lkpCasepriority = new lkpCasepriorityCollection((ECCMS)this);
                return _lkpCasepriority;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpComplainanttype</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpComplainanttypeCollection"/> object.</value>
        public lkpComplainanttypeCollection lkpComplainanttypeCollection
        {
            get
            {
                if (null == _lkpComplainanttype)
                    _lkpComplainanttype = new lkpComplainanttypeCollection((ECCMS)this);
                return _lkpComplainanttype;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpDistrict</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpDistrictCollection"/> object.</value>
        public lkpDistrictCollection lkpDistrictCollection
        {
            get
            {
                if (null == _lkpDistrict)
                    _lkpDistrict = new lkpDistrictCollection((ECCMS)this);
                return _lkpDistrict;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpGenders</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpGendersCollection"/> object.</value>
        public lkpGendersCollection lkpGendersCollection
        {
            get
            {
                if (null == _lkpGenders)
                    _lkpGenders = new lkpGendersCollection((ECCMS)this);
                return _lkpGenders;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpPollingCenter</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpPollingCenterCollection"/> object.</value>
        public lkpPollingCenterCollection lkpPollingCenterCollection
        {
            get
            {
                if (null == _lkpPollingCenter)
                    _lkpPollingCenter = new lkpPollingCenterCollection((ECCMS)this);
                return _lkpPollingCenter;
            }
        }


        /// <summary>
        /// Gets an object that represents the <c>lkpRespondanttype</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpRespondanttypeCollection"/> object.</value>
        public lkpRespondanttypeCollection lkpRespondanttypeCollection
        {
            get
            {
                if (null == _lkpRespondanttype)
                    _lkpRespondanttype = new lkpRespondanttypeCollection((ECCMS)this);
                return _lkpRespondanttype;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpResponsibleOffice</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpResponsibleOfficeCollection"/> object.</value>
        public lkpResponsibleOfficeCollection lkpResponsibleOfficeCollection
        {
            get
            {
                if (null == _lkpResponsibleOffice)
                    _lkpResponsibleOffice = new lkpResponsibleOfficeCollection((ECCMS)this);
                return _lkpResponsibleOffice;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpSanction</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpSanctionCollection"/> object.</value>
        public lkpSanctionCollection lkpSanctionCollection
        {
            get
            {
                if (null == _lkpSanction)
                    _lkpSanction = new lkpSanctionCollection((ECCMS)this);
                return _lkpSanction;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpStatus</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpStatusCollection"/> object.</value>
        public lkpStatusCollection lkpStatusCollection
        {
            get
            {
                if (null == _lkpStatus)
                    _lkpStatus = new lkpStatusCollection((ECCMS)this);
                return _lkpStatus;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Applications</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_ApplicationsCollection"/> object.</value>
        public aspnet_ApplicationsCollection aspnet_ApplicationsCollection
        {
            get
            {
                if (null == _aspnet_Applications)
                    _aspnet_Applications = new aspnet_ApplicationsCollection((ECCMS)this);
                return _aspnet_Applications;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Membership</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_MembershipCollection"/> object.</value>
        public aspnet_MembershipCollection aspnet_MembershipCollection
        {
            get
            {
                if (null == _aspnet_Membership)
                    _aspnet_Membership = new aspnet_MembershipCollection((ECCMS)this);
                return _aspnet_Membership;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Paths</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_PathsCollection"/> object.</value>
        public aspnet_PathsCollection aspnet_PathsCollection
        {
            get
            {
                if (null == _aspnet_Paths)
                    _aspnet_Paths = new aspnet_PathsCollection((ECCMS)this);
                return _aspnet_Paths;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_PersonalizationAllUsers</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_PersonalizationAllUsersCollection"/> object.</value>
        public aspnet_PersonalizationAllUsersCollection aspnet_PersonalizationAllUsersCollection
        {
            get
            {
                if (null == _aspnet_PersonalizationAllUsers)
                    _aspnet_PersonalizationAllUsers = new aspnet_PersonalizationAllUsersCollection((ECCMS)this);
                return _aspnet_PersonalizationAllUsers;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_PersonalizationPerUser</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_PersonalizationPerUserCollection"/> object.</value>
        public aspnet_PersonalizationPerUserCollection aspnet_PersonalizationPerUserCollection
        {
            get
            {
                if (null == _aspnet_PersonalizationPerUser)
                    _aspnet_PersonalizationPerUser = new aspnet_PersonalizationPerUserCollection((ECCMS)this);
                return _aspnet_PersonalizationPerUser;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Profile</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_ProfileCollection"/> object.</value>
        public aspnet_ProfileCollection aspnet_ProfileCollection
        {
            get
            {
                if (null == _aspnet_Profile)
                    _aspnet_Profile = new aspnet_ProfileCollection((ECCMS)this);
                return _aspnet_Profile;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Roles</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_RolesCollection"/> object.</value>
        public aspnet_RolesCollection aspnet_RolesCollection
        {
            get
            {
                if (null == _aspnet_Roles)
                    _aspnet_Roles = new aspnet_RolesCollection((ECCMS)this);
                return _aspnet_Roles;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_SchemaVersions</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_SchemaVersionsCollection"/> object.</value>
        public aspnet_SchemaVersionsCollection aspnet_SchemaVersionsCollection
        {
            get
            {
                if (null == _aspnet_SchemaVersions)
                    _aspnet_SchemaVersions = new aspnet_SchemaVersionsCollection((ECCMS)this);
                return _aspnet_SchemaVersions;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_Users</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_UsersCollection"/> object.</value>
        public aspnet_UsersCollection aspnet_UsersCollection
        {
            get
            {
                if (null == _aspnet_Users)
                    _aspnet_Users = new aspnet_UsersCollection((ECCMS)this);
                return _aspnet_Users;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_UsersInRoles</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_UsersInRolesCollection"/> object.</value>
        public aspnet_UsersInRolesCollection aspnet_UsersInRolesCollection
        {
            get
            {
                if (null == _aspnet_UsersInRoles)
                    _aspnet_UsersInRoles = new aspnet_UsersInRolesCollection((ECCMS)this);
                return _aspnet_UsersInRoles;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>aspnet_WebEvent_Events</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="aspnet_WebEvent_EventsCollection"/> object.</value>
        public aspnet_WebEvent_EventsCollection aspnet_WebEvent_EventsCollection
        {
            get
            {
                if (null == _aspnet_WebEvent_Events)
                    _aspnet_WebEvent_Events = new aspnet_WebEvent_EventsCollection((ECCMS)this);
                return _aspnet_WebEvent_Events;
            }
        }

        public lkpStatusCollection  lklStatusCollection
        {
            get
            {
                if (null == _lkpStatus )
                    _lkpStatus = new lkpStatusCollection((ECCMS)this);
                return _lkpStatus;
            }
        }

		/// <summary>
		/// Begins a new database transaction.
		/// </summary>
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction()
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction();
			return _transaction;
		}

		/// <summary>
		/// Begins a new database transaction with the specified 
		/// transaction isolation level.
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		/// <param name="isolationLevel">The transaction isolation level.</param>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction(isolationLevel);
			return _transaction;
		}

		/// <summary>
		/// Commits the current database transaction.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		public void CommitTransaction()
		{
			CheckTransactionState(true);
			_transaction.Commit();
			_transaction = null;
		}

		/// <summary>
		/// Rolls back the current transaction from a pending state.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="CommitTransaction"/>
		/// </summary>
		public void RollbackTransaction()
		{
			CheckTransactionState(true);
			_transaction.Rollback();
			_transaction = null;
		}

		// Checks the state of the current transaction
		private void CheckTransactionState(bool mustBeOpen)
		{
			if(mustBeOpen)
			{
				if(null == _transaction)
					throw new InvalidOperationException("Transaction is not open.");
			}
			else
			{
				if(null != _transaction)
					throw new InvalidOperationException("Transaction is already open.");
			}
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText)
		{
			return CreateCommand(sqlText, false);
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <param name="procedure">Specifies whether the sqlText parameter is 
		/// the name of a stored procedure.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText, bool procedure)
		{
			IDbCommand cmd = _connection.CreateCommand();
			cmd.CommandText = sqlText;
			cmd.Transaction = _transaction;
			if(procedure)
				cmd.CommandType = CommandType.StoredProcedure;
			return cmd;
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// An application can call the <c>Close</c> method more than
		/// one time without generating an exception.
		/// </summary>
		public virtual void Close()
		{
			if(null != _connection)
				_connection.Close();
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// </summary>
		public virtual void Dispose()
		{
			Close();
			if(null != _connection)
				_connection.Dispose();
		}
	} // End of ECCMS_Base class
} // End of namespace

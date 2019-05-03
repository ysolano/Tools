namespace FactoryDataService
{
    using System.Data;
    using System.Data.Odbc;
    using Interfaces;

    public class OdbcDataAccess : IDatabaseHandler
    {
        #region Attributes

        string ConnectionString { get; set; }

        #endregion

        #region Public Methods

        public OdbcDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new OdbcConnection(ConnectionString);
        }

        public void CloseConnection(IDbConnection connection)
        {
            var odbcConnection = (OdbcConnection)connection;
            odbcConnection.Close();
            odbcConnection.Dispose();
        }

        public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
        {
            return new OdbcCommand
            {
                CommandText = commandText,
                Connection = (OdbcConnection)connection,
                CommandType = commandType
            };
        }

        public IDataAdapter CreateAdapter(IDbCommand command)
        {
            return new OdbcDataAdapter((OdbcCommand)command);
        }

        public IDbDataParameter CreateParameter(IDbCommand command)
        {
            var SQLcommand = (OdbcCommand)command;
            return SQLcommand.CreateParameter();
        } 

        #endregion
    }
}

namespace FactoryDataService
{
    using System.Data;
    using System.Data.OracleClient;
    using FactoryDataService.Interfaces;

    public class OracleDataAccess : IDatabaseHandler
    {
        #region Attributes

        string ConnectionString { get; set; }

        #endregion

        #region Public Methods

        public OracleDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection(ConnectionString);
        }

        public void CloseConnection(IDbConnection connection)
        {
            var oracleConnection = (OracleConnection)connection;
            oracleConnection.Close();
            oracleConnection.Dispose();
        }

        public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
        {
            return new OracleCommand
            {
                CommandText = commandText,
                Connection = (OracleConnection)connection,
                CommandType = commandType
            };
        }

        public IDataAdapter CreateAdapter(IDbCommand command)
        {
            return new OracleDataAdapter((OracleCommand)command);
        }

        public IDbDataParameter CreateParameter(IDbCommand command)
        {
            var SQLcommand = (OracleCommand)command;
            return SQLcommand.CreateParameter();
        } 

        #endregion
    }
}

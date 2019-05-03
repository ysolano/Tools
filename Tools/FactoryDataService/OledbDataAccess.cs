namespace FactoryDataService
{
    using System.Data;
    using System.Data.OleDb;
    using Interfaces;

    public class OledbDataAccess : IDatabaseHandler
    {
        #region Attributes

        string ConnectionString { get; set; }

        #endregion

        #region Public Methods

        public OledbDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        public void CloseConnection(IDbConnection connection)
        {
            var oleDbConnection = (OleDbConnection)connection;
            oleDbConnection.Close();
            oleDbConnection.Dispose();
        }

        public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
        {
            return new OleDbCommand
            {
                CommandText = commandText,
                Connection = (OleDbConnection)connection,
                CommandType = commandType
            };
        }

        public IDataAdapter CreateAdapter(IDbCommand command)
        {
            return new OleDbDataAdapter((OleDbCommand)command);
        }

        public IDbDataParameter CreateParameter(IDbCommand command)
        {
            var SQLcommand = (OleDbCommand)command;
            return SQLcommand.CreateParameter();
        } 

        #endregion
    }
}

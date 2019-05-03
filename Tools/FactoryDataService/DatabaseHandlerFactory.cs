namespace FactoryDataService
{
    using System.Configuration;
    using Interfaces;

    public class DatabaseHandlerFactory
    {
        #region Attributes

        ConnectionStringSettings connectionStringSettings;

        #endregion

        #region Constructors

        public DatabaseHandlerFactory(string connectionStringName)
        {
            connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringName];
        } 

        #endregion

        #region Public Methods

        public IDatabaseHandler CreateDatabase()
        {
            IDatabaseHandler database = null;

            switch (connectionStringSettings.ProviderName.ToLower())
            {
                case "system.data.sqlclient":
                    database = new SqlDataAccess(connectionStringSettings.ConnectionString);
                    break;
                case "system.data.oracleclient":
                    database = new OracleDataAccess(connectionStringSettings.ConnectionString);
                    break;
                case "system.data.oleDb":
                    database = new OledbDataAccess(connectionStringSettings.ConnectionString);
                    break;
                case "system.data.odbc":
                    database = new OdbcDataAccess(connectionStringSettings.ConnectionString);
                    break;
            }

            return database;
        }

        public string GetProviderName()
        {
            return connectionStringSettings.ProviderName;
        } 

        #endregion
    }
}

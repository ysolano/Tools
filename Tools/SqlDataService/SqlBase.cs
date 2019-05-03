namespace SqlDataService
{
    using System.Configuration;
    using System.Data.SqlClient;

    public class SqlBase
    {
        #region Properties

        public SqlHelper sqlHelper = null;

        public SqlConnection connection = null;

        #endregion

        #region Constructors

        public SqlBase()
        {
            sqlHelper = new SqlHelper(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());
        }

        #endregion

        #region Public Methods

        public void CloseConnection()
        {
            sqlHelper.CloseConnection(connection);
        } 

        #endregion
    }
}

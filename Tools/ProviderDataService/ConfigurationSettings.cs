namespace ProviderDataService
{
    using System;
    using System.Configuration;

    internal static class ConfigurationSettings
    {
        #region Properties

        public static string DefaultConnection => ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public static string ProviderName => ConfigurationManager.ConnectionStrings[DefaultConnection].ProviderName;

        public static string ConnectionString
        {
            get
            {
                try
                {
                    return ConfigurationManager.ConnectionStrings[DefaultConnection].ConnectionString;
                }
                catch (Exception)
                {

                    throw new Exception($"Connection string '{DefaultConnection}' not found.");
                }
            }
        }

        #endregion

        #region Static Methods

        public static string GetConnectionString(string connectionName)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            }
            catch (Exception)
            {

                throw new Exception($"Connection string '{connectionName}' not found.");
            }
        }

        public static string GetProviderName(string connectionName)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[connectionName].ProviderName;
            }
            catch (Exception)
            {

                throw new Exception($"Connection string '{connectionName}' not found.");
            }
        }

        #endregion
    }
}

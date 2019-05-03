namespace ProviderDataService
{
    using System.Data.Common;

    public class ProviderManager
    {
        #region Property

        public string ProviderName { get; set; }

        public DbProviderFactory Factory => DbProviderFactories.GetFactory(ProviderName);

        #endregion

        #region Constructor

        public ProviderManager()
        {
            ProviderName = ConfigurationSettings.GetProviderName(ConfigurationSettings.DefaultConnection);
        }

        public ProviderManager(string providerName)
        {
            ProviderName = providerName;
        }

        #endregion
    }
}

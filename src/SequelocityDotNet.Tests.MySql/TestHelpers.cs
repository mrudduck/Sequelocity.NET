﻿namespace SequelocityDotNet.Tests.MySql
{
    public class TestHelpers
    {
        public static void ClearDefaultConfigurationSettings()
        {
            Sequelocity.ConfigurationSettings.Default.ConnectionString = null;
            Sequelocity.ConfigurationSettings.Default.ConnectionStringName = null;
            Sequelocity.ConfigurationSettings.Default.DbProviderFactoryInvariantName = null;
        }
    }
}
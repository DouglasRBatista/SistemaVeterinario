using System.Configuration;
using System.Windows.Forms;

namespace VetSysControl.Configuracao
{
    public class ConfigSettings
    {
        public string GetConfiguration(string KeyField)
        {
            return ConfigurationManager.AppSettings[KeyField];
        }

        public void SetConfigurarion(string KeyField, string KeyValue) 
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add(KeyField, KeyValue);
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}

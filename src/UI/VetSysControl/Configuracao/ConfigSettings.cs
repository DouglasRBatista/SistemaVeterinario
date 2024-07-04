using System.Configuration;
using System.Windows.Forms;

namespace VetSysControl.Configuracao
{
    public class ConfigSettings
    {
        public string GetAppSettingsConfig(string KeyField)
        {
            return ConfigurationManager.AppSettings[KeyField];
        }

        public void SetAppSettingsConfig(string KeyField, string KeyValue) 
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add(KeyField, KeyValue);
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}

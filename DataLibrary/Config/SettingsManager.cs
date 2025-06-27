using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataLibrary.Config
{
    public class SettingsManager
    {
        public static readonly string SettingsFilePath = Path.GetFullPath(Path.Combine("..", "..", "..", "usersettings.json")
            
        );

        public static void SaveSettings(UserSettings settings)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(SettingsFilePath)!);
            var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(SettingsFilePath, json);
        }

        public static UserSettings? LoadSettings()
        {
            if (!File.Exists(SettingsFilePath))
                return null;

            var json = File.ReadAllText(SettingsFilePath);
            return JsonSerializer.Deserialize<UserSettings>(json);
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glScrSaver1
{
    public static class AppSettings
    {
        private const string RegistryPath = "Software\\MyScreenSaver";

        public static double RotationSpeedX
        {
            get => GetRegistryValue("RotationSpeedX", 0.2); 
            set => SetRegistryValue("RotationSpeedX", value);
        }

        public static double ScaleFactor
        {
            get => GetRegistryValue("ScaleFactor", 0.5); 
            set => SetRegistryValue("ScaleFactor", value);
        }

        private static double GetRegistryValue(string key, double defaultValue)
        {
            using (var regKey = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (regKey?.GetValue(key) is string valueStr && double.TryParse(valueStr, out double value))
                {
                    return value;
                }
                return defaultValue;
            }
        }

        private static void SetRegistryValue(string key, double value)
        {
            using (var regKey = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                regKey?.SetValue(key, value.ToString());
            }
        }
    }
}

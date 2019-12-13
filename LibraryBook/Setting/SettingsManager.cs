using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryBook.Setting
{
    class SettingsManager:ISettingsManager
    {
        public Settings GetSettings()
        {
            var fail = File.ReadAllText(Const.SettingsPath);

            Settings s = JsonConvert.DeserializeObject<Settings>(fail);
            return s;

        }
    }
}

using Exiled.API.Interfaces;
using Utf8Json.Resolvers.Internal;

namespace SCPHealonkill
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        
        public int SCP049_Healonkill { get; set; } = 100;
        public int SCP096_Healonkill { get; set; } = 100;
        public int SCP173_Healonkill { get; set; } = 100;
        public int SCP106_Healonkill { get; set; } = 100;
        public int SCP3114_Healonkill { get; set; } = 100;
        public int SCP939_Healonkill { get; set; } = 100;
    }
}
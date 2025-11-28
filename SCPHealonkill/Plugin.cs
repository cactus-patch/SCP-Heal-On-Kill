using System;
using Exiled.API.Features;

namespace SCPHealonkill
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "Cactus-Patch";
        public override string Name => "SCP Heal on kill";
        public override string Author => "Noobest1001";
        public override Version Version => new(1, 0, 0);
        public override Version RequiredExiledVersion => new(9, 6, 0);
        public static Plugin? Instance;
        
        private static EventHandlers _eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            _eventHandlers = new EventHandlers(this);
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            
            _eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
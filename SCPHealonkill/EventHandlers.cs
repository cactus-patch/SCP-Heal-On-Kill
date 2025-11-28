using UnityEngine;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace SCPHealonkill
{
    public class EventHandlers(Plugin instance)
    {
        public void OnPlayerDied(DiedEventArgs ev)
        {
            if (ev.Attacker.IsScp)
            {
                // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
                switch (ev.Attacker.Role.Type)
                {
                    case RoleTypeId.Scp049:
                        ev.Attacker.Heal(instance.Config.SCP049_Healonkill);
                        break;
                    case RoleTypeId.Scp173:
                        ev.Attacker.Heal(instance.Config.SCP173_Healonkill);
                        break;
                    case RoleTypeId.Scp106:
                        ev.Attacker.Heal(instance.Config.SCP106_Healonkill);
                        break;
                    case RoleTypeId.Scp096:
                        ev.Attacker.Heal(instance.Config.SCP096_Healonkill);
                        break;
                    case RoleTypeId.Scp939:
                        ev.Attacker.Heal(instance.Config.SCP939_Healonkill);
                        break;
                    case RoleTypeId.Scp3114:
                        ev.Attacker.Heal(instance.Config.SCP3114_Healonkill);
                        break;
                    default:
                        Log.Debug("Hi");
                        break;
                }
            }
            else
            {
                if (ev.Ragdoll.Position.y <= -200f)
                {   
                    ev.Attacker.Heal(instance.Config.SCP106_Healonkill);
                }
            }
        }
    }
}
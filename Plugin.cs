using Rocket.Core.Plugins;
using Rocket.Unturned.Extensions;
using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;
using SDG.Unturned;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Rocket.Unturned.Events.UnturnedPlayerEvents;

namespace Stamina
{
    public class Plugin : RocketPlugin<Config>
    {
        public void FixedUpdate()
        {
            foreach (var stpl in Provider.clients)
            {
                UnturnedPlayer uplayer = stpl.ToUnturnedPlayer();
                uplayer.SetSkillLevel(UnturnedSkill.Exercise, 50);
            }
        }
    }
  
}

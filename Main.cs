using Rocket.API;
using Rocket.API.Collections;
using Rocket.API.Serialisation;
using Rocket.Core;
using Rocket.Core.Commands;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Enumerations;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;
using SDG.Framework.UI.Devkit;
using SDG.Unturned;
using Steamworks;

namespace StaminaUnturned
{
    public class Main : RocketPlugin<Config>
    {
        public static Main Instance;

        protected override void Load()
        {
            Instance = this;

            UnturnedPlayerEvents.OnPlayerUpdateStamina += OnPlayerUpdateStamina;
        }

        private void OnPlayerUpdateStamina(UnturnedPlayer player, byte stamina)
        {
            //nigga pls don't rape me with 70%
            if (stamina < 70)
            {
                player.Player.life.serverModifyStamina(100);
            }
        }

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerUpdateStamina -= OnPlayerUpdateStamina;
        }
    }
}

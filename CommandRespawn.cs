using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;

namespace RespawnMe
{
    public class CommandRespawn : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "respawn";

        public string Help => "Respawn a player";

        public string Syntax => "/respawn [<player>]";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "respawnme.respawn" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer targetPlayer = UnturnedPlayer.FromName(command[0]);

            if (targetPlayer == null)
            {
                // Player doesn't exist
                UnturnedChat.Say(caller, Main.Instance.Translate("player_not_online"));
                return;
            }

            targetPlayer.Player.life.askRespawn(targetPlayer.CSteamID, false);
        }
    }
}

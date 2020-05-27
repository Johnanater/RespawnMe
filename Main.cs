using Rocket.API.Collections;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace RespawnMe
{
    public class Main : RocketPlugin<Configuration>
    {
        public static Main Instance;
        public static Configuration Config;
        public const string Version = "1.0.0";

        protected override void Load()
        {
            Instance = this;
            Config = Configuration.Instance;

            Logger.Log($"RespawnMe by Johnanater, version: {Version}");
        }

        protected override void Unload()
        {
            Instance = null;
        }

        public override TranslationList DefaultTranslations => new TranslationList
        {
            {"player_not_online", "That player is not online!"},
        };
    }
}

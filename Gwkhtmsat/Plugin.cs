using System;
using Exiled;
using Exiled.API;
using Exiled.API.Features;

namespace Gwkhtmsat
{
	public class Plugin : Plugin<Configs>
	{
		public EventHandlers EventHandlers;

		public override string Author { get; } = "Dark7eamplar#2683";

		public override string Name { get; } = "Gwkhtmsat";

		public override string Prefix { get; } = "GT";

		public override Version Version { get; } = new Version(2, 0, 0);

		public override Version RequiredExiledVersion { get; } = new Version(2, 0, 0);

		public override Exiled.API.Enums.PluginPriority Priority { get; } = Exiled.API.Enums.PluginPriority.Medium;

		public override void OnEnabled()
		{
			try
			{
				if (!Config.IsEnabled)
				{
					Log.Info("Gwkhtmsat is disabled by config setting");
					return;
				}
				EventHandlers = new EventHandlers(this);
				Exiled.Events.Handlers.Server.WaitingForPlayers += EventHandlers.WaitingForPlayers;
				Log.Info($"Gwkhtmsat loaded");
			}
			catch (Exception e)
			{
				Log.Error($"There was an error loading the plugin: {e}");
			}
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Server.WaitingForPlayers -= EventHandlers.WaitingForPlayers;
			EventHandlers = null;
		}

		public override void OnReloaded()
		{
		}
	}
}
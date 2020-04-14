using System;
using EXILED;

namespace Gwkhtmsat
{
	public class Plugin : EXILED.Plugin
	{
		public EventHandlers EventHandlers;

		public override string getName { get; } = "Gwkhtmsat";

		internal const string pluginVersion = "1.0";

		internal const string pluginPrefix = "gwkhtmsat";

		public override void OnEnable()
		{
			try
			{
				Configs.Reload();
				if (Configs.disabled)
				{
					Log.Info("Gwkhtmsat is disabled by config setting");
					return;
				}
				Log.Debug("Initializing event handlers..");
				EventHandlers = new EventHandlers(this);
				Events.WaitingForPlayersEvent += EventHandlers.WaitingForPlayers;
				Log.Info($"Gwkhtmsat loaded");
			}
			catch (Exception e)
			{
				Log.Error($"There was an error loading the plugin: {e}");
			}
		}

		public override void OnDisable()
		{
			Events.WaitingForPlayersEvent -= EventHandlers.WaitingForPlayers;
			EventHandlers = null;
		}

		public override void OnReload()
		{
		}
	}
}
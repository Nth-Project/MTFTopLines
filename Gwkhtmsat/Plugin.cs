using Respawning;
using Respawning.NamingRules;
using Exiled.API.Features;

namespace Gwkhtmsat
{
	public class Plugin : Plugin<Configs>
	{
		public override string Author { get; } = "ggpabuk (original by Dark7eamplar#2683)";
		public override string Name { get; } = "MTFTopLines";
		public override string Prefix { get; } = "MTL (NTL)";
		public override Exiled.API.Enums.PluginPriority Priority { get; } = Exiled.API.Enums.PluginPriority.Lowest;

		public void WaitingForPlayers()
		{
			foreach (var line in Config.Lines)
			{
				SyncUnit mtfUnit = new SyncUnit
				{
					SpawnableTeam = (byte)SpawnableTeamType.NineTailedFox,
					UnitName = line
				};
				RespawnManager.Singleton.NamingManager.AllUnitNames.Add(mtfUnit);
			}
		}

		public override void OnEnabled()
		{
			Exiled.Events.Handlers.Server.WaitingForPlayers += this.WaitingForPlayers;
			Log.Info($"Gwkhtmsat loaded");
		}

		public override void OnDisabled()
		{
			Exiled.Events.Handlers.Server.WaitingForPlayers -= this.WaitingForPlayers;
		}
	}
}
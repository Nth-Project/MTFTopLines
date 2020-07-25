using Respawning;
using Respawning.NamingRules;

namespace Gwkhtmsat
{
	public class EventHandlers
	{
		public Plugin plugin;

		public EventHandlers(Plugin plugin) => this.plugin = plugin;

		public void WaitingForPlayers()
		{
			if (!plugin.Config.IsEnabled)
			{
				return;
			}
			foreach (var text in plugin.Config.Lines)
			{
				SyncUnit mtfUnit = new SyncUnit
				{
					SpawnableTeam = (byte)SpawnableTeamType.NineTailedFox,
					UnitName = text
				};
				RespawnManager.Singleton.NamingManager.AllUnitNames.Add(mtfUnit);
			}
		}
	}
}
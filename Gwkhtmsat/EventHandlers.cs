namespace Gwkhtmsat
{
	public class EventHandlers
	{
		public Plugin plugin;

		public EventHandlers(Plugin plugin) => this.plugin = plugin;

		public void WaitingForPlayers()
		{
			Configs.Reload();
			if (Configs.disabled)
			{
				return;
			}
			NineTailedFoxUnits ntfUnits = PlayerManager.localPlayer.GetComponent<NineTailedFoxUnits>();
			foreach (var message in Configs.lines)
			{
				ntfUnits.AddUnit(message);
			}
		}
	}
}
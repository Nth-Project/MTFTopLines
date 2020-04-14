namespace Gwkhtmsat
{
    internal static class Configs
    {
        internal static bool disabled = false;

        internal static int linesCount = 0;

        internal static string[] lines = new string[0];

        internal static void Reload()
        {
            disabled = Plugin.Config.GetBool($"{Plugin.pluginPrefix}_disable", false);
            if (disabled)
            {
                return;
            }
            linesCount = Plugin.Config.GetInt($"{Plugin.pluginPrefix}_linescount", 0);
            lines = new string[linesCount];
            for (int i = 0; i < linesCount; i++)
            {
                lines[i] = Plugin.Config.GetString($"{Plugin.pluginPrefix}_line_{i + 1}", string.Empty);
            }
        }
    }
}

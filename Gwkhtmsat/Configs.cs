using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace Gwkhtmsat
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public List<string> Lines { get; set; } = new List<string>();
    }
}

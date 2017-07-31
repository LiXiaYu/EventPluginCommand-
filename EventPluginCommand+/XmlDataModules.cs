using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPluginCommand_
{
    class PluginModule
    {
        public string name = "";
        public string text = "";
        public string note = "";
        public List<CommandModule> content = new List<CommandModule>();
    }
    class CommandModule
    {
        public string name = "";
        public string text = "";
        public string note = "";
        public List<ParameterModule> content = new List<ParameterModule>();
    }
    class ParameterModule
    {
        public string name = "";
        public string note = "";
        public string content = "";
    }
}

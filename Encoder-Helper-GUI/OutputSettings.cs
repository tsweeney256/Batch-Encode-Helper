using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder_Helper_GUI
{
    [Serializable]
    class OutputSettings : Settings
    {
        public string FileName { get; set; }

        public OutputSettings() { }
        public OutputSettings(Settings settings) : base(settings) { }
    }
}

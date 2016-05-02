using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHelper.Model
{
    [Serializable]
    public class Record
    {
        public List<KeyShortcut> Shortcuts { get; set; }
        public RichContent Content { get; set; }
    }
}

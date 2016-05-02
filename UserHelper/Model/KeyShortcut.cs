using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserHelper.Model
{
    [Serializable]
    public class KeyShortcut
    {
        public string Action { get; set; }
        public HashSet<Keys> Keys { get; set; }
    }
}

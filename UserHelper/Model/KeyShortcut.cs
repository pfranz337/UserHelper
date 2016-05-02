using System;
using System.Collections.Generic;

namespace UserHelper.Model
{
    [Serializable]
    public class KeyShortcut
    {
        public string Action { get; set; }
        public List<string> Keys { get; set; }
    }
}

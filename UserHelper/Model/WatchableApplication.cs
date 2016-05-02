using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace UserHelper.Model
{
    [Serializable]
    public class WatchableApplication
    {
        public string Name { get; set; }
        public string ExeLocation { get; set; }
        [XmlIgnoreAttribute]
        public List<Record> Records { get; set; }
    }
}

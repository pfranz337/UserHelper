using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace UserHelper.Model
{
    [Serializable]
    public class WatchableApplication
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public string ExeLocation { get; set; }
        [XmlIgnore]
        public Record RecordContent { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

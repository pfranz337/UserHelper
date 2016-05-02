using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHelper
{
    [Serializable()]
    public class HelperData
    {

        public string NAME_PROG { get; set; }
        public string DESC_PROG { get; set; }
        public Dictionary<string, string> ZKRATKY { get; set; }
        public bool ON_OFF_HELPER { get; set; }
        public PPP ppp { get; set; }

        public HelperData() { }

        public void setFromFile() {
        }

        public void saveToFile() {      //serializace celeho objektu - to by se asi melo delat v mainu ne? stejne jako deserializace - nacteni ze souboru
        }

        public void setFromApp() {      
        }
    }

    [Serializable()]
    public class PPP
    {
        public string NAME { get; set; }
        public string DESC { get; set; }
        public List<string> POSTUP { get; set; }
    }
}

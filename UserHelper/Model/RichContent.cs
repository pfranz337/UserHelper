using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHelper.Model
{
    [Serializable]
    public class RichContent
    {
        public string Language { get; set; }
        public string Text { get; set; }
    }
}

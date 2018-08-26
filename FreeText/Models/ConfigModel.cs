using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeText.Models
{
    public class ConfigModel
    {
        public Uri FreeTextUrl { get; set; }
        public Uri FreeTextApiUrl { get; set; }
        public string ApplicationName { get; set; }
    }
}

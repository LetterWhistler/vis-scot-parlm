using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualScotParliament.Common
{
   /// <summary>
   /// This represents a member of Scottish Parliament
   /// </summary>
    public class MSP
    {
        public string MemberId { get; set; }
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string Party { get; set; }
        public string Constitueny { get; set; }
    }
}

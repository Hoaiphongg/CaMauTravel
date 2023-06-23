using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaMauTravel.Common
{
    [Serializable]
    public class ClientLogin
    {
        public long Account_ID { get; set; }
        public string UserName { get; set; }
    }
}
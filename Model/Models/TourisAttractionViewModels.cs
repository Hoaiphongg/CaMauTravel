using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class TourisAttractionViewModels
    {
        public long ID { set; get; }
        public string Images { set; get; }
        public string Name { set; get; }
        public string CateName { set; get; }
        public string CateMetaTitle { set; get; }
        public string MetaTitle { set; get; }
        public DateTime? CreatedDate
        {
            set; get;
        }
    }
}

using System;

namespace QuangNhaDat.Core.Common
{
    public class BaseModel
    {
        public int ID { get; set; }
        public string MetaTitel { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool TopHot { get; set; }
        public bool ShowOnHome { get; set; }
        public string SeoTitel { get; set; }
    }
}

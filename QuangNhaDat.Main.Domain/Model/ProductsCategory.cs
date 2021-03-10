using QuangNhaDat.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuangNhaDat.Main.Domain.Model
{
    public class ProductsCategory:BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Acreages { get; set; }
        public decimal Prices { get; set; }
        public int ViewCount { get; set; }
        public int DisplayOrder { get; set; }
        public int ParentID { get; set; }
    }
}

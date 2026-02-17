using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalWebsite.Doamin.Common
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public bool isDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}

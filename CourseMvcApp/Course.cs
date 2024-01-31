using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMvcApp
{
    public class Course
    {
        public int Cid { get; set; }
        public string CName { get; set; }
        public float CFee { get; set; }
        public string Technology { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
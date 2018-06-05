using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data
{

    public class PlanDetail
    {
        public string expand { get; set; }
        public Link link { get; set; }
        public Plans plans { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string rel { get; set; }
    }

    public class Plans
    {
        public int size { get; set; }
        public string expand { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
        public Plan[] plan { get; set; }
    }

    public class Plan
    {
        public string shortName { get; set; }
        public string shortKey { get; set; }
        public string type { get; set; }
        public bool enabled { get; set; }
        public Link1 link { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public Plankey planKey { get; set; }
    }

    public class Link1
    {
        public string href { get; set; }
        public string rel { get; set; }
    }

    public class Plankey
    {
        public string key { get; set; }
    }

}

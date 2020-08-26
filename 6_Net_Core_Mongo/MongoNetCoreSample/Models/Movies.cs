using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{

    public class Movies
    {
        public string _id { get; set; }
        public GrossRevenue gross_revenue { get; set; }
        public EstimatedBudget estimated_budget { get; set; }
        public string type { get; set; }
        public string[] genre { get; set; }
        public string[] directed_by { get; set; }
        public Starring[] starring { get; set; }
        public object[] tagline { get; set; }
        public string title { get; set; }
    }

    public class GrossRevenue
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class EstimatedBudget
    {
        public int amount { get; set; }
        public string currency { get; set; }
    }

    public class Starring
    {
        public string actor { get; set; }
    }




}

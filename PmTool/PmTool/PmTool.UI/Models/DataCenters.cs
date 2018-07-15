using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTool.UI.Models
{
    public class DataCenters
    {
        public int DataCenter_request_id { get; set; }

        public int? DataCenter_requestor_id { get; set; }

        public double? Square_footage { get; set; }

        public string DataCenter_name { get; set; }

        public int? Scope { get; set; }

        public int? Total_number_racks { get; set; }

        public int? Total_number_ports_per_rack { get; set; }

        public int? Total_number_copper_ports_per_racks { get; set; }

        public int? Total_number_fiber_ports_per_rack { get; set; }

        public int? Speed_connection { get; set; }

        public string Project_description { get; set; }

    }

}

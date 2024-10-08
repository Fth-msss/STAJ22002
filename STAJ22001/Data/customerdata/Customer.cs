﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAJ22001.Data.customerdata
{
    //database class
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        public string ServiceName { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Path { get; set; } = default!;
        public string? QueryString { get; set; }
        public string? RequestBody { get; set; }
        public string? Header { get; set; }
        public string? ResponseBody { get; set; }
        public int IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }

    }
}

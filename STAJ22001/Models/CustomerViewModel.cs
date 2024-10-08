﻿
namespace STAJ22001.Models
{
    //the purpose of this class is to be a bridge between the databasemodel and views
    //actual mapping is done in customer class
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Service { get; set; } = "";
        public string Type { get; set; } = "";
        public string Path { get; set; } = "";
        public string? Query { get; set; }
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

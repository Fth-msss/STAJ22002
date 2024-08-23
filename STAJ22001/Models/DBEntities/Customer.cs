using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAJ22001.Models
{
    public class Customer
    {
        //this is customerviewmodel
        //this is supposed to display data
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int CustomerId { get; set; }
        public string ServiceName { get; set; } = "";
        public string Type { get; set; } = "";
        public string Path { get; set; } = "";
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

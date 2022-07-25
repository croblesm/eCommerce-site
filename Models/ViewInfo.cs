using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    
    [Table("vwServerEndpoint", Schema="Admin")]
    public class ViewInfo
    {
        [Key]
        public string ServerEndpoint { get; set; }
    }
}
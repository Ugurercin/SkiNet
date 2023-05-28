using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStoreNet.Core.Entitites
{
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
    }       
}

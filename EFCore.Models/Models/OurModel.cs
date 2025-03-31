using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EFCore.Models.Models
{
    public class OurModel
    {

        public string Id { get; set; }
        //Add Range
        [Range(1, 10)]
        public string Title { get; set; }
        [Range(1, 20)]
        public string AuthorName { get; set; }
    }
}

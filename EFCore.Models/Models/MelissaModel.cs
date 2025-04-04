using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EFCore.Models
{
    public class MelissaModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string College { get; set; }

        public int Age { get; set; }
    }
}

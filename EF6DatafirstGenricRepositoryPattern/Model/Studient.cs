using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6DatafirstGenricRepositoryPattern.Model
{
    public class Studient
    {
        [Key]
        public int Id { get; set; }
        public string StudientName { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace TimeFutebol.Models
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
    }
}

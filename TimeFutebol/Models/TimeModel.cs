using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeFutebol.Models
{
    [Table("Time")]
    public class TimeModel
    {
        [Key]
        public int IdTime { get; set; }
        public string Name { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }

        public ICollection<JogadorModel> Jogador { get; set; }
    }
}

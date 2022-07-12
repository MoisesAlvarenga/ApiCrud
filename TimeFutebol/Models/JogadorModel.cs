using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Data;
using TimeFutebol.Interface;

namespace TimeFutebol.Models
{
    [Table("Jogador")]
    public class JogadorModel 
    {
        [Key]
        public int IdJogador { get; set; }
        public string Nome { get; set; }

        
        public int Camisa { get; set; }
        public string Posicao { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public int TimeFK { get; set; }


       [ForeignKey("TimeFK")]
       public  TimeModel Time { get; set; }

    }
}

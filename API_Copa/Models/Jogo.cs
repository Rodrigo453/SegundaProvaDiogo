using System;
using System.ComponentModel.DataAnnotations;

namespace API_Copa.Models
{
    public class Jogo
    {
        
        public Jogo()
        {
            // SelecaoA = new Selecao();
            // SelecaoB = new Selecao();
            CriadoEm = DateTime.Now;

        }

        public int Id { get; set; }
        public Selecao SelecaoA { get; set; }
        public int SelecaoA_Id {get; set;}
        public Selecao SelecaoB { get; set; }

        public int SelecaoB_Id {get; set;}
        // public Selecao valorA { get; set; }

        // public Selecao valorB { get; set; }
        public DateTime CriadoEm { get; set; }

        

    }
}

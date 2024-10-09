using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevisaoMeteorologica.Models
{
    internal class Previsao
    {
        private String Cidade { get; set; }
        private String Estado { get; set; }
        private String Atualizado { get; set; }

        public class Clima() {

            private String Data { get; set; }
            private String Condicao { get; set; }
            private int Min { get; set; }
            private int Max { get; set; } 
            private int Indice { get; set; }
            private String Descricao { get; set; }
        
        }
    }
}
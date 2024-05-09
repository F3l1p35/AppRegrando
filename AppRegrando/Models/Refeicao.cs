using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRegrando.Models.Enuns;

namespace AppRegrando.Models
{
    public class Refeicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Calorias { get; set; }
        public int Proteinas { get; set; }
        public int Carboidratos { get; set; }
        public int Gorduras { get; set; }
        public int ValorNutricional { get; set; }

    }
}

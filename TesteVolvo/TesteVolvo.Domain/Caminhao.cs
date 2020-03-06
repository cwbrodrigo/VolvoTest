using System;
using System.Collections.Generic;
using System.Text;

namespace TesteVolvo.Domain
{
    public class Caminhao : BaseEntity
    {
        public string Nome { get; set; }
        public Modelo Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
    }
}

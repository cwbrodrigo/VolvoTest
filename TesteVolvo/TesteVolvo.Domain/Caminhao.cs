using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteVolvo.Domain
{
    public class Caminhao : BaseEntity
    {

        [Required(ErrorMessage = "Informe o nome do caminhão")]
        public string Nome { get; set; }
        public Modelo Modelo { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
    }
}

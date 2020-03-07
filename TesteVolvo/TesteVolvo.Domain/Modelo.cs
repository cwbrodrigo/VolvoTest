using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteVolvo.Domain
{
    public enum Modelo
    {
        [Display(Name = "FH")]
        FH = 1,
        [Display(Name = "FM")]
        FM = 2
    }
}

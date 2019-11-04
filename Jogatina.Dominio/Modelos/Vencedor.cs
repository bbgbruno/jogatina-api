using System;
using System.Collections.Generic;
using System.Text;

namespace Jogatina.Dominio.Modelos
{
    public class Vencedor
    {
        public Guid ID { get; set; }
        virtual public Jogador Jogador { get; set; }
    }
}

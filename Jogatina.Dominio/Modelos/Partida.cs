using System;
using System.Collections.Generic;
using System.Text;

namespace Jogatina.Dominio.Modelos
{
    
    public class Partida
    {
        public Guid ID { get; set; }
        virtual public Jogo Jogo { get; set; }
        virtual public IEnumerable<Vencedor> Vencedores { get; set; }
    }
}

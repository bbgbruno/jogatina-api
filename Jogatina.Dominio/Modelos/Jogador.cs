﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jogatina.Dominio.Modelos
{
    public class Jogador
    {
        public Guid JogadorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UrlFoto { get; set; }
        public string Senha { get; set; }
    }
}

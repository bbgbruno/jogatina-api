using Jogatina.Dominio.Modelos;
using Jogatina.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jogatina.Repositorio.Repositorio
{
    public class JogadorRepositorio : BaseRepositorio<Jogador>, IJogadorRepositorio
    {
        public JogadorRepositorio(string stringConnect) : base(stringConnect)
        {
        }

        public override void Atualizar(Jogador item)
        {
            throw new NotImplementedException();
        }

        public override Jogador BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Jogador> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public override void Incluir(Jogador model)
        {
            throw new NotImplementedException();
        }

        public override void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Jogatina.Repositorio.Repositorio
{
    public abstract class BaseRepositorio<T>
    {
         private string _connectionString;
        protected string ConnectionString => _connectionString;

        public BaseRepositorio(string stringConnect)
        {
            _connectionString = stringConnect;
        }

        public abstract void Incluir(T model);
        public abstract void Remove(int id);
        public abstract void Atualizar(T item);
        public abstract T BuscarPorId(Guid id);
        public abstract IEnumerable<T> BuscarTodos();
    }
}

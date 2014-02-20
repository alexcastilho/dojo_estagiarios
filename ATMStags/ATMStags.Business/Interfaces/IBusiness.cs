using System.Collections.Generic;

namespace ATMStags.Business.Interfaces
{
    public interface IBusiness<T>
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Remover(int id);
        T Buscar(int id);
        List<T> BuscarTodos();
    }
}
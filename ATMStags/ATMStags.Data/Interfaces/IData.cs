using System.Collections.Generic;
namespace ATMStags.Data.Interfaces
{
    public interface IData<T>
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Remover(T obj);
        T Buscar(int id);
        List<T> BuscarTodos();
    }
}
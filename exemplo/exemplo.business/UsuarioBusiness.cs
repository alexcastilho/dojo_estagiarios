using exemplo.data;
using exemplo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo.business
{
    public class UsuarioBusiness
    {
        public void Inserir(Usuario usuario)
        {
            try
            {
                UsuarioData data = new UsuarioData();
                data.Inserir(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> BuscarTodos()
        {
            try
            {
                UsuarioData data = new UsuarioData();
                return data.BuscarTodos();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Deletar(int id)
        {
            try
            {
                UsuarioData data = new UsuarioData();
                data.Deletar(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try
            {
                UsuarioData data = new UsuarioData();
                data.Atualizar(usuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

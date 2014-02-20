using exemplo.model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo.data
{
    public class UsuarioData
    {
        public void Inserir(Usuario usuario)
        {
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = @"INSERT INTO USUARIO (NOME,SOBRENOME,NASCIMENTO,RG) VALUES 
                            (@NOME,@SOBRENOME,@NASCIMENTO,@RG)
                            SET @ID = (@@IDENTITY)";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@NOME", System.Data.DbType.String, usuario.Nome);
                    db.AddInParameter(cmd, "@SOBRENOME", System.Data.DbType.String, usuario.Sobrenome);
                    db.AddInParameter(cmd, "@NASCIMENTO", System.Data.DbType.DateTime, usuario.Nascimento);
                    db.AddInParameter(cmd, "@RG", System.Data.DbType.String, usuario.Rg);
                    db.AddOutParameter(cmd, "@ID", System.Data.DbType.Int32, 4);

                    db.ExecuteNonQuery(cmd);

                    usuario.Id = (int)cmd.Parameters["@ID"].Value;
                }
            }
            catch (Exception)
            {
                //Logar o erro aqui..
                throw;
            }
        }

        public List<Usuario> BuscarTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = "SELECT ID,NOME,SOBRENOME,NASCIMENTO,RG FROM USUARIO";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(dr["ID"]);
                            usuario.Nome = Convert.ToString(dr["NOME"]);
                            usuario.Sobrenome = Convert.ToString(dr["SOBRENOME"]);
                            usuario.Rg = Convert.ToString(dr["RG"]);
                            usuario.Nascimento = Convert.ToDateTime(dr["NASCIMENTO"]);

                            listaUsuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return listaUsuarios;
        }

        public void Deletar(int id)
        {
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = "DELETE FROM USUARIO WHERE ID = @ID";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@ID", DbType.Int32, id);

                    db.ExecuteNonQuery(cmd);
                }
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
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = @"UPDATE USUARIO SET 
                            NOME = @NOME,
                            SOBRENOME = @SOBRENOME,
                            NASCIMENTO = @NASCIMENTO,
                            RG = @RG
                            WHERE ID = @ID";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@NOME", System.Data.DbType.String, usuario.Nome);
                    db.AddInParameter(cmd, "@SOBRENOME", System.Data.DbType.String, usuario.Sobrenome);
                    db.AddInParameter(cmd, "@NASCIMENTO", System.Data.DbType.DateTime, usuario.Nascimento);
                    db.AddInParameter(cmd, "@RG", System.Data.DbType.String, usuario.Rg);
                    db.AddInParameter(cmd, "@ID", System.Data.DbType.Int32, usuario.Id);

                    db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
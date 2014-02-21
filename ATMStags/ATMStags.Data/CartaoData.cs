using ATMStags.Data.Interfaces;
using ATMStags.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Data
{
    public class CartaoData : IData<CartaoModel>
    {
        public void Inserir(CartaoModel obj)
        {
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                String query = @"INSERT INTO CARTAO (DATAVALIDADE) VALUES (@DATAVALIDADE)
                                 SET @ID = (@@IDENTITY)";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@DATAVALIDADE", System.Data.DbType.DateTime, obj.DataValidade);
                    db.AddOutParameter(cmd, "@ID", System.Data.DbType.Int32, 4);
                    
                    db.ExecuteNonQuery(cmd);

                    obj.Id = (int)cmd.Parameters["@ID"].Value;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(CartaoModel obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(CartaoModel obj)
        {
            throw new NotImplementedException();
        }

        public CartaoModel Buscar(int Id)
        {
            CartaoModel cartao = null;

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                String query = @"SELECT ID,DATAVALIDADE FROM CARTAO WHERE ID=@ID";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@ID", System.Data.DbType.Int32, 4);
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            cartao = new CartaoModel();
                            cartao.Id = Convert.ToInt32(dr["ID"]);
                            cartao.DataValidade = Convert.ToDateTime(dr["DATAVALIDADE"]);
                        }
                    }
                }

                return cartao;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CartaoModel> BuscarTodos()
        {
            List<CartaoModel> cartoes = new List<CartaoModel>();

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                String query = "SELECT ID, DATAVALIDADE FROM CARTAO";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        while (dr.Read())
                        {
                            CartaoModel cartao = new CartaoModel();
                            cartao.Id = Convert.ToInt32(dr["ID"]);
                            cartao.DataValidade = Convert.ToDateTime(dr["DATAVALIDADE"]);
                            cartoes.Add(cartao);
                        }
                    }
                }

                return cartoes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
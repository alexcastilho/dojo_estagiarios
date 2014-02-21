using ATMStags.Data.Interfaces;
using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace ATMStags.Data
{
    public class ContaData : IData<ContaModel>
    {
        public void Inserir(ContaModel obj)
        {
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                string query = @"INSERT INTO CONTA (SALDO) VALUES (@SALDO)
                                SET @ID=(@@IDENTITY)";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@SALDO", System.Data.DbType.Double, obj.Saldo);
                    db.AddOutParameter(cmd, "@ID", System.Data.DbType.Int32, 4);
                    db.ExecuteNonQuery(cmd);
                    obj.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(ContaModel obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(ContaModel obj)
        {
            throw new NotImplementedException();
        }

        public ContaModel Buscar(int id)
        {
            ContaModel conta = null;

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = "SELECT ID,SALDO FROM CONTA WHERE ID = @ID";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@ID", System.Data.DbType.Int32, id);

                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            conta = new ContaModel();
                            conta.Id = Convert.ToInt32(dr["ID"]);
                            conta.Saldo = Convert.ToDouble(dr["SALDO"]);
                        }
                    }
                }

                return conta;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ContaModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
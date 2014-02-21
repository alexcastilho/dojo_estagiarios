using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using ATMStags.Model;
using ATMStags.Data.Interfaces;
using System.Data;

namespace ATMStags.Data
{
    public class ClienteData : IData<ClienteModel>
    {
        public void Inserir(Model.ClienteModel obj)
        {
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                String query = @"INSERT INTO CLIENTE (NOME, SOBRENOME, CPF, RG, IDADE, IDCONTA, IDCARTAO) 
                               VALUES (@NOME, @SOBRENOME, @CPF, @RG, @IDADE, @IDCONTA, @IDCARTAO) 
                               SET @ID=(@@IDENTITY)";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@NOME", System.Data.DbType.String, obj.Nome);
                    db.AddInParameter(cmd, "@SOBRENOME", System.Data.DbType.String, obj.Sobrenome);
                    db.AddInParameter(cmd, "@CPF", System.Data.DbType.String, obj.CPF);
                    db.AddInParameter(cmd, "@RG", System.Data.DbType.String, obj.RG);
                    db.AddInParameter(cmd, "@IDADE", System.Data.DbType.Int32, obj.Idade);
                    db.AddInParameter(cmd, "@IDCONTA", System.Data.DbType.Int32, obj.IdConta);
                    db.AddInParameter(cmd, "@IDCARTAO", System.Data.DbType.Int32, obj.IdCartao);
                    db.AddOutParameter(cmd, "@ID", System.Data.DbType.Int16, 4);

                    db.ExecuteNonQuery(cmd);

                    obj.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(ClienteModel obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(ClienteModel obj)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Buscar(int id)
        {
            ClienteModel cliente = null;

            try 
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = @" SELECT ID, NOME, SOBRENOME, CPF, RG, IDADE, IDCARTAO, IDCONTA
                                  FROM CLIENTE
                                  WHERE ID = @ID";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    db.AddInParameter(cmd, "@ID", DbType.Int32, id);
                    
                    using(IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            cliente = new ClienteModel();
                            cliente.Id = Convert.ToInt32(dr["ID"]);
                            cliente.Nome = Convert.ToString(dr["NOME"]);
                            cliente.Sobrenome = Convert.ToString(dr["SOBRENOME"]);
                            cliente.CPF = Convert.ToString(dr["CPF"]);
                            cliente.RG = Convert.ToString(dr["RG"]);
                            cliente.Idade = Convert.ToInt32(dr["IDADE"]);
                            cliente.IdCartao = Convert.ToInt32(dr["IDCARTAO"]);
                            cliente.IdConta = Convert.ToInt32(dr["IDCONTA"]);
                        }
                    }
                }

                return cliente;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<ClienteModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public List<ClienteInfoModel> BuscarTodasInformacoes()
        {
            List<ClienteInfoModel> listaClienteInfo = new List<ClienteInfoModel>();

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string query = @"SELECT CLI.ID, CLI.NOME,CLI.SOBRENOME, CLI.CPF, CLI.RG, CLI.IDADE, 
                                CAR.DATAVALIDADE, CLI.IDCARTAO, CON.SALDO, CLI.IdConta 
                                FROM CLIENTE CLI
                                INNER JOIN CARTAO CAR ON CLI.IDCARTAO = CAR.ID
                                INNER JOIN CONTA CON ON CON.ID = CLI.IDCONTA";

                using (DbCommand cmd = db.GetSqlStringCommand(query))
                {
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        while (dr.Read())
                        {
                            ClienteInfoModel clienteInfo = new ClienteInfoModel();
                            clienteInfo.Id = Convert.ToInt32(dr["ID"]);
                            clienteInfo.Nome = Convert.ToString(dr["NOME"]);
                            clienteInfo.Sobrenome = Convert.ToString(dr["SOBRENOME"]);
                            clienteInfo.CPF = Convert.ToString(dr["CPF"]);
                            clienteInfo.RG = Convert.ToString(dr["RG"]);
                            clienteInfo.Idade = Convert.ToInt32(dr["IDADE"]);
                            clienteInfo.DataValidadeCartao = Convert.ToDateTime(dr["DATAVALIDADE"]);
                            clienteInfo.IdCartao = Convert.ToInt32(dr["IDCARTAO"]);
                            clienteInfo.NumeroCartao = Convert.ToInt32(dr["IDCARTAO"]);
                            clienteInfo.Saldo = Convert.ToDouble(dr["SALDO"]);
                            clienteInfo.IdConta = Convert.ToInt32(dr["IDCONTA"]);                        

                            listaClienteInfo.Add(clienteInfo);
                        }
                    }
                }

                return listaClienteInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
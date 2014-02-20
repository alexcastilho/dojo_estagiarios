using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace ATMStags.Data
{
    public class ClienteData
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
    }
}

using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.Helpers;

namespace GVC.BLL
{
    internal class CidadeBLL
    {
        CidadeDal CidadeDal = null;
        // ************************LISTA USUARIO*********************************************
        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            
            try
            {
                CidadeDal = new CidadeDal();
                dtable = CidadeDal.Listar_Cidades();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(CidadeMODEL cidades)
        {
            try
            {
                CidadeDal = new CidadeDal();
                CidadeDal.Salvar(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(CidadeMODEL cidades)
        {
            try
            {
                CidadeDal = new  CidadeDal();
                CidadeDal.Excluir(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(CidadeMODEL cidades)
        {           
            try
            {
                CidadeDal = new CidadeDal();
                CidadeDal.Atualizar(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public CidadeMODEL Pesquisar(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqliteCommand sql = new SqliteCommand("SELECT * FROM Cidade WHERE Nome like '" + pesquisa + "%'", conn);
                conn.Open();
                SqliteDataReader datareader;
                CidadeMODEL obj_cidade = new CidadeMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_cidade.CidadeID = Convert.ToInt32(datareader["CidadeID"]);
                    obj_cidade.Nome = datareader["Nome"].ToString();
                }
                return obj_cidade;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

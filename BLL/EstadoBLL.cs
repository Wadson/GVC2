using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class EstadoBLL
    {
        EstadoDal estadoDal = null;
        // ************************LISTA USUARIO*********************************************
        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            
            try
            {
                estadoDal = new EstadoDal();
                dtable = estadoDal.Listar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(EstadoMODEL estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Salvar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(EstadoMODEL estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Excluir(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(EstadoMODEL estado)
        {
           
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Atualizar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public EstadoMODEL Pesquisar(string pesquisa)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                SqliteCommand sql = new SqliteCommand("SELECT CodigoUf, Nome, Uf FROM Estado WHERE Nome like '" + pesquisa + "%'", conn);
                conn.Open();
                SqliteDataReader datareader;
                EstadoMODEL obj_estado = new EstadoMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_estado.EstadoID = Convert.ToInt32(datareader["EstadoID"]);
                    obj_estado.Nome = datareader["Nome"].ToString();
                    obj_estado.UF = datareader["Uf"].ToString();
                }
                return obj_estado;
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

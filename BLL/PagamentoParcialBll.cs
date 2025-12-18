using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class PagamentoParcialBll
    {
        private PagamentoParcialDal _dal;

        PagamentoParcialDal pagamentoParcialDAL = null;
        public void Excluir(PagamentoParcialModel pagamentoParcial)
        {
            try
            {
                pagamentoParcialDAL = new PagamentoParcialDal();
                pagamentoParcialDAL.Excluir(pagamentoParcial);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public PagamentoParcialBll()
        {
            _dal = new PagamentoParcialDal();
        }


        public void RegistrarPagamentoParcial(PagamentoParcialModel pagamentoParcial)
        {
            // Lógica de negócios antes de inserir o pagamento parcial, se necessário
            _dal.InserirPagamentoParcial(pagamentoParcial);
        }

        public List<PagamentoParcialModel> ObterPagamentosParciaisPorParcela(int parcelaID)
        {
            // Lógica de negócios antes de obter os pagamentos parciais, se necessário
            return _dal.ObterPagamentosParciaisPorParcela(parcelaID);
        }
    }
}

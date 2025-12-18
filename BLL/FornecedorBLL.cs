using GVC.DALL;
using GVC.MODEL;
using GVC.MUI;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace GVC.BLL
{
    internal class FornecedorBll
    {
        private readonly FornecedorDal _dal = new FornecedorDal();

        // ==============================================================
        // 1. LISTAR TODOS OS FORNECEDORES
        // ==============================================================
        public DataTable Listar()
        {
            try
            {
                return _dal.ListarFornecedores();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar fornecedores: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 2. SALVAR NOVO FORNECEDOR
        // ==============================================================
        public void Salvar(FornecedorModel fornecedor)
        {
            try
            {
                ValidarFornecedor(fornecedor, isNovo: true);

                var cnpjLimpo = LimparCnpj(fornecedor.Cnpj);
                fornecedor.Cnpj = string.IsNullOrWhiteSpace(cnpjLimpo) ? null : cnpjLimpo;

                if (_dal.FornecedorExiste(fornecedor.Nome, fornecedor.Cnpj))
                    throw new Exception("Já existe um fornecedor cadastrado com este nome ou CNPJ.");

                if (_dal.BuscarPorCnpj(fornecedor.Cnpj) != null)
                    throw new Exception("Já existe um fornecedor cadastrado com este CNPJ.");

                fornecedor.DataCriacao = DateTime.Now;

                _dal.SalvarFornecedor(fornecedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar fornecedor: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 3. ALTERAR FORNECEDOR EXISTENTE
        // ==============================================================
        public void Alterar(FornecedorModel fornecedor)
        {
            try
            {
                if (fornecedor.FornecedorID <= 0)
                    throw new Exception("Fornecedor inválido para alteração.");

                ValidarFornecedor(fornecedor, isNovo: false);

                var cnpjLimpo = LimparCnpj(fornecedor.Cnpj);
                var existente = _dal.BuscarPorCnpj(cnpjLimpo);

                // Permite manter o mesmo CNPJ se for o próprio fornecedor
                if (existente != null && existente.FornecedorID != fornecedor.FornecedorID)
                    throw new Exception("Outro fornecedor já está cadastrado com este CNPJ.");

                fornecedor.DataCriacao ??= DateTime.Now;

                _dal.Atualizar(fornecedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar fornecedor: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 4. EXCLUIR FORNECEDOR
        // ==============================================================
        public void Excluir(int fornecedorId)
        {
            try
            {
                if (fornecedorId <= 0) throw new Exception("ID do fornecedor inválido.");
                _dal.ExcluirFornecedor(fornecedorId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir fornecedor: {ex.Message}", ex);
            }
        }
        public void Excluir(FornecedorModel fornecedor) => Excluir((int)fornecedor.FornecedorID);

        // ==============================================================
        // 5. PESQUISAS
        // ==============================================================
        public DataTable PesquisarPorNome(string nome)
        {
            try
            {
                return string.IsNullOrWhiteSpace(nome) ? Listar() : _dal.PesquisarPorNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa por nome: {ex.Message}", ex);
            }
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            try
            {
                return _dal.PesquisarPorCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa por código: {ex.Message}", ex);
            }
        }

        public DataTable PesquisarGeral(string texto)
        {
            try
            {
                return _dal.PesquisarGeral(texto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro na pesquisa geral: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 6. BUSCAR POR CNPJ
        // ==============================================================
        public FornecedorModel? BuscarPorCnpj(string cnpj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cnpj)) return null;

                cnpj = LimparCnpj(cnpj);
                if (!Utilitario.ValidarCNPJ(cnpj))
                    throw new Exception("CNPJ inválido.");

                return _dal.BuscarPorCnpj(cnpj);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar fornecedor por CNPJ: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 7. BUSCAR POR ID
        // ==============================================================
        public FornecedorModel? BuscarPorId(int id)
        {
            try
            {
                if (id <= 0) return null;
                return _dal.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar fornecedor por ID: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // VALIDAÇÕES DO FORNECEDOR
        // ==============================================================
        private void ValidarFornecedor(FornecedorModel f, bool isNovo)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            if (string.IsNullOrWhiteSpace(f.Nome))
                throw new Exception("Nome do fornecedor é obrigatório.");

            if (!string.IsNullOrWhiteSpace(f.Email) && !IsValidEmail(f.Email))
                throw new Exception("E-mail inválido.");

            if (f.CidadeID <= 0)
                throw new Exception("Cidade é obrigatória.");

            if (string.IsNullOrWhiteSpace(f.Logradouro))
                throw new Exception("Logradouro é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Numero))
                throw new Exception("Número é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Bairro))
                throw new Exception("Bairro é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Cep))
                throw new Exception("CEP é obrigatório.");

            if (f.Cep.Length < 8 || !Regex.IsMatch(f.Cep, @"^\d{8}$"))
                throw new Exception("CEP deve conter 8 dígitos numéricos.");

            // Documento (CNPJ) opcional
            string cnpj = Utilitario.ApenasNumeros(f.Cnpj);
            if (!string.IsNullOrWhiteSpace(cnpj))
            {
                if (cnpj.Length != 14 || !Utilitario.ValidarCNPJ(cnpj))
                    throw new Exception("CNPJ inválido. Verifique os dígitos.");
            }
        }

        // ==============================================================
        // MÉTODOS AUXILIARES
        // ==============================================================
        private static string LimparCnpj(string cnpj) => Regex.Replace(cnpj ?? "", @"\D", "");
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

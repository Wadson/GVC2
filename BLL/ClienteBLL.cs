using GVC.DALL;
using GVC.MODEL;
using GVC.MUI;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace GVC.BLL
{
    internal class ClienteBLL
    {
        private readonly ClienteDal _dal = new ClienteDal();

        // ==============================================================
        // 1. LISTAR TODOS OS CLIENTES
        // ==============================================================
        public DataTable Listar()
        {
            try
            {
                return _dal.ListarClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar clientes: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 2. SALVAR NOVO CLIENTE
        // ==============================================================
        public void Salvar(ClienteMODEL cliente)
        {
            ClienteDal _dal = new ClienteDal();
            try
            {
                ValidarCliente(cliente, isNovo: true);

                var cpfLimpo = Utilitario.ApenasNumeros(cliente.Cpf);
                var cnpjLimpo = Utilitario.ApenasNumeros(cliente.Cnpj);

                cliente.Cpf = string.IsNullOrWhiteSpace(cpfLimpo) ? null : cpfLimpo;
                cliente.Cnpj = string.IsNullOrWhiteSpace(cnpjLimpo) ? null : cnpjLimpo;

                if (_dal.ClienteExiste(cliente.Nome, cliente.Cpf))
                    throw new Exception("Já existe um cliente cadastrado com este nome ou CPF.");

                if (_dal.BuscarPorCpf(cliente.Cpf) != null)
                    throw new Exception("Já existe um cliente cadastrado com este CPF.");

                if (_dal.BuscarPorCnpj(cliente.Cnpj) != null)
                    throw new Exception("Já existe um cliente cadastrado com este CNPJ.");

                cliente.DataCriacao = DateTime.Now;
                cliente.UsuarioCriacao = FrmLogin.UsuarioConectado;

                _dal.SalvarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar cliente: {ex.Message}", ex);
            }
        }


        // ==============================================================
        // 3. ALTERAR CLIENTE EXISTENTE
        // ==============================================================
        public void Alterar(ClienteMODEL cliente)
        {
            try
            {
                if (cliente.ClienteID <= 0)
                    throw new Exception("Cliente inválido para alteração.");

                ValidarCliente(cliente, isNovo: false);

                var cpfLimpo = LimparCpf(cliente.Cpf);
                var existente = _dal.BuscarPorCpf(cpfLimpo);

                // Permite manter o mesmo CPF se for o próprio cliente
                if (existente != null && existente.ClienteID != cliente.ClienteID)
                    throw new Exception("Outro cliente já está cadastrado com este CPF.");

                // Atualiza dados de auditoria
                cliente.DataAtualizacao = DateTime.Now;
                //cliente.UsuarioAtualizacao = Environment.UserName ?? "Sistema";

                _dal.Atualizar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar cliente: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 4. EXCLUIR CLIENTE
        // ==============================================================
        public void Excluir(int clienteId)
        {
            try
            {
                if (clienteId <= 0) throw new Exception("ID do cliente inválido.");
                _dal.ExcluirCliente(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir cliente: {ex.Message}", ex);
            }
        }
        public void Excluir(ClienteMODEL cliente) => Excluir(cliente.ClienteID);

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
        // 6. BUSCAR POR CPF (muito usado no PDV!)
        // ==============================================================
        public ClienteMODEL? BuscarPorCpf(string cpf)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cpf)) return null;

                cpf = LimparCpf(cpf);
                if (!Utilitario.ValidarCPF(cpf))
                    throw new Exception("CPF inválido.");

                return _dal.BuscarPorCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente por CPF: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // 7. BUSCAR POR ID
        // ==============================================================
        public ClienteMODEL? BuscarPorId(int id)
        {
            try
            {
                if (id <= 0) return null;
                return _dal.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente por ID: {ex.Message}", ex);
            }
        }

        // ==============================================================
        // VALIDAÇÕES COMPLETAS DO CLIENTE
        // ==============================================================
        private void ValidarCliente(ClienteMODEL c, bool isNovo)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));

            // -------------------------------------------
            // CAMPOS BÁSICOS (independentes do documento)
            // -------------------------------------------
            if (string.IsNullOrWhiteSpace(c.Nome))
                throw new Exception("Nome do cliente é obrigatório.");

            if (!string.IsNullOrWhiteSpace(c.Email) && !IsValidEmail(c.Email))
                throw new Exception("E-mail inválido.");

            if (c.CidadeID <= 0)
                throw new Exception("Cidade é obrigatória.");

            if (string.IsNullOrWhiteSpace(c.Logradouro))
                throw new Exception("Logradouro é obrigatório.");

            if (string.IsNullOrWhiteSpace(c.Numero))
                throw new Exception("Número é obrigatório.");

            if (string.IsNullOrWhiteSpace(c.Bairro))
                throw new Exception("Bairro é obrigatório.");

            if (string.IsNullOrWhiteSpace(c.Cep))
                throw new Exception("CEP é obrigatório.");

            if (c.Cep.Length < 8 || !Regex.IsMatch(c.Cep, @"^\d{8}$"))
                throw new Exception("CEP deve conter 8 dígitos numéricos.");

            if (c.DataNascimento.HasValue && c.DataNascimento.Value.Date > DateTime.Today)
                throw new Exception("Data de nascimento não pode ser futura.");

            // -------------------------------------------
            // DOCUMENTO (CPF OU CNPJ) - OPCIONAL
            // -------------------------------------------
            bool isPessoaFisica =
                c.TipoCliente == "Física" ||
                c.TipoCliente == "Operador" ||
                c.TipoCliente == "Administrador" ||
                c.TipoCliente == "Consumidor Final";

            bool isPessoaJuridica =
                c.TipoCliente == "Jurídica" ||
                c.TipoCliente == "Empresa";

            string cpf = Utilitario.ApenasNumeros(c.Cpf);
            string cnpj = Utilitario.ApenasNumeros(c.Cnpj);

            if (isPessoaFisica && !string.IsNullOrWhiteSpace(cpf))
            {
                if (cpf.Length != 11 || !Utilitario.ValidarCPF(cpf))
                    throw new Exception("CPF inválido. Verifique os dígitos.");
            }
            else if (isPessoaJuridica && !string.IsNullOrWhiteSpace(cnpj))
            {
                if (cnpj.Length != 14 || !Utilitario.ValidarCNPJ(cnpj))
                    throw new Exception("CNPJ inválido. Verifique os dígitos.");
            }
            // Se não informar documento, não gera erro
        }


        // ==============================================================
        // MÉTODOS AUXILIARES
        // ==============================================================
        private static string LimparCpf(string cpf) => Regex.Replace(cpf ?? "", @"\D", "");
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
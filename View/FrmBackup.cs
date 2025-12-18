using Krypton.Toolkit;
using System;
using System.IO;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmBackup : KryptonForm
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        // Retorna o caminho completo do arquivo de banco dentro da pasta Data da aplicação
        private string GetDatabaseFilePath()
        {
            // Caminho REAL onde o banco fica SEMPRE
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "bdsiscontrol.db");
        }

        //2. Criar caminho padrão do backup
        private string GetDefaultBackupFolder()
        {
            string pastaBackup = @"C:\GVC\Data\Backup";

            if (!Directory.Exists(pastaBackup))
                Directory.CreateDirectory(pastaBackup);

            return pastaBackup;
        }



        // Verifica permissão de gravação no diretório
        private bool VerificarPermissoesGravacao(string caminho)
        {
            try
            {
                if (!Directory.Exists(caminho))
                    Directory.CreateDirectory(caminho);

                string tempFile = Path.Combine(caminho, "gvc_perm_test.tmp");
                using (FileStream fs = File.Create(tempFile)) { }
                File.Delete(tempFile);
                return true;
            }
            catch
            {
                MessageBox.Show("Sem permissão para gravar no diretório selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ================================
        //   GERAR BACKUP: copia banco -> pasta destino escolhida
        // ================================
        private bool RealizarBackupSQLite(string pastaDestino)
        {
            try
            {
                MostrarCaminhoBancoDebug();

                string origem = GetDatabaseFilePath();

                if (!File.Exists(origem))
                {
                    MessageBox.Show("Arquivo de banco de dados não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(pastaDestino))
                {
                    MessageBox.Show("Selecione a pasta de desstino do backup.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!VerificarPermissoesGravacao(pastaDestino))
                    return false;

                string nomeArquivo = $"BackupSQLite_{DateTime.Now:yyyyMMdd_HHmmss}.db";
                string destino = Path.Combine(pastaDestino, nomeArquivo);

                File.Copy(origem, destino);

                MessageBox.Show($"Backup gerado com sucesso:\n{destino}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ================================
        //   RESTAURAR BACKUP: copia arquivo selecionado -> pasta Data/banco.db (substitui)
        //   Faz backup automático do banco atual antes de sobrescrever (opcional)
        // ================================
        private bool RestaurarBackupSQLite(string arquivoBackup)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(arquivoBackup) || !File.Exists(arquivoBackup))
                {
                    MessageBox.Show("Arquivo de backup não encontrado ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string destinoDb = GetDatabaseFilePath();
                string pastaData = Path.GetDirectoryName(destinoDb) ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

                // Confirmação
                var resp = MessageBox.Show("A restauração irá substituir o banco atual. Deseja prosseguir?\nRecomenda-se fazer backup antes.", "Confirmar Restauração",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp != DialogResult.Yes) return false;

                // tenta criar pasta Data caso não exista
                if (!Directory.Exists(pastaData))
                    Directory.CreateDirectory(pastaData);

                // Verificar permissão de gravação na pasta Data
                if (!VerificarPermissoesGravacao(pastaData))
                    return false;

                // Fazer backup do banco atual (se existe) para pasta Data\BackupsAntesRestore
                if (File.Exists(destinoDb))
                {
                    string pastaBackupAntes = Path.Combine(pastaData, "BackupsAntesRestore");
                    if (!Directory.Exists(pastaBackupAntes))
                        Directory.CreateDirectory(pastaBackupAntes);

                    string backupAtual = Path.Combine(pastaBackupAntes, $"PreRestore_{DateTime.Now:yyyyMMdd_HHmmss}.db");
                    try
                    {
                        // liberar recursos pendentes
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        File.Copy(destinoDb, backupAtual);
                    }
                    catch (Exception exCopy)
                    {
                        // se não conseguir fazer backup prévio, pede confirmação para continuar
                        var r = MessageBox.Show($"Não foi possível criar backup do banco atual:\n{exCopy.Message}\nDeseja continuar e sobrescrever mesmo assim?", "Atenção",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r != DialogResult.Yes)
                            return false;
                    }
                }

                // Liberar conexões pendentes
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Copiar arquivo de backup selecionado para a pasta Data como banco.db (sobrescreve)
                File.Copy(arquivoBackup, destinoDb, overwrite: true);

                MessageBox.Show("Restauração concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao restaurar backup: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void rbtGerarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGerarBackup.Checked)
            {
                lblRotulo.Text = "Escolha o local para salvar o backup";

                // Carrega caminho padrão automaticamente
                txtCaminhoBackup.Text = GetDefaultBackupFolder();
                btnExecutar.Text = "Gerar Backup";
            }
        }

        private void rbtRestaurarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRestaurarBackup.Checked)
            {
                lblRotulo.Text = "Escolha o local onde está o arquivo de backup";
                txtCaminhoBackup.Clear();
                btnExecutar.Text = "Restaurar Backup";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalBackup_Click(object sender, EventArgs e)
        {
            if (rbtGerarBackup.Checked)
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.SelectedPath = GetDefaultBackupFolder();
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.SelectedPath;
                }
            }
            else if (rbtRestaurarBackup.Checked)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Backup SQLite (*.db)|*.db|Todos os Arquivos (*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.FileName;
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string caminho = txtCaminhoBackup.Text?.Trim();

            if (rbtGerarBackup.Checked)
            {
                // caminho deve ser pasta
                if (string.IsNullOrWhiteSpace(caminho))
                {
                    MessageBox.Show("Selecione o destino do backup.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RealizarBackupSQLite(caminho);
            }
            else if (rbtRestaurarBackup.Checked)
            {
                // caminho deve ser arquivo .db
                if (string.IsNullOrWhiteSpace(caminho) || !File.Exists(caminho))
                {
                    MessageBox.Show("Selecione um arquivo de backup válido para restaurar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RestaurarBackupSQLite(caminho);
            }
        }

        private void MostrarCaminhoBancoDebug()
        {
            string pastaData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string caminhoProcurado = Path.Combine(pastaData, "banco.db");

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("BaseDirectory: " + AppDomain.CurrentDomain.BaseDirectory);
            sb.AppendLine("Procurando por: " + caminhoProcurado);
            sb.AppendLine("");
            sb.AppendLine("Existe Data?: " + Directory.Exists(pastaData));
            if (Directory.Exists(pastaData))
            {
                sb.AppendLine("Arquivos em Data:");
                foreach (var f in Directory.GetFiles(pastaData))
                    sb.AppendLine("  " + Path.GetFileName(f));
            }
            MessageBox.Show(sb.ToString(), "DEBUG - Caminhos");
        }

    }
}


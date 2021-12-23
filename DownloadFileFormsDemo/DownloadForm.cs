namespace DownloadFileFormsDemo
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchFileAt.Text))
                {
                    MessageBox.Show("Informe o arquivo a ser buscado!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSaveFileAt.Text))
                {
                    MessageBox.Show("Informe o arquivo a ser salvo!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var searchFileAt = txtSearchFileAt.Text;
                var saveFileAt = txtSaveFileAt.Text;

                using var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5149/") };
                var response = await httpClient.GetAsync($@"api/files/download/filePath?filePath={searchFileAt}");
                response.EnsureSuccessStatusCode();

                using var stream = await response.Content.ReadAsStreamAsync();
                using var fileStream = File.Create(@saveFileAt);
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);

                MessageBox.Show($"Arquivo salvo em {saveFileAt}", "Arquivo salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
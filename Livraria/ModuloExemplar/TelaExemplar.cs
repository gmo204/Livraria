﻿using ClassLib.Classes.Enum;

namespace Trabalho_Forms
{
    public partial class TelaExemplar : Form
    {
        public TelaExemplar()
        {
            InitializeComponent();
            // carrega os valores do Enum para o combobox/Listbox
            statusExemplar.DataSource = Enum.GetValues(typeof(StatusExemplar));
            statusExemplar.SelectedIndex = 0;
            listaGenerico.DataSource = Enum.GetValues(typeof(TipoGenerico));
            listaGenerico.SelectedIndex = 0;

        }

        private void TelaExemplar_Load(object sender, EventArgs e)
        {
            painalEbook.Enabled = checkEBook.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TipoCapaLivro(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoSalvarExemplar(object sender, EventArgs e)
        {

        }

        private void painalEbook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StatusExemplar(object sender, EventArgs e)
        {

        }

        private void GeneroExemplar(object sender, EventArgs e)
        {

        }

        private void TituloExemplar(object sender, EventArgs e)
        {

        }

        private void SubTituloExemplar(object sender, EventArgs e)
        {

        }

        private void EscritorExemplar(object sender, EventArgs e)
        {

        }

        private void EditoraExemplar(object sender, EventArgs e)
        {

        }

        private void AnoPublicacaoExemplar(object sender, EventArgs e)
        {

        }

        private void PaginasLivro(object sender, EventArgs e)
        {

        }

        private void ISBNLivro(object sender, EventArgs e)
        {

        }

        private void FormatoEbook(object sender, EventArgs e)
        {

        }

        private void TamanhoEbook(object sender, EventArgs e)
        {

        }

        private void URLEbook(object sender, EventArgs e)
        {

        }

        private void EdicaoRevista(object sender, EventArgs e)
        {

        }

        private void PaginasRevista(object sender, EventArgs e)
        {

        }

        private void EdicaoHQ(object sender, EventArgs e)
        {

        }

        private void IlustradorHQ(object sender, EventArgs e)
        {

        }

        private void TipoGenerico(object sender, EventArgs e)
        {

        }
    }
}
//Gilberto Mota de Oliveira Junior
﻿using ClassLib.Classes.Enum;

namespace Trabalho_Forms;

public partial class TelaPessoa : Form
{
    public TelaPessoa()
    {
        InitializeComponent();

        // carrega os valores do Enum para o combobox/Listbox
        cargoFuncionario.DataSource = Enum.GetValues(typeof(CargoFuncionario));
        cargoFuncionario.SelectedIndex = 0;
    }

    public void Form2_Load(object sender, EventArgs e)
    {

    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void listaLeitor(object sender, EventArgs e)
    {

    }

    private void nomePessoa(object sender, EventArgs e)
    {

    }

    private void dataNascimentoPessoa(object sender, EventArgs e)
    {

    }

    private void cpfPessoa(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void emailPessoa(object sender, EventArgs e)
    {

    }

    private void telefonePessoa(object sender, MaskInputRejectedEventArgs e)
    {

    }

    public void cargaFuncionario(object sender, EventArgs e)
    {

    }

    private void salarioFuncionario(object sender, EventArgs e)
    {

    }

    private void cargaHorariaFuncionario(object sender, EventArgs e)
    {

    }

    private void funcaoFuncionario(object sender, EventArgs e)
    {

    }

    private void botaoSalvarPessoa(object sender, EventArgs e)
    {

    }
}
//Gilberto Mota de Oliveira Junior
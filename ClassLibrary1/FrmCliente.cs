using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Negocio;



namespace ClassLibrary1
{
    public partial class FrmCliente : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public FrmCliente()
        {
            
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtNome, "Insira um cliente");
        }
        // Mostra msg de confirmação
        private void MenssagemOk( string mensagem)
        {

            MessageBox.Show(mensagem,"Sistema Academia",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        // Mostra msg de erro
        private void MenssagemErro(string mensagem)
        {

            MessageBox.Show(mensagem, "Sistema Academia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // limpar
        private void limpar()
        {
            foreach (Control caixatexto in this.Controls)
            {
                if (caixatexto is TextBox)
                    caixatexto.Text = string.Empty;
            }
        }
        // Habilitar txt
        private void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor;

          

        }

        // Habilitar os botões
        private void HabilitaBotoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        // Ocultar as colunas do gride 
        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
           // this.dataLista.Columns[1].Visible = false;
        }
        // mostrar no data grid

        private void Mostrar()
        {
            this.dataLista.DataSource = NCliente.Mostrar();
            
           this.OcultarColunas();
            ldlTotal.Text = "Total de registros "+Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCliente.BuscarNome(this.TxtBuscar.Text);
            this.OcultarColunas();
            ldlTotal.Text = "Total de registros " + Convert.ToString(dataLista.Rows.Count);
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

      

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.HabilitaBotoes();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void DataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dataLista.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell chkExcluir = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Excluir"];
                chkExcluir.Value = !Convert.ToBoolean(chkExcluir.Value);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitaBotoes();
            this.limpar();
            this.Habilitar(true);
            this.txtCodigo.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                if (this.txtNome.Text == string.Empty)
                {
                    MenssagemErro("Preenccha todos campos");
                    //errorIcone.SetError(txtNome, "Insira um nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NCliente.Inserir(this.txtNome.Text.Trim(), 
                           Convert.ToDateTime (this.txtData.Text.Trim()), 
                            Convert.ToInt32(this.txtCpf.Text.Trim()), 
                            Convert.ToInt32(this.txtRg.Text.Trim()), 
                            this.txtEndereco.Text.Trim(), 
                            this.txtTelefone.Text.Trim(),
                           this.txtContato.Text.Trim(),
                           
                           this.txtFoto.Text.Trim(), Convert.ToDouble(this.txtAltura.Text.Trim()), 
                           Convert.ToDouble(this.txtPeso.Text.Trim()),
                           Convert.ToInt32(this.txtAula.Text.Trim()), this.txtLaudo.Text.Trim());
                    }

                    else
                    {
                        resp = NCliente.Editar(Convert.ToInt32(txtCodigo.Text), 
                            txtNome.Text,Convert.ToDateTime(txtData.Text), Convert.ToInt32(txtCpf.Text), 
                            Convert.ToInt32(txtRg.Text), txtEndereco.Text, txtTelefone.Text,
                           txtContato.Text, txtFoto.Text,
                           Convert.ToDouble(txtPeso.Text), 
                           Convert.ToDouble(txtAltura.Text), 
                           Convert.ToInt32(txtAula.Text), 
                           txtLaudo.Text);
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MenssagemOk("Registro Salvo com  sucesso");
                        }
                        else
                        {
                            this.MenssagemOk("Registro Editado com  sucesso");
                        }
                    }
                    else
                    {
                        this.MenssagemErro(resp);
                    }
                }

                this.eNovo = false;
                this.eEditar = false;
                this.HabilitaBotoes();
                this.limpar();
                this.Mostrar();

               

                
            }
            catch(Exception ex)
            
            {
                MessageBox.Show(ex.Message +ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.eEditar = false;
            this.eNovo = false;
            this.HabilitaBotoes();
            this.Habilitar(false);
        }

        private void DataLista_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[1].Value);
            txtNome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[2].Value);
            txtData.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[3].Value);
            txtCpf.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[4].Value);
            txtRg.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[5].Value);
            txtEndereco.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[6].Value);
            txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[7].Value);
            txtContato.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[8].Value);
            txtFoto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[9].Value);
            txtPeso.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[10].Value);
            txtAltura.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[11].Value);
            
            txtAula.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[12].Value);
            txtLaudo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells[13].Value);
            tabControl1.SelectedIndex = 1;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Equals(""))
            {
                this.MenssagemErro("Selecione um registro");
            }
            else
            {
                this.eEditar = true;
                this.HabilitaBotoes();
                this.Habilitar (true);
           }
        }

        private void ChkExcluir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluir.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }

            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja apagar os registros", "Sistema Academia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcao== DialogResult.OK)
                {
                    string codigo;
                    string resp="";
                    foreach (DataGridViewRow row in dataLista.Rows) 
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) 

                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resp = NCliente.Excluir(Convert.ToInt32(codigo));

                            if (resp.Equals("Ok"))
                            {
                                this.MenssagemOk("Excluido com sucesso");
                            }
                            else
                            {
                                this.MenssagemErro("Registro não excluido");
                            }
                        }
                    }
                    this.Mostrar();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ ex.StackTrace);
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

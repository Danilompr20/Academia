using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;




namespace Dados
{
    public class DClientes
    {
        private int _ClienteId;
        private string _ClienteNome;
        private DateTime _ClienteDataNasc;
        private int _ClienteCPF;
        private int _rg;
        private string _ClienteEndereco;
        private string _ClienteTelfone;
        private string _Clienteontato;
        private string _ClienteFoto;
        private double _ClientePeso;
        private double _ClienteALtura;
        private int aulaId;
        private string laudo;
        private string _textobuscar;

        public int ClienteId { get => _ClienteId; set => _ClienteId = value; }
        public string ClienteNome { get => _ClienteNome; set => _ClienteNome = value; }
        public DateTime ClienteDataNasc { get => _ClienteDataNasc; set => _ClienteDataNasc = value; }
        public int ClienteCPF { get => _ClienteCPF; set => _ClienteCPF = value; }
        public string ClienteEndereco { get => _ClienteEndereco; set => _ClienteEndereco = value; }
        public string ClienteTelfone { get => _ClienteTelfone; set => _ClienteTelfone = value; }
        public string Clienteontato { get => _Clienteontato; set => _Clienteontato = value; }
        public string ClienteFoto { get => _ClienteFoto; set => _ClienteFoto = value; }
        public double ClientePeso { get => _ClientePeso; set => _ClientePeso = value; }
        public double ClienteALtura { get => _ClienteALtura; set => _ClienteALtura = value; }
        public int AulaId { get => aulaId; set => aulaId = value; }
        public string Laudo { get => laudo; set => laudo = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public int Rg { get => _rg; set => _rg = value; }

        public void DCliente()
        {

        }




        public void DCliente(int clienteId, string clienteNome, DateTime clienteDataNasc, int clienteCPF, int rg, string clienteEndereco,
            string clienteTelfone, string clienteontato, string clienteFoto, double clientePeso, double clienteALtura, int aulaId,
            string laudo, string textobuscar)
        {
            this.ClienteId = clienteId;
            this.ClienteNome = clienteNome;
            this.ClienteDataNasc = clienteDataNasc;
            this.ClienteCPF = clienteCPF;
            this.Rg = rg;

            this.ClienteEndereco = clienteEndereco;
            this.ClienteTelfone = clienteTelfone;
            this.Clienteontato = clienteontato;
            this.ClienteFoto = clienteFoto;
            this.ClientePeso = clientePeso;
            this.ClienteALtura = clienteALtura;
            this.Laudo = laudo;
            this.Textobuscar = textobuscar;
        }
        public string Inserir(DClientes cliente)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();

       

            try
            {
                sqlCon.ConnectionString = conexao.cn;
                sqlCon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlCon;
                sqlcmd.CommandText = "inserir_cliente";
               
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@idNome";
                parIdCliente.SqlDbType = SqlDbType.Int;
                parIdCliente.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parIdCliente);
                //sqlcmd.Parameters.Clear();

                SqlParameter parnomeCliente = new SqlParameter();
                parnomeCliente.ParameterName = "@nome";
                parnomeCliente.SqlDbType = SqlDbType.VarChar;
                parnomeCliente.Size = 60;
                parnomeCliente.Value = cliente.ClienteNome;
                sqlcmd.Parameters.Add(parnomeCliente);
                //sqlcmd.Parameters.Clear();

                SqlParameter parDataNasc = new SqlParameter();
                parDataNasc.ParameterName = "@dataNascimento";
                parDataNasc.SqlDbType = SqlDbType.DateTime;
               
                parDataNasc.Value = cliente.ClienteDataNasc;
                sqlcmd.Parameters.Add(parDataNasc);
                //sqlcmd.Parameters.Clear();

                SqlParameter parcpf = new SqlParameter();
                parcpf.ParameterName = "@cpf";
                parcpf.SqlDbType = SqlDbType.Float;
                parcpf.Value = cliente.ClienteCPF;
                sqlcmd.Parameters.Add(parcpf);
                //sqlcmd.Parameters.Clear();

                SqlParameter parg = new SqlParameter();
                parg.ParameterName = "@rg";
                parg.SqlDbType = SqlDbType.Float;
                parg.Value = cliente.Rg;
                sqlcmd.Parameters.Add(parg);
                //sqlcmd.Parameters.Clear();

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 100;
                parEndereco.Value = cliente.ClienteEndereco;
                sqlcmd.Parameters.Add(parEndereco);
                //sqlcmd.Parameters.Clear();


                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 20;
                parTelefone.Value = cliente.ClienteTelfone;
                sqlcmd.Parameters.Add(parTelefone);
                //sqlcmd.Parameters.Clear();

                SqlParameter parContato = new SqlParameter();
                parContato.ParameterName = "@contatoEmergencia";
                parContato.SqlDbType = SqlDbType.VarChar;
                parContato.Size = 200;
                parContato.Value = cliente.Clienteontato;
                sqlcmd.Parameters.Add(parContato);
                //sqlcmd.Parameters.Clear();

                SqlParameter parFoto = new SqlParameter();
                parFoto.ParameterName = "@clienteFoto";
                parFoto.SqlDbType = SqlDbType.Text;
                parFoto.Value = cliente.ClienteFoto;
                sqlcmd.Parameters.Add(parFoto);
                //sqlcmd.Parameters.Clear();

                SqlParameter parAltura = new SqlParameter();
                parAltura.ParameterName = "@altura";
                parAltura.SqlDbType = SqlDbType.Float;
                parAltura.Value = cliente.ClienteALtura;
                sqlcmd.Parameters.Add(parAltura);
                //sqlcmd.Parameters.Clear();

                SqlParameter parPeso = new SqlParameter();
                parPeso.ParameterName = "@peso";
                parPeso.SqlDbType = SqlDbType.Float;
                parPeso.Value = cliente.ClientePeso;
                sqlcmd.Parameters.Add(parPeso);
                //sqlcmd.Parameters.Clear();


                SqlParameter parAula = new SqlParameter();
                parAula.ParameterName = "@auldaId";
                parAula.SqlDbType = SqlDbType.Int;
                parAula.Value = cliente.AulaId;
                sqlcmd.Parameters.Add(parAula);
                //sqlcmd.Parameters.Clear();

                SqlParameter parLaudo = new SqlParameter();
                parLaudo.ParameterName = "@laudoMedico";
                parLaudo.SqlDbType = SqlDbType.VarChar;
                parLaudo.Size = 100;
                parLaudo.Value = cliente.Laudo;
                sqlcmd.Parameters.Add(parLaudo);
                //sqlcmd.Parameters.Clear();
                resp = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não inserido";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                sqlCon.Close();
            }
            return resp;
        }
        public string Editar(DClientes cliente)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = conexao.cn;
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlCon;
                sqlcmd.CommandText = "editar_cliente";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@idNome";
                parIdCliente.SqlDbType = SqlDbType.Int;
                parIdCliente.Value = cliente.ClienteId;
                sqlcmd.Parameters.Add(parIdCliente);
                //sqlcmd.Parameters.Clear();

                SqlParameter parnomeCliente = new SqlParameter();
                parnomeCliente.ParameterName = "@nome";
                parnomeCliente.SqlDbType = SqlDbType.VarChar;
                parnomeCliente.Size = 60;
                parnomeCliente.Value = cliente.ClienteNome;
                sqlcmd.Parameters.Add(parnomeCliente);

                SqlParameter parDataNasc = new SqlParameter();
                parDataNasc.ParameterName = "@dataNascimento";
                parDataNasc.SqlDbType = SqlDbType.Date;

                parDataNasc.Value = cliente.ClienteDataNasc;
                sqlcmd.Parameters.Add(parDataNasc);
                // sqlcmd.Parameters.Clear();

                SqlParameter parcpf = new SqlParameter();
                parcpf.ParameterName = "@cpf";
                parcpf.SqlDbType = SqlDbType.Float;
                parcpf.Value = cliente.ClienteCPF;
                sqlcmd.Parameters.Add(parcpf);
                //sqlcmd.Parameters.Clear();

                SqlParameter parg = new SqlParameter();
                parg.ParameterName = "@rg";
                parg.SqlDbType = SqlDbType.Float;
                parg.Value = cliente.Rg;
                sqlcmd.Parameters.Add(parg);
                // sqlcmd.Parameters.Clear();

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 100;
                parEndereco.Value = cliente.ClienteEndereco;
                sqlcmd.Parameters.Add(parEndereco);
                // sqlcmd.Parameters.Clear();


                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 20;
                parTelefone.Value = cliente.ClienteTelfone;
                sqlcmd.Parameters.Add(parTelefone);
                //   sqlcmd.Parameters.Clear();

                SqlParameter parContato = new SqlParameter();
                parContato.ParameterName = "@contatoEmergencia";
                parContato.SqlDbType = SqlDbType.VarChar;
                parContato.Size = 200;
                parContato.Value = cliente.Clienteontato;
                sqlcmd.Parameters.Add(parContato);
                //sqlcmd.Parameters.Clear();

                SqlParameter parFoto = new SqlParameter();
                parFoto.ParameterName = "@clienteFoto";
                parFoto.SqlDbType = SqlDbType.Text;
                parFoto.Value = cliente.ClienteFoto;
                sqlcmd.Parameters.Add(parFoto);
                // sqlcmd.Parameters.Clear();

                SqlParameter parAltura = new SqlParameter();
                parAltura.ParameterName = "@altura";
                parAltura.SqlDbType = SqlDbType.Float;
                parAltura.Value = cliente.ClienteALtura;
                sqlcmd.Parameters.Add(parAltura);
                // sqlcmd.Parameters.Clear();



                SqlParameter parPeso = new SqlParameter();
                parPeso.ParameterName = "@peso";
                parPeso.SqlDbType = SqlDbType.Float;
                parPeso.Value = cliente.ClientePeso;
                sqlcmd.Parameters.Add(parPeso);
                // sqlcmd.Parameters.Clear();


                SqlParameter parAula = new SqlParameter();
                parAula.ParameterName = "@auldaId";
                parAula.SqlDbType = SqlDbType.Int;
                parAula.Value = cliente.AulaId;
                sqlcmd.Parameters.Add(parAula);
                // sqlcmd.Parameters.Clear();

                SqlParameter parLaudo = new SqlParameter();
                parLaudo.ParameterName = "@laudoMedico";
                parLaudo.SqlDbType = SqlDbType.VarChar;
                parLaudo.Size = 100;
                parLaudo.Value = cliente.Laudo;
                sqlcmd.Parameters.Add(parLaudo);
                // sqlcmd.Parameters.Clear();
                resp = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "Exclusão não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                sqlCon.Close();
            }
            return resp;
        }
        public string Excluir(DClientes cliente)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = conexao.cn;
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlCon;
                sqlcmd.CommandText = "excluir_cliente";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                //sqlcmd.Parameters.Clear();

                SqlParameter parIdCliente = new SqlParameter();
                parIdCliente.ParameterName = "@idNome";
                parIdCliente.SqlDbType = SqlDbType.Int;
                parIdCliente.Value = cliente.ClienteId;
                sqlcmd.Parameters.Add(parIdCliente);
                resp = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "Edição não foi feita";
            }

            catch (Exception ex)

            {
                resp = ex.Message;
            }
            finally
            {
                sqlCon.Close();
            }
            return resp;
        }


        public DataTable BuscarNome(DClientes cliente)
        {
            DataTable dtresultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conexao.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlCon;
                sqlcmd.CommandText = "buscar_nome";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parBuscar = new SqlParameter();
                parBuscar.ParameterName = "@textobuscar";
                parBuscar.SqlDbType = SqlDbType.VarChar;
                parBuscar.Size = 50;
                parBuscar.Value = cliente.Textobuscar;
                sqlcmd.Parameters.Add(parBuscar);
                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
                sqlcmd.Parameters.Clear();
            }
            catch
            {
                dtresultado = null;
            }
            return dtresultado;
        }
        public DataTable Mostrar()
        {
            DataTable dtresultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conexao.cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlCon;
                sqlcmd.CommandText = "mostrarClientes";
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
                sqlcmd.Parameters.Clear();
            }
            catch
            {
                dtresultado = null;
            }
            return dtresultado;
        }

    }
}
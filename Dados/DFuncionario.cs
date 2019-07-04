using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DFuncionario
    {
        private int IdFunc;
        private string NomeFunc;
        private int CPFFunc;
        private int RGFunc;
        private string EnderecoFunc;
        private string TelefoneFunc;
        private DateTime NascimentoFunc;
        private string CargoFunc;
        private string FotoFunc;
        private string TextobuscarFunc;

        public int IdFunc1 { get => IdFunc; set => IdFunc = value; }
        public string NomeFunc1 { get => NomeFunc; set => NomeFunc = value; }
        public int CPFFunc1 { get => CPFFunc; set => CPFFunc = value; }
        public int RGFunc1 { get => RGFunc; set => RGFunc = value; }
        public string EnderecoFunc1 { get => EnderecoFunc; set => EnderecoFunc = value; }
        public string TelefoneFunc1 { get => TelefoneFunc; set => TelefoneFunc = value; }
        public DateTime NascimentoFunc1 { get => NascimentoFunc; set => NascimentoFunc = value; }
        public string CargoFunc1 { get => CargoFunc; set => CargoFunc = value; }
        public string FotoFunc1 { get => FotoFunc; set => FotoFunc = value; }
        public string TextobuscarFunc1 { get => TextobuscarFunc; set => TextobuscarFunc = value; }



        //Construtor vazio

        public DFuncionario()
        {

        }

        //Construtor com Parametros

        public DFuncionario(int IdFunc, string NomeFunc, int CPFFunc, int RGFunc, string EnderecoFunc, string TelefoneFunc, DateTime NascimentoFunc, string CargoFunc, string FotoFunc, string TextobuscarFunc)
        {
            this.IdFunc = IdFunc;
            this.NomeFunc = NomeFunc;
            this.CPFFunc = CPFFunc;
            this.RGFunc = RGFunc;
            this.EnderecoFunc = EnderecoFunc;
            this.TelefoneFunc = TelefoneFunc;
            this.NascimentoFunc = NascimentoFunc;
            this.CargoFunc = CargoFunc;
            this.FotoFunc = FotoFunc;
            this.TextobuscarFunc = TextobuscarFunc;
        }

        //Metodo Inserir
        public string Inserir(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo Inserção
                SqlCon.ConnectionString = conexao.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Inserir_Func";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFuncId = new SqlParameter();
                ParFuncId.ParameterName = "@func_Id";
                ParFuncId.SqlDbType = SqlDbType.Int;
                ParFuncId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParFuncId);

                SqlParameter ParNomeFunc = new SqlParameter();
                ParNomeFunc.ParameterName = "@func_Nome";
                ParNomeFunc.SqlDbType = SqlDbType.VarChar;
                ParNomeFunc.Size = 50;
                ParNomeFunc.Value = Funcionario.NomeFunc;
                SqlCmd.Parameters.Add(ParNomeFunc);

                SqlParameter ParCPFFunc = new SqlParameter();
                ParCPFFunc.ParameterName = "@func_CPF";
                ParCPFFunc.SqlDbType = SqlDbType.Int;
                ParCPFFunc.Size = 11;
                ParCPFFunc.Value = Funcionario.CPFFunc;
                SqlCmd.Parameters.Add(ParCPFFunc);

                SqlParameter ParRGFunc = new SqlParameter();
                ParRGFunc.ParameterName = "@func_RG";
                ParRGFunc.SqlDbType = SqlDbType.Int;
                ParRGFunc.Size = 9;
                ParCPFFunc.Value = Funcionario.RGFunc;
                SqlCmd.Parameters.Add(ParRGFunc);

                SqlParameter ParEnderecoFunc = new SqlParameter();
                ParEnderecoFunc.ParameterName = "@func_Endereco";
                ParEnderecoFunc.SqlDbType = SqlDbType.VarChar;
                ParEnderecoFunc.Size = 100;
                ParEnderecoFunc.Value = Funcionario.EnderecoFunc;
                SqlCmd.Parameters.Add(ParEnderecoFunc);

                SqlParameter ParTelefoneFunc = new SqlParameter();
                ParTelefoneFunc.ParameterName = "@func_Telefone";
                ParTelefoneFunc.SqlDbType = SqlDbType.VarChar;
                ParTelefoneFunc.Size = 11;
                ParTelefoneFunc.Value = Funcionario.TelefoneFunc;
                SqlCmd.Parameters.Add(ParTelefoneFunc);

                SqlParameter ParNascimentoFunc = new SqlParameter();
                ParNascimentoFunc.ParameterName = "@func_DataNascimento";
                ParNascimentoFunc.SqlDbType = SqlDbType.Date;
                ParNascimentoFunc.Value = Funcionario.NascimentoFunc;
                SqlCmd.Parameters.Add(ParNascimentoFunc);

                SqlParameter ParCargoFunc = new SqlParameter();
                ParCargoFunc.ParameterName = "@func_Cargo";
                ParCargoFunc.SqlDbType = SqlDbType.VarChar;
                ParCargoFunc.Size = 40;
                ParCargoFunc.Value = Funcionario.CargoFunc;
                SqlCmd.Parameters.Add(ParCargoFunc);

                SqlParameter ParFotoFunc = new SqlParameter();
                ParFotoFunc.ParameterName = "@func_Foto";
                ParFotoFunc.SqlDbType = SqlDbType.Image;
                ParFotoFunc.Value = Funcionario.FotoFunc;
                SqlCmd.Parameters.Add(ParFotoFunc);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Metodo Editar
        public string Editar(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo Inserção
                SqlCon.ConnectionString = conexao.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Editar_Func";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFuncId = new SqlParameter();
                ParFuncId.ParameterName = "@func_Id";
                ParFuncId.SqlDbType = SqlDbType.Int;
                ParFuncId.Value = Funcionario.IdFunc;
                SqlCmd.Parameters.Add(ParFuncId);

                SqlParameter ParNomeFunc = new SqlParameter();
                ParNomeFunc.ParameterName = "@func_Nome";
                ParNomeFunc.SqlDbType = SqlDbType.VarChar;
                ParNomeFunc.Size = 50;
                ParNomeFunc.Value = Funcionario.NomeFunc;
                SqlCmd.Parameters.Add(ParNomeFunc);

                SqlParameter ParCPFFunc = new SqlParameter();
                ParCPFFunc.ParameterName = "@func_CPF";
                ParCPFFunc.SqlDbType = SqlDbType.Int;
                ParCPFFunc.Size = 11;
                ParCPFFunc.Value = Funcionario.CPFFunc;
                SqlCmd.Parameters.Add(ParCPFFunc);

                SqlParameter ParRGFunc = new SqlParameter();
                ParRGFunc.ParameterName = "@func_RG";
                ParRGFunc.SqlDbType = SqlDbType.Int;
                ParRGFunc.Size = 9;
                ParCPFFunc.Value = Funcionario.RGFunc;
                SqlCmd.Parameters.Add(ParRGFunc);

                SqlParameter ParEnderecoFunc = new SqlParameter();
                ParEnderecoFunc.ParameterName = "@func_Endereco";
                ParEnderecoFunc.SqlDbType = SqlDbType.VarChar;
                ParEnderecoFunc.Size = 100;
                ParEnderecoFunc.Value = Funcionario.EnderecoFunc;
                SqlCmd.Parameters.Add(ParEnderecoFunc);

                SqlParameter ParTelefoneFunc = new SqlParameter();
                ParTelefoneFunc.ParameterName = "@func_Telefone";
                ParTelefoneFunc.SqlDbType = SqlDbType.VarChar;
                ParTelefoneFunc.Size = 11;
                ParTelefoneFunc.Value = Funcionario.TelefoneFunc;
                SqlCmd.Parameters.Add(ParTelefoneFunc);

                SqlParameter ParNascimentoFunc = new SqlParameter();
                ParNascimentoFunc.ParameterName = "@func_DataNascimento";
                ParNascimentoFunc.SqlDbType = SqlDbType.Date;
                ParNascimentoFunc.Value = Funcionario.NascimentoFunc;
                SqlCmd.Parameters.Add(ParNascimentoFunc);

                SqlParameter ParCargoFunc = new SqlParameter();
                ParCargoFunc.ParameterName = "@func_Cargo";
                ParCargoFunc.SqlDbType = SqlDbType.VarChar;
                ParCargoFunc.Size = 40;
                ParCargoFunc.Value = Funcionario.CargoFunc;
                SqlCmd.Parameters.Add(ParCargoFunc);

                SqlParameter ParFotoFunc = new SqlParameter();
                ParFotoFunc.ParameterName = "@func_Foto";
                ParFotoFunc.SqlDbType = SqlDbType.Image;
                ParFotoFunc.Value = Funcionario.FotoFunc;
                SqlCmd.Parameters.Add(ParFotoFunc);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A edição não pode ser realizada";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Metodo Excluir
        public string Excluir(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo Inserção
                SqlCon.ConnectionString = conexao.cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Excluir_Func";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFuncId = new SqlParameter();
                ParFuncId.ParameterName = "@func_Id";
                ParFuncId.SqlDbType = SqlDbType.Int;
                ParFuncId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParFuncId);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A exclusão não pode ser feita";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Metodo Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo Buscar Nome
        public DataTable BuscarNome(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("Funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Func";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@textobuscarFunc";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 50;
                ParBuscar.Value = Funcionario.TextobuscarFunc;
                SqlCmd.Parameters.Add(ParBuscar);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}

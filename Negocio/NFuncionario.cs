using System;
using System.Collections.Generic;
using System.Text;
using Dados;
using System.Data;

namespace Negocio
{
        public class NFuncionario
        {
            //Método Inserir
            public static string Inserir(string NomeFunc, int CPFFunc, int RGFunc, string EnderecoFunc, string TelefoneFunc, DateTime NascimentoFunc, string CargoFunc, string FotoFunc, string TextobuscarFunc)
            {
                DFuncionario Obj = new Dados.DFuncionario();
                Obj.NomeFunc1 = NomeFunc;
                Obj.CPFFunc1 = CPFFunc;
                Obj.RGFunc1 = RGFunc;
                Obj.EnderecoFunc1 = EnderecoFunc;
                Obj.TelefoneFunc1 = TelefoneFunc;
                Obj.NascimentoFunc1 = NascimentoFunc;
                Obj.CargoFunc1 = CargoFunc;
                Obj.FotoFunc1 = FotoFunc;
                return Obj.Inserir(Obj);
            }

            //Método Editar
            public static string Editar(int IdFunc, string NomeFunc, int CPFFunc, int RGFunc, string EnderecoFunc, string TelefoneFunc, DateTime NascimentoFunc, string CargoFunc, string FotoFunc, string TextobuscarFunc)
            {
                DFuncionario Obj = new Dados.DFuncionario();
                Obj.IdFunc1 = IdFunc;
                Obj.NomeFunc1 = NomeFunc;
                Obj.CPFFunc1 = CPFFunc;
                Obj.RGFunc1 = RGFunc;
                Obj.EnderecoFunc1 = EnderecoFunc;
                Obj.TelefoneFunc1 = TelefoneFunc;
                Obj.NascimentoFunc1 = NascimentoFunc;
                Obj.CargoFunc1 = CargoFunc;
                Obj.FotoFunc1 = FotoFunc;
                return Obj.Editar(Obj);
            }

            //Método Excluir
            public static string Excluir(int IdFunc)
            {
                DFuncionario Obj = new Dados.DFuncionario();
                Obj.IdFunc1 = IdFunc;
                return Obj.Excluir(Obj);
            }

            //Método Mostrar
            public static DataTable Mostrar()
            {
                return new DFuncionario().Mostrar();
            }

            //Método BuscarNome
            public static DataTable Buscar(string TextoBuscar)
            {
                DFuncionario Obj = new DFuncionario();
                Obj.TextobuscarFunc1 = TextoBuscar;
                return Obj.BuscarNome(Obj);
            }
        }
}

using Dados;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace Negocio
{
    public class NCliente
    {

        public static string Inserir(string clienteNome, DateTime clienteDataNasc, int clienteCPF, int rg, string clienteEndereco,
            string clienteTelfone, string clienteontato, string clienteFoto, double clientePeso, double clienteALtura, int aulaId,
            string laudo)
        {
            DClientes obj = new Dados.DClientes();

            obj.ClienteNome = clienteNome;
            obj.ClienteDataNasc = clienteDataNasc;
            obj.ClienteCPF = clienteCPF;
            obj.Rg = rg;

            obj.ClienteEndereco = clienteEndereco;
            obj.ClienteTelfone = clienteTelfone;
            obj.Clienteontato = clienteontato;
            obj.ClienteFoto = clienteFoto;
            obj.ClientePeso = clientePeso;
            obj.ClienteALtura = clienteALtura;
            obj.Laudo = laudo;
            obj.AulaId = aulaId;
            return obj.Inserir(obj);
        }


      
            public static string Editar(int clienteId, string clienteNome, DateTime clienteDataNasc, int clienteCPF, int rg, string clienteEndereco,
                string clienteTelfone, string clienteontato, string clienteFoto, double clientePeso, double clienteALtura, int aulaId,
                string laudo)
            {
                DClientes obj = new Dados.DClientes();
            
                obj.ClienteId = clienteId;
                obj.ClienteNome = clienteNome;
                obj.ClienteDataNasc = clienteDataNasc;
                obj.ClienteCPF = clienteCPF;
                obj.Rg = rg;

                obj.ClienteEndereco = clienteEndereco;
                obj.ClienteTelfone = clienteTelfone;
                obj.Clienteontato = clienteontato;
                obj.ClienteFoto = clienteFoto;
                obj.ClientePeso = clientePeso;
                obj.ClienteALtura = clienteALtura;
                obj.Laudo = laudo;
                obj.AulaId = aulaId;
            return obj.Editar(obj);
            }

        public static string Excluir(int clienteId)
        {
            DClientes obj = new Dados.DClientes();
            obj.ClienteId = clienteId;


            return obj.Excluir(obj);
        }

        public static DataTable Mostrar()
        {
            return new DClientes().Mostrar();
        }
        public static DataTable BuscarNome(string textoBuscar)
        {
            DClientes obj = new DClientes(); 
           obj.Textobuscar =textoBuscar ;
            return obj.BuscarNome(obj);
        
        }
    }


    }


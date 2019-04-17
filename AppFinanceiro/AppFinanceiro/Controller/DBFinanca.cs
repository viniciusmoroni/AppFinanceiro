using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppFinanceiro.Models;

namespace AppFinanceiro.Controller
{
    public class DBFinanca
    {
        SQLiteConnection conn; //representa o banco de dados
        public string StatusMessage { get; set; } //representa a mensagem da ultima operação

        public DBFinanca(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Financa>(); //cria a tabela no banco se ela não existir
        }

        public void Inserir(Financa financa)
        {
            int result = 0;

            try
            {
                if (string.IsNullOrEmpty(financa.Descricao))
                    throw new Exception("Descrição Não poder ser Nulo");


                if (string.IsNullOrEmpty(financa.TipoOperacao))
                    throw new Exception("Descrição Não poder ser Nulo");

                if (financa.Data == null)
                    throw new Exception("Data da Finança não informada");

                if (financa.Valor == 0)
                    throw new Exception("Valor da Finança Nulo");

                result = conn.Insert(financa);
                StatusMessage = string.Format("{0} registro(s) adicionado(s):[Descrição: {1}, tipo:{2}, valor:{3}]",
                result, financa.Descricao, financa.TipoOperacao, financa.Valor);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Erro ao adcionar o registro. Error:{0}", ex.Message); //Jhowzera fraquinho
            }
        }

        public void Alterar(Financa financa)
        {
            
        }

        public void Excluir(int Id)
        {

        }

        //localizar
        //mais um montão de coisas
    }
}

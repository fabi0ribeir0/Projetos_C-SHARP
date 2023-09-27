﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Novo_Colaborador
{
    internal class Conexao
    {
        //Conexão LOCAL        
        public string conect = "SERVER=192.168.0.201;DATABASE=kanboard_stats;UID=root;PWD=UNS@1623;PORT=";

        //Conexão Remota        
        //public string conect = "SERVER=mysql247.umbler.com;DATABASE=aula;UID=csharpaula;PWD=fabio123;PORT=41890;";        

        public MySqlConnection con = null;

        //Abrir conexão 
        public void AbrirConexao()
        {
            //testar
            try
            {
                con = new MySqlConnection(conect);
                con.Open();
            }
            catch (Exception ex)
            {
                //erro
                MessageBox.Show("Erro de conexão " + ex.Message + "\nVerifique o servidor");
            }
        }
        //fexar conexão
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de conexão " + ex.Message);
            }
        }
    }
}

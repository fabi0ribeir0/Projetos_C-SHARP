using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Colaborador
{
    public partial class FrmCadastrados : Form
    {
        public FrmCadastrados()
        {
            InitializeComponent();
        }

        private void FrmCadastrados_Load(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            BackColor = frm.backgroundColor;
            ListarGD();
        }

        Conexao conect = new Conexao();
        string sql;
        MySqlCommand cmd;


        private void FormatarGD()
        {
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Função";
            grid.Columns[3].HeaderText = "Estado";
            grid.Columns[4].HeaderText = "Equipamentos";
            grid.Columns[5].HeaderText = "Solicitado por";
            grid.Columns[6].HeaderText = "Data";

            // Oculta a coluna de índice 0 (ID)
            grid.Columns[0].Visible = false;

            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ListarGD()
        {
            conect.AbrirConexao();
            sql = "SELECT * FROM Contratados ORDER BY Nome ASC";
            cmd = new MySqlCommand(sql, conect.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            conect.FecharConexao();

            FormatarGD();
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna é a coluna "Estado" (índice 3) e se o valor não é nulo
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                int estado = Convert.ToInt32(e.Value);

                // Mapeia os valores 1, 2 e 3 para "PR", "SC" e "RS"
                switch (estado)
                {
                    case 1:
                        e.Value = "PR";
                        break;
                    case 2:
                        e.Value = "SC";
                        break;
                    case 3:
                        e.Value = "RS";
                        break;
                    default:
                        // Tratar qualquer outro valor, se necessário
                        break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusca = txtBusca.Text.Trim(); // Obtém o texto inserido no TextBox
            if (string.IsNullOrEmpty(textoBusca))
            {
                // Se o campo de busca estiver vazio, exiba todos os registros
                ListarGD();
            }
            else
            {
                // Filtra a DataGridView com base no texto de busca (no exemplo, filtramos pela coluna "Nome")
                BindingSource bs = new BindingSource();
                bs.DataSource = grid.DataSource;
                bs.Filter = "Nome LIKE '%" + textoBusca + "%'";
                grid.DataSource = bs;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            ListarGD();
        }
    }
}

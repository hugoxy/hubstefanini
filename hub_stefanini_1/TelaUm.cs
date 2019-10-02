using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace hub_stefanini_1
{
    public partial class TelaUm : UserControl
    {
        public TelaUm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime horaAtual = DateTime.Now;

                horaAtual = DateTime.Parse(txtHchegada.Text);
                horaAtual = horaAtual.AddHours(9);
                horaAtual = horaAtual.AddMinutes(38);
                labRes.Text = Convert.ToString(horaAtual.ToLongTimeString());

                //Tratamento de pasta
                string folder = @"C:\hubstefanini\";
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                DateTime dataAgora = DateTime.Now;

                string dataformat = string.Format("{0:dd/MM/yyyy}", dataAgora);

                //Gravar em log
                ManipulaArquivo arquivo = new ManipulaArquivo(@"C:\hubstefanini\logs.txt");
                string log;
                log = txtHchegada.Text + " - " + labRes.Text +" - "+dataformat;
                arquivo.Escrever(log);


            }
            catch
            {
                MessageBox.Show("Formatação incorreta, siga com HH:MM:SS", "Formatação Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labRes.Text = "00:00:00";
            }




        }

        DataTable table = new DataTable();

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            //@"C:\hubstefanini\logs.txt");
            try
            {


                table.Columns.Add("Chegadas", typeof(string));
                table.Columns.Add("Saidas", typeof(string));
                table.Columns.Add("Data", typeof(string));

                dgHistorico.DataSource = table;

                string[] lines = File.ReadAllLines(@"C:\hubstefanini\logs.txt");
                string[] values;


                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('-');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);

                }
            }
            catch
            {

            }
        }

        //Class arquivo
        public class ManipulaArquivo
        {
            private string arquivo;
            public ManipulaArquivo(string arquivo)
            {
                this.arquivo = arquivo;
            }

            public void Escrever<T>(T conteudo)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(this.arquivo, true))
                {
                    sw.WriteLine(conteudo);
                    sw.Close();
                }
            }

            public string Ler()
            {
                string conteudo = string.Empty;
                if (File.Exists(this.arquivo))
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(this.arquivo))
                    {
                        conteudo = sr.ReadToEnd();
                        sr.Close();
                    }
                }
                return conteudo;
            }
        }
    }
}

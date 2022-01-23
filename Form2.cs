using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekat_pravi
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(konekcija.conn);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garazaDataSet.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.garazaDataSet.Radnik);
            // TODO: This line of code loads data into the 'garazaDataSet.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.garazaDataSet.Marka);
            // TODO: This line of code loads data into the 'garazaDataSet.Vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this.garazaDataSet.Vlasnik);
            // TODO: This line of code loads data into the 'garazaDataSet.Auto' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.garazaDataSet.Auto);


            tbPrikaz.Text = podatak.Podaci;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indeks = dataGridView1.SelectedRows[0].Index;
                int ID = int.Parse(dataGridView1[0, indeks].Value.ToString());

                SqlCommand command = new SqlCommand("DELETE from auto where IDauto = @value", connection);
                SqlParameter parameter = new SqlParameter("value", ID);
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    this.autoTableAdapter.Fill(this.garazaDataSet.Auto);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("SELEKTUJ RED","UPOZORENJE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.autoTableAdapter.Update(this.garazaDataSet.Auto);
        }

       

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            SqlCommand komanda = new SqlCommand("select a.IDauto, v.Ime, r.Ime from Auto as a join Vlasnik as v on a.Vlasnik = v.IDVlasnik join Radnik as r on a.Radnik = r.IDRadnik join Marka as m on a.Marka = m.IDMarka where m.Ime_Marke =  @marka ", connection);
            komanda.CommandType = CommandType.Text;
            SqlParameter pomMarka = new SqlParameter("@marka", SqlDbType.NVarChar);
            komanda.Parameters.Add(pomMarka);
            pomMarka.Value = tbPrikaz.Text;

            SqlDataReader reader = null;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto ID" + "\t" + "Ime vlasnika" + "   " + "Ime radnika");

            try
            {
                connection.Open();

                reader = komanda.ExecuteReader();

                while(reader.Read())
                {
                    sb.Append(reader[0].ToString() + "\t" + reader[1].ToString()+"\t"+ reader[2].ToString()+"\n\n");
                    
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            richTextBox3.Text = sb.ToString();


        }

           

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            listBox1.Items.Clear();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach(DataGridViewColumn kolona in dataGridView1.Columns)
                {
                    listBox1.Items.Add(dataGridView1.CurrentRow.Cells[kolona.Name].Value);
                }
            }
        }
    }
}

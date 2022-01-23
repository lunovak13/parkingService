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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            podatak.Podaci = comboBox1.Text;


            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garazaDataSet.Auto' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.garazaDataSet.Auto);
            // TODO: This line of code loads data into the 'garazaDataSet.Marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.garazaDataSet.Marka);

        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
           







            SqlConnection Konekcija = new SqlConnection(konekcija.conn);


            SqlParameter IDparam = new SqlParameter("@ID", SqlDbType.Int);
            SqlParameter IDvlasnik = new SqlParameter("@vlasnik", SqlDbType.Int);
            SqlParameter IDmarka = new SqlParameter("@marka", SqlDbType.Int);
            SqlParameter IDboja = new SqlParameter("@boja", SqlDbType.NVarChar);
            SqlParameter IDmesto = new SqlParameter("@mesto", SqlDbType.Int);
            SqlParameter IDradnik = new SqlParameter("@radnik", SqlDbType.Int);



            SqlCommand Komanda = new SqlCommand("insert into Auto (IDauto, Vlasnik, Marka, Boja, Mesto, Radnik) values (@ID, @vlasnik,@marka, @boja, @mesto, @radnik ); ", Konekcija);



            Komanda.Parameters.Add(IDparam);
            IDparam.Value = Convert.ToInt32(tbID.Text);


            Komanda.Parameters.Add(IDvlasnik);
            IDvlasnik.Value = Convert.ToInt32(tbVlasnik.Text);

            Komanda.Parameters.Add(IDmarka);
            IDmarka.Value = Convert.ToInt32(tbMarka.Text);

            Komanda.Parameters.Add(IDboja);
            IDboja.Value = tbBoja.Text;

            Komanda.Parameters.Add(IDmesto);
            IDmesto.Value = Convert.ToInt32(tbMesto.Text);

            Komanda.Parameters.Add(IDradnik);
            IDradnik.Value = Convert.ToInt32(tbRadnik.Text);

            
            try
            {
                Konekcija.Open();
                Komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Konekcija.Close();
            }

            tbID.Text = "";
            tbMarka.Text = "";
            tbMesto.Text = "";
            tbRadnik.Text = "";
            tbBoja.Text = "";
            tbVlasnik.Text = "";



        }
    }
}

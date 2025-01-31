using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace steamEarnsCalc{
    public partial class Form1 : Form    {
        public float taxPayed;
        public Form1(){
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            CultureInfo culture = new CultureInfo("en-US"); // Configuración en inglés (USA)
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            if (totalComments.Text == "0") {
                totalComments.Text = ""; // Borra el texto si es "0"
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(totalComments.Text)){
                totalComments.Text = "0"; // Restaura el "0" si queda vacío
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            int tComments = int.Parse(totalComments.Text);
            float price = float.Parse(gamePrice.Text);
            float playerPercent = float.Parse(gamePercentOp.Text);
            float tax = float.Parse(gameTax.Text);
            float steamTax = float.Parse(steamPercentage.Text);
            //float taxPayed;

            DateTime dateReleased = DateTime.ParseExact(gameDateReleased.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dateNow = DateTime.Today;
            float totalEarnings;
            float emptyEarnings;
            float steamEarnings;
            float montlyEarnings;
            int totalPlayers;

            //string timePassed = "";//Time elapsed since the game was released until now
            totalPlayers = (int)((tComments * 100.0) / playerPercent);
            totalEarnings = totalPlayers * price;

            emptyEarnings = totalEarnings - ((totalEarnings * steamTax) / 100);

            steamEarnings = totalEarnings - emptyEarnings;

            int totalMonts = ((dateNow.Year - dateReleased.Year) * 12) + dateNow.Month - dateReleased.Month;

            montlyEarnings = emptyEarnings / totalMonts;

            boxResults.Text = "";


            boxResults.AppendText("Total players...");
            boxResults.SelectionColor = Color.Blue;
            boxResults.AppendText(totalPlayers.ToString());
            boxResults.SelectionColor = Color.Black;
            boxResults.AppendText(" APPROX" + Environment.NewLine);
            boxResults.AppendText(Environment.NewLine);

            boxResults.AppendText("Total earnings...");
            boxResults.SelectionColor = Color.Green;
            boxResults.AppendText( totalEarnings.ToString("F2") );
            boxResults.SelectionColor = Color.Black;
            boxResults.AppendText( " USD" + Environment.NewLine);
            boxResults.AppendText(Environment.NewLine);
            Console.WriteLine("ganancias antes es  " + emptyEarnings);  // Usando concatenación


            if (tax > 0.0){
                //tax implemented
                taxPayed = (emptyEarnings * tax) / 100;
                emptyEarnings -= taxPayed;

            }

            //empty earnings
            if (tax > 0.0) { 
                boxResults.AppendText("Earnings after Steam and tax discounts ");
            } else { 
                boxResults.AppendText("Earnings after Steam discount ");
            }
            
            boxResults.SelectionColor = Color.Green;
            boxResults.AppendText(emptyEarnings.ToString("F2"));
            boxResults.SelectionColor = Color.Black;
            boxResults.AppendText(" USD" + Environment.NewLine);
            boxResults.AppendText(Environment.NewLine);

            //months 
            if (totalMonts > 0){
                boxResults.AppendText("Total monts...");
                boxResults.SelectionColor = Color.Red;
                boxResults.AppendText(totalMonts.ToString());
                boxResults.SelectionColor = Color.Black;
                boxResults.AppendText(Environment.NewLine);
                

                boxResults.AppendText("Monthly earnings ");
                boxResults.SelectionColor = Color.Blue;
                boxResults.AppendText(montlyEarnings.ToString("F2"));
                boxResults.SelectionColor = Color.Black;
                boxResults.AppendText(" USD" + Environment.NewLine);
                boxResults.AppendText(Environment.NewLine);
            }

            boxResults.AppendText("Payed to steam ");
            boxResults.SelectionColor = Color.Pink;
            boxResults.AppendText(steamEarnings.ToString("F2"));
            boxResults.SelectionColor = Color.Black;
            boxResults.AppendText(" USD" + Environment.NewLine);            

            boxResults.SelectionColor = Color.Pink;
            boxResults.AppendText("payed in all period ");            
            boxResults.SelectionColor = Color.Black;
            boxResults.AppendText( Environment.NewLine);

            if (tax > 0.0) {
                //tax implemented
                boxResults.AppendText(Environment.NewLine);
                boxResults.AppendText("Tax payed ");
                boxResults.SelectionColor = Color.Green;
                boxResults.AppendText(taxPayed.ToString("F2"));
                boxResults.SelectionColor = Color.Black;
                boxResults.AppendText(" USD" + Environment.NewLine);
                boxResults.AppendText(Environment.NewLine);
            }

            //MessageBox.Show("Número ingresado: " + numero);
        }
    }
}

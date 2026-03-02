using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            //Coffee Reset
            doubleEspresso_txt.Text = "0";
            cappuccino_txt.Text = "0";
            americano_txt.Text = "0";
            macchiato_txt.Text = "0";
            icedLatte_txt.Text = "0";
            flatWhite_txt.Text = "0";
            espresso_txt.Text = "0";
            latte_txt.Text = "0";

            DoubleEspresso_chk.Checked = false;
            Cappuccino_chk.Checked = false;
            Americano_chk.Checked = false;
            Macchiato_chk.Checked = false;
            icedLatte_chk.Checked = false;
            FlatWhite_chk.Checked = false;
            Espresso_chk.Checked = false;
            Latte_chk.Checked = false;

            //Desserts Reset
            strawberryWaffle_txt.Text = "0";
            chocolateWaffle_txt.Text = "0";
            ChocolateMuffin_txt.Text = "0";
            cinnamonRoll_txt.Text = "0";
            cheesecake_txt.Text = "0";
            LemonPie_txt.Text = "0";
            croissant_txt.Text = "0";
            brownies_txt.Text = "0";

            StrawberryWaffle_chk.Checked = false;
            ChocolateMuffin_chk.Checked = false;
            ChocolateWaffle_chk.Checked = false;
            CinnamonRoll_chk.Checked = false;
            Cheesecake_chk.Checked = false;
            LemonPie_chk.Checked = false;
            Croissant_chk.Checked = false;
            Brownies_chk.Checked = false;

            //Cost Reset
            coffeeTotal_txt.Text = "0";
            dessertsTotal_txt.Text = "0";
            serviceCharge_txt.Text = "500";

            tax_txt.Text = "0";
            subTotal_txt.Text = "0";
            total_txt.Text = "0";


        }

        //Receipt Button
        private void Receipt_btn_Click(object sender, EventArgs e)
        {
            receipt_rtb.Clear();
            
            receipt_rtb.AppendText("ORDER DETAILS" + Environment.NewLine);
            receipt_rtb.AppendText("------------------------------------------------------------------" + Environment.NewLine);

            receipt_rtb.AppendText("Double Espresso \t\t\t" + doubleEspresso_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Cappuccino \t\t\t\t" + cappuccino_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Americano \t\t\t\t" + americano_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Macchiato \t\t\t\t" + macchiato_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Iced-Latte \t\t\t\t" + icedLatte_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Flat White \t\t\t\t" + flatWhite_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Espresso \t\t\t\t" + espresso_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("latte \t\t\t\t\t" + latte_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("------------------------------------------------------------------" + Environment.NewLine);
            receipt_rtb.AppendText("Strawberry Waffle \t\t\t" + strawberryWaffle_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Chocolate Waffle \t\t\t" + chocolateWaffle_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Chocolate Muffin \t\t\t" + ChocolateMuffin_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("CinnamonRoll \t\t\t" + cinnamonRoll_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Cheesecake \t\t\t\t" + cheesecake_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Lemon Pie \t\t\t\t" + LemonPie_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Croissant \t\t\t\t" + croissant_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Brownies \t\t\t\t" + brownies_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("------------------------------------------------------------------" + Environment.NewLine);
            receipt_rtb.AppendText("Service Charges \t\t\t\t" + serviceCharge_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("------------------------------------------------------------------" + Environment.NewLine);
            receipt_rtb.AppendText("Tax \t\t\t\t\t" + tax_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("SubTotal \t\t\t\t" + subTotal_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("Total \t\t\t\t\t" + total_txt.Text + Environment.NewLine);
            receipt_rtb.AppendText("------------------------------------------------------------------" + Environment.NewLine);
            receipt_rtb.AppendText(timer_lbl.Text + "\t\t" + date_lbl.Text);
            
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            date_lbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            //Coffee Reset
            doubleEspresso_txt.Text = "0";
            cappuccino_txt.Text = "0";
            americano_txt.Text = "0";
            macchiato_txt.Text = "0";
            icedLatte_txt.Text = "0";
            flatWhite_txt.Text = "0";
            espresso_txt.Text = "0";
            latte_txt.Text = "0";

            // Textboxes Initially Disabled for Coffee
            doubleEspresso_txt.Enabled = false;
            cappuccino_txt.Enabled = false;
            americano_txt.Enabled = false;
            macchiato_txt.Enabled = false;
            icedLatte_txt.Enabled = false;
            flatWhite_txt.Enabled = false;
            espresso_txt.Enabled = false;
            latte_txt.Enabled = false;


            //Desserts Reset
            strawberryWaffle_txt.Text = "0";
            chocolateWaffle_txt.Text = "0";
            ChocolateMuffin_txt.Text = "0";
            cinnamonRoll_txt.Text = "0";
            cheesecake_txt.Text = "0";
            LemonPie_txt.Text = "0";
            croissant_txt.Text = "0";
            brownies_txt.Text = "0";

            // Textboxes Initially Disabled for Desserts
            strawberryWaffle_txt.Enabled = false;
            chocolateWaffle_txt.Enabled = false;
            ChocolateMuffin_txt.Enabled = false;
            cinnamonRoll_txt.Enabled = false;
            cheesecake_txt.Enabled = false;
            LemonPie_txt.Enabled = false;
            croissant_txt.Enabled = false;
            brownies_txt.Enabled = false;

            //Cost Reset
            coffeeTotal_txt.Text = "0";
            dessertsTotal_txt.Text = "0";
            serviceCharge_txt.Text = "500";

            tax_txt.Text = "0";
            subTotal_txt.Text = "0";
            total_txt.Text = "0";
        }


        //Exit Button
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         
        // COFFEE CHECKBOX CONDITIONS
        //DoubleEspresso CheckBox Coniditon
        private void DoubleEspresso_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (DoubleEspresso_chk.Checked == true)
            {
                doubleEspresso_txt.Enabled = true;
            }
            else
            {
                doubleEspresso_txt.Enabled = false;
                doubleEspresso_txt.Text = "0";
            }
        }

        private void doubleEspresso_txt_Click(object sender, EventArgs e)
        {
            doubleEspresso_txt.Text = "";
            doubleEspresso_txt.Focus();
        }



        //Cappuccino CheckBox Coniditon
        private void Cappuccino_chk_CheckedChanged(object sender, EventArgs e)
        {
            if(Cappuccino_chk.Checked == true)
            {
                cappuccino_txt.Enabled = true;
            }
            else
            {
                cappuccino_txt.Enabled = false;
                cappuccino_txt.Text = "0";
            }
        }

        private void cappuccino_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cappuccino_txt_Click(object sender, EventArgs e)
        {
            cappuccino_txt.Text = "";
            cappuccino_txt.Focus();
        }



        //Americano CheckBox Coniditon
        private void Americano_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Americano_chk.Checked == true)
            {
                americano_txt.Enabled = true;
            }
            else
            {
                americano_txt.Enabled = false;
                americano_txt.Text = "0";
            }
        }

        private void americano_txt_Click(object sender, EventArgs e)
        {
            americano_txt.Text = "";
            americano_txt.Focus();
        }


        //Macchiato CheckBox Coniditon
        private void Macchiato_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Macchiato_chk.Checked == true)
            {
                macchiato_txt.Enabled = true;
            }
            else
            {
                macchiato_txt.Enabled = false;
                macchiato_txt.Text = "0";
            }
        }

        private void macchiato_txt_Click(object sender, EventArgs e)
        {
            macchiato_txt.Text = "";
            macchiato_txt.Focus();
        }


        //Iced-Latte CheckBox Coniditon
        private void icedLatte_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (icedLatte_chk.Checked == true)
            {
                icedLatte_txt.Enabled = true;
            }
            else
            {
                icedLatte_txt.Enabled = false;
                icedLatte_txt.Text = "0";
            }
        }

        private void icedLatte_txt_Click(object sender, EventArgs e)
        {
            icedLatte_txt.Text = "";
            icedLatte_txt.Focus();
        }


        //FlatWhite CheckBox Coniditon
        private void FlatWhite_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (FlatWhite_chk.Checked == true)
            {
                flatWhite_txt.Enabled = true;
            }
            else
            {
                flatWhite_txt.Enabled = false;
                flatWhite_txt.Text = "0";
            }
        }

        private void flatWhite_txt_Click(object sender, EventArgs e)
        {
            flatWhite_txt.Text = "";
            flatWhite_txt.Focus();
        }


        //Espresso CheckBox Coniditon
        private void Espresso_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Espresso_chk.Checked == true)
            {
                espresso_txt.Enabled = true;
            }
            else
            {
                espresso_txt.Enabled = false;
                espresso_txt.Text = "0";
            }
        }

        private void espresso_txt_Click(object sender, EventArgs e)
        {
            espresso_txt.Text = "";
            espresso_txt.Focus();
        }


        //Latte CheckBox Coniditon
        private void Latte_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Latte_chk.Checked == true)
            {
                latte_txt.Enabled = true;
            }
            else
            {
                latte_txt.Enabled = false;
                latte_txt.Text = "0";
            }
        }

        private void latte_txt_Click(object sender, EventArgs e)
        {
            latte_txt.Text = "";
            latte_txt.Focus();
        }



        // DESSERTS CHECKBOX CONDITIONS
        //StrawberryWaffle CheckBox Coniditon
        private void StrawberryWaffle_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (StrawberryWaffle_chk.Checked == true)
            {
                strawberryWaffle_txt.Enabled = true;
            }
            else
            {
                strawberryWaffle_txt.Enabled = false;
                strawberryWaffle_txt.Text = "0";
            }
        }

        private void strawberryWaffle_txt_Click(object sender, EventArgs e)
        {
            strawberryWaffle_txt.Text = "";
            strawberryWaffle_txt.Focus();
        }


        //ChocolateWaffle CheckBox Coniditon
        private void ChocolateWaffle_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateWaffle_chk.Checked == true)
            {
                chocolateWaffle_txt.Enabled = true;
            }
            else
            {
                chocolateWaffle_txt.Enabled = false;
                chocolateWaffle_txt.Text = "0";
            }
        }

        private void chocolateWaffle_txt_Click(object sender, EventArgs e)
        {
            chocolateWaffle_txt.Text = "";
            chocolateWaffle_txt.Focus();
        }


        //ChocolateMuffin CheckBox Coniditon
        private void ChocolateMuffin_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateMuffin_chk.Checked == true)
            {
                ChocolateMuffin_txt.Enabled = true;
            }
            else
            {
                ChocolateMuffin_txt.Enabled = false;
                ChocolateMuffin_txt.Text = "0";
            }
        }

        private void ChocolateMuffin_txt_Click(object sender, EventArgs e)
        {
            ChocolateMuffin_txt.Text = "";
            ChocolateMuffin_txt.Focus();
        }


        //CinnamonRoll CheckBox Coniditon
        private void CinnamonRoll_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (CinnamonRoll_chk.Checked == true)
            {
                cinnamonRoll_txt.Enabled = true;
            }
            else
            {
                cinnamonRoll_txt.Enabled = false;
                cinnamonRoll_txt.Text = "0";
            }
        }

        private void cinnamonRoll_txt_Click(object sender, EventArgs e)
        {
            cinnamonRoll_txt.Text = "";
            cinnamonRoll_txt.Focus();
        }


        //Cheesecake CheckBox Coniditon
        private void Cheesecake_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Cheesecake_chk.Checked == true)
            {
                cheesecake_txt.Enabled = true;
            }
            else
            {
                cheesecake_txt.Enabled = false;
                cheesecake_txt.Text = "0";
            }
        }

        private void cheesecake_txt_Click(object sender, EventArgs e)
        {
            cheesecake_txt.Text = "";
            cheesecake_txt.Focus();
        }


        //LemonPie CheckBox Coniditon
        private void LemonPie_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (LemonPie_chk.Checked == true)
            {
                LemonPie_txt.Enabled = true;
            }
            else
            {
                LemonPie_txt.Enabled = false;
                LemonPie_txt.Text = "0";
            }
        }

        private void LemonPie_txt_Click(object sender, EventArgs e)
        {
            LemonPie_txt.Text = "";
            LemonPie_txt.Focus();
        }


        //Croissant CheckBox Coniditon
        private void Croissant_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Croissant_chk.Checked == true)
            {
                croissant_txt.Enabled = true;
            }
            else
            {
                croissant_txt.Enabled = false;
                croissant_txt.Text = "0";
            }
        }

        private void Croissant_chk_Click(object sender, EventArgs e)
        {
          
        }

        private void Brownies_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Brownies_chk.Checked == true)
            {
                brownies_txt.Enabled = true;
            }
            else
            {
                brownies_txt.Enabled = false;
                brownies_txt.Text = "0";
            }
        }

        private void brownies_txt_Click(object sender, EventArgs e)
        {
            brownies_txt.Text = "";
            brownies_txt.Focus();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_lbl.Text = DateTime.Now.ToLongTimeString();
        }


        //Print Reciept
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt_rtb.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }
        //Print Reciept DialogBox
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        // New Reciept
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            receipt_rtb.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            receipt_rtb.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            receipt_rtb.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            receipt_rtb.Paste();
        }

        // To open text file
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                receipt_rtb.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }


        // To save text file (receipt)
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(receipt_rtb.Text);
            }
        }

        

    }
}

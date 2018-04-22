using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;


namespace Excel_To_Text
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;

        int brNalozi = 0;
        int vkupnoIznos = 0;
        int redBroj = 1;
        string[] fileNames;
        int fileIndex = 0;
        string trezorskaSmetka = "100000000063095";
        string primacSmetka = "16001085677871";
        string folioBroj = "9109701503181101472873";
        string konto = "442599072";
        string celNaDoznaka = "honorar";
        string danocenBroj = "7034030974246709";
        string opstina;

        string redBrojString, embg, imeprezime, transakciskaSmetka, iznos;
        decimal diznos;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOutput.Text += "1IMCTRZ" + DateTime.Today.ToString("yyyyMMdd") + "1" + brNalozi.ToString("D6") + "+" + vkupnoIznos.ToString("D15") + ",00\r\n";
            tbTrezorskaSmetka.Text = trezorskaSmetka;
            tbPrimacSmetka.Text = primacSmetka;
            tbFolioBroj.Text = folioBroj;
            tbRashodnoKonto.Text = konto;
            tbCelNaDoznaka.Text = celNaDoznaka;
            btnIzvrsiSite.Enabled = false;
            xlApp = new Excel.Application();
        }

        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Одбери Excel фајл(ови)";

            // openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileNames = openFileDialog1.FileNames;
                label4.Text = "0 од " + fileNames.Length;
                fileIndex = 0;
                loadFile();
                fileIndex++;
                btnIzvrsiSite.Enabled = true;
            }
        }

        private void btnSledno_click(object sender, EventArgs e)
        {
            if (fileNames == null && (
                String.IsNullOrEmpty(tbCelNaDoznaka.Text)
                || (String.IsNullOrEmpty(tbEmbg.Text) && rbPP30.Checked)
                || String.IsNullOrEmpty(tbFolioBroj.Text)
                || String.IsNullOrEmpty(tbIznos.Text)
                || String.IsNullOrEmpty(tbImePrezime.Text)
                || String.IsNullOrEmpty(tbTrezorskaSmetka.Text)
                || String.IsNullOrEmpty(tbRashodnoKonto.Text)
                || String.IsNullOrEmpty(tbCelNaDoznaka.Text)
                || String.IsNullOrEmpty(tbPrimacSmetka.Text)
                || String.IsNullOrEmpty(tbTSNalogodavac.Text)))
            {
                // MessageBox.Show("Пополнете ги сите полиња и обидете се повторно");
                tbIznos_Validating(null, null);
                tbEmbg_Validating(null, null);
                tbTSNalogodavac_Validating(null, null);
                tbCelNaDoznaka_Validating(null, null);
                tbRashodnoKonto_Validating(null, null);
                tbTrezorskaSmetka_Validating(null, null);
                tbPrimacSmetka_Validating(null, null);
                tbFolioBroj_Validating(null, null);
                tbImePrezime_Validating(null, null);
                return;
            }

            
            // Vnesenite podatoci zapishi gi vo output poleto
            redBrojString = (2000000 + redBroj++).ToString();
            printRow();

            //azuriraj go header-ot
            brNalozi++;
            vkupnoIznos += (int)diznos;
            tbOutput.Text = tbOutput.Text.Remove(16, 22);
            tbOutput.Text = tbOutput.Text.Insert(16, brNalozi.ToString("D6") + "+" + vkupnoIznos.ToString("D15"));
            if (rbPP30.Checked)
            {
                clearFields();

                // Ako ima fajlovi za procesiranje prikazhi gi podatocite od sledniot falj
                if (fileNames != null)
                {
                    if (fileIndex < fileNames.Length)
                    {
                        loadFile();
                        fileIndex++;
                    }
                    else
                    {
                        btnIzvrsiSite.Enabled = false;
                        fileNames = null;
                        fileIndex = 0;
                    }
                }
            }
        }

        private void loadFile()
        {
            xlWorkbook = xlApp.Workbooks.Open(fileNames[fileIndex]);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            tbEmbg.Text = xlRange.Cells[9, 1].Value2.ToString();

            tbImePrezime.Text = kirilicaToLatinica(xlRange.Cells[9, 2].Value2.ToString());

            tbTSNalogodavac.Text = xlRange.Cells[9, 3].Value2.ToString();

            iznos = xlRange.Cells[9, 9].Value2.ToString();
            iznos = iznos.Trim(new Char[] { ' ', ',' });
            diznos = Decimal.Parse(iznos);
            
            tbIznos.Text = Convert.ToInt32(diznos).ToString();

            label4.Text = fileIndex + 1 + " од " + fileNames.Length;

            tbFilePath.Text = fileNames[fileIndex];
        }

        private void clearFields()
        {
            tbTSNalogodavac.Text = "";
            tbImePrezime.Text = "";
            tbIznos.Text = "";
            tbEmbg.Text = "";
        }

        private void btnIzvrsiSite_Click(object sender, EventArgs e)
        {
            /* Samo klikaj go btnSledno dodeka ne se procesiraat site fajlovi */
            while (fileIndex < fileNames.Length) btnSledno_click(null, null);
            btnSledno_click(sender, e);
            MessageBox.Show("Сите фајлови беа процесирани успешно!");
        }

        private void printRow()
        {
            if (rbPP30.Checked)
            {
                tbOutput.Text += redBrojString + trezorskaSmetka + primacSmetka + konto + folioBroj +
                String.Format("{0,-48}", celNaDoznaka) + "000000+" + iznos + transakciskaSmetka
                + String.Format("{0,-91}", imeprezime) + "00101                     622" + embg + "\r\n";
            }
            else
            {
                tbOutput.Text += redBrojString + trezorskaSmetka + primacSmetka + konto + folioBroj +
                String.Format("{0,-48}", celNaDoznaka) + "000000+" + iznos + transakciskaSmetka
                + String.Format("{0,-70}", imeprezime) + "840" + opstina +
                "01450    71112100                        " + danocenBroj + "\r\n";

            }
        }

        private void rbPP50_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Уплатна сметка";
            label10.Text = "Даночен број";
            tbFolioBroj.Visible = false;
            tbRashodnoKonto.Visible = false;
            tbDanocenBroj.Visible = true;
            tbUplatnaSmetka1.Visible = true;
            tbUplatnaSmetka3.Visible = true;
            tbOpstina.Visible = true;
            tbDanocenBroj.Visible = true;
            btnOdberiFile.Enabled = false;
            tbImePrezime.Text = "Narodna banka na RM";
            label5.Text = "Банка на примачот";
            tbCelNaDoznaka.Text = "personalen danok za honorar   za 1 vraboteni";
            tbTSNalogodavac.Text = trezorskaSmetka;
            tbEmbg.Enabled = false;
        }

        private void rbPP30_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Фолио број";
            label10.Text = "Расходно конто и програма";
            tbFolioBroj.Visible = true;
            tbRashodnoKonto.Visible = true;
            tbUplatnaSmetka1.Visible = false;
            tbUplatnaSmetka3.Visible = false;
            tbOpstina.Visible = false;
            tbDanocenBroj.Visible = false;
            btnOdberiFile.Enabled = true;
            tbImePrezime.Text = "";
            label5.Text = "Име и презиме";
            tbCelNaDoznaka.Text = "honorar";
            clearFields();
            tbEmbg.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string s = "ABVGDGEZZDIJKLLMNNOPRSTKUFHCCDS";
            for (int i = 0; i < s.Length; i++)
            {
                tbOutput.Text +="\"" + s[i] + "\", ";
            }
            */
            // tbOutput.Text = kirilicaToLatinica("Љубљана Чашчешка, Његош Стоичковски, Ќирил Ѓошевич");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Зачувај txt фајл";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                FileStream file = (FileStream)saveFileDialog1.OpenFile();

                byte[] info = new UTF8Encoding(true).GetBytes(tbOutput.Text);
                file.Write(info, 0, info.Length);
                file.Close();
            }
            MessageBox.Show("Зачувано!");
        }

        static char[] azbuka = { 'а', 'б', 'в', 'г', 'д', 'ѓ', 'е', 'ж', 'з', 'ѕ', 'и', 'ј', 'к', 'л', 'љ', 'м', 'н', 'њ', 'о', 'п', 'р', 'с', 'т', 'ќ', 'у', 'ф', 'х', 'ц', 'ч', 'џ', 'ш',
                              'А', 'Б', 'В', 'Г', 'Д', 'Ѓ', 'Е', 'Ж', 'З', 'Ѕ', 'И', 'Ј', 'К', 'Л', 'Љ', 'М', 'Н', 'Њ', 'О', 'П', 'Р', 'С', 'Т', 'Ќ', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Џ', 'Ш'};
        static string[] alfabeta = { "a", "b", "v", "g", "d", "gj", "e", "zh", "z", "dz", "i", "j", "k", "l", "lj", "m", "n", "nj", "o", "p", "r", "s", "t", "kj", "u", "f", "h", "c", "ch", "dј", "sh",
                                  "A", "B", "V", "G", "D", "Gj", "E", "Zh", "Z", "Dz", "I", "J", "K", "L", "Lj", "M", "N", "Nj", "O", "P", "R", "S", "T", "Kj", "U", "F", "H", "C", "Ch", "Dj", "Sh", };

        private static string kirilicaToLatinica(string s)
        {
            if (!azbuka.Contains(s[0])) return s;
            string ret = "";
            bool golemaBukva = true;
            foreach (char cc in s)
            {
                char c = cc;
                if(!golemaBukva)
                {
                    c = Char.ToLower(cc);
                }
                golemaBukva = false;
                int poz = Array.IndexOf(azbuka, c);
                if (poz != -1)
                {
                    ret += alfabeta[poz];
                }
                else if (c == ' ')
                {
                    ret += c;
                    golemaBukva = true;
                }
                else
                {
                    MessageBox.Show("Не знам како да го преведам симболот [" + c + "] во името [" + s + "] :(");
                    break;
                }
            }
            return ret;
        }


        private void tbImePrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbImePrezime.Text == "")
            {
                string error = "Внесете име и презиме";
                epIme.SetError(tbImePrezime, error);
            }
            else
            {
                epIme.SetError(tbImePrezime, "");
            }
        }

        private void tbTSNalogodavac_Validating(object sender, CancelEventArgs e)
        {
            if (tbTSNalogodavac.Text == "")
            {
                string error = "Внесете трансакциска сметка на налогодавачот";
                epTransakciska.SetError(tbTSNalogodavac, error);
            }
            else if(tbTSNalogodavac.Text.Length != 15)
            {
                epTransakciska.SetError(tbTSNalogodavac, "Трансакциската сметка треба да има точно 15 цифри");
            }
            else
            {
                epTransakciska.SetError(tbTSNalogodavac, "");
            }
        }

        private void tbCelNaDoznaka_Validating(object sender, CancelEventArgs e)
        {
            if (tbCelNaDoznaka.Text == "")
            {
                string error = "Внесете цел на дознака";
                epCelNaDoznaka.SetError(tbCelNaDoznaka, error);
            }
            else
            {
                epCelNaDoznaka.SetError(tbCelNaDoznaka, "");
            }
        }

        private void tbEmbg_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmbg.Text == "")
            {
                string error = "Внесете матичен број";
                epEmbg.SetError(tbEmbg, error);
            }
            else
            {
                epEmbg.SetError(tbEmbg, "");
            }
        }

        private void tbIznos_Validating(object sender, CancelEventArgs e)
        {
            if (tbIznos.Text == "")
            {
                string error = "Внесете износ";
                epIznos.SetError(tbIznos, error);
            }
            else
            {
                epIznos.SetError(tbIznos, "");
            }
        }

        private void tbTrezorskaSmetka_Validating(object sender, CancelEventArgs e)
        {
            if (tbTrezorskaSmetka.Text == "")
            {
                string error = "Внесете трезорска сметка";
                epTrezorskaSemtka.SetError(tbTrezorskaSmetka, error);
            }
            else
            {
                epTrezorskaSemtka.SetError(tbTrezorskaSmetka, "");
            }
        }

        private void tbPrimacSmetka_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrimacSmetka.Text == "")
            {
                string error = "Внесете сметка на примачот";
                epPrimacSmetka.SetError(tbPrimacSmetka, error);
            }
            else
            {
                epPrimacSmetka.SetError(tbPrimacSmetka, "");
            }
        }

        private void tbFolioBroj_Validating(object sender, CancelEventArgs e)
        {
            if (tbFolioBroj.Text == "")
            {
                string error = "Внесете фолио број";
                epFolio.SetError(tbFolioBroj, error);
            }
            else
            {
                epFolio.SetError(tbFolioBroj, "");
            }
        }

        private void tbRashodnoKonto_Validating(object sender, CancelEventArgs e)
        {
            if (tbRashodnoKonto.Text == "")
            {
                string error = "Внесете конто број";
                epKonto.SetError(tbRashodnoKonto, error);
            }
            else
            {
                epKonto.SetError(tbRashodnoKonto, "");
            }
        }

        private void tbCelNaDoznaka_TextChanged(object sender, EventArgs e)
        {
            celNaDoznaka = tbCelNaDoznaka.Text;
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            imeprezime = tbImePrezime.Text;
        }

        private void tbTSNalogodavac_TextChanged(object sender, EventArgs e)
        {
            transakciskaSmetka = tbTSNalogodavac.Text;
        }

        private void tbEmbg_TextChanged(object sender, EventArgs e)
        {
            embg = tbEmbg.Text;
        }

        private void tbTrezorskaSmetka_TextChanged(object sender, EventArgs e)
        {
            trezorskaSmetka = tbTrezorskaSmetka.Text;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tbOutput.Size = new System.Drawing.Size(this.Size.Width - 60, this.Size.Height -405);
        }

        

        private void tbDanocenBroj_TextChanged(object sender, EventArgs e)
        {
            danocenBroj = tbDanocenBroj.Text;
        }

        private void tbOpstina_TextChanged(object sender, EventArgs e)
        {
            opstina = tbOpstina.Text;
        }

        private void tbOpstina_Validating(object sender, CancelEventArgs e)
        {
            if (tbOpstina.Text == "")
            {
                string error = "Внесете број на општина";
                epUplatnaSmetka.SetError(tbOpstina, error);
            }
            else
            {
                epUplatnaSmetka.SetError(tbOpstina, "");
            }
        }

        private void tbDanocenBroj_Validating(object sender, CancelEventArgs e)
        {
            if (tbDanocenBroj.Text == "")
            {
                string error = "Внесете број на општина";
                epDanocenBroj.SetError(tbDanocenBroj, error);
            }
            else
            {
                epDanocenBroj.SetError(tbDanocenBroj, "");
            }
        }

        private void tbFolioBroj_TextChanged(object sender, EventArgs e)
        {
            folioBroj = tbFolioBroj.Text;
        }

        private void tbIznos_TextChanged(object sender, EventArgs e)
        {
            if (tbIznos.Text != "")
            {
                diznos = Int32.Parse(tbIznos.Text);
                iznos = diznos.ToString("000000000000000.00000");
                iznos = iznos.Replace('.', ',');
            }
        }

        private void tbRashodnoKonto_TextChanged(object sender, EventArgs e)
        {
            konto = tbRashodnoKonto.Text;
        }

        private void tbPrimacSmetka_TextChanged(object sender, EventArgs e)
        {
            primacSmetka = tbPrimacSmetka.Text;
        }
    }
}

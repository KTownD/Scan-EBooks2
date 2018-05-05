using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scan_EBooks
{
    public partial class frmEBooks : Form
    {
        public frmEBooks()
        {
            InitializeComponent();
        }

        private async void btnStartScan_Click(object sender, EventArgs e)
        {
            lbxBooks.Items.Clear();

            // Start reading all titles for the given path.
            var fileNames = Directory.EnumerateFiles(txtPathForBooks.Text, "*.txt");

            foreach (var filename in fileNames)
            {
                lbxBooks.Items.Add((object)filename);
                lblBookCount.Text = lbxBooks.Items.Count.ToString();
            }

            lblLineCount.Text = "0";

            // Loop through all titles, open each book and count the lines.
            var bookNo = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            foreach (var item in lbxBooks.Items)
            {
                bookNo++;
                var path = item.ToString();

                using (var fileStream = new StreamReader(path))
                {
                    var fileText = await fileStream.ReadToEndAsync();
                    var lineCount = fileText.Split('\n').Count();
                    lblLineCount.Text = Convert.ToString(Convert.ToInt32(lblLineCount.Text) + lineCount);
                }
                progressBar1.Value =(int) ((float)(bookNo)/(float)lbxBooks.Items.Count * (float)100);
            }

            progressBar1.Visible = false;

            //

        }
    }

}

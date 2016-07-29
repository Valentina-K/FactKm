using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Пробег_по_депо
{
    public partial class LoadData : Form
    {
        Broker br;
        Param p;
        Form1 f;
        public LoadData()
        {
            InitializeComponent();
            br = new Broker();
            p = new Param();
            f = new Form1();
            bgWorker.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progrBar.Value = e.ProgressPercentage;
            lblPercent.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           if (e.Error != null)
            {
                MessageBox.Show("Ошибка: " + e.Error.Message);
            }
            else
            {
                DialogResult result = MessageBox.Show("Загрузка данных успешно завершена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    this.Close();
            }
            
        }

        
        private void bgWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            p.year = int.Parse(f.cmbYear.SelectedItem.ToString());
            p.month = int.Parse(f.cmbMonth.SelectedIndex.ToString())+1;
            p.countdaysmonth = DateTime.DaysInMonth(p.year, p.month);
            p.dateB = new DateTime(p.year, p.month, p.countdaysmonth);
            bgWorker.ReportProgress(0);
            br.CreateTables(p);
            bgWorker.ReportProgress(20);
            br.CopyData(p);
            bgWorker.ReportProgress(40);
            br.UpdateRaceOfCars(p);
            bgWorker.ReportProgress(60);
            br.UpdateRaceOfTyres(p);
            bgWorker.ReportProgress(80);
            br.UpdateUpData(p);
            bgWorker.ReportProgress(100);
        }
    }
}

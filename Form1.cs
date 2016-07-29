using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace Пробег_по_депо
{
    public partial class Form1 : Form
    {
        Param p = new Param();
        Broker br = new Broker();
        string[] rep;
        int cas = 0;//ввод машин
        int cat = 0;//ввод шин
        DataTable dt;
        DialogResult result;
        List<string> nameTyre;
        //List<int> idTyre;
        public Form1()
        {
            InitializeComponent();
            Iniz();
        }

        private void Iniz()
        {
            cmbDepo.SelectedIndex = 0;
            cmbDepoBars.SelectedIndex = 0;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            p.depo = 1;
            rep = new string[3] {"ТО-2","Средний","Капитальный"};
            SetDate();
            p.countdaysmonth = DateTime.DaysInMonth(p.year, p.month);
            p.dateB = new DateTime(p.year,p.month,p.countdaysmonth);
            lblUpdate.Text = br.GetUpData();
            dt = new DataTable();
            lblReportHalf.Visible = false;
            lblReportMonth.Visible = false;
            HideRepotrBar();
            dataGV.Visible = false;
            grbTyre.Visible = false;
            grbTypeTyres.Visible = false;
        }

        private void Form1_Load(object sender, System.EventArgs e)//ok!
        {
            timer1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//ok!
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer1.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)//ok!
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnType_Click(object sender, EventArgs e)//ok!
        {
            dataGV.Visible = false;
            groupBox1.Visible = false;
            lblReportHalf.Visible = false;
            lblReportMonth.Visible = false;
            groupBox2.Visible = true;
            LoadTypePe();
        }

        private void LoadTypePe()//ok!
        {
            
            btnAddTypeCars.Enabled = false;
            lsbTypeCars.DataSource = br.GetTypePe(p);
            lsbTypeCars.SelectedIndex = -1;
            txtTypeCar.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)//Ok!
        {
            dataGV.Visible = false;
            cas = 0;
            groupBox2.Visible = false;
            cmbRepairOrTypePe.Visible = true;
            lblReportHalf.Visible = false;
            lblReportMonth.Visible = false;
            cmbRepairOrTypePe.DataSource=br.GetTypePe(p);
            txtPE.Visible = true;
            dateTimePicker2.Value=new DateTime(p.year,p.month,p.countdaysmonth);
            groupBox1.Text = "Ввод машин";
            groupBox1.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)//Ok!
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dataGV.Visible = false;
            lblReportHalf.Visible = true;
            lblReportMonth.Visible = true;
        }

        private void btnRepair_Click(object sender, EventArgs e)//Ok!
        {
            cas = 2;
            groupBox2.Visible = false;
            txtPE.Visible = false;
            lblReportHalf.Visible = false;
            lblReportMonth.Visible = false;
            cmbRepairOrTypePe.Visible = true;
            dataGV.Visible = false;
            cmbRepairOrTypePe.DataSource = null;
            cmbRepairOrTypePe.Items.Clear();
            cmbRepairOrTypePe.Items.AddRange(rep);
            cmbPE.DataSource = br.GetNpe(p);
            cmbPE.Visible = true;
            cmbRepairOrTypePe.SelectedIndex = 0;
            dateTimePicker2.Value = new DateTime(p.year, p.month, p.countdaysmonth);
            groupBox1.Text = "Ремонты";
            groupBox1.Visible = true;
        }

        private void tabPageCars_Leave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cas = 1;
            lblReportHalf.Visible = false;
            lblReportMonth.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Text = "Списание машин";
            cmbPE.DataSource = br.GetNpe(p);
            cmbPE.Visible = true;
            cmbRepairOrTypePe.Visible = false;
            txtPE.Visible = false;
            dataGV.Visible = false;
            dateTimePicker2.Value = new DateTime(p.year, p.month, p.countdaysmonth);
            groupBox1.Visible = true;
        }

        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)//ok!
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            ComboBox cmb=(ComboBox)sender;
            if (cmb.SelectedIndex == 0) p.depo = 1;
            else p.depo = 2;
        }

        private void lsbTypeCars_SelectedIndexChanged(object sender, EventArgs e)//ok!
        {
            ListBox cmb = (ListBox)sender;
            if (cmb.SelectedIndex != -1)
                btnDelTypeCars.Enabled = true;
            else
                btnDelTypeCars.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)//доработать!
        {
            switch (cas)//все обнулить
            {
                case 0://ввод машин
                    {
                        txtPE.Text="";
                        //dateTimePicker2.Value=DateTime.Now.Subtract(TimeSpan.FromDays(30));
                        cmbRepairOrTypePe.SelectedIndex=0;
                        
                    }
                    break;
                case 1://списание машин
                    {
                        cmbPE.SelectedIndex=-1;
                    }
                    break;
                case 2://ремонты
                    {
                        cmbPE.SelectedIndex=-1;
                        cmbRepairOrTypePe.SelectedIndex=0;
                    }
                    break;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //проверка, есть ли запись в RaceOfCars за рабочий месяц
            switch (cas)
            {
                case 0://ввод машин
                    {
                        p.pe = txtPE.Text;
                        p.dateB = dateTimePicker2.Value;
                        p.typecar = cmbRepairOrTypePe.SelectedItem.ToString().Trim();
                        br.AddCars(p);
                        txtPE.Text = "";
                    }
                    break;
                case 1://списание машин
                    {
                        p.pe = cmbPE.SelectedItem.ToString();
                        p.dateB = dateTimePicker2.Value;
                        br.DeleteCar(p);
                    }
                    break;
                case 2://ремонты
                    {
                        p.pe = cmbPE.SelectedItem.ToString();
                        p.dateB = dateTimePicker2.Value;
                        p.repair = cmbRepairOrTypePe.SelectedIndex;
                        br.UpdateRepair(p);
                    }
                    break;
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)//ok!
        {
            p.year = int.Parse(cmbYear.SelectedItem.ToString());
            p.month = cmbMonth.SelectedIndex + 1;
            p.countdaysmonth = DateTime.DaysInMonth(p.year, p.month);
            if (p.year == DateTime.Now.Year && p.month == DateTime.Now.Month - 1)//если рабочий период
            {
               if (br.IsUpdateData(p))//проверяем обновление
                   MessageBox.Show("Обновление уже было сделано! Приятной работы.");
               else 
               {
                   LoadData ld = new LoadData();//загружаем обновление
                   ld.ShowDialog();
                   lblUpdate.Text = br.GetUpData();
               }
                   
            }
            else
            {
                if (br.IsExistTables(p.month.ToString(), p.year.ToString()))//есть ли данные за выбранный архивный период
                {
                    result=MessageBox.Show("Внимание! Работа будет происходить в архивном режиме. Согласны?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        lblUpdate.Text = p.month.ToString().Trim() + "." + p.year.ToString().Trim();
                    else
                        MessageBox.Show("Выберите другой рабочий период.");
                }
                else
                    MessageBox.Show("Данных за выбранный период не существует!\nВыберите правильный рабочий период.");
            }       
        }

        private void tabPageService_Enter(object sender, EventArgs e)//ok!
        {
            SetDate();
        }
        /// <summary>
        /// Установка даты рабочего периода
        /// </summary>
        private void SetDate()
        {
            int d = DateTime.Now.Month;
            if (d == 1)
            {
                cmbMonth.SelectedIndex = 11;
                p.month = 12;
            }
            else
            {
                cmbMonth.SelectedIndex = d - 2;
                p.month = d - 1;
            }
            cmbYear.SelectedIndex = DateTime.Now.Year - 2016;
            p.year = 2016 + cmbYear.SelectedIndex;
        }

        private void txtTypeCar_TextChanged(object sender, EventArgs e)//ok!
        {
            TextBox txt=(TextBox)sender;
            if (txt.Text != "")
                btnAddTypeCars.Enabled = true;
            else
                btnAddTypeCars.Enabled = false;
        }

        private void btnAddTypeCars_Click(object sender, EventArgs e)//ok!
        {
            p.typecar = txtTypeCar.Text;
            br.AddTypePe(p);
            LoadTypePe();
        }

        private void btnDelTypeCars_Click(object sender, EventArgs e)//ok!
        {
            p.typecar = lsbTypeCars.SelectedItem.ToString();
            br.DeleteTypeCar(p);
            LoadTypePe();
        }

        private void tabPageService_Leave(object sender, EventArgs e)
        {
            p.countdaysmonth = DateTime.DaysInMonth(p.year, p.month);
        }

        private void lblReportMonth_Click(object sender, EventArgs e)//Ok!
        {
            dataGV.Visible = false;
            dataGV.DataSource = null;
            dataGV.DataSource = br.GetReportRaceOfCars(p);//?
            dataGV.Visible = true;
        }

        private void ReportForm(string nameTypeCar,DataTable dd)
        {
            //throw new NotImplementedException();
        }

        private void lblReportHalf_Click(object sender, EventArgs e)//Ok!
        {
            string nameTypeCar = "";
            List<Param> list=new List<Param>();
            list = br.GetIdTypeCar(p);
            foreach (Param ob in list)
            {
                dataGV.Visible = false;
                nameTypeCar = ob.typecar;
                dataGV.DataSource = null;
                ob.dateB = p.dateB;
                ob.depo = p.depo;
                dataGV.DataSource=br.GetReportOldOfCars(ob);
                dataGV.Visible = true;
                MessageBox.Show("Отчет по "+nameTypeCar);
                ReportForm(nameTypeCar,dt);
            }
        }

        private void btnTypeBar_Click(object sender, EventArgs e)
        {
            HideRepotrBar();
            grbTyre.Visible = false;
            listBTypeTyres.DataSource = br.GetTypeTyres(p);
            listBTypeTyres.SelectedIndex = -1;
            grbTypeTyres.Visible = true;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnUpd.Enabled = false;
        }

        private void tabPageTyre_Leave(object sender, EventArgs e)
        {
            grbTyre.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnPlus.Enabled = true;
        }

        private void listBTypeTyres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox cmb = (ListBox)sender;
            if (cmb.SelectedIndex != -1)
                btnMinus.Enabled = true;
            else
            {
                btnMinus.Enabled = false;
                btnUpd.Enabled = false;
                btnPlus.Enabled = false;
            }
        }

        private void btnEnterBar_Click(object sender, EventArgs e)
        {
            HideRepotrBar();
            cat = 0;
            txtTyre.Visible = true;
            cmbBind.Visible = true;
            cmbTyres.Visible = false;
            txtBindTyre.Visible = false;
            cmbBind.DataSource = br.GetNpe(p);
            cmbBind.Visible = true;
            cmbTypeTyres.Visible = true;
            grbTypeTyres.Visible = false;
            grbTyre.Text = "Ввод шин";
            nameTyre=br.GetTypeTyres(p);
            cmbTypeTyres.DataSource = br.typetyres;
            grbTyre.Visible = true;
        }

        private void btnDeleteBar_Click(object sender, EventArgs e)
        {
            HideRepotrBar();
            cat = 1;
            cmbTyres.DataSource = br.GetTyre(p);
            txtBindTyre.Visible = true;
            cmbBind.Visible = false;
            cmbTyres.Visible = true;
            txtTyre.Visible = false;
            cmbTypeTyres.Visible = false;
            grbTypeTyres.Visible = false;
            cmbBind.Visible = false;
            lblnameTyre.Visible = false;
            grbTyre.Text = "Списание шин";
            grbTyre.Visible = true;
        }

        private void btnMoveBar_Click(object sender, EventArgs e)
        {
            HideRepotrBar();
            cat = 2;
            txtBindTyre.Enabled = false;
            txtBindTyre.Visible = true;
            cmbTyres.DataSource = br.GetTyre(p);
            cmbTyres.Visible = true;
            txtTyre.Visible = false;
            cmbBind.DataSource = br.GetNpe(p);//здесь нужно подгрузить машины
            cmbBind.Visible = true;
            cmbTypeTyres.Visible = false;
            grbTypeTyres.Visible = false;
            lblnameTyre.Visible = false;
            grbTyre.Text = "Перемещение шин";
            grbTyre.Visible = true;
        }

        private void btnReportBar_Click(object sender, EventArgs e)
        {
            ShowRepotrBar();
        }

        private void ShowRepotrBar()
        {
            lblBinding.Visible = true;
            lblMoving.Visible = true;
            lblReportRace.Visible = true;
        }

        private void HideRepotrBar()
        {
            lblBinding.Visible = false;
            lblMoving.Visible = false;
            lblReportRace.Visible = false;
        }

        private void lblReportRace_Click(object sender, EventArgs e)
        {

        }

        private void lblMoving_Click(object sender, EventArgs e)
        {

        }

        private void lblBinding_Click(object sender, EventArgs e)
        {

        }

        private void cmbDepoBars_SelectedIndexChanged(object sender, EventArgs e)
        {
            grbTyre.Visible = false;
            grbTypeTyres.Visible = false;
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex == 0) p.depo = 1;
            else p.depo = 2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            combTypeTeres.DataSource = br.GetFreeType(p);
            combTypeTeres.Visible = true;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            br.UpdateTypeTyre(br.typetyres[listBTypeTyres.SelectedIndex], textBox1.Text, textBox2.Text);
            MessageBox.Show("Редакция внесена.");
            OperationComplite();
        }

        private void listBTypeTyres_DoubleClick(object sender, EventArgs e)
        {
            ListBox lsb=(ListBox)sender;
            btnUpd.Enabled = true;
            
            textBox1.Text = lsb.SelectedItem.ToString();
            textBox2.Text = br.GetNormaRaceItem(br.typetyres[listBTypeTyres.SelectedIndex]);
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
        }

        private void OperationComplite()
        {
            listBTypeTyres.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            btnPlus.Enabled = false;
            combTypeTeres.DataSource = null;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void combTypeTeres_SelectionChangeCommitted(object sender, EventArgs e)
        {
            result = MessageBox.Show("Внимание! Вносится новый тип: \n"+combTypeTeres.SelectedItem.ToString()+"\n"+textBox1.Text+"\n"+textBox2.Text+". Согласны?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                br.LetNewTypeTyre(combTypeTeres.SelectedItem.ToString(),textBox1.Text,textBox2.Text);
                OperationComplite();
            }
                
            else
               OperationComplite();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            
            result = MessageBox.Show("Внимание! Удаляется тип: \n" + listBTypeTyres.SelectedItem.ToString() + ". Согласны?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                br.DeleteTypeTyre(br.typetyres[listBTypeTyres.SelectedIndex]);
            else
                OperationComplite();
        }

        private void cmbTypeTyres_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblnameTyre.Text = nameTyre[cmbTypeTyres.SelectedIndex];
        }

        private void btnYesTyres_Click(object sender, EventArgs e)
        {
            switch (cat)
            {
                case 0://ввод шин
                    {
                        p.nameTyre=txtTyre.Text;
                        p.typeTyre=cmbTypeTyres.SelectedItem.ToString();
                        p.dateB=dateTimePicker3.Value;
                        p.pe = cmbBind.SelectedItem.ToString();
                        br.AddNewTyre(p);
                        txtTyre.Text = "";
                    }
                    break;
                case 1://списание шин
                    {
                        p.nameTyre = cmbTyres.SelectedItem.ToString();
                        p.dateB = dateTimePicker3.Value;
                        br.DeleteTyre(p);
                    }
                    break;
                case 2://перемещения
                    {
                        
                    }
                    break;
            }
            
        }

        private void cmbTyres_SelectionChangeCommitted(object sender, EventArgs e)
        {
            p.idTyre = int.Parse(br.idTyres[cmbTyres.SelectedIndex].ToString());
            txtBindTyre.Text = br.FindBinding(p);
        }

        private void btnNoTyres_Click(object sender, EventArgs e)
        {

        }
    }
}

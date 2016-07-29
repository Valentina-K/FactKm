using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Пробег_по_депо
{
    public class Broker
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        object[] obRow;
        OleDbConnection conn; 
        DataTable dt;
        string constring;
        public List<string> typetyres;
        public List<int> idTyres;

        public Broker()
        {
            ConnecTo();
        }

        private void ConnecTo()
        {
            constring = Environment.CurrentDirectory;
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+constring+"\\Race.mdf;Integrated Security=True");
            com = con.CreateCommand();
        }

        public List<string> GetNpe(Param p) //ok! для подключения к cmbPe
        {
            List<string> lstNpe = new List<string>();
            com.CommandText = "Select nameCar From Cars Where idDepo="+p.depo+" ORDER BY nameCar";
            try 
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstNpe.Add(dr[0].ToString()); 
                }
                dr.Close();
            }
            catch { throw; }
            finally 
            {
                if (con != null) con.Close();
            }
            return lstNpe;
        }

        public List<string> GetTypePe(Param p)//ok!
        {
            List<string> lstTypePe = new List<string>();
            com.CommandText = "Select nameType From TypeCars";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstTypePe.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return lstTypePe;
        }

        private bool IsCopyData(string mm,string yy) //ok! получение пробега за месяц в Temp по всем депо
        {
            dt=new DataTable();
            bool result = true;
            conn=new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\dbf;Extended Properties=dBASE IV;User ID=;Password=;");
            try
            {
                conn.Open();
                con.Open();
                SqlBulkCopy bulk = new SqlBulkCopy(con);
                bulk.DestinationTableName = "dbo.temp"+mm.Trim()+yy.Trim();
                bulk.BatchSize = 100000;//размер пакета передаваемых данных, нужно задавать при большом объеме данных

                OleDbCommand comm = conn.CreateCommand();
                comm.CommandText = @"SELECT depo,day,n_pe,km FROM sum_km";
                // OleDbDataReader read = comm.ExecuteReader(); как альтернатива загрузки в таблицу
                //bulk.WriteToServer(read);
                dt.Load(comm.ExecuteReader());
                bulk.WriteToServer(dt);

            }

            catch { result = false; }
            finally
            {
                conn.Close();
                con.Close();
            }
            return result;
        }

        public void CopyData(Param p) //Если данные успешно скопированы в Temp, обновляется поле idCar и всавляется пробег по Спец ПЕ
        {
            if (IsCopyData(p.month.ToString(),p.year.ToString()))
            {
                UpdateTemp(p.month.ToString(),p.year.ToString());
                AddedSpez(p);
            }
            else
                MessageBox.Show("Произошла ошибка обновления!\n Попробуйте еще раз.");
                
        }

        private List<int> GetSpez() //ok! Получаю Спец ПЕ по всем депо за указанный период
        {
            List<int> spez=new List<int>();
            com.CommandText = "Select Id From Cars Where idType=9";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    spez.Add(int.Parse(dr[0].ToString()));
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return spez;
        }

        private void AddedSpez(Param p)//Вставляю Спец ПЕ в Temp с пробегом за каждый день
        {
            DataTable dd = new DataTable();
            dd.Columns.Add("depo",typeof(string));//0
            dd.Columns.Add("day",typeof(string));//1
            dd.Columns.Add("n_pe", typeof(string));//2
            dd.Columns.Add("km",typeof(float));//3
            dd.Columns.Add("idCar",typeof(int));//4
            obRow = new object[5];
            //int countDays=DateTime.DaysInMonth(p.year,p.month);
            float daysrace = 2600 / p.countdaysmonth;
            List<int> sp = GetSpez();
            for (int i = 0; i < p.countdaysmonth; i++)
            {
                for (int j = 0; j < sp.Count; j++)
                {
                    obRow[1]=(i+1).ToString().Trim();
                    obRow[4]=sp[j];
                    obRow[3]=daysrace;

                    dd.Rows.Add(obRow);
                }
            }

            AddSpeztoTemp(dd,p.month.ToString(),p.year.ToString());
        }

        private void UpdateTemp(string mm,string yy) //ok! получаю idCar для всех n_pe в Temp
        {
            string name = "temp" + mm + yy;
            com.CommandText = "Update "+name+" SET idCar=(SELECT Id From Cars where nameCar="+name+".n_pe and idDepo="+name+".depo-1)";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private void AddSpeztoTemp(DataTable dt,string mm,string yy)//Ok!
        {
            con.Open();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
            {
                bulkCopy.DestinationTableName =
                    "dbo.temp"+mm.Trim()+yy.Trim();
                try
                {
                    // Write from the source to the destination.
                    bulkCopy.WriteToServer(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                    {
                        if (con != null) con.Close();
                    }
             }
        }

        public void AddTypePe(Param p)//ok!
        {
            com.CommandText = "INSERT INTO TypeCars (nameType) VALUES (N'"+p.typecar+"')";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        public void DeleteTypeCar(Param p)//ok!
        {
            com.CommandText = "UPDATE TypeCars SET dateDelete="+p.dateB+" WHERE nameType='"+p.typecar+"'";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        public void AddCars(Param p)//ok!
        {
            //int id=GetIdTypeCar(p);//??????(SELECT Id FROM TypeCars WHERE nameType='"+p.typecar+"')
            com.CommandText = "INSERT INTO Cars (nameCar,idDepo,dateBegin,idType) VALUES ('" + p.pe + "'," + p.depo + ",CONVERT(date,'" + p.dateB.ToShortDateString() + "',104),(SELECT Id FROM TypeCars WHERE nameType='" + p.typecar + "'))";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
                MessageBox.Show("Машина "+p.pe+" успешно внесена!");
            }
        }

        public void DeleteCar(Param p)//Ok!
        {
            com.CommandText = "UPDATE Cars SET dateDelete='"+p.dateB+"' WHERE idDepo=" + p.depo + " and nameCar='" + p.pe + "'";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        public List<Param> GetIdTypeCar(Param p)//Ok! idType,nameType
        {
            List<Param> list = new List<Param>();
            Param p1;
            com.CommandText = "SELECT Id,nameType FROM TypeCars WHERE Id IN (SELECT DISTINCT idType FROM Cars WHERE idDepo="+p.depo+")";
            try
            {
                con.Open();
                dr=com.ExecuteReader();
                while (dr.Read())
                {
                    p1 = new Param();//поскольку в list хранятся ссылки на объект, а не сам объект, нужно каждый раз создавать новый объект
                    p1.idTypeCar = int.Parse(dr[0].ToString());
                    p1.typecar = dr[1].ToString();
                    list.Add(p1);
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return list;
        }

        public string GetUpData()//!ok
        {
            string stroka="";
            com.CommandText = "SELECT * FROM UpData";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    stroka = dr[0].ToString()+"."+dr[1].ToString();
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return stroka;
        }

        public bool IsUpdateData(Param p)//!ok
        {
            string stroka=GetUpData();
            string[] dd = new string[2];
            dd=stroka.Split('.');
            if (int.Parse(dd[1]) == p.year && int.Parse(dd[0]) == p.month)
                return true;
            else
                return false;
        }

        public void UpdateUpData(Param p)//!ok
        {
            com.CommandText = "Update UpData SET year="+p.year+", month="+p.month;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }
        
        public void UpdateRaceOfCars(Param p)//Обновляется пробег в RaceOfCars 
        {
            string name = "RaceOfCars" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name1 = "temp" + p.month.ToString().Trim() + p.year.ToString().Trim();
            com.CommandText = "Update " + name + " SET "
            + "race=race+t.Skm,"
            + "raceYear=raceYear+t.Skm,"
            + "raceRepairK=CASE WHEN dateRepairK IS NULL THEN raceRepairK ELSE raceRepairK + t.Skm END,"
            + "raceRepairM=CASE WHEN dateRepairM IS NULL THEN raceRepairM ELSE raceRepairM + t.Skm END,"
            + "raceRepairT=CASE WHEN dateRepairT IS NULL THEN raceRepairT ELSE raceRepairT + t.Skm END "
            + "FROM " + name + " INNER JOIN (SELECT sum(km) Skm,idCar FROM " + name1 + " GROUP BY idCar) t ON " + name + ".idCar=t.idCar";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        public void UpdateRaceOfTyres(Param p)
        {
            string name = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name1 = "temp" + p.month.ToString().Trim() + p.year.ToString().Trim();
            com.CommandText = "Update " + name + " SET "
            + "raceBefore=race,"
            + "race=race+t.Skm "
            + "FROM " + name + " INNER JOIN (SELECT sum(km) Skm,idCar FROM "+name1+" GROUP BY idCar) t ON " + name + ".binding=t.idCar";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private float GetKm(Param p)//получение км от даты1(p.dateB) до даты2(p.coutndaysmonth)
        {
            string name = "temp" + p.month.ToString().Trim() + p.year.ToString().Trim();
            int skm = 0;
            StringBuilder strb = new StringBuilder();
            for (int i = p.dateB.Day; i <= p.countdaysmonth; i++)
            {
                strb.Append("'"+i.ToString()+"',");
            }
            strb.Remove(strb.Length - 1, 1);
            strb.ToString();
            com.CommandText = "SELECT sum(km) from " + name + " where n_pe='" + p.pe.Trim() + "' and day in ("+strb+")";
            try
            {
                con.Open();
                dr=com.ExecuteReader();
                while(dr.Read())
                    skm = int.Parse(dr[0].ToString());
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return skm;
        }
                
        public void UpdateRepair(Param p)//Ok!
        {
            float skm=GetKm(p);
            int id = GetIdCar(p);
            switch (p.repair)
            {
                case 0:
                    com.CommandText = "UPDATE RaceOfCars Set raceRepairT=" + skm + ", dateRepairT = CONVERT(date,'" + p.dateB.ToShortDateString() + "',104) WHERE idCar=" + id;
                    break;
                case 1:
                    com.CommandText = "UPDATE RaceOfCars Set raceRepairM=" + skm + ", dateRepairM = CONVERT(date,'" + p.dateB.ToShortDateString() + "',104), raceReparT = 0 WHERE idCar=" + id;
                    break;
                case 2:
                    com.CommandText = "UPDATE RaceOfCars Set raceRepairK=" + skm + ", dateRepairK = CONVERT(date,'" + p.dateB.ToShortDateString() + "',104), raceRepairM = 0, raceRepairT = 0 WHERE idCar=" + id;
                    break;
            }
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private int GetIdCar(Param p)//используется в UpdateRepair
        {
            int id = 0;
            com.CommandText = "Select idCar From Cars Where n_pe='" + p.pe.Trim() + "' and idDepo = " + p.depo;
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id=int.Parse(dr[0].ToString());
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return id;
        }
                
        public DataTable GetReportRaceOfCars(Param p)
        {
            string name = "RaceOfCars" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name1 = "temp" + p.month.ToString().Trim() + p.year.ToString().Trim();
            dt = new DataTable();
            com.CommandText = "SELECT nameCar,dateBegin,dateRepairK,dateRepairM,dateRepairT,race,raceRepairK,raceRepairM,raceRepairT,cDay,skm,raceYear FROM Cars C"
                + " LEFT JOIN "+name+" R ON C.Id=R.idCar"
                + " LEFT JOIN (SELECT idCar,SUM(km) skm,COUNT(day) cDay FROM "+name1+" GROUP BY idCar) T ON C.Id=T.idCar"
                + " WHERE idDepo="+p.depo;
            try
            {
                con.Open();
                //com.ExecuteNonQuery();
                dt.Load(com.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return dt;
        }

        public DataTable GetReportOldOfCars(Param p)//Ok!
        {
            //нужно сделать так, чтобы брался последний день месяца, отрицательные года?
            dt = new DataTable();
            com.CommandText = "SELECT nameCar as ПЕ,dateBegin as 'Дата ввода',case when month(convert(date,'" + p.dateB + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear,case when month(convert(date,'" + p.dateB + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth,day(convert(date,'" + p.dateB + "',104))-day(convert(date,dateBegin,104)) as cDay,"
            + "case when month(convert(date,'" + p.dateB.AddMonths(1) + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB.AddMonths(1) + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear1,case when month(convert(date,'" + p.dateB.AddMonths(1) + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB.AddMonths(1) + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB.AddMonths(1) + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth1,day(convert(date,'" + p.dateB.AddMonths(1) + "',104))-day(convert(date,dateBegin,104)) as cDay1,"
            + "case when month(convert(date,'" + p.dateB.AddMonths(2) + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB.AddMonths(2) + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear2,case when month(convert(date,'" + p.dateB.AddMonths(2) + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB.AddMonths(2) + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB.AddMonths(2) + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth2,day(convert(date,'" + p.dateB.AddMonths(2) + "',104))-day(convert(date,dateBegin,104)) as cDay2,"
            + "case when month(convert(date,'" + p.dateB.AddMonths(3) + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB.AddMonths(3) + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear3,case when month(convert(date,'" + p.dateB.AddMonths(3) + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB.AddMonths(3) + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB.AddMonths(3) + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth3,day(convert(date,'" + p.dateB.AddMonths(3) + "',104))-day(convert(date,dateBegin,104)) as cDay3,"
            + "case when month(convert(date,'" + p.dateB.AddMonths(4) + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB.AddMonths(4) + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear4,case when month(convert(date,'" + p.dateB.AddMonths(4) + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB.AddMonths(4) + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB.AddMonths(4) + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth4,day(convert(date,'" + p.dateB.AddMonths(4) + "',104))-day(convert(date,dateBegin,104)) as cDay4,"
            + "case when month(convert(date,'" + p.dateB.AddMonths(5) + "',104))-month(convert(date,dateBegin,104))>=0 then year(convert(date,'" + p.dateB.AddMonths(5) + "',104))-year(convert(date,dateBegin,104)) else year(convert(date,'" + p.dateB + "',104))-year(convert(date,dateBegin,104))-1 end as cYear5,case when month(convert(date,'" + p.dateB.AddMonths(5) + "',104))-month(convert(date,dateBegin,104))>=0 then month(convert(date,'" + p.dateB.AddMonths(5) + "',104))-month(convert(date,dateBegin,104)) else month(convert(date,'" + p.dateB.AddMonths(5) + "',104))-month(convert(date,dateBegin,104))+12 end as cMonth5,day(convert(date,'" + p.dateB.AddMonths(5) + "',104))-day(convert(date,dateBegin,104)) as cDay5 "
            + "FROM Cars WHERE idType="+p.idTypeCar+" AND idDepo="+p.depo+" ORDER BY nameCar";
            try
            {
                con.Open();
                //com.ExecuteNonQuery();
                dt.Load(com.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return dt;
        }

        public bool IsExistTables(string mm, string yy)
        {
            string name = "temp" + mm.Trim() + yy.Trim();
            com.CommandText = "SELECT TABLE_NAME FROM information_schema.tables";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == name)
                        break;
                }
            }
            catch { return false;}
            finally 
            {
                if (con != null) con.Close();
            }
            
            return true;
        }

        public void CreateTables(Param p)//создаю таблицы за выбранный рабочий период: temp, MovingTyres - только структура, остальные - с данными за предыдущий период
        {
            int m,y;
            if (p.month == 1)
            {
                m = 12; y = p.year - 1;
            }

            else
            {
                m = p.month - 1; y = p.year;
            }
            string name1 = "temp" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name2 = "RaceOfCars" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name3 = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string name4 = "MovingTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string from2 = "RaceOfCars" + m.ToString().Trim() + y.ToString().Trim();
            string from3 = "WorkWithTyres" + m.ToString().Trim() + y.ToString().Trim();
            try
            {
                com.CommandText = "Create table " + name1 + " ([depo]  NCHAR (10) NULL,"
                   + "[day]   NCHAR (10) NULL,"
                   + "[n_pe]  NCHAR (10) NULL,"
                   + "[km]    FLOAT (53) NULL,"
                   + "[idCar] INT        NULL)";
                   
                con.Open();
                com.ExecuteNonQuery();
                com.CommandText="Create table " + name2 + "( [idCar] INT NULL,"
                    +"[raceRepairK] FLOAT (53)    NULL,"
                    +"[raceRepairM] FLOAT (53)    NULL,"
                    +"[raceRepairT] FLOAT (53)    NULL,"
                    +"[raceYear]    FLOAT (53)    NULL,"
                    +"[race]        FLOAT (53)    NULL,"
                    +"[dateRepairK] SMALLDATETIME NULL,"
                    +"[dateRepairM] SMALLDATETIME NULL,"
                    +"[dateRepairT] SMALLDATETIME NULL)"
                    + " INSERT INTO " + name2 + " SELECT * FROM " + from2+" WHERE idCar IN (SELECT Id FROM Cars Where dateDelete IS NOT NULL)";
                com.ExecuteNonQuery();
                com.CommandText = "Create table " + name3 + "([idTyre] INT NULL,"
                    +"[binding]    INT           NULL,"
                    +"[oldBinding] INT           NULL,"
                    +"[dateMoving] SMALLDATETIME NULL,"
                    +"[race]       FLOAT (53)    NULL,"
                    +"[raceBefore] FLOAT (53)    NULL)"
                    + " INSERT INTO " + name3 + " SELECT * FROM " + from3 + " WHERE idTyre IN (SELECT Id FROM Tyres Where dateDelete IS NOT NULL)";
                com.ExecuteNonQuery();
                com.CommandText = "Create table " + name4 + "([idTyre] INT NULL,"
                    + "[binding]        INT           NULL,"
                    + "[oldBinding]     INT           NULL,"
                    + "[dateMoving]     SMALLDATETIME NULL,"
                    + "[raceOnEndMonth] FLOAT (53)    NULL,"
                    + "[raceBefore]     FLOAT (53)    NULL)";
                com.ExecuteNonQuery();
            }
            
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public DataTable GetReportOfRaceTyres(Param p)//
        {
            string name = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            dt = new DataTable();
            com.CommandText = "SELECT nameTyre,type,dateBegin,raceBefore,race-raceBefore,race,normaRace-race,binding FROM "+name+" W" 
                + " INNER JOIN (SELECT Id,nameTyre,type,normaRace,dateBegin From Tyres T" 
                + " RIGHT JOIN TypeTyres TT ON T.idType=TT.Id WHERE idDepo=" + p.depo + ") TTT" 
                + " ON W.idTyre=TTT.Id"
                + " ORDER BY nameTyre";
            try
            {
                con.Open();
                //com.ExecuteNonQuery();
                dt.Load(com.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return dt;
        }

        public DataTable GetReportOfBindingTyres(Param p)
        {
            string name = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            dt = new DataTable();
            com.CommandText = "SELECT binding,nameTyre,type,dateBegin,race, case when normaRace-race >0 then normaRace-race else \" \" FROM " + name + " W"
                + " INNER JOIN (SELECT Id,nameTyre,type,normaRace,dateBegin From Tyres T"
                + " RIGHT JOIN TypeTyres TT ON T.idType=TT.Id WHERE idDepo=" + p.depo + ") TTT"
                + " ON W.idTyre=TTT.Id"
                + " ORDER BY binding";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                dt.Load(com.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return dt;
        }

        public DataTable GetReportOfMovingTyres(Param p)
        {
            string name = "MovingTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            dt = new DataTable();
            com.CommandText = "SELECT nameTyre,type,dateMoving,oldBinding,binding,raceBefore,raceOnEndMonth FROM "+name+" W"
                + " INNER JOIN (SELECT Id,nameTyre,type From Tyres T"
                + " RIGHT JOIN TypeTyres TT ON T.idType=TT.Id WHERE idDepo=" + p.depo + ") TTT"
                + " ON W.idTyre=TTT.Id"
                + " ORDER BY nameTyre";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                dt.Load(com.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
            return dt;
        }

        public List<string> GetTyre(Param p) //ok! для подключения к cmbTyres
        {
            List<string> lstTyre = new List<string>();
            idTyres = new List<int>();
            com.CommandText = "Select nameTyre,Id From Tyres Where idDepo=" + p.depo+" ORDER BY nameTyre";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstTyre.Add(dr[0].ToString());
                    idTyres.Add(int.Parse(dr[1].ToString()));
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return lstTyre;
        }

        public List<string> GetFreeType(Param p)
        {
            string stro;
            if (p.depo == 1)
                stro = "cast([type] as int)<31";
            else
                stro = "cast([type] as int)>31";

            List<string> lstTyre = new List<string>();
            com.CommandText = "Select type From TypeTyres Where "+stro+" AND normaRace IS NULL ORDER BY cast([type] as int)";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstTyre.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return lstTyre;
        }

        public List<string> GetTypeTyres(Param p)
        {
            typetyres = new List<string>();
            string stro;
            if (p.depo == 1)
                stro = "cast([type] as int)<31";
            else
                stro = "cast([type] as int)>=31";

            List<string> lstTyre = new List<string>();
            com.CommandText = "Select nameType,type From TypeTyres Where " + stro + " AND nameType IS NOT NULL";
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstTyre.Add(dr[0].ToString());
                    typetyres.Add(dr[1].ToString());
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
            return lstTyre;
        }
        
        internal void LetNewTypeTyre(string p1, string p2, string p3)
        {
            float p3f = float.Parse(p3);
            com.CommandText = "Update TypeTyres SET nameType="+p2+", normaRace="+p3f+" WHERE type="+p1;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        internal void DeleteTypeTyre(string p)
        {
            com.CommandText = "Update TypeTyres SET nameType=null, normaRace=null WHERE type=" + p;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        internal string GetNormaRaceItem(string p)
        {
            string rez="";
            com.CommandText = "SELECT normaRace FROM TypeTyres WHERE type="+p;
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    rez = dr[0].ToString();
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
                
            }
            return rez;
        }

        internal void UpdateTypeTyre(string p,string nameT,string normaR)
        {
            com.CommandText = "Update TypeTyres SET nameType=N'"+nameT+"', normaRace="+normaR+" WHERE type=" + p;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        internal void AddNewTyre(Param p)
        {
            InsertNewTyre(p);
            com.CommandText = "INSERT INTO Tyres (nameTyre,idDepo,dateBegin,idType) VALUES ('" + p.nameTyre + "'," + p.depo + ",CONVERT(date,'" + p.dateB.ToShortDateString() + "',104),(SELECT Id FROM TypeTyres WHERE type='" + p.nameTyre + "'))";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
                MessageBox.Show("Шина " + p.nameTyre + " успешно внесена!");
            }
        }

        public void DeleteTyre(Param p)//Ok!
        {
            string name3 = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            
            com.CommandText = "UPDATE Tyres SET dateDelete='" + p.dateB + "' WHERE idDepo=" + p.depo + " and nameTyre='" + p.nameTyre + "'";
            
            float km = GetKm(p);// недоработано
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                com.CommandText = "UPDATE " + name3 + " SET oldBinding = binding, binding='8888', dateMoving = " + p.dateB + ",race = "+km+" WHERE idTyre="+p.idTyre;
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
                MessageBox.Show("Шина " + p.nameTyre + " удалена!");
            }
        }

        private void InsertNewTyre(Param p)
        {
            string name = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            float km=GetKm(p);
            com.CommandText = "INSERT INTO "+name+" (idTyre,binding,race) VALUES ((SELECT Id FROM Tyres WHERE nameTyre='" + p.nameTyre + "')," + p.pe + ",km)";
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();
            }
        }

        internal string FindBinding(Param p)
        {
            string from3 = "WorkWithTyres" + p.month.ToString().Trim() + p.year.ToString().Trim();
            string rez = "";
            com.CommandText = "SELECT binding FROM "+from3+" WHERE idTyre=" + p.idTyre;
            try
            {
                con.Open();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    rez = dr[0].ToString();
                }
                dr.Close();
            }
            catch { throw; }
            finally
            {
                if (con != null) con.Close();

            }
            return rez;
        }
    }
}

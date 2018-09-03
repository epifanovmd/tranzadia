using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TranZadIA
{
    public partial class TrainingForm : Form
    {
        public TrainingForm()
        {
            InitializeComponent();

            NextBtn.Visible = false;
            ViewDeltaBtn.Visible = false;
            txBZ.Visible = false;
            lblSum.Visible = false;

            RowCount.Value = 3;
            ColumnCount.Value = 2;

            gridA.RowCount = 3;
            gridA.Rows[0].Cells[0].Value = 75;
            gridA.Rows[1].Cells[0].Value = 100;
            gridA.Rows[2].Cells[0].Value = 70;



            gridB.RowCount = 2;
            gridB.Rows[0].Cells[0].Value = 45;
            gridB.Rows[1].Cells[0].Value = 200;




            gridC.RowCount = 3;
            gridC.ColumnCount = 2;
            gridC.Rows[0].Cells[0].Value = 7;
            gridC.Rows[1].Cells[0].Value = 1;
            gridC.Rows[2].Cells[0].Value = 9;


            gridC.Rows[0].Cells[1].Value = 4;
            gridC.Rows[1].Cells[1].Value = 6;
            gridC.Rows[2].Cells[1].Value = 5;







        }

        public struct Element
        {
            public int Index { get; set; }
            public int Value { get; set; }
            public string Q { get; set; }
            public int Delta { get; set; }
            public static int FindMinElement(int a, int b)
            {
                if (a > b)
                    return b;
                if (a == b)
                { return a; }
                else
                    return a;
            }
        }
        struct El
        {
            public int IndexI;
            public int IndexJ;
            public int Index;
        }

        public List<Element[,]> saveTableArray;
        public Object[] Csave;

        public List<int[]> saveTableU;
        public Object[] Usave;
        public List<int[]> saveTableV;
        public Object[] Vsave;

        public int CountStep;
        public int[] aDemand;
        public int[] aSupply;
        public int nVeryLargeNumber = int.MaxValue;
        public int PivotN;
        public int PivotM;
        public static int n;
        public static int m;
        Element[,] C;
        int[] U = new int[n];
        int[] V = new int[m];

        private void RowCount_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(RowCount.Value);
                aSupply = new int[n];
                m = Convert.ToInt32(ColumnCount.Value);
                aDemand = new int[m];
                C = new Element[n, m];
                gridA.RowCount = n;
                gridC.RowCount = n;
                gridA.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();
                gridC.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();
                gridB.RowCount = m;
                gridC.ColumnCount = m;
                gridB.Rows[m - 1].HeaderCell.Value = "B" + m.ToString();
                gridC.Columns[m - 1].HeaderText = "B" + m.ToString();

            }
            catch (Exception)
            {
                if (sender == RowCount)
                {
                    RowCount.Value = 1;
                }
                if (sender == ColumnCount)
                {
                    ColumnCount.Value = 1;
                }
            }
        }
        public static int countTable = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            U = (int[])Usave[countTable];
            V = (int[])Vsave[countTable];
            C = (Element[,])Csave[countTable];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try
                    {
                        if (lblQ[i, j].Text != ((C[i, j].Q == null) ? "" : C[i, j].Q) || (
                             (gridSupport.Rows[i].Cells[j].Value.ToString() == "--") ? 0 != C[i, j].Value : gridSupport.Rows[i].Cells[j].Value.ToString() != C[i, j].Value.ToString()))
                        {
                            gridSupport.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            lblOptPlan.Visible = false;
                            lblQ[i, j].BackColor = Color.Yellow;
                            //MessageBox.Show("Неправильный ввод!");
                        }
                        else
                        {
                            gridSupport.Rows[i].Cells[j].Style.BackColor = Color.White;
                            lblQ[i, j].BackColor = Color.White;
                        }
                    }
                    catch (Exception)
                    {
                        gridSupport.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        lblOptPlan.Visible = false;
                        //MessageBox.Show("Не все клетки заполнены");
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(gridSupport.Rows[i].Cells[m].Value) != U[i])
                {
                    gridSupport.Rows[i].Cells[m].Style.BackColor = Color.Yellow;
                    lblOptPlan.Visible = false;
                    //MessageBox.Show("Неправильный ввод!");
                }
                else
                {
                    gridSupport.Rows[i].Cells[m].Style.BackColor = Color.White;
                }
            }
            for (int j = 0; j < m; j++)
            {
                if (Convert.ToInt32(gridSupport.Rows[n].Cells[j].Value) != V[j])
                {
                    gridSupport.Rows[n].Cells[j].Style.BackColor = Color.Yellow;
                    lblOptPlan.Visible = false;
                    //MessageBox.Show("Неправильный ввод!");
                }
                else
                {
                    gridSupport.Rows[n].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    if (gridSupport.Rows[i].Cells[j].Style.BackColor == Color.Yellow)
                    {
                        lblOptPlan.Visible = false;
                        return;
                    }
                }
            }
            //считаем колличество пустых клеток
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == 0)
                    {
                        //колличество пустых клеток
                        k++;
                    }
                }
            }
            gridDelta.RowCount = k;
            gridDelta.RowHeadersWidth = 85;
            k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == 0)
                    {
                        gridDelta.Rows[k].HeaderCell.Value = "∆[" + (i + 1) + "," + (j + 1) + "]";
                        gridDelta.Rows[k].Cells[0].Value = "";
                        k++;
                    }
                }
            }
            NextBtn.Visible = false;
            ViewDeltaBtn.Visible = true;
            txBZ.Visible = true;
            lblSum.Visible = true;
            lblSum.Text = "Z =";
            txBZ.Text = "";
        }
        private void ViewDeltaBtn_Click(object sender, EventArgs e)
        {
            int kN = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == 0)
                    {
                        if (C[i, j].Delta.ToString() != gridDelta.Rows[kN].Cells[0].Value.ToString())
                        {
                            gridDelta.Rows[kN].HeaderCell.Style.BackColor = Color.Yellow;
                            //gridDelta.Rows[kN].Cells[0].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            gridDelta.Rows[kN].HeaderCell.Style.BackColor = Color.White;
                            //gridDelta.Rows[kN].Cells[0].Style.BackColor = Color.White;
                        }
                        kN++;
                    }
                }
            }
            kN = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == 0)
                    {
                        if (C[i, j].Delta.ToString() != gridDelta.Rows[kN].Cells[0].Value.ToString())
                        {
                            return;
                        }
                        kN++;
                    }
                }
            }
            //считаем и выводим сумму
            int Z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == -1)
                        Z += C[i, j].Index * (C[i, j].Value + 1);
                    else
                        Z += C[i, j].Index * C[i, j].Value;
                }
            }
            //lblSum.Text = "Сумма Z = " + Z.ToString();

            if (txBZ.Text != Z.ToString())
            {
                txBZ.BackColor = Color.Yellow;
                return;
            }
            else
            {
                txBZ.BackColor = Color.White;
            }
            if (countTable + 1 != Csave.Length)
            {
                countTable++;
                PrintPlanTable(countTable + 1);
                gridDelta.RowCount = 0;
                NextBtn.Visible = true;
                ViewDeltaBtn.Visible = false;
                txBZ.Visible = false;
                lblSum.Visible = false;
            }
            else
            {
                lblSum.Text = "Z = " + Z.ToString();
                lblOptPlan.Visible = true;
                NextBtn.Visible = false;
                ViewDeltaBtn.Visible = false;
                txBZ.Visible = false;
                lblSum.Visible = true;
            }
        }
        private void solveTZ()
        {
            GetUVDelta();
            if (NotOptimal())
            {
                getQ();
            }
            SaveResult();
            while (NotOptimal())
            {
                getQ();
                //gridDelta.RowCount = 0;
                BetterOptimal();
                //printZ();
                //PrintQmin();
                CountStep++;

                GetUVDelta();
                SaveResult();
            }
            btnSolve.Enabled = true;
            lblOptPlan.Visible = true;

            countTable = 0;
            PrintPlanTable(1);
        }
        private void SaveResult()
        {
            saveTableArray.Add((Element[,])C.Clone());
            Csave = new Object[saveTableArray.Count];
            int x = 0;
            foreach (var item in saveTableArray)
            {
                Csave[x] = item;
                x++;
            }
            saveTableU.Add((int[])U.Clone());
            saveTableV.Add((int[])V.Clone());
            Usave = new Object[saveTableU.Count];
            Vsave = new Object[saveTableV.Count];
            x = 0;
            foreach (var item in saveTableU)
            {
                Usave[x] = item;
                x++;
            }
            x = 0;
            foreach (var item in saveTableV)
            {
                Vsave[x] = item;
                x++;
            }
        }
        private void PrintQmin()
        {
            int nMin = nVeryLargeNumber;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Q == "-Q")
                    {
                        if (C[i, j].Value < nMin)
                        {
                            if (C[i, j].Value == -1)
                            {
                                nMin = 0;
                            }
                            else
                                nMin = C[i, j].Value;
                        }
                    }
                }
            }
            if (nMin != nVeryLargeNumber)
            {
                Qmin.Text = "Q = " + nMin;
                Qmin.Visible = true;
            }
            else
                Qmin.Visible = false;
        }
        private void printZ()
        {
            //считаем и выводим сумму
            int Z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == -1)
                        Z += C[i, j].Index * (C[i, j].Value + 1);
                    else
                        Z += C[i, j].Index * C[i, j].Value;
                }
            }
            lblSum.Text = "Сумма Z = " + Z.ToString();
        }
        Label[,] lblQ;
        public void crQ(int ii, int jj)
        {
            lblQ = new Label[ii, jj];
            for (int i = 0; i < ii; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    lblQ[i, j] = new Label();
                    lblQ[i, j].Text = "";
                    lblQ[i, j].Name = i.ToString() + "-" + j.ToString();
                    lblQ[i, j].ForeColor = Color.Red;
                    lblQ[i, j].Size = new System.Drawing.Size(25, 15);
                    lblQ[i, j].Location = new System.Drawing.Point((j * 100) + 82, (i * 40) + 25);
                    lblQ[i, j].Click += new EventHandler((sender, e) => lblQChange(sender, e, i, j));
                    gridSupport.Controls.Add(lblQ[i, j]);
                }
            }



        }
        private void clrQLabel()
        {
            foreach (var item in lblQ)
            {
                item.Text = "";
            }
        }
        private void lblQChange(object sender, EventArgs e, int i, int j)
        {
            if ((sender as Label).Text == "+Q")
            {


                gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.ForeColor = Color.Black;
                (sender as Label).Text = "";
            }
            else
            {
                if ((sender as Label).Text == "-Q")
                {
                    gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.ForeColor = Color.Red;
                    (sender as Label).Text = "+Q";
                }
                else
                {
                    if ((sender as Label).Text == "")
                    {
                        gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[Convert.ToInt32((sender as Label).Name.Split('-')[0])].Cells[Convert.ToInt32((sender as Label).Name.Split('-')[1])].Style.ForeColor = Color.Red;
                        (sender as Label).Text = "-Q";
                    }
                }
            }
        }
        private void prTarif(int i, int j, int Tarif)
        {
            Label lblTarif = new Label();
            lblTarif.Text = Tarif.ToString();
            lblTarif.Size = new System.Drawing.Size(25, 15);
            lblTarif.Location = new System.Drawing.Point((j * 100) + 155, (i * 40) + 25);
            gridSupport.Controls.Add(lblTarif);
        }
        private void PrintPlanTable(int CountTable)
        {
            lblOptPlan.Visible = false;
            gridSupport.RowCount = n;
            gridSupport.ColumnCount = m;
            gridSupport.RowHeadersWidth = 80;

            gridSupport.TopLeftHeaderCell.Value = "X" + CountTable.ToString();
            gridDelta.TopLeftHeaderCell.Value = "X" + CountTable.ToString();

            // поставщик и потребитель
            for (int i = 0; i < aSupply.Length; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
                gridSupport.Rows[i].HeaderCell.Value = aSupply[i].ToString();
            }
            for (int j = 0; j < aDemand.Length; j++)
            {
                aDemand[j] = Convert.ToInt32(gridB.Rows[j].Cells[0].Value);
                gridSupport.Columns[j].HeaderText = "      " + aDemand[j].ToString();
            }

            //инициализируем таблицу U, V
            gridSupport.RowCount = n + 1;
            gridSupport.ColumnCount = m + 1;
            gridSupport.Rows[n].HeaderCell.Value = "Vj";
            gridSupport.Columns[m].HeaderText = "Ui";
            gridSupport.Rows[0].Cells[m].Value = 0.ToString();
            gridSupport.Rows[n].Cells[m].Value = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    prTarif(i, j, C[i, j].Index);
                    gridSupport.Rows[i].Cells[j].Value = "";
                    gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    lblQ[i, j].Text = "";
                }
            }
        }
        private void GetUVDelta()
        {
            //обнуляем массивы U и V 
            U = new int[n];
            V = new int[m];

            //доп массивы для проверки пустых U и V
            bool[] Uf = new bool[n];
            bool[] Vf = new bool[m];
            Uf[0] = true;

            //сносим с первой строчки индексы в V 
            for (int i = 0; i < m; i++)
            {
                if (C[0, i].Value != 0)
                {
                    Vf[i] = true;
                    V[i] = C[0, i].Index;
                }
            }



            //считаем U и V 
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (C[i, j].Value != 0)
                        {
                            if (Vf[j] != false)
                            {
                                Uf[i] = true;
                                U[i] = Convert.ToInt32(C[i, j].Index - V[j]);
                            }
                            else
                            {
                                if (Uf[i] != false)
                                {
                                    Vf[j] = true;
                                    V[j] = Convert.ToInt32(C[i, j].Index - U[i]);
                                }
                            }
                        }
                    }
                }
                for (int i = 1; i < n; i++)
                {
                    if (Uf[i] == false)
                    {
                        flag = true;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (Vf[j] == false)
                    {
                        flag = true;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j].Delta = 0;
                    if (C[i, j].Value == 0)
                    {
                        C[i, j].Delta = (U[i] + V[j] - C[i, j].Index);
                    }
                }
            }
        }
        private ArrayList FindPath(int u, int v)
        {
            ArrayList aPath = new ArrayList();
            aPath.Add(new int[2] { u, v });
            LookHorizontaly(ref aPath, u, v, u, v);
            return aPath;
        }
        private bool LookHorizontaly(ref ArrayList aPath, int u, int v, int u1, int v1)
        {
            for (int i = 0; i < m; i++)
            {
                if (i != v && C[u, i].Value != 0)
                {
                    if (i == v1)
                    {
                        aPath.Add(new int[2] { u, i });
                        return true;
                    }
                    if (LookVerticaly(ref aPath, u, i, u1, v1))
                    {
                        aPath.Add(new int[2] { u, i });
                        return true;
                    }
                }
            }
            return false;
        }
        private bool LookVerticaly(ref ArrayList aPath, int u, int v, int u1, int v1)
        {
            for (int i = 0; i < n; i++)
            {
                if (i != u && C[i, v].Value != 0)
                {
                    if (LookHorizontaly(ref aPath, i, v, u1, v1))
                    {
                        aPath.Add(new int[2] { i, v });
                        return true;
                    }
                }
            }
            return false;
        }
        private void NorthWest()
        {
            gridDelta.RowCount = 0;
            C = new Element[n, m];
            PivotN = -1;
            PivotM = -1;
            int i = 0;
            int j = 0;

            for (i = 0; i < aSupply.Length; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (j = 0; j < aDemand.Length; j++)
            {
                aDemand[j] = Convert.ToInt32(gridB.Rows[j].Cells[0].Value);
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    C[i, j].Index = Convert.ToInt32(gridC.Rows[i].Cells[j].Value);
                }
            }
            i = j = 0;
            while (i < n && j < m)
            {
                try
                {   //ложный ноль (-1)
                    if (aSupply[i] == 0 && aDemand[j] == 0)
                    {
                        if (j + 1 != m && i + 1 != n)
                        {
                            if (C[i, j + 1].Index < C[i + 1, j].Index)
                            {
                                C[i, j + 1].Value = -1;
                            }
                            else
                            {
                                C[i + 1, j].Value = -1;
                            }
                        }
                    }
                    if (aSupply[i] == 0)
                    { i++; }
                    if (aDemand[j] == 0)
                    { j++; }

                    if (aSupply[i] == 0 && aDemand[j] == 0)
                    { i++; j++; }

                    C[i, j].Value = Element.FindMinElement(aSupply[i], aDemand[j]);


                    aSupply[i] -= C[i, j].Value;
                    aDemand[j] -= C[i, j].Value;
                }
                catch { }
            }
            //PrintPlan();
            //printZ();
        }
        private void MetodMinElement()
        {
            int[] indexNullI = new int[m * n];
            int[] indexNullJ = new int[m * n];
            gridDelta.RowCount = 0;
            C = new Element[n, m];
            El[] CC = new El[n * m];
            PivotN = -1;
            PivotM = -1;
            int i = 0;
            int j = 0;
            int indNull = 0;

            //сохраняем значения 
            for (i = 0; i < aSupply.Length; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (j = 0; j < aDemand.Length; j++)
            {
                aDemand[j] = Convert.ToInt32(gridB.Rows[j].Cells[0].Value);
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    C[i, j].Index = Convert.ToInt32(gridC.Rows[i].Cells[j].Value);
                }
            }


            //сохраняем тарифы и их индексы 
            int l = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    CC[l].Index = C[i, j].Index;
                    CC[l].IndexI = i;
                    CC[l].IndexJ = j;
                    l++;
                }
            }
            //сортируем по тарифам (индексам)
            l = 0;
            foreach (var p in CC.OrderBy(itm => itm.Index))
            {
                CC[l] = p;
                l++;
            }

            l = 0;
            int minEl = 0;
            while (l < n * m)
            {

                if (CC[l].Index != 0)
                {
                    minEl = Element.FindMinElement(aSupply[CC[l].IndexI], aDemand[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;


                    if ((aSupply[CC[l].IndexI] - minEl == 0 && aDemand[CC[l].IndexJ] - minEl == 0) && (aSupply[CC[l].IndexI] != 0 && aDemand[CC[l].IndexJ] != 0))
                    {
                        indexNullI[indNull] = CC[l].IndexI;
                        indexNullJ[indNull] = CC[l].IndexJ;
                        indNull++;
                    }

                    aSupply[CC[l].IndexI] -= minEl;
                    aDemand[CC[l].IndexJ] -= minEl;
                }

                l++;
            }

            l = 0;
            while (l < n * m)
            {
                if (CC[l].Index == 0)
                {
                    minEl = Element.FindMinElement(aSupply[CC[l].IndexI], aDemand[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;
                    aSupply[CC[l].IndexI] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                    aDemand[CC[l].IndexJ] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                }

                l++;
            }
            int s = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        s++;
                    }
                }
            }
            indNull = 0;
            while (s < n + m - 1)
            {
                int minInd = int.MaxValue;
                int indI = 0;
                int indJ = 0;

                if (indexNullJ[indNull] + 1 <= m)
                {
                    if (C[indexNullI[indNull], indexNullJ[indNull] + 1].Index < minInd)
                    {
                        minInd = C[indexNullI[indNull], indexNullJ[indNull] + 1].Index;
                        indI = indexNullI[indNull];
                        indJ = indexNullJ[indNull] + 1;
                    }
                }
                if (indexNullJ[indNull] - 1 >= 0)
                {
                    if (C[indexNullI[indNull], indexNullJ[indNull] - 1].Index < minInd)
                    {
                        minInd = C[indexNullI[indNull], indexNullJ[indNull] - 1].Index;
                        indI = indexNullI[indNull];
                        indJ = indexNullJ[indNull] - 1;
                    }
                }

                if (indexNullI[indNull] + 1 <= n)
                {
                    if (C[indexNullI[indNull] + 1, indexNullJ[indNull]].Index < minInd)
                    {
                        minInd = C[indexNullI[indNull] + 1, indexNullJ[indNull]].Index;
                        indI = indexNullI[indNull] + 1;
                        indJ = indexNullJ[indNull];
                    }
                }
                if (indexNullI[indNull] - 1 >= 0)
                {
                    if (C[indexNullI[indNull] - 1, indexNullJ[indNull]].Index < minInd)
                    {
                        minInd = C[indexNullI[indNull] - 1, indexNullJ[indNull]].Index;
                        indI = indexNullI[indNull] - 1;
                        indJ = indexNullJ[indNull];
                    }
                }
                C[indI, indJ].Value = -1;
                s++;
                indNull++;
            }
            //PrintPlan();
            //printZ();
        }
        private bool NotOptimal()
        {   //проверка на оптимальность
            int nMax = -nVeryLargeNumber;
            int x;
            //GetUVDelta();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x = C[i, j].Delta;
                    if (x > nMax)
                    {
                        nMax = x;
                        PivotN = i;
                        PivotM = j;
                    }
                }
            }
            return (nMax > 0);
        }
        private void BetterOptimal()
        {   // высчитываем оптимальный
            ArrayList aPath = new ArrayList();
            aPath = FindPath(PivotN, PivotM);
            int nMin = nVeryLargeNumber;
            int t;
            for (int w = 1; w < aPath.Count; w += 2)
            {
                t = C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value;
                if (t == -1)
                    t = 0;
                if (t < nMin)
                {
                    nMin = t;
                }
            }
            for (int w = 1; w < aPath.Count; w += 2)
            {
                if (nMin == 0)
                {
                    if (C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value == -1)
                        C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value = 0;
                    else
                        C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value -= nMin;

                    if (C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value == 0)
                        C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value = -1;
                    else
                    {
                        if (C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value == -1)
                            C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value = -1;
                        else
                            C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value += nMin;
                    }
                }
                else
                {

                    C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value -= nMin;
                    if (C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value == -1)
                        C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value += (nMin + 1);
                    else
                        C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value += nMin;
                }
            }
            //Проверка на невырожденность
            CountBaseCell();
            ClearQ();
        }
        private void CountBaseCell()
        {   // кол-во базисных клеток
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        s++;
                    }
                }
            }
            while (s < n + m - 1)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        if (C[i, j].Q == "-Q")
                        {
                            if (C[i, j].Value == 0)
                            {
                                C[i, j].Value = -1;
                                s++;
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void ClearQ()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j].Q = "";
                }
            }
        }
        public void getQ()
        {
            ClearQ();
            ArrayList aPath = new ArrayList();
            aPath = FindPath(PivotN, PivotM);
            for (int w = 1; w < aPath.Count; w += 2)
            {
                //gridSupport.Rows[(aPath[w] as int[])[0]].Cells[(aPath[w] as int[])[1]].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                //gridSupport.Rows[(aPath[w] as int[])[0]].Cells[(aPath[w] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Q = "-Q";
                //gridSupport.Rows[(aPath[w - 1] as int[])[0]].Cells[(aPath[w - 1] as int[])[1]].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                //gridSupport.Rows[(aPath[w - 1] as int[])[0]].Cells[(aPath[w - 1] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Q = "+Q";

            }
            //gridSupport.RowCount = n;
            //gridSupport.ColumnCount = m;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (C[i, j].Value != 0)
            //        {
            //            if (C[i, j].Value == -1)
            //            {
            //                //prQ(i, j, C[i, j].Q);
            //                //prTarif(i, j, C[i, j].Index);
            //                //gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n" + (C[i, j].Value + 1).ToString();
            //                //gridSupport.Rows[i].Cells[j].Value = (C[i, j].Value + 1).ToString();
            //            }
            //            else
            //            {
            //                //prQ(i, j, C[i, j].Q);
            //                //prTarif(i, j, C[i, j].Index);
            //                //gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n" + C[i, j].Value.ToString();
            //                //gridSupport.Rows[i].Cells[j].Value = C[i, j].Value.ToString();
            //            }
            //        }
            //        else
            //        {
            //            //prQ(i, j, C[i, j].Q);
            //            //prTarif(i, j, C[i, j].Index);
            //            //gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n " + "--";
            //            //gridSupport.Rows[i].Cells[j].Value = "--";
            //        }
            //    }
            //}
        }
        private void ModelType(object sender, EventArgs e)
        {
            int sumA = 0, sumB = 0;

            try
            {   //исключение
                int TEMP = 0;
                for (int i = 0; i < gridC.RowCount; i++)
                {
                    for (int j = 0; j < gridC.ColumnCount; j++)
                    {
                        TEMP = Convert.ToInt32(gridC.Rows[i].Cells[j].Value);
                    }

                }
                for (int i = 0; i < aSupply.Length; i++)
                {
                    sumA += Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
                }
                for (int j = 0; j < aDemand.Length; j++)
                {
                    sumB += Convert.ToInt32(gridB.Rows[j].Cells[0].Value);
                }
                if (sumA == sumB)
                {
                    lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A = B - Закрытая модель";
                }
                else
                {
                    if (sumA > sumB)
                    {
                        ColumnCount.Value++;
                        gridB.Rows[Convert.ToInt32(ColumnCount.Value) - 1].Cells[0].Value = sumA - sumB;

                        for (int i = 0; i < n; i++)
                        {
                            gridC.Rows[i].Cells[m - 1].Value = 0;
                        }
                        lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A > B - Открытая модель";
                    }
                    else
                    {
                        RowCount.Value++;
                        gridA.Rows[Convert.ToInt32(RowCount.Value) - 1].Cells[0].Value = sumB - sumA;

                        for (int i = 0; i < m; i++)
                        {
                            gridC.Rows[n - 1].Cells[i].Value = 0;
                        }
                        lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A < B - Открытая модель";
                    }
                }
                for (int i = 0; i < aSupply.Length; i++)
                {
                    if (Convert.ToInt32(gridA.Rows[i].Cells[0].Value) == 0)
                    {
                        throw new Exception();
                    }
                }
                for (int j = 0; j < aDemand.Length; j++)
                {

                    if (Convert.ToInt32(gridB.Rows[j].Cells[0].Value) == 0)
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectTab(0);
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
                ModelType(null, null);
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            NextBtn.Visible = true;
            ViewDeltaBtn.Visible = false;
            txBZ.Visible = false;
            lblSum.Visible = false;
            lblSum.Text = "Z =";
            try
            {
                foreach (var item in lblQ)
                {

                    gridSupport.Controls.Clear();
                }
            }
            catch (Exception)
            {
            }
            crQ(n, m);
            CountStep = 0;
            saveTableArray = new List<Element[,]>();
            saveTableU = new List<int[]>();
            saveTableV = new List<int[]>();


            Qmin.Visible = false;
            gridDelta.RowCount = 0;
            C = new Element[n, m];
            lblOptPlan.Visible = false;

            if (rbNW.Checked)
            {
                NorthWest();
            }
            else
            {
                MetodMinElement();
            }
            solveTZ();
        }
    }
}

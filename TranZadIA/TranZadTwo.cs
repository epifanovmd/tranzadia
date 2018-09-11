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
using TranZadIA;

namespace TranZadTwoIA
{
    public partial class TranZadTwo : Form
    {
        public TranZadTwo()
        {
            InitializeComponent();
            RowColCount_ValueChanged(null, null);






            RowCount.Value = 3;
            ColumnCount.Value = 3;

            gridA.RowCount = 3;
            gridA.Rows[0].Cells[0].Value = 247;
            gridA.Rows[1].Cells[0].Value = 382;
            gridA.Rows[2].Cells[0].Value = 249;



            gridB.RowCount = 3;
            gridB.Rows[0].Cells[0].Value = 542;
            gridB.Rows[1].Cells[0].Value = 179;
            gridB.Rows[2].Cells[0].Value = 203;



            gridD.RowCount = 3;
            gridD.Rows[0].Cells[0].Value = 458;
            gridD.Rows[1].Cells[0].Value = 321;
            gridD.Rows[2].Cells[0].Value = 387;


            gridCBig.RowCount = 3;
            gridCBig.ColumnCount = 3;
            gridCBig.Rows[0].Cells[0].Value = 6;
            gridCBig.Rows[1].Cells[0].Value = 8;
            gridCBig.Rows[2].Cells[0].Value = 2;


            gridCBig.Rows[0].Cells[1].Value = 4;
            gridCBig.Rows[1].Cells[1].Value = 3;
            gridCBig.Rows[2].Cells[1].Value = 7;

            gridCBig.Rows[0].Cells[2].Value = 8;
            gridCBig.Rows[1].Cells[2].Value = 5;
            gridCBig.Rows[2].Cells[2].Value = 4;



            gridCSmall.RowCount = 3;
            gridCSmall.ColumnCount = 3;
            gridCSmall.Rows[0].Cells[0].Value = 28;
            gridCSmall.Rows[1].Cells[0].Value = 25;
            gridCSmall.Rows[2].Cells[0].Value = 24;


            gridCSmall.Rows[0].Cells[1].Value = 27;
            gridCSmall.Rows[1].Cells[1].Value = 23;
            gridCSmall.Rows[2].Cells[1].Value = 24;

            gridCSmall.Rows[0].Cells[2].Value = 12;
            gridCSmall.Rows[1].Cells[2].Value = 18;
            gridCSmall.Rows[2].Cells[2].Value = 26;





        }

        class Person
        {
            private int age;

            public int Age
            {
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть больше 17");
                    }
                    else
                    {
                        age = value;
                    }
                }
                get { return age; }
            }
        }

        public struct Element
        {
            public int Index1 { get; set; }
            public int Index2 { get; set; }
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
        int numTable;

        //ввод данных в начале
        private void RowColCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(RowCount.Value);
                aSupply = new int[n + m];
                m = Convert.ToInt32(ColumnCount.Value);
                aDemand = new int[m + m];
                C = new Element[n + m, m + m];
                gridA.RowCount = n;
                gridA.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();

                gridB.RowCount = m;
                gridB.Rows[m - 1].HeaderCell.Value = "B" + m.ToString();

                gridCBig.RowCount = n;
                gridCBig.ColumnCount = m;
                gridCBig.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();
                gridCBig.Columns[m - 1].HeaderText = "D" + m.ToString();

                gridD.RowCount = m;
                gridD.Rows[m - 1].HeaderCell.Value = "D" + m.ToString();



                gridCSmall.RowCount = m;
                gridCSmall.ColumnCount = m;
                gridCSmall.Rows[m - 1].HeaderCell.Value = "D" + m.ToString();
                gridCSmall.Columns[m - 1].HeaderText = "B" + m.ToString();




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
        private void NextPlan(object sender, EventArgs e)
        {
            if (NotOptimal())
            {
                gridDelta.RowCount = 0;
                BetterOptimal();
                printZ();
                PrintPlan();
                CountStep++;
                backTable.Enabled = true;
            }
            UVDOutBtn.Enabled = true;
            NextPlanBtn.Enabled = false;
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
        private void UVDOut(object sender, EventArgs e)
        {
            UVDOutBtn.Enabled = false;
            NextPlanBtn.Enabled = true;
            if (NotOptimal())
            {
                getPrintQ();
            }
            PrintUVDelta();
            if (!NotOptimal())
            {
                UVDOutBtn.Visible = false;
                NextPlanBtn.Visible = false;
                btnSolve.Enabled = true;
                lblOptPlan.Visible = true;
                backTable.Visible = true;
                nextTable.Visible = true;
                nextTable.Enabled = false;

            }
            PrintQmin();
            SaveResult();
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
                        Z += C[i, j].Index1 * (C[i, j].Value + 1);
                    else
                        Z += C[i, j].Index1 * C[i, j].Value;
                }
            }
            lblSum.Text = "Сумма Z = " + Z.ToString();
        }
        private void PrintPlan()
        {
            gridSupport.RowCount = n + m;
            gridSupport.ColumnCount = m + m;
            gridSupport.RowHeadersWidth = 80;

            gridSupport.TopLeftHeaderCell.Value = "X" + numTable.ToString();
            gridDelta.TopLeftHeaderCell.Value = "X" + numTable.ToString();

            //if (NotOptimal())
            //{
            //    numTable++;
            //}

            //сохраняем значения 
            for (int i = 0; i < n; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (int i = n; i < n + m; i++)
            {
                aSupply[i] = Convert.ToInt32(gridD.Rows[i - n].Cells[0].Value);
            }
            for (int j = 0; j < m; j++)
            {
                aDemand[j] = Convert.ToInt32(gridD.Rows[j].Cells[0].Value);
            }
            for (int j = m; j < m + m; j++)
            {
                aDemand[j] = Convert.ToInt32(gridB.Rows[j - m].Cells[0].Value);
            }


            // поставщик, потребитель и склады
            for (int i = 0; i < n; i++)
            {
                gridSupport.Rows[i].HeaderCell.Value = aSupply[i].ToString();
            }
            for (int j = m; j < m + m; j++)
            {
                gridSupport.Columns[j].HeaderText = "      " + aDemand[j].ToString();
            }
            for (int i = n; i < n + m; i++)
            {
                gridSupport.Rows[i].HeaderCell.Value = aSupply[i].ToString();
            }
            for (int j = 0; j < m; j++)
            {
                gridSupport.Columns[j].HeaderText = "      " + aDemand[j].ToString();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = m; j < m + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }

            for (int i = n; i < n + m; i++)
            {
                for (int j = m; j < m + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n " + "--";
                    }
                }
            }
            for (int i = n; i < n+m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }





        }
        private void PrintUVDelta()
        {
            GetUVDelta();
            gridDelta.Visible = true;
            //инициализируем таблицу U, V
            gridSupport.RowCount = n + 1;
            gridSupport.ColumnCount = m + 1;
            gridSupport.Rows[n].HeaderCell.Value = "Vj";
            gridSupport.Columns[m].HeaderText = "Ui";
            gridSupport.Rows[0].Cells[m].Value = "Ui = " + 0.ToString();

            for (int i = 0; i < n; i++)
            {
                gridSupport.Rows[i].Cells[m].Value = "\nU" + (i + 1) + " = " + U[i];
            }
            for (int j = 0; j < m; j++)
            {

                gridSupport.Rows[n].Cells[j].Value = "\nV" + (j + 1) + " = " + V[j];
            }
            gridSupport.Rows[n].Cells[m].Value = "";

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

            //вывод дельт
            gridDelta.RowCount = k + 1;
            gridDelta.RowHeadersWidth = 85;
            k = 0;
            int deltaMax = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value == 0)
                    {
                        gridDelta.Rows[k].HeaderCell.Value = "∆[" + (i + 1) + "," + (j + 1) + "]";
                        gridDelta.Rows[k].Cells[0].Value = (C[i, j].Delta).ToString();

                        if (C[i, j].Delta > deltaMax)
                        {
                            deltaMax = U[i] + V[j] - C[i, j].Index1;
                        }
                        k++;
                    }
                }
            }
            gridDelta.Rows[k].HeaderCell.Value = "Max";
            gridDelta.Rows[k].Cells[0].Value = (deltaMax == 0 ? "" : deltaMax.ToString());
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
                    V[i] = C[0, i].Index1;
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
                                U[i] = Convert.ToInt32(C[i, j].Index1 - V[j]);
                            }
                            else
                            {
                                if (Uf[i] != false)
                                {
                                    Vf[j] = true;
                                    V[j] = Convert.ToInt32(C[i, j].Index1 - U[i]);
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
                        C[i, j].Delta = (U[i] + V[j] - C[i, j].Index1);
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

        private void MetodMinElement()
        {
            int[] indexNullI = new int[(n + m) * (m + m)];
            int[] indexNullJ = new int[(n + m) * (m + m)];
            gridDelta.RowCount = 0;
            C = new Element[n + m, m + m];
            El[] CC = new El[n *  m];
            PivotN = -1;
            PivotM = -1;
            int i = 0;
            int j = 0;
            int indNull = 0;

            //сохраняем значения 
            for (i = 0; i < n; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (i = n; i < n + m; i++)
            {
                aSupply[i] = Convert.ToInt32(gridD.Rows[i - n].Cells[0].Value);
            }
            for (j = 0; j < m; j++)
            {
                aDemand[j] = Convert.ToInt32(gridD.Rows[j].Cells[0].Value);
            }
            for (j = m; j < m + m; j++)
            {
                aDemand[j] = Convert.ToInt32(gridB.Rows[j - m].Cells[0].Value);
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    C[i, j].Index1 = Convert.ToInt32(gridCBig.Rows[i].Cells[j].Value);
                }
            }

            int[] skladi = new int[m];
            for (j = 0; j < m; j++)
            {
                skladi[j] = Convert.ToInt32(gridD.Rows[j].Cells[0].Value);
            }


            int[] aaSupply = new int[aSupply.Length];
            int[] aaDemand = new int[aDemand.Length];
            aaSupply = aSupply;
            aaDemand = aDemand;

            for (i = n; i < n + m; i++)
            {
                for (j = m; j < m + m; j++)
                {
                    C[i, j].Index2 = Convert.ToInt32(gridCSmall.Rows[i - n].Cells[j - m].Value);
                }
            }


            for (i = 0; i < n; i++)
            {
                for (j = m; j < m + m; j++)
                {
                    C[i, j].Value = -11;
                }
            }

            for (i = n; i < n+m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if((i-n)!=j)
                    C[i, j].Value = -11;
                }
            }


            //сохраняем тарифы и их индексы 
            int l = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    CC[l].Index = C[i, j].Index1;
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
                    minEl = Element.FindMinElement(aaSupply[CC[l].IndexI], skladi[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;


                    if ((aaSupply[CC[l].IndexI] - minEl == 0 && skladi[CC[l].IndexJ] - minEl == 0) && (aaSupply[CC[l].IndexI] != 0 && skladi[CC[l].IndexJ] != 0))
                    {
                        indexNullI[indNull] = CC[l].IndexI;
                        indexNullJ[indNull] = CC[l].IndexJ;
                        indNull++;
                    }

                    aaSupply[CC[l].IndexI] -= minEl;
                    skladi[CC[l].IndexJ] -= minEl;
                }

                l++;
            }

            l = 0;
            while (l < n * m)
            {
                if (CC[l].Index == 0)
                {
                    minEl = Element.FindMinElement(aaSupply[CC[l].IndexI], skladi[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;
                    aaSupply[CC[l].IndexI] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                    skladi[CC[l].IndexJ] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
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
                    if (C[indexNullI[indNull], indexNullJ[indNull] + 1].Index1 < minInd)
                    {
                        minInd = C[indexNullI[indNull], indexNullJ[indNull] + 1].Index1;
                        indI = indexNullI[indNull];
                        indJ = indexNullJ[indNull] + 1;
                    }
                }
                if (indexNullJ[indNull] - 1 >= 0)
                {
                    if (C[indexNullI[indNull], indexNullJ[indNull] - 1].Index1 < minInd)
                    {
                        minInd = C[indexNullI[indNull], indexNullJ[indNull] - 1].Index1;
                        indI = indexNullI[indNull];
                        indJ = indexNullJ[indNull] - 1;
                    }
                }

                if (indexNullI[indNull] + 1 <= n)
                {
                    if (C[indexNullI[indNull] + 1, indexNullJ[indNull]].Index1 < minInd)
                    {
                        minInd = C[indexNullI[indNull] + 1, indexNullJ[indNull]].Index1;
                        indI = indexNullI[indNull] + 1;
                        indJ = indexNullJ[indNull];
                    }
                }
                if (indexNullI[indNull] - 1 >= 0)
                {
                    if (C[indexNullI[indNull] - 1, indexNullJ[indNull]].Index1 < minInd)
                    {
                        minInd = C[indexNullI[indNull] - 1, indexNullJ[indNull]].Index1;
                        indI = indexNullI[indNull] - 1;
                        indJ = indexNullJ[indNull];
                    }
                }
                C[indI, indJ].Value = -1;
                s++;
                indNull++;
            }
            PrintPlan();
            //printZ();
        }


        private bool NotOptimal()
        {   //проверка на оптимальность
            int nMax = -nVeryLargeNumber;
            int x;
            GetUVDelta();

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
        public void getPrintQ()
        {
            ClearQ();
            ArrayList aPath = new ArrayList();
            aPath = FindPath(PivotN, PivotM);
            for (int w = 1; w < aPath.Count; w += 2)
            {
                gridSupport.Rows[(aPath[w] as int[])[0]].Cells[(aPath[w] as int[])[1]].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                gridSupport.Rows[(aPath[w] as int[])[0]].Cells[(aPath[w] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Q = "-Q";
                gridSupport.Rows[(aPath[w - 1] as int[])[0]].Cells[(aPath[w - 1] as int[])[1]].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                gridSupport.Rows[(aPath[w - 1] as int[])[0]].Cells[(aPath[w - 1] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Q = "+Q";

            }
            gridSupport.RowCount = n;
            gridSupport.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }
        }
        private void ModelType(object sender, EventArgs e)
        {
            int sumA = 0, sumB = 0;

            try
            {   //исключение
                int TEMP = 0;
                for (int i = 0; i < gridCBig.RowCount; i++)
                {
                    for (int j = 0; j < gridCBig.ColumnCount; j++)
                    {
                        TEMP = Convert.ToInt32(gridCBig.Rows[i].Cells[j].Value);
                    }

                }
                for (int i = 0; i < n; i++)
                {
                    sumA += Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
                }
                for (int j = 0; j < m; j++)
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
                            gridCBig.Rows[i].Cells[m - 1].Value = 0;
                        }
                        lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A > B - Открытая модель";
                    }
                    else
                    {
                        RowCount.Value++;
                        gridA.Rows[Convert.ToInt32(RowCount.Value) - 1].Cells[0].Value = sumB - sumA;

                        for (int i = 0; i < m; i++)
                        {
                            gridCBig.Rows[n - 1].Cells[i].Value = 0;
                        }
                        lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A < B - Открытая модель";
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (Convert.ToInt32(gridA.Rows[i].Cells[0].Value) == 0)
                    {
                        throw new Exception();
                    }
                }
                for (int j = 0; j < m; j++)
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
            numTable = 1;
            CountStep = 0;
            saveTableArray = new List<Element[,]>();
            saveTableU = new List<int[]>();
            saveTableV = new List<int[]>();

            backTable.Visible = false;
            backTable.Enabled = false;
            nextTable.Visible = false;
            nextTable.Enabled = false;

            Qmin.Visible = false;
            gridDelta.RowCount = 0;



            C = new Element[n + m, m + m];
            UVDOutBtn.Enabled = true;
            NextPlanBtn.Enabled = false;
            UVDOutBtn.Visible = true;
            NextPlanBtn.Visible = true;
            lblOptPlan.Visible = false;


            MetodMinElement();
        }
        private void PrintSavePlan()
        {
            gridSupport.RowCount = n;
            gridSupport.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    if (C[i, j].Q == "+Q" || C[i, j].Q == "-Q")
                    {
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            if (C[i, j].Q != "")
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            }
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Q != "")
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            }
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                        }
                    }
                    else
                    {
                        if (C[i, j].Q != "")
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        }
                        else
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        }
                        gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }
        }
        private void backTable_Click(object sender, EventArgs e)
        {
            if (CountStep > 0)
            {
                lblOptPlan.Visible = false;
                nextTable.Enabled = true;
                CountStep--;
                U = (int[])Usave[CountStep];
                V = (int[])Vsave[CountStep];
                C = (Element[,])Csave[CountStep];

                gridSupport.TopLeftHeaderCell.Value = "X" + (CountStep + 1).ToString();
                gridDelta.TopLeftHeaderCell.Value = "X" + (CountStep + 1).ToString();   //

                PrintSavePlan();
                printZ();
                PrintUVDelta();
                PrintQmin();
                if (CountStep == 0)
                    backTable.Enabled = false;
            }
        }
        private void nextTable_Click(object sender, EventArgs e)
        {
            if (CountStep < Csave.Length - 1)
            {
                backTable.Enabled = true;
                CountStep++;
                U = (int[])Usave[CountStep];
                V = (int[])Vsave[CountStep];
                C = (Element[,])Csave[CountStep];

                gridSupport.TopLeftHeaderCell.Value = "X" + (CountStep + 1).ToString();
                gridDelta.TopLeftHeaderCell.Value = "X" + (CountStep + 1).ToString();   //


                PrintSavePlan();
                printZ();
                PrintUVDelta();
                PrintQmin();
                if (CountStep == Csave.Length - 1)
                {
                    lblOptPlan.Visible = true;
                    nextTable.Enabled = false;
                }
            }
        }
        private void тренажерТЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form training = new TrainingForm();
            training.ShowDialog();
        }
    }
}
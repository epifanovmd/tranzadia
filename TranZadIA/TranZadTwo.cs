﻿using System;
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






            //RowCount.Value = 3;
            //ColumnCount.Value = 3;
            //StoreCount.Value = 3;

            //gridA.RowCount = 3;
            //gridA.Rows[0].Cells[0].Value = 247;
            //gridA.Rows[1].Cells[0].Value = 382;
            //gridA.Rows[2].Cells[0].Value = 249;



            //gridB.RowCount = 3;
            //gridB.Rows[0].Cells[0].Value = 542;
            //gridB.Rows[1].Cells[0].Value = 179;
            //gridB.Rows[2].Cells[0].Value = 203;



            //gridD.RowCount = 3;
            //gridD.Rows[0].Cells[0].Value = 458;
            //gridD.Rows[1].Cells[0].Value = 321;
            //gridD.Rows[2].Cells[0].Value = 387;


            //gridCBig.RowCount = 3;
            //gridCBig.ColumnCount = 3;
            //gridCBig.Rows[0].Cells[0].Value = 6;
            //gridCBig.Rows[1].Cells[0].Value = 8;
            //gridCBig.Rows[2].Cells[0].Value = 2;


            //gridCBig.Rows[0].Cells[1].Value = 4;
            //gridCBig.Rows[1].Cells[1].Value = 3;
            //gridCBig.Rows[2].Cells[1].Value = 7;

            //gridCBig.Rows[0].Cells[2].Value = 8;
            //gridCBig.Rows[1].Cells[2].Value = 5;
            //gridCBig.Rows[2].Cells[2].Value = 4;



            //gridCSmall.RowCount = 3;
            //gridCSmall.ColumnCount = 3;
            //gridCSmall.Rows[0].Cells[0].Value = 28;
            //gridCSmall.Rows[1].Cells[0].Value = 25;
            //gridCSmall.Rows[2].Cells[0].Value = 24;


            //gridCSmall.Rows[0].Cells[1].Value = 27;
            //gridCSmall.Rows[1].Cells[1].Value = 23;
            //gridCSmall.Rows[2].Cells[1].Value = 24;

            //gridCSmall.Rows[0].Cells[2].Value = 12;
            //gridCSmall.Rows[1].Cells[2].Value = 18;
            //gridCSmall.Rows[2].Cells[2].Value = 26;




            //RowCount.Value = 3;
            //ColumnCount.Value = 3;
            //StoreCount.Value = 3;

            //gridA.RowCount = 3;
            //gridA.Rows[0].Cells[0].Value = 120;
            //gridA.Rows[1].Cells[0].Value = 150;
            //gridA.Rows[2].Cells[0].Value = 170;



            //gridB.RowCount = 3;
            //gridB.Rows[0].Cells[0].Value = 110;
            //gridB.Rows[1].Cells[0].Value = 140;
            //gridB.Rows[2].Cells[0].Value = 150;



            //gridD.RowCount = 3;
            //gridD.Rows[0].Cells[0].Value = 200;
            //gridD.Rows[1].Cells[0].Value = 250;
            //gridD.Rows[2].Cells[0].Value = 150;


            //gridCBig.RowCount = 3;
            //gridCBig.ColumnCount = 3;
            //gridCBig.Rows[0].Cells[0].Value = 7;
            //gridCBig.Rows[1].Cells[0].Value = 8;
            //gridCBig.Rows[2].Cells[0].Value = 6;


            //gridCBig.Rows[0].Cells[1].Value = 4;
            //gridCBig.Rows[1].Cells[1].Value = 9;
            //gridCBig.Rows[2].Cells[1].Value = 5;

            //gridCBig.Rows[0].Cells[2].Value = 8;
            //gridCBig.Rows[1].Cells[2].Value = 3;
            //gridCBig.Rows[2].Cells[2].Value = 3;



            //gridCSmall.RowCount = 3;
            //gridCSmall.ColumnCount = 3;
            //gridCSmall.Rows[0].Cells[0].Value = 14;
            //gridCSmall.Rows[1].Cells[0].Value = 16;
            //gridCSmall.Rows[2].Cells[0].Value = 10;


            //gridCSmall.Rows[0].Cells[1].Value = 17;
            //gridCSmall.Rows[1].Cells[1].Value = 11;
            //gridCSmall.Rows[2].Cells[1].Value = 18;

            //gridCSmall.Rows[0].Cells[2].Value = 12;
            //gridCSmall.Rows[1].Cells[2].Value = 13;
            //gridCSmall.Rows[2].Cells[2].Value = 15;


















            RowCount.Value = 5;
            ColumnCount.Value = 6;
            StoreCount.Value = 6;

            gridA.RowCount = 5;
            gridA.Rows[0].Cells[0].Value = 120;
            gridA.Rows[1].Cells[0].Value = 80;
            gridA.Rows[2].Cells[0].Value = 300;
            gridA.Rows[3].Cells[0].Value = 250;
            gridA.Rows[4].Cells[0].Value = 50;



            gridB.RowCount = 6;
            gridB.Rows[0].Cells[0].Value = 40;
            gridB.Rows[1].Cells[0].Value = 160;
            gridB.Rows[2].Cells[0].Value = 120;
            gridB.Rows[3].Cells[0].Value = 150;
            gridB.Rows[4].Cells[0].Value = 130;
            gridB.Rows[5].Cells[0].Value = 200;



            gridD.RowCount = 6;
            gridD.Rows[0].Cells[0].Value = 100;
            gridD.Rows[1].Cells[0].Value = 30;
            gridD.Rows[2].Cells[0].Value = 70;
            gridD.Rows[3].Cells[0].Value = 240;
            gridD.Rows[4].Cells[0].Value = 160;
            gridD.Rows[5].Cells[0].Value = 200;


            gridCBig.RowCount = 5;
            gridCBig.ColumnCount = 6;
            gridCBig.Rows[0].Cells[0].Value = 3;
            gridCBig.Rows[1].Cells[0].Value = 5;
            gridCBig.Rows[2].Cells[0].Value = 3;
            gridCBig.Rows[3].Cells[0].Value = 6;
            gridCBig.Rows[4].Cells[0].Value = 1;


            gridCBig.Rows[0].Cells[1].Value = 5;
            gridCBig.Rows[1].Cells[1].Value = 6;
            gridCBig.Rows[2].Cells[1].Value = 1;
            gridCBig.Rows[3].Cells[1].Value = 1;
            gridCBig.Rows[4].Cells[1].Value = 3;

            gridCBig.Rows[0].Cells[2].Value = 1;
            gridCBig.Rows[1].Cells[2].Value = 4;
            gridCBig.Rows[2].Cells[2].Value = 5;
            gridCBig.Rows[3].Cells[2].Value = 4;
            gridCBig.Rows[4].Cells[2].Value = 5;
        
            gridCBig.Rows[0].Cells[3].Value = 4;
            gridCBig.Rows[1].Cells[3].Value = 1;
            gridCBig.Rows[2].Cells[3].Value = 2;
            gridCBig.Rows[3].Cells[3].Value = 3;
            gridCBig.Rows[4].Cells[3].Value = 2;

            gridCBig.Rows[0].Cells[4].Value = 2;
            gridCBig.Rows[1].Cells[4].Value = 8;
            gridCBig.Rows[2].Cells[4].Value = 1;
            gridCBig.Rows[3].Cells[4].Value = 5;
            gridCBig.Rows[4].Cells[4].Value = 8;

            gridCBig.Rows[0].Cells[5].Value = 3;
            gridCBig.Rows[1].Cells[5].Value = 3;
            gridCBig.Rows[2].Cells[5].Value = 3;
            gridCBig.Rows[3].Cells[5].Value = 2;
            gridCBig.Rows[4].Cells[5].Value = 4;



            gridCSmall.RowCount = 6;
            gridCSmall.ColumnCount = 6;
            gridCSmall.Rows[0].Cells[0].Value = 9;
            gridCSmall.Rows[1].Cells[0].Value = 1;
            gridCSmall.Rows[2].Cells[0].Value = 3;
            gridCSmall.Rows[3].Cells[0].Value = 7;
            gridCSmall.Rows[4].Cells[0].Value = 2;
            gridCSmall.Rows[5].Cells[0].Value = 5;

            gridCSmall.Rows[0].Cells[1].Value = 3;
            gridCSmall.Rows[1].Cells[1].Value = 6;
            gridCSmall.Rows[2].Cells[1].Value = 5;
            gridCSmall.Rows[3].Cells[1].Value = 2;
            gridCSmall.Rows[4].Cells[1].Value = 3;
            gridCSmall.Rows[5].Cells[1].Value = 3;

            gridCSmall.Rows[0].Cells[2].Value = 4;
            gridCSmall.Rows[1].Cells[2].Value = 2;
            gridCSmall.Rows[2].Cells[2].Value = 2;
            gridCSmall.Rows[3].Cells[2].Value = 5;
            gridCSmall.Rows[4].Cells[2].Value = 1;
            gridCSmall.Rows[5].Cells[2].Value = 2;

            gridCSmall.Rows[0].Cells[3].Value = 1;
            gridCSmall.Rows[1].Cells[3].Value = 5;
            gridCSmall.Rows[2].Cells[3].Value = 1;
            gridCSmall.Rows[3].Cells[3].Value = 1;
            gridCSmall.Rows[4].Cells[3].Value = 4;
            gridCSmall.Rows[5].Cells[3].Value = 4;

            gridCSmall.Rows[0].Cells[4].Value = 5;
            gridCSmall.Rows[1].Cells[4].Value = 3;
            gridCSmall.Rows[2].Cells[4].Value = 3;
            gridCSmall.Rows[3].Cells[4].Value = 4;
            gridCSmall.Rows[4].Cells[4].Value = 2;
            gridCSmall.Rows[5].Cells[4].Value = 1;

            gridCSmall.Rows[0].Cells[5].Value = 2;
            gridCSmall.Rows[1].Cells[5].Value = 8;
            gridCSmall.Rows[2].Cells[5].Value = 4;
            gridCSmall.Rows[3].Cells[5].Value = 6;
            gridCSmall.Rows[4].Cells[5].Value = 8;
            gridCSmall.Rows[5].Cells[5].Value = 3;










        }
        public struct Index
        {
            public int I { get; set; }
            public int J { get; set; }
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

        public struct IndexItem
        {
            public Element Item { get; set; }
            public int I { get; set; }
            public int J { get; set; }
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
        public int[] aStore;
        public int nVeryLargeNumber = int.MaxValue;
        public int PivotN;
        public int PivotM;
        public static int n;
        public static int m;
        public static int d;
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
                aSupply = new int[n];
                m = Convert.ToInt32(ColumnCount.Value);
                aDemand = new int[m];
                d = Convert.ToInt32(StoreCount.Value);
                aStore = new int[d];
                C = new Element[n + d, m + d];
                gridA.RowCount = n;
                gridA.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();

                gridB.RowCount = m;
                gridB.Rows[m - 1].HeaderCell.Value = "B" + m.ToString();

                gridCBig.RowCount = n;
                gridCBig.ColumnCount = d;
                gridCBig.Rows[n - 1].HeaderCell.Value = "A" + n.ToString();
                gridCBig.Columns[d - 1].HeaderText = "D" + d.ToString();

                gridD.RowCount = d;
                gridD.Rows[d - 1].HeaderCell.Value = "D" + m.ToString();



                gridCSmall.RowCount = d;
                gridCSmall.ColumnCount = m;
                gridCSmall.Rows[d - 1].HeaderCell.Value = "D" + d.ToString();
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
                if (sender == StoreCount)
                {
                    StoreCount.Value = 1;
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
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < m + d; j++)
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
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < m + d; j++)
                {
                    if (C[i, j].Value == -1)
                        Z += (i >= n || j >= d) ? C[i, j].Index2 * (C[i, j].Value + 1) : C[i, j].Index1 * (C[i, j].Value + 1);
                    else
                        Z += (i >= n || j >= d) ? C[i, j].Index2 * C[i, j].Value : C[i, j].Index1 * C[i, j].Value;
                }
            }
            lblSum.Text = "Сумма Z = " + Z.ToString();
        }
        private void PrintPlan()
        {
            gridSupport.RowCount = n + d;
            gridSupport.ColumnCount = m + d;
            gridSupport.RowHeadersWidth = 80;

            gridSupport.TopLeftHeaderCell.Value = "X" + numTable.ToString();
            gridDelta.TopLeftHeaderCell.Value = "X" + numTable.ToString();

            if (NotOptimal())
            {
                numTable++;
            }

            //сохраняем значения 
            for (int i = 0; i < n; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (int i = 0; i < d; i++)
            {
                aStore[i] = Convert.ToInt32(gridD.Rows[i].Cells[0].Value);
            }


            for (int i = 0; i < m; i++)
            {
                aDemand[i] = Convert.ToInt32(gridB.Rows[i].Cells[0].Value);
            }


            // поставщик, потребитель и склады
            for (int i = 0; i < n; i++)
            {
                gridSupport.Rows[i].HeaderCell.Value = aSupply[i].ToString();
            }
            for (int j = d; j < d + m; j++)
            {
                gridSupport.Columns[j].HeaderText = "      " + aDemand[j - d].ToString();
            }
            for (int i = n; i < n + d; i++)
            {
                gridSupport.Rows[i].HeaderCell.Value = aStore[i - n].ToString();
            }
            for (int j = 0; j < d; j++)
            {
                gridSupport.Columns[j].HeaderText = "      " + aStore[j].ToString();
            }


            //верхняя правая таблица
            for (int i = 0; i < n; i++)
            {
                for (int j = d; j < d + m; j++)
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


            //левая верхняя таблица
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < d; j++)
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
            //нижняя правая таблица
            for (int i = n; i < n + d; i++)
            {
                for (int j = d; j < d + m; j++)
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
            //левая нижняя таблица
            for (int i = n; i < n + d; i++)
            {
                for (int j = 0; j < d; j++)
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
            gridSupport.RowCount = n + d + 1;
            gridSupport.ColumnCount = d + m + 1;
            gridSupport.Rows[n + d].HeaderCell.Value = "Vj";
            gridSupport.Columns[d + m].HeaderText = "Ui";
            gridSupport.Rows[0].Cells[d + m].Value = "Ui = " + 0.ToString();

            for (int i = 0; i < n + d; i++)
            {
                gridSupport.Rows[i].Cells[d + m].Value = "\nU" + (i + 1) + " = " + U[i];
            }
            for (int j = 0; j < d + m; j++)
            {
                gridSupport.Rows[n + d].Cells[j].Value = "\nV" + (j + 1) + " = " + V[j];
            }
            gridSupport.Rows[n + d].Cells[d + m].Value = "";

            //считаем колличество пустых клеток
            int k = 0;
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
                {
                    if (C[i, j].Value == 0 || C[i, j].Value == -1)
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
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
                {
                    if (C[i, j].Value == 0 || C[i, j].Value == -1)
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
            U = new int[n + d];
            V = new int[d + m];

            //доп массивы для проверки пустых U и V
            bool[] Uf = new bool[n + d];
            bool[] Vf = new bool[d + m];
            Uf[0] = true;

            //сносим с первой строчки индексы в V 
            for (int i = 0; i < d + m; i++)
            {
                if (C[0, i].Value != 0 && C[0, i].Value != -1 && C[0, i].Value != -11)
                {
                    Vf[i] = true;
                    V[i] = (i >= n) ? C[0, i].Index2 : C[0, i].Index1;
                }
            }
            //считаем U и V 
            bool flag = true;
            int uuu = 0;
            int vvv = 0;
            while (flag)
            {
                flag = false;
                for (int i = 1; i < n + d; i++)
                {
                    for (int j = 0; j < d + m; j++)
                    {
                        if (C[i, j].Value != 0 && C[i, j].Value != -11)
                        {
                            if (Vf[j] != false)
                            {
                                uuu = Convert.ToInt32((i >= n || j >= d) ? C[i, j].Index2 - V[j] : C[i, j].Index1 - V[j]);
                                U[i] = uuu;
                                Uf[i] = true;
                            }
                            else if (Uf[i] != false)
                            {
                                vvv = Convert.ToInt32((i >= n || j >= d) ? C[i, j].Index2 - U[i] : C[i, j].Index1 - U[i]);
                                V[j] = vvv;
                                Vf[j] = true;
                            }
                        }
                    }
                }
                for (int i = 1; i < n + d; i++)
                {
                    if (Uf[i] == false)
                    {
                        flag = true;
                    }
                }
                for (int j = 0; j < d + m; j++)
                {
                    if (Vf[j] == false)
                    {
                        flag = true;
                    }
                }
            }
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
                {
                    C[i, j].Delta = 0;
                    if (C[i, j].Value == 0 || C[i, j].Value == -1)
                    {
                        C[i, j].Delta = ((i >= n || j >= d) ? U[i] + V[j] - C[i, j].Index2 : U[i] + V[j] - C[i, j].Index1);
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
            for (int i = 0; i < d + m; i++)
            {
                if (i != v && C[u, i].Value != 0 && C[u, i].Value != -11)
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
            for (int i = 0; i < n + d; i++)
            {
                if (i != u && C[i, v].Value != 0 && C[i, v].Value != -11)
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
            List<Index> indexesFalseTable = new List<Index>();

            gridDelta.RowCount = 0;
            C = new Element[n + d, d + m];
            El[] CC = new El[n * d];
            PivotN = -1;
            PivotM = -1;
            int i = 0;
            int j = 0;

            //сохраняем значения 
            for (i = 0; i < n; i++)
            {
                aSupply[i] = Convert.ToInt32(gridA.Rows[i].Cells[0].Value);

            }
            for (i = 0; i < d; i++)
            {
                aStore[i] = Convert.ToInt32(gridD.Rows[i].Cells[0].Value);
            }


            for (i = 0; i < m; i++)
            {
                aDemand[i] = Convert.ToInt32(gridB.Rows[i].Cells[0].Value);
            }




            int[] aaSupply = new int[aSupply.Length];
            int[] aaDemand = new int[aDemand.Length];
            int[] aaStore = new int[aStore.Length];
            aaSupply = (int[])aSupply.Clone();
            aaDemand = (int[])aDemand.Clone();
            aaStore = (int[])aStore.Clone();

            // индексы верхней левой таблицы
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < d; j++)
                {
                    C[i, j].Index1 = Convert.ToInt32(gridCBig.Rows[i].Cells[j].Value);
                }
            }

            // индексы нижней правой таблицы
            for (i = n; i < n + d; i++)
            {
                for (j = d; j < d + m; j++)
                {
                    C[i, j].Index2 = Convert.ToInt32(gridCSmall.Rows[i - n].Cells[j - d].Value);
                }
            }
            //смотрим есть ли 0-ые индексы в левой верхней таблице
            bool tmp = false;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < d; j++)
                {
                    if (C[i, j].Index1 == 0)
                    {
                        tmp = true;
                    }
                }
            }

            //смотрим есть ли 0-ые индексы в правой нижней таблице
            bool tmp1 = false;
            for (i = n; i < n + d; i++)
            {
                for (j = d; j < d + m; j++)
                {
                    if (C[i, j].Index2 == 0)
                    {
                        tmp1 = true;
                    }
                }
            }


            // M-ки правой верхней таблицы
            for (i = 0; i < ((tmp == true) ? n - 1 : n); i++)
            {
                for (j = d; j < ((tmp1 == true) ? d + m - 1 : d + m); j++)
                {
                    C[i, j].Value = -11;
                }
            }

            // M-ки левой нижней таблицы
            for (i = n; i < n + d; i++)
            {
                for (j = 0; j < d; j++)
                {
                    if ((i - n) != j)
                        C[i, j].Value = -11;
                }
            }


            //сохраняем тарифы и их индексы 
            int l = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < d; j++)
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
            while (l < n * d)
            {

                if (CC[l].Index != 0)
                {
                    minEl = Element.FindMinElement(aaSupply[CC[l].IndexI], aaStore[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;


                    if ((aaSupply[CC[l].IndexI] - minEl == 0 && aaStore[CC[l].IndexJ] - minEl == 0) && (aaSupply[CC[l].IndexI] != 0 && aaStore[CC[l].IndexJ] != 0))
                    {

                        indexesFalseTable.Add(new Index { I = CC[l].IndexI, J = CC[l].IndexJ });
                    }

                    aaSupply[CC[l].IndexI] -= minEl;
                    aaStore[CC[l].IndexJ] -= minEl;
                }

                l++;
            }

            l = 0;
            while (l < n * d)
            {
                if (CC[l].Index == 0)
                {
                    minEl = Element.FindMinElement(aaSupply[CC[l].IndexI], aaStore[CC[l].IndexJ]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;
                    aaSupply[CC[l].IndexI] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                    aaStore[CC[l].IndexJ] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                }

                l++;
            }


            int s = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < d; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        s++;
                    }
                }
            }


            //ложный ноль
            int indI = -1;
            int indJ = -1;

            IndexItem[] arr = new IndexItem[] { };
            IndexItem itemToRemove = new IndexItem { };

            foreach (Index indexes in indexesFalseTable)
            {
                if (s < n + d - 1)
                {

                    if (indexes.I + 1 >= n)
                    {
                        if (indexes.J + 1 >= d)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }
                        else if (indexes.J - 1 <= 0)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }

                    }

                    if (indexes.I - 1 <= 0)
                    {
                        if (indexes.J + 1 >= d)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };
                        }
                        else if (indexes.J - 1 <= 0)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };
                        }

                    }
                    if (indexes.I - 1 >= 0 && indexes.I + 1 <= n)
                    {

                        if (indexes.J + 1 >= d)
                        {
                            arr = new IndexItem[] {
                        new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                        new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                        new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                        };
                        }
                        else if (indexes.J - 1 <= 0)
                        {
                            arr = new IndexItem[] {
                        new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                        new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                        new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                        };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                        new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                        new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                        new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                        new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                        };
                        }
                    }


                    int minInd = int.MaxValue;
                    indI = -1;
                    indJ = -1;

                    foreach (IndexItem item in arr)
                    {
                        if (item.Item.Index1 <= minInd && item.Item.Value == 0 && item.Item.Value != -1)
                        {
                            minInd = item.Item.Index1;
                            indI = item.I;
                            indJ = item.J;
                        }
                    }

                    if (indI >= 0 && indJ >= 0)
                    {
                        C[indI, indJ].Value = -1;
                    }
                }
                s++;

            }

            int ind = 0;
            int value = 0;

            bool flag = false;

            for (i = 0; i < aaStore.Length; i++)
            {
                if (aaStore[i] > 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                for (i = 0; i < d; i++)
                {
                    if (aaStore[i] != 0)
                    {

                        ind = i;
                        value = aaStore[i];
                        C[i + n, i].Value = aaStore[i];
                    }

                }
            }
            else
            {
                for (i = 0; i < d; i++)
                {
                    if (i == indJ)
                    {

                        ind = i;
                        value = aaStore[i];
                        C[i + n, i].Value = -1;
                    }

                }
            }


            aaDemand = (int[])aDemand.Clone();
            aaStore = (int[])aStore.Clone();

            for (i = 0; i < d; i++)
            {
                if (i == ind)
                {

                    aaStore[i] -= value;
                }
            }


























            //правая нижняя таблица
            aaDemand = (int[])aDemand.Clone();
            aaStore = (int[])aStore.Clone();
            indexesFalseTable = new List<Index>();


            for (i = n; i < n + d; i++)
            {
                for (j = 0; j < d; j++)
                {
                    if (C[i, j].Value > 0 && i - n == j)
                    {
                        aaStore[i - n] -= C[i, j].Value;
                    }

                }
            }


            CC = new El[d * m];
            //сохраняем тарифы и их индексы 
            l = 0;
            for (i = n; i < n + d; i++)
            {
                for (j = d; j < d + m; j++)
                {
                    CC[l].Index = C[i, j].Index2;
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
            minEl = 0;
            while (l < d * m)
            {

                if (CC[l].Index != 0)
                {
                    minEl = Element.FindMinElement(aaStore[CC[l].IndexI - n], aaDemand[CC[l].IndexJ - d]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;


                    if ((aaStore[CC[l].IndexI - n] - minEl == 0 && aaDemand[CC[l].IndexJ - d] - minEl == 0) && (aaStore[CC[l].IndexI - n] != 0 && aaDemand[CC[l].IndexJ - d] != 0))
                    {
                        indexesFalseTable.Add(new Index { I = CC[l].IndexI, J = CC[l].IndexJ });
                    }

                    aaStore[CC[l].IndexI - n] -= minEl;
                    aaDemand[CC[l].IndexJ - d] -= minEl;
                }

                l++;
            }

            l = 0;
            while (l < d * m)
            {
                if (CC[l].Index == 0)
                {
                    minEl = Element.FindMinElement(aaStore[CC[l].IndexI - n], aaDemand[CC[l].IndexJ - d]);

                    C[CC[l].IndexI, CC[l].IndexJ].Value = minEl;
                    aaStore[CC[l].IndexI - n] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                    aaDemand[CC[l].IndexJ - d] -= C[CC[l].IndexI, CC[l].IndexJ].Value;
                }

                l++;
            }


            s = 0;
            for (i = n; i < n + d; i++)
            {
                for (j = d; j < d + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        s++;
                    }
                }
            }



            //ложный ноль

            arr = new IndexItem[] { };
            itemToRemove = new IndexItem { };

            foreach (Index indexes in indexesFalseTable)
            {
                if (s < d + m - 1)
                {

                    if (indexes.I + 1 >= (n + d))
                    {
                        if (indexes.J + 1 >= (d + m))
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }
                        else if (indexes.J - 1 <= m)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }

                    }

                    if (indexes.I - 1 <= d)
                    {
                        if (indexes.J + 1 >= (d + m))
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };
                        }
                        else if (indexes.J - 1 <= m)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J }
                            };
                        }

                    }

                    if (indexes.I - 1 >= d && indexes.I + 1 <= n + d)
                    {

                        if (indexes.J + 1 >= (d + m))
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }
                        else if (indexes.J - 1 <= m)
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };

                        }
                        else
                        {
                            arr = new IndexItem[] {
                            new IndexItem { Item = C[indexes.I, indexes.J + 1], I = indexes.I, J = indexes.J + 1 },
                            new IndexItem { Item = C[indexes.I, indexes.J - 1], I = indexes.I, J = indexes.J - 1 },
                            new IndexItem { Item = C[indexes.I + 1, indexes.J], I = indexes.I + 1, J = indexes.J },
                            new IndexItem { Item = C[indexes.I - 1, indexes.J], I = indexes.I - 1, J = indexes.J }
                            };
                        }
                    }

                    int minInd = int.MaxValue;
                    indI = -1;
                    indJ = -1;

                    foreach (IndexItem item in arr)
                    {
                        if (item.Item.Index2 <= minInd && item.Item.Value == 0 && item.Item.Value != -1)
                        {
                            minInd = item.Item.Index2;
                            indI = item.I;
                            indJ = item.J;
                        }
                    }

                    if (indI >= 0 && indJ >= 0)
                    {
                        C[indI, indJ].Value = -1;
                    }
                }
                s++;

            }

            PrintPlan();
            printZ();
        }


        private bool NotOptimal()
        {   //проверка на оптимальность
            int nMax = -nVeryLargeNumber;
            int x;
            GetUVDelta();

            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
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
            bool needZerro = false;
            for (int w = 1; w < aPath.Count; w += 2)
            {
                if (nMin == 0)
                {
                    // -Q
                    if (C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value == -1)
                    {
                        C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value = 0;
                    }
                    //+Q
                    if (C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value == 0)
                    {
                        C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value = -1;
                    }
                    else
                    {
                        //узнать как должно быть правильно
                        if (C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value == -1)
                        {
                            //C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value += (nMin + 1);
                        }
                        else
                        {
                            C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Value += nMin;
                        }
                    }
                }
                else
                {
                    //-Q
                    C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value -= nMin;

                    if (C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value == 0)
                    {
                        if (needZerro)
                        {
                            C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Value = -1;
                        }
                        needZerro = true;
                    }
                    //+Q
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
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        s++;
                    }
                }
            }
            while (s < n + d + d + m - 1)
            {
                for (int i = n + d - 1; i >= 0; i--)
                {
                    for (int j = d + m - 1; j >= 0; j--)
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
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
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
                gridSupport.Rows[(aPath[w] as int[])[0]].Cells[(aPath[w] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w] as int[])[0], (aPath[w] as int[])[1]].Q = "-Q";
                gridSupport.Rows[(aPath[w - 1] as int[])[0]].Cells[(aPath[w - 1] as int[])[1]].Style.ForeColor = Color.Red;
                C[(aPath[w - 1] as int[])[0], (aPath[w - 1] as int[])[1]].Q = "+Q";

            }
            gridSupport.RowCount = n + d;
            gridSupport.ColumnCount = d + m;
            for (int i = 0; i < n + d; i++)
            {
                for (int j = 0; j < d + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + ((i >= n && j >= d) ? C[i, j].Index2 : C[i, j].Index1) + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + "" + "\n" + "M";
                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + ((i >= n && j >= d) ? C[i, j].Index2 : C[i, j].Index1) + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + ((i >= n && j >= d) ? C[i, j].Index2 : C[i, j].Index1) + "\n " + "--";
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

                        for (int i = 0; i < d; i++)
                        {
                            gridCSmall.Rows[i].Cells[m - 1].Value = 0;
                        }
                        lblModelType.Text = "A = " + sumA + "; B = " + sumB + ";    A > B - Открытая модель";
                    }
                    else
                    {
                        RowCount.Value++;
                        gridA.Rows[Convert.ToInt32(RowCount.Value) - 1].Cells[0].Value = sumB - sumA;

                        for (int i = 0; i < d; i++)
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
            int sumA = 0, sumB = 0, sumD = 0, sum = 0;

            for (int i = 0; i < n; i++)
            {
                sumA += Convert.ToInt32(gridA.Rows[i].Cells[0].Value);
            }
            for (int j = 0; j < m; j++)
            {
                sumB += Convert.ToInt32(gridB.Rows[j].Cells[0].Value);
            }

            for (int j = 0; j < d; j++)
            {
                sumD += Convert.ToInt32(gridD.Rows[j].Cells[0].Value);
            }
            if (sumA > sumB)
            {
                sum = sumA;
            }
            else sum = sumB;
            

            if (sumD < sum  )
            {
                e.Cancel = true;
                MessageBox.Show("Склады должны быть больше поставщиков и потребителей.", "Ошибка");
                return;
            }
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



            C = new Element[n + d, d + m];
            UVDOutBtn.Enabled = true;
            NextPlanBtn.Enabled = false;
            UVDOutBtn.Visible = true;
            NextPlanBtn.Visible = true;
            lblOptPlan.Visible = false;


            MetodMinElement();
        }
        private void PrintSavePlan()
        {
            gridSupport.RowCount = n + d;
            gridSupport.ColumnCount = d + m;
            //верхняя правая таблица
            for (int i = 0; i < n; i++)
            {
                for (int j = d; j < d + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }


            //левая верхняя таблица
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
                    }
                }
            }
            //нижняя правая таблица
            for (int i = n; i < n + d; i++)
            {
                for (int j = d; j < d + m; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index2 + "\n " + "--";
                    }
                }
            }
            //левая нижняя таблица
            for (int i = n; i < n + d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (C[i, j].Value != 0)
                    {
                        if (C[i, j].Value == -1)
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            if (C[i, j].Value == -11)
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = "M";

                            }
                            else
                            {
                                gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                                gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n" + C[i, j].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = (C[i, j].Q != "" && C[i, j].Q != null) ? Color.Red : Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index1 + "\n " + "--";
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

        private void TranZadTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите завершить работу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
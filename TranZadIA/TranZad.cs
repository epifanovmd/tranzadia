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
using TranZadTwoIA;

namespace TranZadIA
{
    public partial class TranZad : Form
    {
        public TranZad()
        {
            InitializeComponent();
            RowColCount_ValueChanged(null, null);
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

        public struct Index
        {
            public int I { get; set; }
            public int J { get; set; }
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
                        Z += C[i, j].Index * (C[i, j].Value + 1);
                    else
                        Z += C[i, j].Index * C[i, j].Value;
                }
            }
            lblSum.Text = "Сумма Z = " + Z.ToString();
        }
        private void PrintPlan()
        {
            gridSupport.RowCount = n;
            gridSupport.ColumnCount = m;
            gridSupport.RowHeadersWidth = 80;

            gridSupport.TopLeftHeaderCell.Value = "X" + numTable.ToString();
            gridDelta.TopLeftHeaderCell.Value = "X" + numTable.ToString();

            if (NotOptimal())
            {
                numTable++;
            }

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
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n" + C[i, j].Value.ToString();
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        gridSupport.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        gridSupport.Rows[i].Cells[j].Value = ((C[i, j].Q == "") || (C[i, j].Q == null) ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n " + "--";
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
                            deltaMax = U[i] + V[j] - C[i, j].Index;
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
            PrintPlan();
            printZ();
        }
        private void MetodMinElement()
        {
            List<Index> indexesFalseTable = new List<Index>();
            gridDelta.RowCount = 0;
            C = new Element[n, m];
            El[] CC = new El[n * m];
            PivotN = -1;
            PivotM = -1;
            int i = 0;
            int j = 0;

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
                        indexesFalseTable.Add(new Index { I = CC[l].IndexI, J = CC[l].IndexJ });
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
            //ложный ноль

            IndexItem[] arr = new IndexItem[] { };
            IndexItem itemToRemove = new IndexItem { };

            foreach (Index indexes in indexesFalseTable)
            {
                if (s < n + m - 1)
                {

                    if (indexes.I + 1 >= n)
                    {
                        if (indexes.J + 1 >= m)
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
                        if (indexes.J + 1 >= m)
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

                        if (indexes.J + 1 >= m)
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

                    int indI = -1;
                    int indJ = -1;

                    int minInd = int.MaxValue;

                    foreach (IndexItem item in arr)
                    {
                        if (item.Item.Index <= minInd && item.Item.Value == 0 && item.Item.Value != -1)
                        {
                            minInd = item.Item.Index;
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
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n" + (C[i, j].Value + 1).ToString();
                        }
                        else
                        {
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n" + C[i, j].Value.ToString();
                        }
                    }
                    else
                    {
                        gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "            " + C[i, j].Index + "\n " + "--";
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
            C = new Element[n, m];
            UVDOutBtn.Enabled = true;
            NextPlanBtn.Enabled = false;
            UVDOutBtn.Visible = true;
            NextPlanBtn.Visible = true;
            lblOptPlan.Visible = false;

            if (rbNW.Checked)
            {
                NorthWest();
            }
            else
            {
                MetodMinElement();
            }

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
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n" + (C[i, j].Value + 1).ToString();
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
                            gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n" + C[i, j].Value.ToString();
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
                        gridSupport.Rows[i].Cells[j].Value = (C[i, j].Q == "" ? "          " : C[i, j].Q) + "          " + C[i, j].Index + "\n " + "--";
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

        private void двухэтапнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tranzadtwo = new TranZadTwo();
            tranzadtwo.ShowDialog();
        }

        private void TranZad_FormClosing(object sender, FormClosingEventArgs e)
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
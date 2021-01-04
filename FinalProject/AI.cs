using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace  FinalProject
{
    public class AI
    {
        int test = 0;

        int count = 0;
        bool[,,] wins = new bool[572, 16, 16];//[高,二維]

        int[] myWin = new int[572];
        int[] aiWin = new int[572];
        public AI()//在建構時就生成
        {
            #region 勝利組合
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        wins[count, i, j + k] = true;
                    }
                    count++;
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        wins[count, j + k, i] = true;
                    }
                    count++;
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        wins[count, i + k, j + k] = true;
                    }
                    count++;
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 14; j > 3; j--)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        wins[count, i + k, j - k] = true;
                    }
                    count++;
                }
            }
            #endregion
        }

        public void computer()
        {
            int max = 0;
            int def = 0;
            int x = 0, y = 0;
            myWin = new int[572];
            aiWin = new int[572];
            check();

            int[,] myScore = new int[15, 15];//攻擊分數
            int[,] aiScore = new int[15, 15];//防守分數

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (board[i, j] == 0)
                    {
                        for (int k = 0; k < count; k++)
                        {
                            if (wins[k, i, j])
                            {
                                switch (aiWin[k])
                                {
                                    case 1:
                                        aiScore[i, j] += 10;
                                        break;
                                    case 2:
                                        aiScore[i, j] += 100;
                                        break;
                                    case 3:
                                        aiScore[i, j] += 1000;
                                        break;
                                    case 4:
                                        aiScore[i, j] += 10000;
                                        break;
                                }
                                switch (myWin[k])
                                {
                                    case 1:
                                        myScore[i, j] += 15;
                                        break;
                                    case 2:
                                        myScore[i, j] += 150;
                                        break;
                                    case 3:
                                        myScore[i, j] += 1500;
                                        break;
                                    case 4:
                                        myScore[i, j] += 15000;
                                        break;
                                }
                            }
                        }
                        if (aiScore[i, j] > max)
                        {
                            max = aiScore[i, j];
                            x = i;
                            y = j;
                        }
                        else if (aiScore[i, j] == max)
                        {
                            if (myScore[i, j] > myScore[x, y])
                            {
                                x = i;
                                y = j;
                            }
                        }

                        if (myScore[i, j] > max)
                        {
                            max = myScore[i, j];
                            x = i;
                            y = j;
                        }
                        else if (myScore[i, j] == max)
                        {
                            if (aiScore[i, j] > aiScore[x, y])
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                }
            }
            loc = new Point(x, y);
        }
        private void check()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (board[i, j] == 1)
                    {
                        for (int k = 0; k < count; k++)
                        {
                            if (wins[k, i, j])
                            {
                                myWin[k] = 6;
                                aiWin[k]++;
                            }
                        }
                    }

                    if (board[i, j] == 2)
                    {
                        for (int k = 0; k < count; k++)
                        {
                            if (wins[k, i, j])
                            {
                                myWin[k]++;
                                aiWin[k] = 6;
                            }
                        }
                    }
                }
            }
        }
        public int[,] board { get; set; }//當前棋盤
        public Point loc{ get; set; }
        

    }
}

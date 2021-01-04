using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CircleProgressBar : Control
    {
        private Pen penBottom = null;//底層
        private Pen penTop = null;//上層
        private Pen penFinished = null;//√的圖

        
        protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }
        
        public CircleProgressBar()
        {
            InitControl();
            //初始值
            this.penBottom = new Pen(this.bottomColor, 30);
            this.penTop = new Pen(this.topColor, 30);
            this.penFinished = new Pen(this.finishedColor, 5);

            this.SizeChanged += delegate
            {
                this.Invalidate();
            };
        }
        /// 初始化
        private void InitControl()
        {
            this.Width = 350;
            this.Height = 350;
            this.BackColor = Color.White;
        }

        #region 属性
        //-------------------值
        private int maxValue = 100;
        private int progress = 50;
        
        /// 最大值
        public int MaxValue
        {
            get
            {
                return this.maxValue;
            }
            set
            {
                if (value < this.progress)
                {
                    return;
                }
                this.maxValue = value;
                this.Invalidate();
            }
        }
        
        /// 進度值
        public int Progress
        {
            get { return this.progress; }
            set
            {
                if (value > this.maxValue)
                {
                    return;
                }
                this.progress = value;
                this.Invalidate();
            }
        }

        //-------------------颜色
        private Color bottomColor = Color.FromArgb(224, 224, 224);
        private Color topColor = Color.FromArgb(109, 179, 63);
        private Color finishedColor = Color.FromArgb(109, 179, 63);

        public Color BottomColor
        {
            get { return this.bottomColor; }
            set
            {
                this.bottomColor = value;
                this.penBottom.Color = value;
                this.Invalidate();
            }
        }
        public Color TopColor
        {
            get { return this.topColor; }
            set
            {
                this.topColor = value;
                this.penTop.Color = value;
                this.Invalidate();
            }
        }
        public Color FinishedColor
        {
            get { return this.finishedColor; }
            set
            {
                this.finishedColor = value;
                this.penFinished.Color = value;
                this.Invalidate();
            }
        }
        #endregion

        //Control進行繪製
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            DrawShape(e.Graphics);
        }

        private void DrawShape(Graphics g)
        {
            if (this.Width < 100 || this.Height < 100)
            {
                return;
            }
            g.SmoothingMode = SmoothingMode.AntiAlias;  //消除鋸齒
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            //1、繪製背景
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(0, 0, this.Width, this.Height));
            int size = Math.Min(this.Width, this.Height);//圓的大小
            //2、繪製底层（最大值）
            int sizeOffset = 50;//進度條距離最外側的偏移量
            Rectangle rectangle = new Rectangle(this.Width / 2 - size / 2 + sizeOffset, this.Height / 2 - size / 2 + sizeOffset, size - (sizeOffset * 2), size - (sizeOffset * 2));//計算圓的範圍
            g.DrawArc(this.penBottom, rectangle, 0, 360);//繪製底層進度條
            //g.DrawRectangle(this.penBottom, rectangleBottom);//繪製標示測試區
            //3、繪製上層進度條
            decimal topAngle = (this.progress * 1.0M / this.maxValue) * 360M;//計算進度條劃過的度數
            g.DrawArc(this.penTop, rectangle, -93, (int)topAngle);//繪製進度條
            //4、繪製進度調顯示值
            if (this.progress == maxValue)
            {
                /*//完成
                int lineOffset = (int)(size * (1 / 9.5M));//对勾交叉点距离中心点的偏移量

                //計算左半勾的結束位置
                double x1 = (this.Width / 2) + (size * (1 / 8D)) * Math.Cos((90 * 2 + 90 / 2D) * Math.PI / 180);
                double y1 = (this.Height / 2 + lineOffset) + (size * (1 / 8D)) * Math.Sin((90 * 2 + 90 / 2D) * Math.PI / 180);

                //計算右半勾的結束位置
                double x2 = (this.Width / 2) + (size * (1 / 4D)) * Math.Cos((90 * 3 + 90 / 2D) * Math.PI / 180);
                double y2 = (this.Height / 2 + lineOffset) + (size * (1 / 4D)) * Math.Sin((90 * 3 + 90 / 2D) * Math.PI / 180);

                //繪製整個勾
                var lines = new Point[] {
                    new Point((int)x1,(int)y1),
                    new Point((this.Width / 2 ) , (this.Height / 2 )+ lineOffset),
                    new Point((int)x2,(int)y2) };
                var graphicsPath = new GraphicsPath(lines, new byte[] { (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line });
                g.DrawPath(this.penFinished, graphicsPath);*/
                SizeF proValSize = g.MeasureString(this.progress.ToString() + "%", this.Font);//計算文字範圍
                g.DrawString(this.progress.ToString() + "%", this.Font, new SolidBrush(this.ForeColor), rectangle.X + rectangle.Width / 2 - proValSize.Width / 2, rectangle.Y + rectangle.Height / 2 - proValSize.Height / 2);
            }
            else
            {
                //繪製進度條
                SizeF proValSize = g.MeasureString(this.progress.ToString() + "%", this.Font);//計算文字範圍
                g.DrawString(this.progress.ToString() + "%", this.Font, new SolidBrush(this.ForeColor), rectangle.X + rectangle.Width / 2 - proValSize.Width / 2, rectangle.Y + rectangle.Height / 2 - proValSize.Height / 2);
            }
        }


    }
}

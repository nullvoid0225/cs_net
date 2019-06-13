using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_RemoteCPUCore
{
    public partial class mook_RemoteCPUCore : UserControl
    {
        public mook_RemoteCPUCore()
        {
            InitializeComponent();

            OpenType = ChartControlOpenType.Graph;

            LoadDefaultValues();

            InitChart();
        }
        public float Maximum
        {
            get
            {
                return m_Maximum;
            }
        }

        public enum ChartControlOpenType
        {
            Bar,
            Graph
        };

        public int LineWidth;
        public int PixelsPer;
        public int LineDifference;
        public float ValueMultiplier;
        public Color AboveColor, UnderColor, GridColor, ChartBackColor, AxesColor;
        public ChartControlOpenType OpenType;

        private Graphics g;
        private float[] Values;
        private float m_Maximum;
        private int CurrentYGridStart;
        private int CurrentNumberOfValues;

        private Size CurrentSize = new Size(0, 0);

        private void LoadDefaultValues()
        {
            g = plChart.CreateGraphics();
            PixelsPer = 10;
            ChartBackColor = Color.Black;
            GridColor = Color.Green;
            AboveColor = Color.Chartreuse;
            UnderColor = Color.Red;
            AxesColor = Color.White;
            CurrentYGridStart = 0;
            ValueMultiplier = 1;
            m_Maximum = plChart.Size.Height;
            LineDifference = 1;

            Values = new float[plChart.Size.Width / 2];

            for (int i = 0; i < Values.Length; i++)
                Values[i] = 0;

            CurrentNumberOfValues = 0;
        }

        public void RefreshControl()
        {
            PostInitChart();
            DrawChart();
        }

        public void AddValue(float val)
        {
            if (Maximum != 0)
                if (val * ValueMultiplier > Maximum)
                    return;
            for (int i = 0; i < Values.Length - 1; i++)
                Values[i] = Values[i + 1];
            Values[Values.Length - 1] = val * ValueMultiplier;

            if (CurrentNumberOfValues < Values.Length)
                CurrentNumberOfValues++;

            if (CurrentYGridStart < PixelsPer * LineDifference - 1)
            {
                CurrentYGridStart += 2;
            }
            else
            {
                CurrentYGridStart = 0;
            }

            DrawChart();
        }

        public void InitChart()
        {
            CurrentYGridStart = 0;
            PostInitChart();
        }

        public int IntCmp(float num1, float num2)
        {
            if ((num1 >= 0) && (num2 >= 0))
                return 0;
            if ((num1 < 0) && (num2 < 0))
                return 0;
            if ((num1 >= 0) && (num2 < 0))
                return 1;
            if ((num1 < 0) && (num2 >= 0))
                return -1;

            return 0;
        }

        private void plChart_Paint(object sender, PaintEventArgs e)
        {
            if (this.plChart != null)
                OnResize(new EventArgs());
        }

        public void PostInitChart()
        {
            if ((plChart.Height != 0) && (plChart.Width != 0))
            {
                g.Clear(ChartBackColor);

                DrawGrid();
            }
        }

        private void DrawGrid()
        {
            for (int i = (plChart.Size.Height) - PixelsPer * LineDifference; i > 0; i -= PixelsPer * LineDifference)
                g.DrawLine(new Pen(GridColor), 0, i, plChart.Size.Width, i);


            for (int i = CurrentYGridStart; i < plChart.Size.Width; i += PixelsPer * LineDifference)
                g.DrawLine(new Pen(GridColor), i, 0, i, plChart.Size.Height);

        }

        private void DrawChart()
        {
            PostInitChart();

            Pen AbovePen = new Pen(AboveColor);
            Pen UnderPen = new Pen(UnderColor);

            for (int i = Values.Length - CurrentNumberOfValues; i < Values.Length; i++)
            {
                if (Values[i] >= 0)
                {
                    if (IntCmp(Values[i], Values[i - 1]) > 0)
                    {
                        g.DrawLine(UnderPen, (Values.Length - i) * 2, (int)(plChart.Size.Height) - Values[i - 1], (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height));
                        g.DrawLine(AbovePen, (Values.Length - i) * 2 - 1, (int)(plChart.Size.Height), (Values.Length - i - 1) * 2, (int)(plChart.Size.Height) - Values[i]);
                    }
                    else
                    {
                        g.DrawLine(AbovePen, (Values.Length - i) * 2, (int)(plChart.Size.Height) - Values[i - 1], (Values.Length - i - 1) * 2, (int)(plChart.Size.Height) - Values[i]);
                    }
                }
            }

            UnderPen.Dispose();
            AbovePen.Dispose();
        }
        private void RecalculateSize()
        {
            if ((CurrentSize.Height != 0) && (CurrentSize.Width != 0))
            {
                m_Maximum = plChart.Size.Height;

                float SizeChange = ((float)Size.Height / (float)CurrentSize.Height);

                if (Size.Height != 0)
                    ValueMultiplier *= SizeChange;

                int i, j;

                float[] NewValues = new float[Size.Width];

                for (i = Values.Length - 1, j = NewValues.Length - 1; ((i >= 0) && (j >= 0)); i--, j--)
                {
                    if (SizeChange != 0)
                        NewValues[j] = Values[i] * SizeChange;
                }

                Values = NewValues;

                g.Dispose();
                g = plChart.CreateGraphics();

                DrawChart();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (plChart != null)
            {

                if ((Size.Height == 0) || (Size.Width == 0))
                    return;

                if ((CurrentSize.Height == 0) && (CurrentSize.Width == 0))
                {
                    CurrentSize = Size;
                    return;
                }

                RecalculateSize();
                CurrentSize = Size;
            }
        }
    }
}

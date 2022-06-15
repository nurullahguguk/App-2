using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {
        public int[] fVerticalProj;
        public int[] fHorizontalProj;

        public int[] chVerticalProj;
        public int[] chHorizontalProj;

        public Bitmap fBitmap;
        public Bitmap chBitmap;

        public Form1()
        {
            InitializeComponent();
            fVerticalProj = new int[pictureBox1.Height];
            fHorizontalProj = new int[pictureBox1.Width];
            chVerticalProj = new int[pictureBox2.Height];
            chHorizontalProj = new int[pictureBox2.Width];
        }

        private void recognition_btn_Click(object sender, EventArgs e)
        {
            Bitmap chBitmap = new Bitmap(path_txb.Text);
            pictureBox2.Image = chBitmap;

            //Gray sacle çevir
            for (int i = 0; i < chBitmap.Width; i++)
            {
                chVerticalProj[i] = 0;
                for (int j = 0; j < chBitmap.Height; j++)
                {
                    Color tmp = chBitmap.GetPixel(i, j);
                    int greyPx = (tmp.R + tmp.G + tmp.B) / 3;

                    if (greyPx < 128)
                    {
                        chVerticalProj[i]++;
                    }
                }
            }

            //Allignment
            int pivot = 0;
            for (int i = 0; i < chVerticalProj.Length; i++)
            {
                if (chVerticalProj[i] != 0)
                {
                    pivot = i;
                    break;
                }
            }

            for (int i = 0; i < chVerticalProj.Length - pivot; i++)
            {
                chVerticalProj[i] = chVerticalProj[pivot + i];
            }

            for (int i = chVerticalProj.Length - pivot; i < chVerticalProj.Length; i++)
            {
                chVerticalProj[i] = 0;
            }

            //Display
            charv_tbx.Text = "";
            string vS = "";

            for (int i = 0; i < chVerticalProj.Length; i++)
            {
                vS += chVerticalProj[i].ToString() + " ";
            }
            charv_tbx.Text = vS;

            int vDiff = 0;
            for (int i = 0; i < fVerticalProj.Length; i++)
            {
                vDiff += Math.Abs(fVerticalProj[i] - chVerticalProj[i]);
            }
            vdiff_tbx.Text = vDiff.ToString();

            /* for (int j = 0; j < chBitmap.Height; j++)
             {
                 chHorizontalProj[j] = 0;
                 for (int i = 0; i < chBitmap.Width; i++)
                 {
                     Color tmp = chBitmap.GetPixel(i, j);
                     int greyPx = (tmp.R + tmp.G + tmp.B) / 3;

                     if (greyPx < 128)
                     {
                         chHorizontalProj[j]++;
                     }
                 }
             }*/
        }
        //
        private void generate_knowledge_base_btn_Click(object sender, EventArgs e)
        {
            fBitmap = new Bitmap(pictureBox1.Image);
            //Gray sacle çevir
            for (int i = 0; i < fBitmap.Width; i++)
            {
                fVerticalProj[i] = 0;
                for (int j = 0; j < fBitmap.Height; j++)
                {
                    Color tmp = fBitmap.GetPixel(i, j);
                    int greyPx = (tmp.R + tmp.G + tmp.B) / 3;

                    if (greyPx < 128)
                    {
                        fVerticalProj[i]++;
                    }
                }
            }

            //Allignment
            int pivot = 0;
            for (int i = 0; i < fVerticalProj.Length; i++)
            {
                if (fVerticalProj[i] != 0)
                {
                    pivot = i;
                    break;
                }
            }

            for (int i = 0; i < fVerticalProj.Length - pivot; i++)
            {
                fVerticalProj[i] = fVerticalProj[pivot + i];
            }

            for (int i = fVerticalProj.Length - pivot; i < fVerticalProj.Length; i++)
            {
                fVerticalProj[i] = 0;
            }

            //Display
            fv_tbx.Text = "";
            string vS = "";

            for (int i = 0; i < fVerticalProj.Length; i++)
            {
                vS += fVerticalProj[i].ToString() + " ";
            }
            fv_tbx.Text = vS;

            /*for (int j = 0; j < fBitmap.Height; j++)
            {
                fHorizontalProj[j] = 0;
                for (int i = 0; i < fBitmap.Width; i++)
                {
                    Color tmp = fBitmap.GetPixel(i, j);
                    int greyPx = (tmp.R + tmp.G + tmp.B) / 3;

                    if (greyPx < 128)
                    {
                        fHorizontalProj[j]++;
                    }
                }
            }*/
        }
    }
}

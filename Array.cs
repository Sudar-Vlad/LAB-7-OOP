using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LAB_7_OOP
{
    class Array
    {
        int[] a;
        int[] b;
        int length;
        public bool f = false;
        public Array(int n)
        {
            length = n;
            a = new int[length];
            b = new int[length];
        }
        void show(TextBox t, int[] aa)
        {
            t.Text = " ";
            for (int i = 0; i < length; i++)
            {
                t.Text += aa[i] + " ";
            }
        }
        public void input(TextBox t, string s)
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(s))
            {
                while (!sr.EndOfStream)
                {
                    a[i] = Convert.ToInt32(sr.ReadLine());
                    i++;
                }
            }
            length = i;
            show(t, a);
        }
    

    

    public void zap()
        {
            string s = "";
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        sw.WriteLine(a[i]);
                        b[i] = a[i];
                    }
                }
            }
        }
        public void ras(TextBox t)
        {
            if (length == 0)
            {
                throw new Exception("Спочатку зчитайте масив.");
            }

            int k = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] >= 0)
                {
                    b[k] = a[i];
                    k++;
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (a[i] < 0)
                {
                    b[k] = a[i];
                    k++;
                }
            }

            show(t, b);
            f = true;
        }
    }

}

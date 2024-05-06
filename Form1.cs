using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;

namespace _15prakt
{
    public partial class Form1 : Form
    {
        Vectors vectorA;
        Vectors vectorB;

        List<Vectors> vectorsList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private Vectors CorrectInputs(string xText, string yText, string zText)
        {
            Vectors vector;

            if (xText != "" && yText != "" && zText != "")
            {
                if (double.TryParse(xText, out double x) && double.TryParse(yText, out double y)
                    && double.TryParse(zText, out double z))
                {
                    return vector = new Vectors(x, y, z);
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать координаты в double", "Ошибка преобразования");
                    return vector = new Vectors(0, 0, 0);
                }
            }
            else
            {
                MessageBox.Show("Обнаружены пустые поля", "Ошибка ввода");
                return vector = new Vectors(0, 0, 0);
            }
        }

        private void addVectorA_Click(object sender, EventArgs e)
        {
            vectorA = CorrectInputs(x1Coordinate.Text, y1Coordinate.Text, z1Coordinate.Text);
        }
        private void addVectorB_Click(object sender, EventArgs e)
        {
            vectorB = CorrectInputs(x2Coordinate.Text, y2Coordinate.Text, z2Coordinate.Text);
        }

        private void solveVestorC_Click(object sender, EventArgs e)
        {
            vectorsList.Add(vectorA);
            vectorsList.Add(vectorB);

            foreach (var vector in vectorsList)
            {
                listBox1.Items.Add(vector.GetSetVector[0].ToString());
            }
        }
    }
}

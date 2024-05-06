using System;
using System.Collections;
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
        Vectors vectorC;

        ArrayList vectors = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private Vectors CorrectInputs(string xText, string yText, string zText)
        {
            if (double.TryParse(xText, out double x) && double.TryParse(yText, out double y)
                && double.TryParse(zText, out double z))
            {
                MessageBox.Show("Вектор добавлен", "Операция успешна");
                return new Vectors(x, y, z);
            }
            else
            {
                MessageBox.Show("Не удалось преобразовать координаты в double", "Ошибка преобразования");
                return null;
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
            vectorC = new Vectors();

            vectorC = vectorC.ArithmeticOperationsOnVectors(additional.Checked, vectorA, vectorB);

            if (vectorC != null)
            {
                vectors.Add(vectorA);
                vectors.Add(vectorB);
                vectors.Add(vectorC);

                foreach (Vectors vector in vectors)
                {
                    listBox1.Items.Add($"Координаты вектора: ({vector.GetCoordinates[0]}, " +
                        $"{vector.GetCoordinates[1]}, " +
                        $"{vector.GetCoordinates[2]})");
                }

                listBox1.Items.Add($"Скалярное произведение: {vectorA.DotProduct(vectorB)}");
                listBox1.Items.Add($"Длина вектора А: {vectorA.Magnitude()}");
                listBox1.Items.Add($"Длина вектора А: {vectorB.Magnitude()}");
                listBox1.Items.Add($"Косинус между векторами А и Б: {vectorA.CosineAngle(vectorB)}");
            }
            else
            {
                MessageBox.Show("Не удалось преобразовать введеные поля в double");
            }
        }
    }
}

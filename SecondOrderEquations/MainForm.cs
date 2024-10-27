using System;
using System.Windows.Forms;

namespace SecondOrderEquations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string SolveEquation(string strA, string strB, string strC)
        {
            if (!double.TryParse(strA, out double a)
                || !double.TryParse(strB, out double b)
                || !double.TryParse(strC, out double c))
            {
                return "Vui lòng nhập lại các hệ số.";
            }
            if (a == 0)
            {
                return "Hệ số a = 0 không thể giải.";
            }
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Phương trình vô nghiệm.";
            }
            if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép x = {x}";
            }
            double x_1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x_2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"Phương trình có hai nghiệm phân biệt x1 = {x_1}; x2 = {x_2}";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            lblResult.Text = SolveEquation(txtValueA.Text, txtValueB.Text, txtValueC.Text);
        }
    }
}

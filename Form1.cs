using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace _3sem_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs argc)
        { 
            try {
                string funct = functionInput.Text;
                var function = new Function(funct);
                if (!function.checkSyntax())
                {
                    throw new Exception(funct + " не является формулой");
                }
                NewFunction newFunction = new NewFunction();
                newFunction.Need(funct);
                Func<double, double> _func = newFunction.Calculate;
                double a = double.Parse(x1Input.Text);
                double b = double.Parse(x2Input.Text);
                double e = double.Parse(eInput.Text);
                double result = DyhotomyMethod.Calc(_func, a, b, e);
                resultat.Text = result.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class NewFunction
    {
        private Function _function;

        public void Need(string funct)
        {
            var function = new Function(funct);
            
            if (!function.checkSyntax())
            {
                throw new Exception(funct + " не является формулой");
            }

            _function = function;
        }

        public double Calculate(double num)
        {

            return _function.calculate(num);
        }
    }

    public class DyhotomyMethod
    {
        public static double Calc(Func<double, double> _func, double a, double b, double e)
        {
            // Проверка, что значения a и b подходят
            if (_func(a) * _func(b) >= 0)
            {
                throw new ArgumentException("Функция должна менять знак на интервале [a, b].");
            }

            double midpoint = 0;

            while ((b - a) / 2 > e) // Пока длина интервала больше заданной точности
            {
                midpoint = (a + b) / 2; // Находим середину

                // Проверяем, где функция меняет знак
                if (_func(midpoint) == 0) // Если мы нашли корень
                {
                    return midpoint;
                }
                else if (_func(a) * _func(midpoint) < 0) // Корень находится в [a, midpoint]
                {
                    b = midpoint;
                }
                else // Корень находится в [midpoint, b]
                {
                    a = midpoint;
                }
            }

            return (a + b) / 2; // Возвращаем приближенный корень
        }
    }
}

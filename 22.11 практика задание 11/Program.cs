using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1;
            num1 = Interaction.InputBox("Введите первое число",
                "Ввод первое числа");
            string num2;
            num2 = Interaction.InputBox("Введите второе число", "Ввод числа");
            int x = Convert.ToInt32(num1);
            int y = Convert.ToInt32(num2);
            int num = x - y;
            int num4 = x + y;
            string res = "ответ:" + num + num4;
            MessageBox.Show(res, "ответ");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;

namespace Практ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка расчитывает сумму двух чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int part = Convert.ToInt32(txtThirdNumber1.Text);
            Pair pair1 = new Pair(Convert.ToInt32(txtFirstNumber1.Text), Convert.ToInt32(txtSecondNumber1.Text));
            MessageBox.Show("Значение суммы 2 чисел = " + pair1.Sum(0));
            MessageBox.Show("Значение суммы 3 чисел = " + pair1.Sum(part));
        }

        /// <summary>
        /// Кнопка расчитывает сумму 2 и 3 пар чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCalc_Click(object sender, EventArgs e)
        { 
            Pair pair1 = new Pair(Convert.ToInt32(txtFirstNumber2.Text), Convert.ToInt32(txtSecondNumber2.Text));
            Pair pair2 = new Pair(Convert.ToInt32(txtThirdNumber2.Text), Convert.ToInt32(txtFourhNumber2.Text));
            Pair pair3 = new Pair(Convert.ToInt32(txtFifthNumber2.Text), Convert.ToInt32(txtSixthNumber2.Text));

            Pair sumPair1 = Pair.SumPair(pair1, pair2);
            Pair sumPair2 = Pair.SumPair(pair1, pair2, pair3);
            MessageBox.Show("Значение суммы 2 пар чисел = " + "( " + sumPair1.First + " ; " + sumPair1.Second + " )");
            MessageBox.Show("Значение суммы 3 пар чисел = " + "( " + sumPair2.First + " ; " + sumPair2.Second + " )");
        }

        

        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович \n" +
                "Создать класс Pair (пара чисел). \n" +
                "Создать необходимые методы и свойства.\n" +
                "Определить методы метод сложения полей и \n" +
                "операцию сложения пар (а, b) + (с, d) = (а + c, b + d).\n" +
                "Создать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.");
        }

        /// <summary>
        /// О программе в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович \n" +
                "Создать класс Pair (пара чисел). \n" +
                "Создать необходимые методы и свойства.\n" +
                "Определить методы метод сложения полей и \n" +
                "операцию сложения пар (а, b) + (с, d) = (а + c, b + d).\n" +
                "Создать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.");
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Выход в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

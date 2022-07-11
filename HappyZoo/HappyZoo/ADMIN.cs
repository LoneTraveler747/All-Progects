using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyZoo
{
    public partial class ADMIN : Form
    {
        private readonly object[] _id;
        public ADMIN(object[] ID)
        {
            InitializeComponent();
            _id = ID;
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            if (int.TryParse(_id[0].ToString(), out int num1))
            {
                if (num1 == 2)
                {
                    animalBut.Enabled = true;
                    animalBut.BackColor = Color.FromArgb(157, 237, 126);
                    menuBut.Enabled = true;
                    menuBut.BackColor = Color.FromArgb(157, 237, 126);
                    feedingBut.Enabled = true;
                    feedingBut.BackColor = Color.FromArgb(157, 237, 126);
                    cellBut.Enabled = true;
                    cellBut.BackColor = Color.FromArgb(157, 237, 126);
                    physicalBut.Enabled = true;
                    physicalBut.BackColor = Color.FromArgb(157, 237, 126);
                }
            }

            if (int.TryParse(_id[0].ToString(), out int num2))
            {
                if (num2 == 3)
                {
                    cellBut.Enabled = true;
                    cellBut.BackColor = Color.FromArgb(157, 237, 126);
                    animalBut.Enabled = true;
                    animalBut.BackColor = Color.FromArgb(157, 237, 126);
                }
            }

            if (int.TryParse(_id[0].ToString(), out int num3))
            {
                if (num3 == 4)
                {
                    supplierBut.Enabled = true;
                    supplierBut.BackColor = Color.FromArgb(157, 237, 126);
                    burderingBut.Enabled = true;
                    burderingBut.BackColor = Color.FromArgb(157, 237, 126);
                    employeesBut.Enabled = true;
                    employeesBut.BackColor = Color.FromArgb(157, 237, 126);
                }
            }

            if (int.TryParse(_id[0].ToString(), out int num4))
            {
                if (num4 == 5)
                {
                    feedingBut.Enabled = true;
                    feedingBut.BackColor = Color.FromArgb(157, 237, 126);
                    animalBut.Enabled = true;
                    animalBut.BackColor = Color.FromArgb(157, 237, 126);
                    cellBut.Enabled = true;
                    cellBut.BackColor = Color.FromArgb(157, 237, 126);
                }
            }
            DataBoxLable.Text = _id[1].ToString();
        }

        private void employeesBut_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void cellBut_Click(object sender, EventArgs e)
        {
            Cell cell = new Cell();
            cell.ShowDialog();
        }

        private void supplierBut_Click(object sender, EventArgs e)
        {
            Postavshik postavshik = new Postavshik();
            postavshik.ShowDialog();
        }

        private void menuBut_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();
        }

        private void animalBut_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.ShowDialog();
        }

        private void feedingBut_Click(object sender, EventArgs e)
        {
            Feeding feeding = new Feeding();
            feeding.ShowDialog();
        }

        private void burderingBut_Click(object sender, EventArgs e)
        {
            Barder barder = new Barder();
            barder.ShowDialog();
        }

        private void physicalBut_Click(object sender, EventArgs e)
        {
            Medosmotr medosmotr = new Medosmotr();
            medosmotr.ShowDialog();
        }

        private void ADMIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
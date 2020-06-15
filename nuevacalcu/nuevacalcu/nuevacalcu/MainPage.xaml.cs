using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nuevacalcu
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int total = 0;
        public bool click = false, error = false;
        public int op = 0;
        public bool igual = false;
        public int num1 = 0;
        public int num2 = 0;

        public MainPage()
        {
            InitializeComponent();
            Entradacero();
        }
        private void Entradacero()
        {
            btndiv.IsEnabled = true;
            btnsuma.IsEnabled = true;
            btnresta.IsEnabled = true;
            btnmult.IsEnabled = true;
            btnigual.IsEnabled = true;
            TbNumeros.Text = "0";
            total = 0;
            op = 0;
            error = false;
            click = false;
            igual = false;
            num1 = 0;
            num2 = 0;
        }
        private void btnuno_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "1";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "1";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "1";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "1";
                    }
                }
            }
        }

        private void btnborrar_Clicked(object sender, EventArgs e)
        {
            Entradacero();
        }

        private void btnsiete_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "7";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "7";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "7";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "7";
                    }
                }
            }
        }

        private void btnocho_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "8";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "8";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "8";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "8";
                    }
                }
            }
        }

        private void btnnueve_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "9";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "9";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "9";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "9";
                    }
                }
            }
        }

        private void btncuatro_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "4";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "4";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "4";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "4";
                    }
                }
            }
        }

        private void btncinco_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "5";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "5";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "5";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "5";
                    }
                }
            }
        }

        private void btnseis_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "6";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "6";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "6";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "6";
                    }
                }
            }
        }

        private void btndos_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "2";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "2";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "2";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "2";
                    }
                }
            }
        }

        private void btntres_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "3";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "3";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "3";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "3";
                    }
                }
            }
        }

        private void btncero_Clicked(object sender, EventArgs e)
        {
            if (igual == true)
            {
                Entradacero();
                TbNumeros.Text = "0";
            }
            else
            {
                if (TbNumeros.Text == "0" || click == true)
                {
                    TbNumeros.Text = "0";
                    click = false;
                }
                else
                {
                    if (error == true)
                    {
                        Entradacero();
                        TbNumeros.Text = "0";
                    }
                    else
                    {
                        TbNumeros.Text = TbNumeros.Text + "0";
                    }
                }
            }
        }

        private void btndiv_Clicked(object sender, EventArgs e)
        {
            op = 4;
            if (igual == true)
            {
                igual = false;
            }
            else
            {
                click = true;
                int num;
                num = int.Parse(TbNumeros.Text);
                if (num == 0)
                {
                    TbNumeros.Text = "error matematico";
                    error = true;
                    click = false;
                    btndiv.IsEnabled = false;
                    btnsuma.IsEnabled = false;
                    btnresta.IsEnabled = false;
                    btnmult.IsEnabled = false;
                    btnigual.IsEnabled = false;
                }
                else
                {
                    if (total == 0)
                    {
                        total = num;
                        TbNumeros.Text = Convert.ToString(total);
                    }
                    else
                    {
                        total = total / num;
                        TbNumeros.Text = Convert.ToString(total);
                    }
                }
            }
        }

        private void btnmult_Clicked(object sender, EventArgs e)
        {
            op = 3;
            if (igual == true)
            {
                igual = false;
            }
            else
            {
                click = true;
                int num;
                num = int.Parse(TbNumeros.Text);
                if (total == 0)
                {
                    total = num;
                    TbNumeros.Text = Convert.ToString(total);
                }
                else
                {
                    total = total * num;
                    TbNumeros.Text = Convert.ToString(total);
                }
            }
        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            op = 2;
            if (igual == true)
            {
                igual = false;
            }
            else
            {
                int num;
                num = int.Parse(TbNumeros.Text);
                click = true;
                if (num > 0)
                {
                    if (total == 0)
                    {
                        total = num;
                        TbNumeros.Text = Convert.ToString(total);
                    }
                    else
                    {
                        total = total - num;
                        TbNumeros.Text = Convert.ToString(total);
                    }
                }
                else
                {
                    total = total + num;
                    TbNumeros.Text = Convert.ToString(total);
                }
            }
        }

        private void btnigual_Clicked(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(TbNumeros.Text);
            click = true;
            if (igual == false)
            {
                num1 = num;
                igual = true;
                switch (op)
                {
                    case 1:
                        total = total + num;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 2:
                        total = total - num;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 3:
                        total = total * num;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 4:
                        if (num == 0)
                        {
                            TbNumeros.Text = "Error matematico";
                            error = true;
                            click = false;
                            btndiv.IsEnabled = false;
                            btnsuma.IsEnabled = false;
                            btnresta.IsEnabled = false;
                            btnmult.IsEnabled = false;
                            btnigual.IsEnabled = false;
                        }
                        else
                        {
                            total = total / num;
                            TbNumeros.Text = Convert.ToString(total);
                        }
                        break;
                    default:
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                }
            }
            else
            {
                switch (op)
                {
                    case 1:
                        total = total + num1;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 2:
                        total = total - num1;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 3:
                        total = total * num1;
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                    case 4:
                        if (num1 == 0)
                        {
                            TbNumeros.Text = "Error matematico";
                            error = true;
                            btndiv.IsEnabled = false;
                            btnsuma.IsEnabled = false;
                            btnresta.IsEnabled = false;
                            btnmult.IsEnabled = false;
                            btnigual.IsEnabled = false;
                        }
                        else
                        {
                            total = total / num1;
                            TbNumeros.Text = Convert.ToString(total);
                        }
                        break;
                    default:
                        TbNumeros.Text = Convert.ToString(total);
                        break;
                }
            }
        }

        private void btnsuma_Clicked(object sender, EventArgs e)
        {
            op = 1;
            if (igual == true)
            {
                igual = false;
            }
            else
            {
                click = true;
                int num;
                num = int.Parse(TbNumeros.Text);
                total = total + num;
                TbNumeros.Text = Convert.ToString(total);
            }
        }
    }
}

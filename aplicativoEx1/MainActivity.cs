using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace aplicativoEx1
{
    [Activity(Label = "Casa Automatica", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAdd1,btnRemove1, btnAdd2, btnRemove2, btnAdd3, btnRemove3,
            btnAdd4, btnRemove4;
        TextView qtde1;
        TextView txtValor;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Inicio Alexa
            //Instanciar 
            btnAdd1 = FindViewById<Button>(Resource.Id.btnAd1);
            btnRemove1 = FindViewById<Button>(Resource.Id.btnRemove1);

            btnAdd2 = FindViewById<Button>(Resource.Id.btnAd2);
            btnRemove2 = FindViewById<Button>(Resource.Id.btnRemove2);

            btnAdd3 = FindViewById<Button>(Resource.Id.btnAd3);
            btnRemove3 = FindViewById<Button>(Resource.Id.btnRemove3);

            btnAdd4 = FindViewById<Button>(Resource.Id.btnAd4);
            btnRemove4 = FindViewById<Button>(Resource.Id.btnRemove4);

            //Quando tem click
            btnAdd1.Click += btnAdd1_Click;
            btnRemove1.Click += BtnRemove1_Click;

            btnAdd2.Click += BtnAdd2_Click;
            btnRemove2.Click += BtnRemove2_Click;

            btnAdd3.Click += BtnAdd3_Click;
            btnRemove3.Click += BtnRemove3_Click;

            btnAdd4.Click += BtnAdd4_Click;
            btnRemove4.Click += BtnRemove4_Click;

            //Fim Alexa
        }

        private void BtnRemove4_Click(object sender, EventArgs e)
        {
            Remover(FindViewById<TextView>(Resource.Id.txtQtde4), 499);
        }

        private void BtnAdd4_Click(object sender, EventArgs e)
        {
            Adicionar(FindViewById<TextView>(Resource.Id.txtQtde4), 499);
        }

        private void BtnRemove3_Click(object sender, EventArgs e)
        {
            Remover(FindViewById<TextView>(Resource.Id.txtQtde3), 1519);
        }

        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            Adicionar(FindViewById<TextView>(Resource.Id.txtQtde3), 1519);
        }

        private void BtnRemove2_Click(object sender, EventArgs e)
        {
            Remover(FindViewById<TextView>(Resource.Id.txtQtde2), 341);
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            Adicionar(FindViewById<TextView>(Resource.Id.txtQtde2), 341);
        }


        private void Adicionar(TextView qtdeLabek, int preco)
        {
            //Adicionar a quantidade de um item
            qtde1 = qtdeLabek;
            int alexaQtd = Int32.Parse(qtde1.Text);
            alexaQtd++;
            qtde1.Text = alexaQtd.ToString();

            //Somar valor final
            txtValor = FindViewById<TextView>(Resource.Id.txtValor);
            int valorFinal = Int32.Parse(txtValor.Text);
            valorFinal = valorFinal + preco;

            txtValor.Text = Convert.ToString(valorFinal);
        }
        private void Remover(TextView qtdeLabek,int preco)
        {
            int qtde = Int32.Parse(qtdeLabek.Text);
            if (qtde == 0)
            {
                
            }
            else if (qtde == 1)
            {
                qtde = qtde - 1;
                qtdeLabek.Text = 0.ToString();

                txtValor = FindViewById<TextView>(Resource.Id.txtValor);
                int valorFinal = Int32.Parse(txtValor.Text);
                valorFinal = valorFinal - preco;
                txtValor.Text = valorFinal.ToString();

            }

            else if (qtde > 1)
            {
                qtde = qtde - 1;
                qtdeLabek.Text = qtde.ToString();

                //Subtraçao valor final
                txtValor = FindViewById<TextView>(Resource.Id.txtValor);
                int valorFinal = Int32.Parse(txtValor.Text);
                valorFinal = valorFinal - preco;

                txtValor.Text = Convert.ToString(valorFinal);
            }


        }

        //Alexa
        private void BtnRemove1_Click(object sender, System.EventArgs e)
        {
            Remover(FindViewById<TextView>(Resource.Id.txtQtde1), 474);
        }

        //Alexa
        private void btnAdd1_Click(object sender, System.EventArgs e)
        {
            Adicionar(FindViewById<TextView>(Resource.Id.txtQtde1), 474);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
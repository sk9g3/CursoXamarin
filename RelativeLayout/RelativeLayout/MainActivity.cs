using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace RelativeLayout
{
    [Activity(Label = "RelativeLayout", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnConverter;
         EditText txtDolar;
         EditText txtReal;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            btnConverter = FindViewById<Button>(Resource.Id.btn_converter);
            txtDolar = FindViewById<EditText>(Resource.Id.txt_dolar);
            txtReal = FindViewById<EditText>(Resource.Id.txt_real);

            btnConverter.Click += BtnConverter_Click;
        }

        private void BtnConverter_Click(object sender, System.EventArgs e)
        {
            try
            {
                double dolar = double.Parse(txtDolar.Text);
                double real = dolar * 3.25;
                txtReal.Text = real.ToString();
            }catch(Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }
    }
}


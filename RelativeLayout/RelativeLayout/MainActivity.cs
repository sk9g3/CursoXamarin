using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace RelativeLayout
{
    [Activity(Label = "RelativeLayout", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnConverter;
         EditText txtDolar;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            btnConverter = FindViewById<Button>(Resource.Id.btn_converter);
            txtDolar = FindViewById<EditText>(Resource.Id.txt_dolar);

            btnConverter.Click += BtnConverter_Click;
        }

        private void BtnConverter_Click(object sender, System.EventArgs e)
        {
            Intent objIntent = new Intent(this, typeof(Resultado));
            objIntent.PutExtra("Dolar", double.Parse(txtDolar.Text));
            StartActivity(objIntent);
            
        }
    }
}


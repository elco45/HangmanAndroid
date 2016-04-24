using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Hangman
{
    [Activity(Label = "Hangman", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(R.Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btn_easy = FindViewById<Button>(R.Resource.Id.btn_easy);
            Button btn_medium = FindViewById<Button>(R.Resource.Id.btn_medium);
            Button btn_hard = FindViewById<Button>(R.Resource.Id.btn_hard);

            btn_easy.Click += delegate {
                Intent intent = new Intent(this, typeof(R.GameActivity));
                intent.PutExtra("mode", "1");
                StartActivity(intent);
            };

            btn_medium.Click += delegate {
                Intent intent = new Intent(this, typeof(R.GameActivity));
                intent.PutExtra("mode", "2");
                StartActivity(intent);
            };

            btn_hard.Click += delegate {
                Intent intent = new Intent(this, typeof(R.GameActivity));
                intent.PutExtra("mode", "3");
                StartActivity(intent);
            };

        }
    }
}


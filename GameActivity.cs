using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace R
{
    [Activity(Label = "GameActivity", Theme = "@android:style/Theme.Holo.Light")]
    public class GameActivity : Activity
    {
        int life = 0;
        string resp = "z";
        string guess = "";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            string mode = Intent.GetStringExtra("mode") ?? "Data not available";

            //bd darle valor a resp
            if (mode.Equals("1")){
                resp = "hola";
            }else if (mode.Equals("2"))
            {
                resp = "holis";
            }else{
                resp = "megahola";
            }

            for (int i = 0; i < resp.Length; i++)
            {
                guess += "_ ";
            }

            

            SetContentView(Resource.Layout.Game);
            TextView tv_guess = FindViewById<TextView>(Resource.Id.tv_guess);
            tv_guess.Text = guess;

            Button btn_back = FindViewById<Button>(Resource.Id.btn_back);

            Button btn_a = FindViewById<Button>(Resource.Id.btn_a);
            Button btn_b = FindViewById<Button>(Resource.Id.btn_b);
            Button btn_c = FindViewById<Button>(Resource.Id.btn_c);
            Button btn_d = FindViewById<Button>(Resource.Id.btn_d);
            Button btn_e = FindViewById<Button>(Resource.Id.btn_e);
            Button btn_f = FindViewById<Button>(Resource.Id.btn_f);
            Button btn_g = FindViewById<Button>(Resource.Id.btn_g);
            Button btn_h = FindViewById<Button>(Resource.Id.btn_h);
            Button btn_i = FindViewById<Button>(Resource.Id.btn_i);
            Button btn_j = FindViewById<Button>(Resource.Id.btn_j);
            Button btn_k = FindViewById<Button>(Resource.Id.btn_k);
            Button btn_l = FindViewById<Button>(Resource.Id.btn_l);
            Button btn_m = FindViewById<Button>(Resource.Id.btn_m);
            Button btn_n = FindViewById<Button>(Resource.Id.btn_n);
            Button btn_o = FindViewById<Button>(Resource.Id.btn_o);
            Button btn_p = FindViewById<Button>(Resource.Id.btn_p);
            Button btn_q = FindViewById<Button>(Resource.Id.btn_q);
            Button btn_r = FindViewById<Button>(Resource.Id.btn_r);
            Button btn_s = FindViewById<Button>(Resource.Id.btn_s);
            Button btn_t = FindViewById<Button>(Resource.Id.btn_t);
            Button btn_u = FindViewById<Button>(Resource.Id.btn_u);
            Button btn_v = FindViewById<Button>(Resource.Id.btn_v);
            Button btn_w = FindViewById<Button>(Resource.Id.btn_w);
            Button btn_x = FindViewById<Button>(Resource.Id.btn_x);
            Button btn_y = FindViewById<Button>(Resource.Id.btn_y);
            Button btn_z = FindViewById<Button>(Resource.Id.btn_z);
        
            btn_back.Click += delegate {
                StartActivity(typeof(Hangman.MainActivity));
            };

            btn_a.Click += delegate {
                Gameplay("a");
                btn_a.Enabled = false;
            };
            btn_b.Click += delegate {
                Gameplay("b");
                btn_b.Enabled = false;
            };
            btn_c.Click += delegate {
                Gameplay("c");
                btn_c.Enabled = false;
            };
            btn_d.Click += delegate {
                Gameplay("d");
                btn_d.Enabled = false;
            };
            btn_e.Click += delegate {
                Gameplay("e");
                btn_e.Enabled = false;
            };
            btn_f.Click += delegate {
                Gameplay("f");
                btn_f.Enabled = false;
            };
            btn_g.Click += delegate {
                Gameplay("g");
                btn_g.Enabled = false;
            };
            btn_h.Click += delegate {
                Gameplay("h");
                btn_h.Enabled = false;
            };
            btn_i.Click += delegate {
                Gameplay("i");
                btn_i.Enabled = false;
            };
            btn_j.Click += delegate {
                Gameplay("j");
                btn_j.Enabled = false;
            };
            btn_k.Click += delegate {
                Gameplay("k");
                btn_k.Enabled = false;
            };
            btn_l.Click += delegate {
                Gameplay("l");
                btn_l.Enabled = false;
            };
            btn_m.Click += delegate {
                Gameplay("m");
                btn_m.Enabled = false;
            };
            btn_n.Click += delegate {
                Gameplay("n");
                btn_n.Enabled = false;
            };
            btn_o.Click += delegate {
                Gameplay("o");
                btn_o.Enabled = false;
            };
            btn_p.Click += delegate {
                Gameplay("p");
                btn_p.Enabled = false;
            };
            btn_q.Click += delegate {
                Gameplay("q");
                btn_q.Enabled = false;
            };
            btn_r.Click += delegate {
                Gameplay("r");
                btn_r.Enabled = false;
            };
            btn_s.Click += delegate {
                Gameplay("s");
                btn_s.Enabled = false;
            };
            btn_t.Click += delegate {
                Gameplay("t");
                btn_t.Enabled = false;
            };
            btn_u.Click += delegate {
                Gameplay("u");
                btn_u.Enabled = false;
            };
            btn_v.Click += delegate {
                Gameplay("v");
                btn_v.Enabled = false;
            };
            btn_w.Click += delegate {
                Gameplay("w");
                btn_w.Enabled = false;
            };
            btn_x.Click += delegate {
                Gameplay("x");
                btn_x.Enabled = false;
            };
            btn_y.Click += delegate {
                Gameplay("y");
                btn_y.Enabled = false;
            };
            btn_z.Click += delegate {
                Gameplay("z");
                btn_z.Enabled = false;
            };
        }

        public void LifeAnimation(int vida)
        {
            ImageView imv = FindViewById<ImageView>(Resource.Id.imageView1);
            if (vida == 1)
            {
                imv.SetImageResource(Resource.Drawable.spr2);
            }
            else if (vida == 2)
            {
                imv.SetImageResource(Resource.Drawable.spr3);
            }
            else if (vida == 3)
            {
                imv.SetImageResource(Resource.Drawable.spr4);
            }
            else if (vida == 4)
            {
                imv.SetImageResource(Resource.Drawable.spr5);
            }
            else if (vida == 5)
            {
                imv.SetImageResource(Resource.Drawable.spr6);
            }
            else if (vida == 6)
            {
                imv.SetImageResource(Resource.Drawable.spr7);
            }
            else if (vida == 7)
            {
                imv.SetImageResource(Resource.Drawable.spr8);
                var builder = new AlertDialog.Builder(this);
                builder.SetTitle("Defeat");
                builder.SetMessage("Better luck next time");
                builder.SetPositiveButton("Return", (sender, args) =>
                {
                    StartActivity(typeof(Hangman.MainActivity));
                });
                builder.SetCancelable(false);
                builder.Show();
            }
        }

        public void Gameplay(string character)
        {
            if (resp.Contains(character))
            {
                for(int i = 0; i < resp.Length; i++)
                {
                    if (resp[i].Equals(character[0]))
                    {
                        guess = guess.Remove(i*2,1);
                        guess = guess.Insert(i*2,character);
                    }
                }
                TextView tv_guess = FindViewById<TextView>(Resource.Id.tv_guess);
                tv_guess.Text = guess;
                if (resp.Equals(guess.Replace(" ","")))
                {
                    //modal victory
                    var builder = new AlertDialog.Builder(this);
                    builder.SetTitle("Victory");
                    builder.SetMessage("You are the best!");
                    builder.SetPositiveButton("Return", (sender, args) => {
                        StartActivity(typeof(Hangman.MainActivity));
                    });
                    builder.SetCancelable(false);
                    builder.Show();
                }
            }
            else
            {
                life++;
                LifeAnimation(life);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_Filatov_TARpv19
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm : ContentPage
    {
        Frame head, body, feet;
        Button bt1, bt2;
        public Lumememm()
        {
            head = new Frame() //Вверх снеговики
            {
                BackgroundColor = Color.Gray,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };

            body = new Frame() //Туловище снеговика
            {
                BackgroundColor = Color.Gray,
                CornerRadius = 90,
                Padding = 70,
                HorizontalOptions = LayoutOptions.Center
            };

            feet = new Frame() //Низ снеговика
            {
                BackgroundColor = Color.Gray,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center
            };

            bt1 = new Button() //Кнопка, которая прячет снеговика
            {
                Text = "Спрятать снеговика",
                HorizontalOptions = LayoutOptions.Center
            };

            bt2 = new Button() //Кнопка, чтобый снеговик появился
            {
                Text = "Снеговик появись",
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stackLayout2 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { bt1, bt2 }
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { head, body, feet, stackLayout2 }
            };

            stackLayout2.Margin = new Thickness(90, 0, 0, 0);
            Content = stackLayout;

            bt1.Clicked += Bt1_Clicked;
            bt2.Clicked += Bt2_Clicked;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            head.GestureRecognizers.Add(tap);
            body.GestureRecognizers.Add(tap);
            feet.GestureRecognizers.Add(tap);
        }

        private void Bt2_Clicked(object sender, EventArgs e)
        {
            body.Opacity = 100;
            head.Opacity = 100;
            feet.Opacity = 100;
        }

        private void Bt1_Clicked(object sender, EventArgs e)
        {
            body.Opacity = 0;
            head.Opacity = 0;
            feet.Opacity = 0;
        }


        int tapped1 = 0;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == head)
            {
                tapped1++;
                if (tapped1 == 1)
                {
                    head.Opacity = 0;
                }
                else if (tapped1 == 2)
                {
                    head.Opacity = 100;
                    tapped1 = 0;
                }
            }
            else if (fr == body)
            {
                tapped1++;
                if (tapped1 == 1)
                {
                    body.Opacity = 0;
                }
                else if (tapped1 == 2)
                {
                    body.Opacity = 100;
                    tapped1 = 0;
                }
            }
            else if (fr == feet)
            {
                tapped1++;
                if (tapped1 == 1)
                {
                    feet.Opacity = 0;
                }
                else if (tapped1 == 2)
                {
                    feet.Opacity = 99;
                    tapped1 = 0;
                }
            }
        }
    }
}
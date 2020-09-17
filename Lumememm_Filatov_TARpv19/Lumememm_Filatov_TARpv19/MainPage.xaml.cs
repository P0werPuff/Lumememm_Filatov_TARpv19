using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm_Filatov_TARpv19
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            BoxView redBox = new BoxView { BackgroundColor = Color.Aqua, CornerRadius=110 };
            BoxView greenBox = new BoxView { BackgroundColor = Color.Aqua,CornerRadius = 110 };
            BoxView blueBox = new BoxView { BackgroundColor = Color.Aqua, CornerRadius = 110 };

            AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.5, 0.0, 150, 150));
            // устанавливаем пропорциональные координаты
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.5, 0.4, 200, 200));
            AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(blueBox, new Rectangle(0.8, 0.4, 200, 200));
            // пропорциональные координаты и размеры
            AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);

            absoluteLayout.Children.Add(redBox);
            absoluteLayout.Children.Add(greenBox);
            absoluteLayout.Children.Add(blueBox);

            Content = absoluteLayout;
        }
    }
}

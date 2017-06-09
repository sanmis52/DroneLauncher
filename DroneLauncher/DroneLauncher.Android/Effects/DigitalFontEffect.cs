using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using System.ComponentModel;
using DroneLauncher;
using DroneLauncher.Droid;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(DroneLauncher.Droid.DigitalFontEffect), "FontEffect")]
namespace DroneLauncher.Droid
{
    public class DigitalFontEffect : PlatformEffect
    {
        TextView control;
        protected override void OnAttached()
        {
            try
            {
                control = Control as TextView;
                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/" + DroneLauncher.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == DroneLauncher.DigitalFontEffect.FontFileNameProperty.PropertyName)
            {
                Typeface font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "Fonts/" + DroneLauncher.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
        }
    }
}
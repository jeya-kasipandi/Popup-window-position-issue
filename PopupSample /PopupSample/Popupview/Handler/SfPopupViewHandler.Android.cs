
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using View = Microsoft.Maui.Controls.View;

namespace PopupSample
{

    public partial class SfPopupViewHandler : ContentViewHandler
    {
        private PopupViewExt? popViewExt;

        
        protected override ContentViewGroup CreatePlatformView()
        {
            if (VirtualView == null)
            {
                throw new InvalidOperationException($"{nameof(VirtualView)} must be set to create a LayoutViewGroup");
            }

            this.popViewExt = new PopupViewExt(Context)
            {
               
            };

           
            


            return this.popViewExt;
        }

        public void UpdatePopupContent(View listView)
        {
            _ = MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

            popViewExt?.UpdatePopupContent(listView.ToPlatform(MauiContext));
        }

        public void ShowPopup(View view) 
        {
            _ = MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

            popViewExt?.ShowPopup(view.ToPlatform(MauiContext));
        }

       

    }
}

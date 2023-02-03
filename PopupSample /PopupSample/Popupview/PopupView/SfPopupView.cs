
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Layouts;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PopupSample
{
    public class SfPopup : ContentView,IPopupView
    {
       
        /// <summary>
        /// Identifies the <see cref="AnchorView"/> bindable property.
        /// </summary>
        /// <value>
        /// The identifier for <see cref="AnchorView"/> bindable property.
        /// </value>
        public static readonly BindableProperty AnchorViewProperty =
            BindableProperty.Create(nameof(AnchorView), typeof(View), typeof(SfPopup), null, BindingMode.OneWay, null);

      
        /// <summary>
        /// 
        /// </summary>
        public View AnchorView
        {
            get { return (View)this.GetValue(AnchorViewProperty); }
            set { this.SetValue(AnchorViewProperty, value); }
        }


        /// 
        /// </summary>
     
        
        public void UpdatePopupContent()
        {
#if __ANDROID__

            if (this.Handler is SfPopupViewHandler handler)
                handler?.UpdatePopupContent(listView);
#endif
        }


        public void ShowPopup() 
        {
#if __ANDROID__
  
            if (this.Handler is SfPopupViewHandler handler)
                handler?.ShowPopup(this.AnchorView);

#endif

        }


       
        ListView listView;
        Entry entry;
        public SfPopup()
        {
            entry = new Entry();
            entry.HeightRequest = 50;
            entry.Text = "Enter the text";
            listView = new ListView();
            listView.ItemsSource = new List<string>() { "list1", "list2", "list3", "list4", "list5", "list6", "list7", "list8", "list9", "list10" };
          // base.Content = entry;
           
        }
       

    }

}
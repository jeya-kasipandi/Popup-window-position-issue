using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using Android.Text;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Platform;
using Color = Microsoft.Maui.Graphics.Color;
using Microsoft.Maui.Platform;
using System;
using Android.Runtime;
using ARect = Android.Graphics.Rect;
using Rectangle = Microsoft.Maui.Graphics.Rect;
using Size = Microsoft.Maui.Graphics.Size;
using Android.Widget;
using Microsoft.Maui.Controls;
using View = Android.Views.View;

namespace PopupSample
{
    /// <summary>
    /// 
    /// </summary>
    public class PopupViewExt : ContentViewGroup
    {

        PopupWindow popUpWindow;

        private Context _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public PopupViewExt(Context context) : base(context)
        {
            this.Initialize(context);
            _context = context;
            
        }

       
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="javaReference"></param>
        /// <param name="transfer"></param>
        public PopupViewExt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            var context = Context;
            ArgumentNullException.ThrowIfNull(context);
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        public PopupViewExt(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            this.Initialize(context);
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        /// <param name="drawable"></param>
        public PopupViewExt(Context context, IAttributeSet attrs, IDrawable? drawable = null) : base(context, attrs)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        /// <param name="defStyleAttr"></param>
        public PopupViewExt(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            this.Initialize(context);
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        /// <param name="defStyleAttr"></param>
        /// <param name="defStyleRes"></param>
        public PopupViewExt(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            this.Initialize(context);
            _context = context;
        }

        private void Initialize(Context context)
        {
           
            Android.Widget.Button button = new Android.Widget.Button(context);
            button.Text = "Content";
            this.popUpWindow = new PopupWindow(this.Context);
            this.popUpWindow.Width = 1000;
            this.popUpWindow.Height = 600;
            this.popUpWindow.InputMethodMode = InputMethod.Needed;
            this.popUpWindow.SoftInputMode = SoftInput.AdjustResize;
           this.popUpWindow.ContentView = button;
           this.popUpWindow.OutsideTouchable = true;
        }

        public void UpdatePopupContent(View view)
        {
            if (this.popUpWindow != null)
            {
                this.popUpWindow.ContentView = view;
            }

        }
        public  void ShowPopup(View view)
        {
            if (this.popUpWindow != null)
            {
                this.popUpWindow.ShowAsDropDown(view);
            }

        }
    }
}

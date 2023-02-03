
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using System;

namespace PopupSample
{

    public partial class SfPopupViewHandler : ContentViewHandler
    {
        public SfPopupViewHandler()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        public SfPopupViewHandler(PropertyMapper mapper) : base(mapper)
        {

        }

        public SfPopupViewHandler(IPropertyMapper? mapper = null) : base(mapper)
        {
        }

        protected SfPopupViewHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
        {
        }

    }
    
   
}
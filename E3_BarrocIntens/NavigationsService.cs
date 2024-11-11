using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens
{
    class NavigationsService
    {
        public readonly Frame Frame;

        public NavigationsService(Frame frame)
        {
            Frame = frame;
        }

        public void Navigate(Type pageType)
        {
            Frame.Navigate(pageType);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Leapers
{
    public class LayoutTest:ContentPage //內容分頁 這裡進行畫面編排的測試
    {
        public LayoutTest()
        {
            StackLayout showMainStack = new StackLayout
            {
            };

            Label textLabel = new Label
            {
                Text = "熊熊好漂亮"
            };

            showMainStack.Children.Add(textLabel);

            Content = showMainStack;
        }
    }
}

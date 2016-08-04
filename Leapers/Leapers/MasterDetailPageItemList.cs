using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Leapers
{
    public class MasterDetailPageItemList:ContentPage
    {
        //參考 MasterPageCS
        ListView listView;
        public ListView ListView { get { return listView; }  }

        public MasterDetailPageItemList()
        {
            //這裡目前是儲存要顯示清單的資料
            var masterPageItems = new List<MasterPageItem>(); //List裡面參數就是下面的Title, IconSource, TargetType 因為下面我要逐一的把資料放進去 //targetType是你點下去所要進去的畫面ContentPage
            masterPageItems.Add(new MasterPageItem { Title = "JSON氣象資料API", IconSource = "icon.png", TargetType = typeof(OpenWeather) });
            masterPageItems.Add(new MasterPageItem { Title = "ContentPage模擬測試頁面", IconSource = "icon.png", TargetType = typeof(LayoutTest) });

            Padding = new Thickness(0, 40, 0, 0); //為了iphone上方的邊界
            Icon = "icon.png";
            Title = "各項測試功能清單";

            StackLayout contentStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            contentStack.Children.Add(listView);

            Content = contentStack;
        }
    }
}

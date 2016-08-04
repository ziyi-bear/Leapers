using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Leapers
{
    public partial class PartialDetailListPage : ContentPage
    {
        ListView listView;
        public ListView ListView { get { return listView; } }

        public PartialDetailListPage()
        {

            //這裡目前是儲存要顯示清單的資料
            var masterPageItems = new List<MasterPageItem>(); //List裡面參數就是下面的Title, IconSource, TargetType 因為下面我要逐一的把資料放進去 //targetType是你點下去所要進去的畫面ContentPage
            masterPageItems.Add(new MasterPageItem { Title = "JSON氣象資料API", IconSource = "icon.png", TargetType = typeof(OpenWeather) });
            masterPageItems.Add(new MasterPageItem { Title = "ContentPage模擬測試頁面", IconSource = "icon.png", TargetType = typeof(LayoutTest) });

            listView.ItemsSource = masterPageItems; //清單的資料來源
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Leapers
{
    public class BearMasterDetail:MasterDetailPage
    {
        PartialDetailListPage DetailPageItem;
        public BearMasterDetail() //建立的MasterDetailPage初始畫面
        {
            DetailPageItem = new PartialDetailListPage();

            Master = DetailPageItem; //清單主頁面
            Detail = new NavigationPage(new LayoutTest());
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e) //selectItemChangeEventArgs 是屬於listView的事件處理
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                DetailPageItem.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}

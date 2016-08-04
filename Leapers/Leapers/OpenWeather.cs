using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Leapers
{
    /*
     * 只有單一個頁面的資料
     * 資料為取得氣象資料(API)
     *
     * 
    */ 
    class OpenWeather:ContentPage //內容分頁 這裡藉由使用者輸入的資料取得對應的天氣資料
    {
        const string api_key = "a92ae2dede67de1ecc47e2b23f615644";
    }
}

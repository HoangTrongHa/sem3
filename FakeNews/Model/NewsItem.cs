using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews.Model
{
    public class NewsItem
    {
        public int id { get;set; }
        public String Category { get; set; }
        public  String Headline { get; set; }
        public String SubHead { get; set; }
        public String DeadLine { get; set; }
        public String Image { get; set; }
    }
    
    public class NewsManager{
        public static void GetNews(String Category, ObservableCollection<NewsItem> newsItems){
        var allItems = getNewsItem();
            var filteredNewsItems = allItems.Where(p => p.Category == Category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> getNewsItem()
    {
        var items = new List<FakeNews>();
        items.Add (new NewsItem(){id=1, Category="Financial",Headline="Lorem Ipsum",SubHead="doro sit amet" ,DeadLine="Nunc Tristique nec",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=2, Category="Financial",Headline="Nhung Khong Lam Thi Bi Nhac Nho",SubHead="E thich xem phim hoat hinh" ,DeadLine="Nhung Sao bay gio moi co",
            Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=3, Category="Financial",Headline="CORONA",SubHead="ABC", DeadLine="XYZ",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=4, Category="Financial",Headline="Khong dam dau",SubHead="Em Con Phai Hoc Bai" ,DeadLine="NGay Kia Em Phai Hoc Bai",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=5, Category="Financial",Headline="Nasus",SubHead="Yasuo", DeadLine="Yone",Image="Assets/1.jpg"});
    


        
                items.Add (new NewsItem(){id=6, Category="Jinx",Headline="Quinn",SubHead="Annie", DeadLine="Lucian",
                Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=7, Category="Food",Headline="Tristana",SubHead="Ashe" ,DeadLine="javan",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=8, Category="Food",Headline="Syndra",SubHead="Fizz" ,DeadLine="Jax",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=9, Category="Food",Headline="Aphelius",SubHead="Jhin", DeadLine="Zac",Image="Assets/1.jpg"});
        items.Add (new NewsItem(){id=10, Category="Food",Headline="1234",SubHead="231", DeadLine="dai qua khong viet nua dau",Image="Assets/1.jpg"});
            return items;
    }
}
    }

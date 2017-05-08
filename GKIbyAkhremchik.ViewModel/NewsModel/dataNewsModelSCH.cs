using System;

namespace GKIbyAkhremchik.ViewModel.NewsModel
{
    public class dataNewsModelSch
    {
        public int NewsSchoolId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Img_Title { get; set; }
        public string SmallText { get; set; }
        public string FullText { get; set; }
    }
}

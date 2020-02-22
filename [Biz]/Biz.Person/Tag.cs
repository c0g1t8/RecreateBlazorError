namespace Biz.Person
{
    public class Tag
    {
        public Tag() { }

        public Tag(string stTitle)
        {
            Title = stTitle;
        }

        public Tag(string stTitle, string stAddr)
        {
            Title = stTitle;
            Address = stAddr;             
        }

        // People/?c=asia 
        //public Link(string stParent, string stTitle, bool boolAuto)
        //{
        //    Title = stTitle;
        //    if (boolAuto)
        //        CreateDefaultLink(stParent, stTitle);

        //    //Address = "#";
        //}

        //private void CreateDefaultLink(string stParent, string stTitle)
        //{
        //    //  stTitle = Asia = > <li><a href="People/?c=asia">Asia</a></li>               
        //    // People/?c=asia
        //    //! need to change based on the default link scenario
        //    this.ParentTitle = stParent;
        //    this.Address = String.Format("{0}/?{1}={2}",stParent,stQueryIndicator,stTitle);
        //}


        public string Address { get; set; }
        public string Title { get; set; }
         
    }
}

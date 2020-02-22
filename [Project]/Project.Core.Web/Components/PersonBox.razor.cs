using Biz.Person;
using Microsoft.AspNetCore.Components;

namespace HIH.Components
{
    public partial class PersonBox : ComponentBase
    {
        [Parameter]
        public Person Person { get; set; }

        public Tag[] allTags;

        void GetTags()
        {
            allTags = new Tag[]
            {
                new Tag("Helpful"),
                new Tag("Family"),
                new Tag("Professional"),
                new Tag("Newbie")
            };
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GetTags();
        }

    }
}

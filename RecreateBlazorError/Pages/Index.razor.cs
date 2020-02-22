using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Biz.Person;
using HIH.Core.Services;
using Microsoft.AspNetCore.Components;

namespace HIH.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IPersonService PersonService { get; set; }

        private List<Person> people;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            people = PersonService.GetSamplePeople().ToList<Person>();
            Debug.WriteLine(people[0].Title);

        }
    }
}

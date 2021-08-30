using Blazored.Modal.Services;
using ReproducibleIssue.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace ReproducibleIssue.Pages
{
    public class FilterComponentBase : ComponentBase
    {
        [Parameter] public string View { get; set; }
        [CascadingParameter] public IModalService Modal { get; set; }
        protected List<SwciModel> SwciList { get; set; }
        protected FilterModel filter;

        //Test code
        protected List<string> test;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            test = new List<string>()
            {
            "Part 1",
            "Part 2",
            "Part 3",
            "Part 4"
            };


            var filter = new FilterModel();
            SwciList = GetData().ToList();
        }

        IEnumerable<SwciModel> GetData()
        {
            return new List<SwciModel>() {
                new SwciModel("1", "First"),
                new SwciModel("2", "Second"),
                new SwciModel("3", "Third"),
                new SwciModel("4", "Fourth"),
                new SwciModel("5", "Fifth")
            };
        }
    }
}

using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using ReproducibleIssue.Models;
using ReproducibleIssue.Service;
using System.Collections.Generic;
using System.Linq;

namespace ReproducibleIssue.Pages
{
    public class FirewallRulesBase : ComponentBase
    {
        [Inject] protected RulesService rulesService { get; set; }
        [Parameter] public SwciModel Swci { get; set; }
        [CascadingParameter] public IModalService Modal { get; set; }
        protected RadzenGrid<RulemanModel> grid;
        protected List<RulemanModel> rulemanList;
        protected IList<RulemanModel> selectedRules;

        protected bool IsOpen;
        protected string _arrowRotate = "img-rotated";
        protected string _displayItem = "display:none;";

        protected override void OnInitialized()
        {
            rulemanList = rulesService.GetRules(Swci.SwcId).ToList();
        }
            

        protected void SubmitAffirm(string justification)
        {
            if (selectedRules == null || selectedRules.Count == 0)
            {
                //toastService.ShowError("Please select some rules to affirm");
                return;
            }
            for (var i = 0; i < selectedRules.Count; i++)
            {
                var Id = selectedRules.ElementAt(i).Id;
                //Submit the Affirmation
            }
        }

        protected void OnDropDownClick()
        {
            if (IsOpen)
            {
                _arrowRotate = "img-rotated";
                _displayItem = "display:none;";
            }
            else
            {
                _displayItem = " ";
                _arrowRotate = " ";
            }

            IsOpen = !IsOpen;
        }
    }
}

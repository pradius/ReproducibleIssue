#pragma checksum "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4571b2daa4319547ff7b31f680a02a51b93d0e9e"
// <auto-generated/>
#pragma warning disable 1591
namespace ReproducibleIssue.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using ReproducibleIssue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using ReproducibleIssue.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using ReproducibleIssue.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using ReproducibleIssue.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class FirewallRules : FirewallRulesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between align-items-center w-100");
            __builder.AddAttribute(2, "style", "        height: 40px;\r\n        background-color: #f5f5f5;");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
               (() => OnDropDownClick())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label class=\"ms-2 fs-5\">Firewall Rules </label>\r\n    ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", "img/icons/u121.png");
            __builder.AddAttribute(8, "class", "me-2" + " " + (
#nullable restore
#line 8 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                               _arrowRotate

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", 
#nullable restore
#line 11 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
             _displayItem

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 12 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
     if (rulemanList != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<RulemanModel>>(15);
            __builder.AddAttribute(16, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                                                FilterMode.Simple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                                                                                                20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RulemanModel>>(
#nullable restore
#line 15 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                               rulemanList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ColumnWidth", "70px");
            __builder.AddAttribute(24, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RulemanModel>>(27);
                __builder2.AddAttribute(28, "Property", "Id");
                __builder2.AddAttribute(29, "Title", "");
                __builder2.AddAttribute(30, "Width", "35px");
                __builder2.AddAttribute(31, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(35);
                    __builder3.AddAttribute(36, "TriState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "class", "m-2 checkbox");
                    __builder3.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 19 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                     rulemanList.Any(x => selectedRules != null && selectedRules.Contains(x))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, 
#nullable restore
#line 20 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                  args => selectedRules = args ? rulemanList.ToList() : null

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                    ");
                }
                ));
                __builder2.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RulemanModel>)((item) => (__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                        ");
                    __Blazor.ReproducibleIssue.Pages.FirewallRules.TypeInference.CreateRadzenCheckBox_0(__builder3, 43, 44, 
#nullable restore
#line 23 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                  false

#line default
#line hidden
#nullable disable
                    , 45, "m-2 checkbox", 46, 
#nullable restore
#line 23 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                       selectedRules != null && selectedRules.Contains(item)

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RulemanModel>>(49);
                __builder2.AddAttribute(50, "Property", "AffirmStatus");
                __builder2.AddAttribute(51, "Title", "Affirmation Status");
                __builder2.AddAttribute(52, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RulemanModel>)((item) => (__builder3) => {
                    __builder3.AddMarkupContent(53, "\r\n");
#nullable restore
#line 28 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                          
                            string style = "";

                            switch (item.AffirmStatus)
                            {
                                case "Affirmed":
                                    style = "bg-success";
                                    break;
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(54, "                            ");
                    __builder3.OpenElement(55, "label");
                    __builder3.AddAttribute(56, "data-bs-toggle", "tooltip");
                    __builder3.AddAttribute(57, "data-bs-placement", "top");
                    __builder3.AddAttribute(58, "title", 
#nullable restore
#line 37 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                           item.AffirmStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(59, "\r\n                                ");
                    __builder3.OpenElement(60, "span");
                    __builder3.AddAttribute(61, "class", "badge" + " " + (
#nullable restore
#line 38 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                    style

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(62, 
#nullable restore
#line 38 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                            item.AffirmStatus

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n");
                    __builder3.AddContent(65, "                    ");
                }
                ));
                __builder2.AddAttribute(66, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.OpenElement(68, "label");
                    __builder3.AddAttribute(69, "data-bs-toggle", "tooltip");
                    __builder3.AddAttribute(70, "data-bs-placement", "top");
                    __builder3.AddAttribute(71, "title", 
#nullable restore
#line 43 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                       grid.Count

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, 
#nullable restore
#line 43 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                   grid.Count

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(73, " Total Records");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RulemanModel>>(76);
                __builder2.AddAttribute(77, "Property", "Id");
                __builder2.AddAttribute(78, "Title", "Id");
                __builder2.AddAttribute(79, "Width", "35px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RulemanModel>>(81);
                __builder2.AddAttribute(82, "Property", "DeviceName");
                __builder2.AddAttribute(83, "Title", "Device Name");
                __builder2.AddAttribute(84, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RulemanModel>)((item) => (__builder3) => {
                    __builder3.AddMarkupContent(85, "\r\n                        ");
                    __builder3.OpenElement(86, "label");
                    __builder3.AddAttribute(87, "data-bs-toggle", "tooltip");
                    __builder3.AddAttribute(88, "data-bs-placement", "top");
                    __builder3.AddAttribute(89, "title", 
#nullable restore
#line 49 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                       item.DeviceName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(90, 
#nullable restore
#line 49 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                                                        item.DeviceName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RulemanModel>>(93);
                __builder2.AddAttribute(94, "Property", "LogicalSystem");
                __builder2.AddAttribute(95, "Title", "Logical System");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n\r\n            ");
            }
            ));
            __builder.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 14 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                          grid = (Radzen.Blazor.RadzenGrid<RulemanModel>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.AddMarkupContent(99, "        <br>\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "d-flex justify-content-end");
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "d-flex");
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "btn btn-primary me-4");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
                                                                 () => Modal.Show<AffirmModal>("")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(109, "Affirm ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.AddMarkupContent(111, "<button class=\"btn btn-secondary me-2\">Not Required</button>\r\n                ");
            __builder.AddMarkupContent(112, "<button class=\"btn btn-secondary me-2\">Re-assign</button>\r\n                ");
            __builder.AddMarkupContent(113, "<button class=\"btn btn-secondary me-2\">Edit SWCI</button>\r\n                ");
            __builder.AddMarkupContent(114, "<button class=\"btn btn-secondary me-2\">Request Support</button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        <br>\r\n");
#nullable restore
#line 69 "C:\Users\josec\OneDrive\Desktop\Projects\ReproducibleIssue\Pages\FirewallRules.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n<hr class=\"m-0 p-0\">\r\n\r\n\r\n");
            __builder.AddMarkupContent(118, @"<style>
    .checkbox {
        height: 20px;
        width: 20px;
    }

    .img-rotated {
        transform: rotate( 180deg );
    }

    .rz-datatable-data td .rz-cell-data {
        font-size: 12px;
    }

    .rz-datatable-data td {
        padding: 0 0.2rem !important;
    }

    .rz-datatable-thead {
        font-size: 11px;
        padding: 4px 0;
    }

        .rz-datatable-thead th {
            white-space: normal !important;
        }

            .rz-datatable-thead th .rz-column-title {
                padding: 0 !important;
                text-transform: none !important;
            }

    .rz-paginator-page.rz-state-active {
        color: #17a2b8;
    }

    .rz-button.btn-primary {
        background-color: #17a2b8;
        border-color: #17a2b8;
    }

    .rz-button.btn-secondary {
        background-color: #6c757d;
        border-color: #6c757d;
    }

    .rz-cell-filter {
        padding: .15em 0em;
    }

    th > div {
        display: flex;
        flex-direction: column;
    }

        th > div > div {
            display: none;
        }

    .rz-datatable-thead th {
        padding: 0 !important;
    }
</style>");
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ReproducibleIssue.Pages.FirewallRules
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "TriState", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

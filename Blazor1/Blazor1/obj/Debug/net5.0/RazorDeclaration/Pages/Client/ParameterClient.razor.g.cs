// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor1.Pages.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Blazor1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blazor1\Blazor1\Blazor1\_Imports.razor"
using Blazor1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ParameterClient.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ClientProduits/{Transact}/{SId}")]
    public partial class ParameterClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ParameterClient.razor"
       
    [Parameter]
    public string Transact { get; set; }
    [Parameter]
    public string SId { get; set; }

    [Inject] CategoryService CategoryService { get; set; }
    protected List<Category> categories = new();
    
    protected Parameter parameters = new(2, 3, 1, 1, "", 1, 1);

    protected string selection;

    protected override async Task OnParametersSetAsync()
    {
        categories = await CategoryService.GetCategoriesAsync();
    }

    protected string selectCategories(int selected, int parentId = 0, string submark = "")
    {
        string html = "";
        foreach (var cat in categories)
        {
            if (cat.ParentId == parentId)
            {
                var hasChild = false;
                foreach (var child in categories)
                {
                    if (child.ParentId == cat.CategoryId) { hasChild = true; }
                }
                html += "'<option value=" + @cat.CategoryId;
                if (hasChild) { html += " disabled "; }
                if (selected == cat.CategoryId) { html += " selected "; }
                html += ">" + submark + cat.Name + "</option>";

                html += selectCategories(selected, cat.CategoryId, submark + "--");
            }
        }
        return html;
    }

    protected void OnSelectCategory(ChangeEventArgs e)
    {
        parameters.CategoryId = int.Parse(e.Value.ToString());
        parameters.CurrentPage = 1;
    }
    protected void OnSelectByPage(ChangeEventArgs e)
    {
        parameters.ProductsByPage = int.Parse(e.Value.ToString());
    }
    protected void OnSort(ChangeEventArgs e)
    {
        parameters.Sort = int.Parse(e.Value.ToString());
    }

    protected void OnSearch()
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

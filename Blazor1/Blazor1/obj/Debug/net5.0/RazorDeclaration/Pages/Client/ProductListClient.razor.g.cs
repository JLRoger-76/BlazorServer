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
#line 1 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ProductListClient.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ProductListClient.razor"
using Blazor1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ProductListClient.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ProductListClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\ProductListClient.razor"
       
    [CascadingParameter]
    public Parameter Parameters { get; set; }
    [CascadingParameter]
    public string Transact { get; set; }

    [Inject] StockProductService StockProductService { get; set; }

    protected List<StockProduct> stockProducts = new();
    protected StockProduct SelectedProduct;
    protected StockProduct parent = new();
    protected List<StockProduct> displayedStockProducts = new();

    //pagination
    protected int startPage = 1;      //1ere page du paginateur
    protected int displayedPages = 10;//total pages du paginateur

    protected int productsCount = 0;
    protected override async Task OnParametersSetAsync()
    {
        string parameters = JsonSerializer.Serialize(Parameters);
        stockProducts = await StockProductService.GetStockProductsAsync();
        //stockProducts = await client.GetFromJsonAsync<List<StockProduct>>("api/StockProducts/P/" + parameters);
           string jsonString = JsonSerializer.Serialize(stockProducts);
           Console.WriteLine(jsonString);
        if (Parameters.Sort == 1)
        {
            stockProducts = stockProducts.OrderBy(s => s.Product.Name).ToList();
        }
        else
        {
            stockProducts = stockProducts.OrderByDescending(s => s.Product.Name).ToList();
        }
        productsCount = stockProducts.Count();
        OnPage(Parameters.CurrentPage);
    }
    protected void OnPage(int i)
    {
        Parameters.CurrentPage = i;
        displayedStockProducts = stockProducts
            .Skip((Parameters.CurrentPage - 1) * Parameters.ProductsByPage)
            .Take(Parameters.ProductsByPage).ToList();
    }
    protected void OnPrevPage()
    {
        startPage -= displayedPages;
    }
    protected void OnNextPage()
    {
        startPage += displayedPages;
    }

    protected void OnCart(StockProduct product)
    {
        SelectedProduct = product;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

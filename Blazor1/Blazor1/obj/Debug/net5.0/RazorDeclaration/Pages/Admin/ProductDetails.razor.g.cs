// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor1.Pages.Admin
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
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
using Blazor1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/{Id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
       
    [Parameter]
    public int Id { get; set; }
    [Inject] StockProductService StockProductService { get; set; }
    [Inject] CategoryService CategoryService { get; set; }
    [Inject] ProductService ProductService { get; set; }

    List<Category> categories = new List<Category>();
    private Product product = new Product();
    protected override async Task OnInitializedAsync()
    {
        categories = await CategoryService.GetCategoriesAsync();
        if (Id > 0)
        {
            product = await ProductService.GetProductAsync(Id);
        }
        else
        {
            product.CategoryId = 1;
        }
    }
    string selectCategories(int selected, int parentId = 0, string submark = "")
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

    private void OnSelectCategory(ChangeEventArgs e)
    {
        product.CategoryId = int.Parse(e.Value.ToString());
    }

    IReadOnlyList<IBrowserFile> selectedFiles;
    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();

        this.StateHasChanged();
    }
    private async void OnSubmit()
    {
        if (selectedFiles != null)
        {
            foreach (var file in selectedFiles)
            {
                product.Image = file.Name;
                Stream stream = file.OpenReadStream();
                var path = $"{env.WebRootPath}\\pictures\\{file.Name}";
                FileStream fs = File.Create(path);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }
        }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
         if (Id == 0)
        {
            var response = await ProductService.InsertProductAsync(product);
            StockProduct stockProduct = new StockProduct { };
            stockProduct.StockId = 1;
            stockProduct.ProductId = int.Parse(response.ToString());
            stockProduct.StockQuantity = 0;
            await StockProductService.InsertStockProductAsync(stockProduct);
        }
        else { await ProductService.UpdateProductAsync(product); }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductDetails.razor"
                                                                  
        NavigationManager.NavigateTo("Products");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4708789d434cb813eea958cd8d843aaa57e3584"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
using Blazor1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Produits</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "button button-success");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                                OnCreate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddMarkupContent(8, @"<thead><tr><th scope=""col"">Id</th>
                <th scope=""col"">Nom</th>
                <th scope=""col"">Prix</th>
                <th scope=""col"">Image</th>
                <th scope=""col"">Categorie</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
             foreach (Product product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "scope", "row");
            __builder.AddAttribute(13, "data-label", "Id");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                     product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "data-label", "Nom");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                          product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "data-label", "Prix");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                           product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "data-label", "Image");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "src", "/pictures/" + (
#nullable restore
#line 33 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                                product.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "style", "width:100px; object-fit:cover;");
            __builder.AddAttribute(29, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "data-label", "Catégorie");
            __builder.AddContent(33, 
#nullable restore
#line 34 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                product.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "button button-success");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                                                        () => OnEdit(product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "button button-danger");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
                                                                                       () => Delete(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\Products.razor"
       
    [Inject] ProductService ProductService { get; set; }
    protected List<Product> products = new();

    protected override async Task OnInitializedAsync()
    {
        products = await ProductService.GetProductsAsync();
    }
    void OnCreate()
    {
        NavigationManager.NavigateTo("Product/0");
    }
    void OnEdit(int id)
    {
        NavigationManager.NavigateTo("Product/" + id);
    }
    async Task Insert(Product product)
    {
        await ProductService.InsertProductAsync(product);
        await OnInitializedAsync();
    }

    async Task Delete(Product product)
    {
        await ProductService.DeleteProductAsync(product);
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

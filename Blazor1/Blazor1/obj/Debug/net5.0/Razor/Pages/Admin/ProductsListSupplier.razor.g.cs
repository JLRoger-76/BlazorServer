#pragma checksum "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fcef9bbc98d9a1651bcb3736aee6a826ffb628"
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
#line 1 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ProductsListSupplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Blazor1.Pages.Admin.ProductsListSupplier.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 6 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                       SelectedProduct

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __Blazor.Blazor1.Pages.Admin.ProductsListSupplier.TypeInference.CreateCascadingValue_1(__builder2, 3, 4, 
#nullable restore
#line 7 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                           Transact

#line default
#line hidden
#nullable disable
                , 5, (__builder3) => {
                    __builder3.OpenComponent<Blazor1.Pages.Admin.SelectedProductAdmin>(6);
                    __builder3.CloseComponent();
                }
                );
            }
            );
#nullable restore
#line 11 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
 if (supplierProducts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Chargement...</em></p>");
#nullable restore
#line 14 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
     if (startPage > displayedPages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                          OnPrevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "button button-info");
            __builder.AddContent(12, "Prev");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
     for (int i = startPage; i <= Math.Min(displayedPages + startPage - 1, (productsCount + Parameters.ProductsByPage - 1) / Parameters.ProductsByPage); i++)
    {
        var pageNumber = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                          () => OnPage(pageNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "button button-info");
            __builder.AddContent(17, 
#nullable restore
#line 24 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                                 i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
     if ((productsCount + Parameters.ProductsByPage - 1) / Parameters.ProductsByPage >= startPage + displayedPages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                          OnNextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "button button-info");
            __builder.AddContent(22, "Next");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "table");
            __builder.OpenElement(24, "thead");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "<th scope=\"col\">Produit</th>\r\n                ");
            __builder.AddMarkupContent(27, "<th scope=\"col\">Image</th>\r\n                ");
            __builder.AddMarkupContent(28, "<th scope=\"col\">Prix</th>\r\n                ");
            __builder.OpenElement(29, "th");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "button button-success");
            __builder.AddAttribute(32, "href", "AdminProduits/Fournisseur/" + (
#nullable restore
#line 37 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                      Parameters.SupplierId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 44 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
             foreach (SupplierProduct supplierProduct in displayedSupplierProducts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "scope", "row");
            __builder.AddAttribute(39, "data-label", "Produit");
            __builder.AddContent(40, 
#nullable restore
#line 47 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                          supplierProduct.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "data-label", "Image");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "src", "/pictures/" + (
#nullable restore
#line 48 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                supplierProduct.Product.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "style", "width:100px; object-fit:cover;");
            __builder.AddAttribute(47, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "data-label", "Prix");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "style", "width:5rem !important;");
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                           e => OnPriceChange(supplierProduct.SupplierProductId, e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 50 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                                                                                            supplierProduct.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "button button-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                       () => OnDelete(supplierProduct.SupplierProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "button button-success");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
                                                                                        () => OnCart(supplierProduct)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "<span class=\"oi oi-cart\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Blazor1\Blazor1\Blazor1\Pages\Admin\ProductsListSupplier.razor"
       
    [CascadingParameter]
    public Parameter Parameters { get; set; }
    [CascadingParameter]
    public string Transact { get; set; }
    [Inject] SupplierService SupplierService { get; set; }
    [Inject] SupplierProductService SupplierProductService { get; set; }
    [Inject] StockProductService StockProductService { get; set; }

    protected List<SupplierProduct> supplierProducts;
    protected List<Supplier> suppliers;
    protected List<SupplierProduct> displayedSupplierProducts = new();
    protected SupplierProduct supplierProduct;
    protected StockProduct SelectedProduct;

    //pagination
    protected int startPage = 1;      //1ere page du paginateur
    protected int displayedPages = 10;//total pages du paginateur

    protected int productsCount = 0;
    protected int quantity;
    protected override async Task OnParametersSetAsync()
    {
        suppliers = await SupplierService.GetSuppliersAsync();
        supplierProducts = await SupplierProductService.GetSupplierProductAsync(Parameters.SupplierId);
        if (Parameters.Sort == 1)
        {
            supplierProducts = supplierProducts.OrderBy(s => s.Product.Name).ToList();
        }
        else
        {
            supplierProducts = supplierProducts.OrderByDescending(s => s.Product.Name).ToList();
        }
        productsCount = supplierProducts.Count();
        OnPage(Parameters.CurrentPage);
    }
    protected void OnPage(int i)
    {
        Parameters.CurrentPage = i;
        displayedSupplierProducts = supplierProducts
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

    protected async Task OnSelectSupplier(ChangeEventArgs e)
    {
        supplierProducts = await SupplierProductService.GetSupplierProductAsync(Parameters.SupplierId);
    }
    protected async Task OnPriceChange(int id, ChangeEventArgs e)
    {
        supplierProduct = supplierProducts.Find(e => e.SupplierProductId == id);
        supplierProduct.Price = decimal.Parse(e.Value.ToString());
        await SupplierProductService.UpdateSupplierProductAsync(supplierProduct);
    }
    protected async Task OnDelete(int id)
    {
        supplierProduct = supplierProducts.Single(s => s.SupplierProductId == id);
        supplierProducts.Remove(supplierProduct);
        await SupplierProductService.DeleteSupplierProductAsync(supplierProduct);
    }
    protected async Task OnCart(SupplierProduct supplierProduct)
    {
        StockProduct product = await StockProductService.GetStockProduct2Async("1&" + supplierProduct.ProductId);
        product.Product.Price = supplierProduct.Price;
        SelectedProduct = product;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.Blazor1.Pages.Admin.ProductsListSupplier
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

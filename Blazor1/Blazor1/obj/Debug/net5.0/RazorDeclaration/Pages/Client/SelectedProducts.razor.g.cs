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
#line 1 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\SelectedProducts.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\SelectedProducts.razor"
using Blazor1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\SelectedProducts.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class SelectedProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\SelectedProducts.razor"
       
        [CascadingParameter]
        protected StockProduct SelectedProduct { get; set; }
        [CascadingParameter]
        protected string Transact { get; set; }

    //popup modal Cart
    protected decimal total = 0;
    protected bool showModal = false;
    protected void ModalShow() => showModal = true;
    protected void ModalCancel() => showModal = false;
    protected void ModalOk() => showModal = false;

    [Inject] StockProductService StockProductService { get; set; }
    [Inject] SaleService SaleService { get; set; }
    [Inject] SaleProductService SaleProductService { get; set; }

    protected List<StockProduct> stockProducts = new();
    protected StockProduct parentStockProduct = new();

    protected override async void OnParametersSet()
    {
        if (SelectedProduct != null)
        {
            if (!stockProducts.Exists(s => s.ProductId == SelectedProduct.ProductId))
            {
                parentStockProduct = await StockProductService.GetStockProduct2Async("1&" + SelectedProduct.ProductId);
                SelectedProduct.ParentStockQuantity = parentStockProduct.StockQuantity;
                SelectedProduct.StockEntry = 1;
                stockProducts.Add(SelectedProduct);
                SetTotal();

            }
        }
    }
    protected void OnQuantityChange(int id, ChangeEventArgs e)
    {
        stockProducts.Find(e => e.ProductId == id).StockEntry = int.Parse(e.Value.ToString());
        SetTotal();

    }

    protected void OnDelete(int id)
    {
        var itemToDelete = stockProducts.Single(s => s.ProductId == id);
        stockProducts.Remove(itemToDelete);
        SetTotal();

    }
    protected void SetTotal()
    {
        total = 0;
        foreach (StockProduct stockProduct in stockProducts)
        {
            total += (decimal)stockProduct.Product.Price * stockProduct.StockEntry;
        }
    }
    protected async void OnSave()
    {
        string jsonString = JsonSerializer.Serialize(stockProducts);
        Console.WriteLine(jsonString);
        switch (Transact)
        {
            case "Demande":
                foreach (StockProduct stockProduct in stockProducts)
                {
                    stockProduct.StockQuery += stockProduct.StockEntry;
                    await StockProductService.UpdateStockProductAsync(stockProduct);
                }
                break;
            case "Distribution":
                foreach (StockProduct stockProduct in stockProducts)
                {
                    stockProduct.StockQuantity += stockProduct.StockEntry;
                    stockProduct.StockQuery = Math.Max(stockProduct.StockQuery - stockProduct.StockEntry, 0);
                    await StockProductService.UpdateStockProductAsync(stockProduct);

                    // diminu le stock du parent
                    parentStockProduct = await StockProductService.GetStockProduct2Async("1&" + stockProduct.ProductId);
                    parentStockProduct.StockQuantity -= stockProduct.StockEntry;
                    await StockProductService.UpdateStockProductAsync(parentStockProduct);
                }
                break;
            case "Ajout":
                foreach (StockProduct stockProduct in stockProducts)
                {
                    parentStockProduct = new();
                    parentStockProduct.ProductId = stockProduct.ProductId;
                    parentStockProduct.StockId = stockProduct.StockId;
                    parentStockProduct.StockQuery = stockProduct.StockEntry;
                    parentStockProduct.StockQuantity = 0;
                    await StockProductService.InsertStockProductAsync(parentStockProduct);

                    //   string jsonString = JsonSerializer.Serialize(parentStockProduct);
                    //   Console.WriteLine(jsonString);
                }
                break;
            
            case "Vente":
                foreach (StockProduct stockProduct in stockProducts)
                {
                    stockProduct.StockQuantity -= stockProduct.StockEntry;
                    await StockProductService.UpdateStockProductAsync(stockProduct);
                }
                break;
            case "Inventaire":
                foreach (StockProduct stockProduct in stockProducts)
                {
                    stockProduct.StockQuantity = stockProduct.StockEntry;
                    await StockProductService.UpdateStockProductAsync(stockProduct);
                }
                break;
            default:
                Console.WriteLine("Not Known");
                break;
        }

        stockProducts.Clear();
        SetTotal();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
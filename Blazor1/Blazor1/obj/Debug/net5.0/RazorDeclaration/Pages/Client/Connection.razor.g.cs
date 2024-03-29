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
#line 2 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
using Blazor1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Connection")]
    public partial class Connection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Blazor1\Blazor1\Blazor1\Pages\Client\Connection.razor"
       
    protected User[] users;
    protected User user = new User();
    private List<Stock> stocks = new List<Stock>();
    [Inject] StockService StockService { get; set; }
    [Inject] UserService UserService { get; set; }
    protected override async Task OnInitializedAsync()
    {
        users = await UserService.GetUsersAsync();
        stocks = await StockService.GetStocksAsync();
    }
    private async void connectUser()
    {
        // Create a SHA256
        // ComputeHash - returns byte array
        //using SHA256 sha256Hash = SHA256.Create();
        //string HashPassword = BitConverter.ToString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(user.Password))).Replace("-", String.Empty);
        //user = UserService.GetUserConnected(HashPassword);
        user = UserService.GetUserConnected(user.Password);
        if (user != null)
        {
            await storage.SetAsync("name", user.Pseudo);
            await storage.SetAsync("role", user.Role);
            int role = int.Parse(user.Role);
            if (role == 1)
            {
                NavigationManager.NavigateTo("Categories/");
            }
            else if (role > 1)
            {
                NavigationManager.NavigateTo("UserProduits/Demande/" + user.Role);
            }
            else
            {
                NavigationManager.NavigateTo("ClientProduits/Vente/1");
            }
        }
    }
    private async void createUser()
    {
        //using SHA256 sha256Hash = SHA256.Create();
        //user.Password = BitConverter.ToString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(user.Password))).Replace("-", String.Empty);
        await UserService.CreateUserAsync(user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage storage { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a503fc2769d9a5b124e71df0d8a0371cc1ce5c8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BusPass.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.HelperEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private string userLink;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected override void OnInitialized()
    {
        this.userLink = "/userHistory?user=" + AuthenticationService.user.UserId.ToString();
    }
    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PassportTypes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8d787e6125b69b7185b12cbb234d5e8616c9c2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BusPass.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.HelperEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PassportTypes.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/passportTypes")]
    public partial class PassportTypes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PassportTypes.razor"
       
    private ICollection<PassType> types;
    private PassType typeToUpdate = new PassType();
    private bool loading;
    private string error;
    protected override async Task OnInitializedAsync()
    {
        if (AuthenticationService.checkIfAdmin())
        {
            try
            {
                this.types = await passportTypeRepository.getPassTypes();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            await AuthenticationService.Logout();
        }

    }

    private void setTypeToEdit(PassType type)
    {
        if (typeToUpdate.PassTypeId == type.PassTypeId)
        {
            this.typeToUpdate = new PassType();
            
            StateHasChanged();
        }
        else
        {
            this.typeToUpdate = (PassType)type.Shallowcopy();
            StateHasChanged();
        }

    }

    private async void HandleValidSubmit()
    {
        loading = true;
        try
        {
            if (this.typeToUpdate.PassTypeId == 0)
            {
                await passportTypeRepository.addPassType(this.typeToUpdate);
                this.typeToUpdate = new PassType();
                this.types = await passportTypeRepository.getPassTypes();
                this.loading = false;
                StateHasChanged();
            }
            else
            {
                await passportTypeRepository.updatePassType(this.typeToUpdate);
                this.typeToUpdate = new PassType();
                this.types = await passportTypeRepository.getPassTypes();
                loading = false;
                StateHasChanged();

            }

        }
        catch (Exception ex)
        {
            error = ex.Message;
            loading = false;
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassportTypeRepository passportTypeRepository { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a150ebc2502e90a1aa2e988519d4131b4b7566d"
// <auto-generated/>
#pragma warning disable 1591
namespace BusPass.Client.Pages
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
#nullable restore
#line 6 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adminHome")]
    public partial class AdminHomepage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
 if(passportsToShow == null ||types == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "html");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<head>\r\n            <link href=\"css/UserPaymentHistory.css\" rel=\"stylesheet\">\r\n        </head>\r\n        ");
            __builder.OpenElement(6, "body");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "h1");
            __builder.AddAttribute(9, "class", "header");
            __builder.AddAttribute(10, "style", "margin-bottom: 30px;");
            __builder.AddContent(11, "WELCOME ");
            __builder.AddContent(12, 
#nullable restore
#line 17 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                     logedUser.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 17 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                     logedUser.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "dropDownContainer");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "dropdownItem");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<bool, Validation>>(22);
            __builder.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 20 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                 selectedValidation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Validation>>(
#nullable restore
#line 20 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                                                  validations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<bool>>(27);
                __builder2.AddAttribute(28, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<bool>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<bool>>(this, 
#nullable restore
#line 21 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                           onChangeValid

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(30);
                __builder2.AddAttribute(31, "Value", "valid");
                __builder2.AddAttribute(32, "Text", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "dropdownItem");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, PassType>>(39);
            __builder.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 26 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                 selectedType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Placeholder", "Select type");
            __builder.AddAttribute(42, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<PassType>>(
#nullable restore
#line 26 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                                                                      typesForComboBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(45);
                __builder2.AddAttribute(46, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 27 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                             onChangeType

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(48);
                __builder2.AddAttribute(49, "Value", "PassTypeId");
                __builder2.AddAttribute(50, "Text", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, " \r\n                    ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "style", "border-radius:.2em; border: 1px solid #8080805e;");
            __builder.AddAttribute(56, "value", 
#nullable restore
#line 31 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                            filterValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                                                                   filterPassportsByName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "placeholder", "Filter by name");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "class", "table");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, @"<thead>
                        <tr>
                            <th scope=""col"">Serial number</th>
                            <th scope=""col"">Holder</th>
                            <th scope=""col"">Date of issue</th>
                            <th scope=""col"">Passport type</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(65, "tbody");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 44 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                         foreach (var pass in passportsToShow)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                                ");
            __builder.OpenElement(68, "tr");
            __builder.AddAttribute(69, "style", "cursor: pointer;");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                                         e => goToUserProfile(pass.userId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.OpenElement(72, "th");
            __builder.AddAttribute(73, "scope", "row");
            __builder.AddContent(74, "#");
            __builder.AddContent(75, 
#nullable restore
#line 47 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                                      pass.passportId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                    ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 48 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                         pass.holder

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                    ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 49 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                         pass.dateOfIssue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 50 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                         pass.passType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 52 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                            }       

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "totalUsersWrapper");
            __builder.AddMarkupContent(92, "\r\n                    Total number of users: ");
            __builder.AddContent(93, 
#nullable restore
#line 56 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
                                            totalNumberOfUsers

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 61 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\AdminHomepage.razor"
       
    private LoginUser logedUser;
    private bool selectedValidation;
    private ICollection<UserBusPassport> passports;
    private ICollection<UserBusPassport> passportsToShow = new Collection<UserBusPassport> ();
    private ICollection<PassType> types;
    private ICollection<PassType> typesForComboBox;
    private string selectedType;
    private int totalNumberOfUsers = 0;
    private string filterValue;
    List<Validation> validations = new List<Validation> {
        new Validation () { Name = "Valid", valid = true },
        new Validation () { Name = "Invalid", valid = false },
    };
    protected override async Task OnInitializedAsync () {
        if (AuthenticationService.checkIfAdmin ()) {
            try {
                this.logedUser = AuthenticationService.user;
                this.selectedValidation = true;
                this.types = await passportTypeRepository.getPassTypes ();
                this.createAllType ();
                this.passports = await busPassportRepository.getByValidity (this.selectedValidation);
                this.fillPassportsToShow ();
                this.getTotalNumberOfUsers ();
            } catch (Exception e) {
                Console.WriteLine (e);
            }
        } else {
            await AuthenticationService.Logout ();
        }
    }

    private async void onChangeValid (Syncfusion.Blazor.DropDowns.ChangeEventArgs<bool> args) {
        this.selectedValidation = args.Value;
        if (this.selectedType == "0") {
            this.passports = await busPassportRepository.getByValidity (this.selectedValidation);
            this.fillPassportsToShow ();
        } else {
            this.passports = await busPassportRepository.getByType (this.selectedType, this.selectedValidation);
            this.fillPassportsToShow ();
        }

        this.getTotalNumberOfUsers ();
        StateHasChanged ();
    }

    private async void onChangeType (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        this.selectedType = args.Value;
        if (this.selectedType == "0") {
            this.passports = await busPassportRepository.getByValidity (this.selectedValidation);
            this.fillPassportsToShow ();

        } else {
            this.passports = await busPassportRepository.getByType (this.selectedType, this.selectedValidation);
            this.fillPassportsToShow ();
        }

        this.getTotalNumberOfUsers ();
        StateHasChanged ();
    }

    private void createAllType () {
        typesForComboBox = new Collection<PassType> ();

        PassType allType = new PassType {
            PassTypeId = 0,
            Name = "All",
        };

        this.typesForComboBox.Add (allType);

        foreach (var type in this.types) {
            this.typesForComboBox.Add (type);
        }
        this.selectedType = "0";
    }

    private void goToUserProfile (int userId) {
        NavigationManager.NavigateTo ("userHistory?user=" + userId);
    }

    private void getTotalNumberOfUsers () {
        this.totalNumberOfUsers = 0;
        foreach (var pass in passports) {
            this.totalNumberOfUsers++;
        }
    }

    private void fillPassportsToShow () {
        this.passportsToShow.Clear ();
        foreach (var pass in passports) {
            this.passportsToShow.Add (pass);
        }

        if (this.filterValue != "" && this.filterValue != null) {
            this.filterPassportsByName ();
        }
    }

    private void filterPassportsByName (ChangeEventArgs e = null) {
                
        if (e == null) {
            this.passportsToShow = passports.Where (pass => pass.holder.ToUpperInvariant ().Contains (this.filterValue.ToUpperInvariant ())).ToList ();
        } else {
            this.fillPassportsToShow ();
            this.filterValue = e.Value.ToString ();
            this.passportsToShow = passports.Where (pass => pass.holder.ToUpperInvariant ().Contains (this.filterValue.ToUpperInvariant ())).ToList ();
            StateHasChanged ();
        }
    }
    public class Validation {
    public string Name { get; set; }
    public bool valid { get; set; }
    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassportTypeRepository passportTypeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassportRepository busPassportRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591

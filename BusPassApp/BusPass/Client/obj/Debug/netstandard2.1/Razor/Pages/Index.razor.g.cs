#pragma checksum "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1bfdfe7a7dd803159c83b4cd3ebda897af62efe"
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
#line 2 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
 if (user == null || busPass == null || passType == null || account == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "html");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<head>\r\n        <link href=\"css/BusPass.css\" rel=\"stylesheet\">\r\n    </head>\r\n    ");
            __builder.OpenElement(5, "body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h1");
            __builder.AddAttribute(8, "class", "header");
            __builder.AddContent(9, "WELCOME ");
            __builder.AddContent(10, 
#nullable restore
#line 19 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                    user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 19 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                               user.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "h4");
            __builder.AddAttribute(15, "class", "subHeader");
            __builder.AddContent(16, "Bus passport serial number: #");
            __builder.AddContent(17, 
#nullable restore
#line 20 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                            busPass.BusPassportId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, " \r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "qrCodeContainer");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<h3 style=\"margin-bottom: 30px;\">QR code for your passport</h3>\r\n");
#nullable restore
#line 23 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                 if (!busPass.Valid) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                     if (payedForMonth) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                        ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", "https://api.qrserver.com/v1/create-qr-code/?data=userId:" + (
#nullable restore
#line 25 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                           user.UserId

#line default
#line hidden
#nullable disable
            ) + "&valid:" + (
#nullable restore
#line 25 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                                              busPass.Valid

#line default
#line hidden
#nullable disable
            ) + "&amp;size=100x100");
            __builder.AddAttribute(26, "alt", true);
            __builder.AddAttribute(27, "title", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<div class=\"alert alert-danger mt-3 mb-0\">Passport invalid! Reneweal won\'t be possiblle next month. Please contact Admin</div>\r\n");
#nullable restore
#line 27 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                    } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                        ");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", "https://api.qrserver.com/v1/create-qr-code/?data=userId:" + (
#nullable restore
#line 28 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                           user.UserId

#line default
#line hidden
#nullable disable
            ) + "&valid:" + (
#nullable restore
#line 28 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                                              busPass.Valid

#line default
#line hidden
#nullable disable
            ) + "&color=FF0000&amp;size=100x100");
            __builder.AddAttribute(33, "alt", true);
            __builder.AddAttribute(34, "title", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.AddMarkupContent(36, "<div class=\"alert alert-danger mt-3 mb-0\">Passport invalid! Please contact admin!</div>\r\n");
#nullable restore
#line 30 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                     
                } else {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                     if (payedForMonth) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                        ");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "src", "https://api.qrserver.com/v1/create-qr-code/?data=userId:" + (
#nullable restore
#line 33 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                           user.UserId

#line default
#line hidden
#nullable disable
            ) + "&valid:" + (
#nullable restore
#line 33 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                                              busPass.Valid

#line default
#line hidden
#nullable disable
            ) + "&amp;size=100x100");
            __builder.AddAttribute(40, "alt", true);
            __builder.AddAttribute(41, "title", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 34 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"

                    } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                        ");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "src", "https://api.qrserver.com/v1/create-qr-code/?data=userId:" + (
#nullable restore
#line 36 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                           user.UserId

#line default
#line hidden
#nullable disable
            ) + "&valid:" + (
#nullable restore
#line 36 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                                                              busPass.Valid

#line default
#line hidden
#nullable disable
            ) + "&color=FF0000&amp;size=100x100");
            __builder.AddAttribute(46, "alt", true);
            __builder.AddAttribute(47, "title", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "myButton btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                           renewBusPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 38 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                         if (loading) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "                            <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 40 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "                        RENEW\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 43 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                     if (!string.IsNullOrEmpty(error)) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "alert alert-danger mt-3 mb-0");
            __builder.AddContent(59, 
#nullable restore
#line 44 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                                                                   error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 45 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "userInfoContainer");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<h3>User information</h3>\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "infoWrapper");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "infoContainer");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.AddMarkupContent(73, "<span class=\"dataHeader\">Email:</span>\r\n                        ");
            __builder.OpenElement(74, "span");
            __builder.AddContent(75, 
#nullable restore
#line 54 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                               user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "infoContainer");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.AddMarkupContent(81, "<span class=\"dataHeader\">OIB:</span>\r\n                        ");
            __builder.OpenElement(82, "span");
            __builder.AddContent(83, 
#nullable restore
#line 58 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                               user.OIB

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "infoContainer");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<span class=\"dataHeader\">Type:</span>\r\n                        ");
            __builder.OpenElement(90, "span");
            __builder.AddContent(91, 
#nullable restore
#line 62 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                               passType.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "infoContainer");
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.AddMarkupContent(97, "<span class=\"dataHeader\">Price:</span>\r\n                        ");
            __builder.OpenElement(98, "span");
            __builder.AddContent(99, 
#nullable restore
#line 66 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                               passType.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(100, " kn");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "infoContainer");
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.AddMarkupContent(106, "<span class=\"dataHeader\">Account:</span>\r\n                        ");
            __builder.OpenElement(107, "span");
            __builder.AddContent(108, 
#nullable restore
#line 70 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
                               account.IBAN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 76 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\Index.razor"
       
    private BusPassport busPass;
    private User user;
    private PassType passType;
    private Account account;
    private bool payedForMonth;
    private bool loading;
    private string error;
    protected override async Task OnInitializedAsync () {
        if (!AuthenticationService.checkIfAdmin ()) {
            this.user = await userRepository.getUserById (AuthenticationService.user.UserId);
            try {
                this.busPass = await busPassRepository.getBusPassForUser (this.user.UserId);
                this.payedForMonth = await busPassPaymentRepository.getBusPassForUser (this.busPass.BusPassportId);
                this.passType = await passTypeRepository.getPassType (this.busPass.PassTypeId);
                this.account = await accountRepository.getAccountForUser (this.user.UserId);
            } catch (Exception e) {
                Console.WriteLine (e);
            }

        } else {
            await AuthenticationService.Logout ();
        }
    }

    private async void renewBusPass () {
        try {
            this.loading = true;
            BusPassPayment payment = new BusPassPayment ();
            payment.BusPassportId = this.busPass.BusPassportId;
            payment.Price = passType.Price;
            payment.PassTypeId = passType.PassTypeId;

            await busPassPaymentRepository.renewBusPass (payment);

            this.loading = false;
            this.payedForMonth = true;
            StateHasChanged ();
        } catch (Exception e) {
            this.error = e.Message;
            this.loading = false;
            StateHasChanged ();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountRepository accountRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassPaymentRepository busPassPaymentRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassportTypeRepository passTypeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassportRepository busPassRepository { get; set; }
    }
}
#pragma warning restore 1591

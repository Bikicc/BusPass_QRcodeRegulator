#pragma checksum "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e9b46ed649115d7cf0557b4f213d7ce5c364ec"
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
#line 8 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userHistory")]
    public partial class UserPaymentHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
 if (paymentsWithRecap == null || years == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
} else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "html");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<head>\r\n            <link href=\"css/UserPaymentHistory.css\" rel=\"stylesheet\">\r\n        </head>\r\n        \r\n        ");
            __builder.OpenElement(6, "body");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "allUsersView");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "headerContainer");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h1");
            __builder.AddContent(15, "Payments for ");
            __builder.AddContent(16, 
#nullable restore
#line 25 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                      user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 25 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                 user.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "dropDownContainer");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "dropdownItem");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, Year>>(27);
            __builder.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 29 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                             selectedYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Placeholder", "Select a year");
            __builder.AddAttribute(30, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Year>>(
#nullable restore
#line 29 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                                                                    yearsForComboBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(33);
                __builder2.AddAttribute(34, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 30 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                             onChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(36);
                __builder2.AddAttribute(37, "Value", "YearId");
                __builder2.AddAttribute(38, "Text", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.AddMarkupContent(46, @"<thead>
                        <tr>
                            <th scope=""col"">Serial number</th>
                            <th scope=""col"">Month</th>
                            <th scope=""col"">Date of payment</th>
                            <th scope=""col"">Passport type</th>
                            <th scope=""col"">Price</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 46 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                         foreach (var payment in paymentsWithRecap.payments)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                ");
            __builder.OpenElement(50, "tr");
            __builder.AddAttribute(51, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                   e => doubleClick(e, payment.paymentId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.OpenElement(53, "th");
            __builder.AddAttribute(54, "scope", "row");
            __builder.AddContent(55, "#");
            __builder.AddContent(56, 
#nullable restore
#line 49 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                      payment.paymentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 50 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                         payment.month

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 51 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                         payment.dateOfPayment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 52 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                         payment.busPassType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 53 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                         payment.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " kn");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 55 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                            }       

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "recap");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "recapItems");
            __builder.AddContent(80, "Number of renewals: ");
            __builder.AddContent(81, 
#nullable restore
#line 59 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                 paymentsWithRecap.numberOfPayments

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "recapItems");
            __builder.AddContent(85, "total: ");
            __builder.AddContent(86, 
#nullable restore
#line 60 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                    paymentsWithRecap.totalAmountPaid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, " kn");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 63 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
             if(logedUser.Role == "Admin") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "AdminView");
            __builder.AddMarkupContent(94, "\r\n                    ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "UserInfoContainer");
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.AddMarkupContent(98, "<div class=\"userInfoHeader\">\r\n                            User info\r\n                        </div>\r\n                        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "infoContainer");
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "infoItem");
            __builder.AddMarkupContent(104, "\r\n                                ");
            __builder.AddMarkupContent(105, "<span class=\"dataHeader\">Email:</span>\r\n                                ");
            __builder.OpenElement(106, "span");
            __builder.AddContent(107, 
#nullable restore
#line 72 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                       user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "infoItem");
            __builder.AddMarkupContent(112, "\r\n                                ");
            __builder.AddMarkupContent(113, "<span class=\"dataHeader\">OIB:</span>\r\n                                ");
            __builder.OpenElement(114, "span");
            __builder.AddContent(115, 
#nullable restore
#line 76 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                       user.OIB

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "infoItem");
            __builder.AddMarkupContent(120, "\r\n                                ");
            __builder.AddMarkupContent(121, "<span class=\"dataHeader\">Passport type:</span>\r\n                                ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "updateTypeWrapper");
            __builder.AddMarkupContent(124, "\r\n                                    ");
            __builder.OpenElement(125, "span");
            __builder.AddAttribute(126, "style", "display: flex; padding-right: 5px");
            __builder.AddMarkupContent(127, "\r\n                                        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, PassType>>(128);
            __builder.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 82 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                                 selectedType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "Placeholder", "Select type");
            __builder.AddAttribute(131, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<PassType>>(
#nullable restore
#line 82 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                                                                                      types

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(133, "\r\n                                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(134);
                __builder2.AddAttribute(135, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 83 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                             onChangeType

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(136, "\r\n                                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(137);
                __builder2.AddAttribute(138, "Value", "PassTypeId");
                __builder2.AddAttribute(139, "Text", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n                                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                                    ");
            __builder.OpenElement(143, "span");
            __builder.AddMarkupContent(144, "\r\n                                        ");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "class", "btn btn-primary");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                  updatePassType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 89 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                         if (loading) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(149, "                                            <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 91 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(150, "                                        Change\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                                ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "changeValidStateButtonWrapper");
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 97 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                     if (busPass.Valid == true) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "                                        ");
            __builder.OpenElement(158, "button");
            __builder.AddAttribute(159, "class", "btn btn-success");
            __builder.AddAttribute(160, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                  changeToInvalid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(161, "style", "width: 100%;");
            __builder.AddMarkupContent(162, "\r\n");
#nullable restore
#line 99 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                             if (loadingValid) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(163, "                                                <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 101 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(164, "                                            Valid\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
#nullable restore
#line 104 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                    } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(166, "                                        ");
            __builder.OpenElement(167, "button");
            __builder.AddAttribute(168, "class", "btn btn-danger");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                                                                 changeToValid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "style", "width: 100%;");
            __builder.AddMarkupContent(171, "\r\n");
#nullable restore
#line 106 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                             if (loadingValid) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(172, "                                                <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 108 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(173, "                                            Invalid\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n");
#nullable restore
#line 111 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(175, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, " \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n");
#nullable restore
#line 117 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(181, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n");
#nullable restore
#line 120 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserPaymentHistory.razor"
       
    private PaymentWithRecap paymentsWithRecap;
    private BusPassport busPass;
    int userId;
    private ICollection<Year> yearsForComboBox;
    private ICollection<Year> years;
    private System.Uri uri;
    private LoginUser logedUser;
    private User user;
    private ICollection<PassType> types;
    private string selectedType;
    private string selectedYear;
    private bool loading;
    private bool loadingValid;
    protected override async Task OnInitializedAsync () {
        this.setUserIdFromQuery ();
        this.logedUser = AuthenticationService.user;
        try {
            if (this.logedUser.Role == "Admin") {
                this.types = await passportTypeRepository.getPassTypes ();
            }
            this.user = await userRepository.getUserById (this.userId);
            this.busPass = await busPassRepository.getBusPassForUser (this.userId);
            this.selectedType = this.busPass.PassTypeId.ToString ();
            this.years = await yearRepository.getYears ();
            this.selectedYear = this.years.LastOrDefault ().YearId.ToString ();
            this.createAllYear ();
            this.paymentsWithRecap = await busPassPaymentRepository.getPaymentsForUserByYear (this.busPass.BusPassportId, this.selectedYear);
        } catch (Exception e) {
            Console.WriteLine (e);
        }
    }

    private async void onChange (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        selectedYear = args.Value;
        if (selectedYear == "0") {
            this.paymentsWithRecap = await busPassPaymentRepository.getAllPaymentsForUser (this.busPass.BusPassportId);
        } else {
            this.paymentsWithRecap = await busPassPaymentRepository.getPaymentsForUserByYear (this.busPass.BusPassportId, this.selectedYear);
        }
        StateHasChanged ();
    }

    private void doubleClick (MouseEventArgs e, int buttonNumber) {
        Console.WriteLine (buttonNumber);
    }

    private void createAllYear () {
        yearsForComboBox = new Collection<Year> ();

        Year allYear = new Year {
            YearId = 0,
            Name = "All",
            BusPassPayments = null
        };

        this.yearsForComboBox.Add (allYear);

        foreach (var year in this.years) {
            this.yearsForComboBox.Add (year);
        }

    }

    private void setUserIdFromQuery () {
        this.uri = nav.ToAbsoluteUri (nav.Uri);

        if (QueryHelpers.ParseQuery (this.uri.Query).TryGetValue ("user", out var aVal)) {
            this.userId = int.Parse (aVal);
        }
    }

    private void onChangeType (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        this.selectedType = args.Value;
        StateHasChanged ();
    }

    private async void updatePassType () {
        if (busPass.PassTypeId != int.Parse (this.selectedType)) {
            this.loading = true;
            try {
                this.busPass = await busPassRepository.updatePassType (this.busPass.BusPassportId, int.Parse (this.selectedType));
                this.loading = false;
            } catch (Exception e) {
                Console.WriteLine (e);
                this.loading = false;

            }
            StateHasChanged ();
        }
    }

    private async void changeToInvalid () {
        this.loadingValid = true;
        try {
            this.busPass = await busPassRepository.makePassInvalid (this.busPass.BusPassportId);
            this.loadingValid = false;
        } catch (Exception e) {
            Console.WriteLine(e);
            this.loadingValid = false;
        }
        StateHasChanged ();
    }

    private async void changeToValid () {
        this.loadingValid = true;
        try {
            this.busPass = await busPassRepository.makePassValid (this.busPass.BusPassportId);
            this.loadingValid = false;
        } catch (Exception e) {
            Console.WriteLine(e);
            this.loadingValid = false;
        }
        StateHasChanged ();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassportTypeRepository passportTypeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IYearRepository yearRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassportRepository busPassRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassPaymentRepository busPassPaymentRepository { get; set; }
    }
}
#pragma warning restore 1591

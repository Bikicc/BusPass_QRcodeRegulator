#pragma checksum "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140bb37f5c0cb39d6eedeb80f0213d16f842d696"
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
#line 2 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userSettings")]
    public partial class UserSettings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
 if(user == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6 offset-md-3 mt-5");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<h4 class=\"card-header\">User settings</h4>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.AddMarkupContent(23, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                user.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Name = __value, user.Name))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __Blazor.BusPass.Client.Pages.UserSettings.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 18 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                  () => user.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.AddMarkupContent(37, "<label>Surname</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                user.Surname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Surname = __value, user.Surname))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Surname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __Blazor.BusPass.Client.Pages.UserSettings.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 23 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                  () => user.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.AddMarkupContent(51, "<label>Email</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __Blazor.BusPass.Client.Pages.UserSettings.TypeInference.CreateValidationMessage_2(__builder2, 58, 59, 
#nullable restore
#line 28 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                  () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.AddMarkupContent(65, "<label>Current Password</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "type", "password");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                user.CurrentPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.CurrentPassword = __value, user.CurrentPassword))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.CurrentPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __Blazor.BusPass.Client.Pages.UserSettings.TypeInference.CreateValidationMessage_3(__builder2, 73, 74, 
#nullable restore
#line 33 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                  () => user.CurrentPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.AddMarkupContent(80, "<label>Password</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "type", "password");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                user.PasswordPlain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.PasswordPlain = __value, user.PasswordPlain))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.PasswordPlain));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __Blazor.BusPass.Client.Pages.UserSettings.TypeInference.CreateValidationMessage_4(__builder2, 88, 89, 
#nullable restore
#line 38 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                  () => user.PasswordPlain

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "class", "btn btn-success");
                __builder2.AddAttribute(94, "style", "width: 100%;");
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 41 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                         if (loading) {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(96, "                            <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 43 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(97, "                        Edit \r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n");
#nullable restore
#line 46 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                     if (!string.IsNullOrEmpty(error)) {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(99, "                        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "alert alert-danger mt-3 mb-0");
                __builder2.AddContent(102, 
#nullable restore
#line 47 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                                                                   error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#nullable restore
#line 48 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 53 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "X:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\UserSettings.razor"
        
    private User user;
    private bool loading;
    private string error;
    protected override async Task OnInitializedAsync()
    {
        if (AuthenticationService.checkIfAdmin())
        {
            await AuthenticationService.Logout();

        }
        else
        {
            this.user = await userRepository.getUserById(AuthenticationService.user.UserId);
        }
    }

    private async void HandleValidSubmit()
    {
        this.loading = true;
        try
        {
            this.user = await userRepository.updateUser(this.user);
            this.loading = false;
            this.error = null;
            StateHasChanged();
        }
        catch (Exception ex)
        {
            error = ex.Message;
            this.loading = false;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
    }
}
namespace __Blazor.BusPass.Client.Pages.UserSettings
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

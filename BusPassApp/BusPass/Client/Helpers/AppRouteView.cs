using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BusPass.Client.Helpers {
    public class AppRouteView : RouteView {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        protected override void Render (RenderTreeBuilder builder) {
            var authorize = Attribute.GetCustomAttribute (RouteData.PageType, typeof (AuthorizeAttribute)) != null;
            if (authorize && AuthenticationService.user == null) {
                NavigationManager.NavigateTo ("login");
            } else {
                base.Render (builder);
            }
        }
    }
}
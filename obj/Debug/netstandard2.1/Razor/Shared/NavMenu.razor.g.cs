#pragma checksum "C:\Users\formy\Workspace\project-grizz\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b21f93c2934eb29619b9acde9724082cbc15f6"
// <auto-generated/>
#pragma warning disable 1591
namespace project_grizz.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using project_grizz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\formy\Workspace\project-grizz\_Imports.razor"
using project_grizz.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "collapse" + " navbar-collapse" + " " + (
#nullable restore
#line 2 "C:\Users\formy\Workspace\project-grizz\Shared\NavMenu.razor"
                                        NavMenuCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "id", "navbarSupportedContent");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, @"<ul class=""navbar-nav mr-auto"">
      <li class=""nav-item"">
        <a class=""nav-link c-nav-link"" href=""/"">Portfolio</a>
      </li>
      <li class=""nav-item"">
        <a class=""nav-link c-nav-link"" href=""/blog"">Blog</a>
      </li>
    </ul>

    ");
            __builder.AddMarkupContent(8, @"<ul class=""navbar-nav ml-auto"">
        <li class=""nav-item c-logo-link -bg-highlight"">
            <a href=""https://github.com/GrizzlyEnglish"">
                <i class=""fab fa-github""></i>
            </a>
        </li>
        <li class=""nav-item c-logo-link -bg-secondary"">
            <a href=""https://www.linkedin.com/in/grizzlyenglish/"">
                <i class=""fab fa-linkedin""></i>
            </a>
        </li>
        <li class=""nav-item c-logo-link -bg-secondary-highlight"">
            <a href=""https://www.hackerrank.com/profile/grizzlyenglish"">
                <i class=""fab fa-hackerrank""></i>
            </a>
        </li>
    </ul>
  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\formy\Workspace\project-grizz\Shared\NavMenu.razor"
       

    private bool collapseNavMenu = false;

    private string NavMenuCssClass => collapseNavMenu ? "show" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

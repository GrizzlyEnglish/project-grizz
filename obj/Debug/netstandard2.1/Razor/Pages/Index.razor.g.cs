#pragma checksum "C:\Users\formy\Workspace\project-grizz\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19979403fd702b4291ea7563283f6ff7c4152007"
// <auto-generated/>
#pragma warning disable 1591
namespace project_grizz.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""c-intro-container"">

    <div class=""side"">
        <div class=""c-title-container"">
            <h1>Grizzly</h1>
            <h1>English</h1>
            <p>A software engineers potfolio</p>
        </div>
    </div>

    <div class=""c-gradient""></div>

    <div class=""c-gradient-background""></div>

</div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container c-info-container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<project_grizz.Shared.About>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<project_grizz.Shared.Skills>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<project_grizz.Shared.Projects>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<project_grizz.Shared.Work>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.AddMarkupContent(12, "<footer>\r\n        <p>Icons Provided by <a href=\"https://fontawesome.com\">Font Awesome</a> and <a href=\"https://icons8.com\">Icons8</a></p>\r\n    </footer>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

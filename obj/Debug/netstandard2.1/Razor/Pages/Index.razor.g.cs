#pragma checksum "C:\Users\formy\Workspace\project-grizz\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7066ca2844acad2d42891e81cc35584270284a5"
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
            __builder.OpenComponent<project_grizz.Shared.TitleCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.AddMarkupContent(3, "<h4>the</h4>\r\n    ");
                __builder2.AddMarkupContent(4, "<h1>Grizzly</h1>\r\n    ");
                __builder2.AddMarkupContent(5, "<h1>English</h1>\r\n    ");
                __builder2.AddMarkupContent(6, "<p>A software engineers potfolio</p>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<div class=\"c-arrow-container\">\r\n    <div class=\"arrow\"></div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container c-info-container");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "id", "about");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<project_grizz.Shared.About>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "skills");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenComponent<project_grizz.Shared.Skills>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "id", "education");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<project_grizz.Shared.Education>(27);
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "projects");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenComponent<project_grizz.Shared.Projects>(33);
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "id", "work");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenComponent<project_grizz.Shared.Work>(39);
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.AddMarkupContent(42, "<footer>\r\n        <p>Icons Provided by <a href=\"https://fontawesome.com\">Font Awesome</a> and <a href=\"https://icons8.com\">Icons8</a></p>\r\n    </footer>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

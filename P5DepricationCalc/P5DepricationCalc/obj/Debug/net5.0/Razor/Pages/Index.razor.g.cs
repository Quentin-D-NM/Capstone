#pragma checksum "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de5dd200cd073d1bb5e71a31c2b9862433d783aa"
// <auto-generated/>
#pragma warning disable 1591
namespace P5DepricationCalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using P5DepricationCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using P5DepricationCalc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\Index.razor"
using P5DepricationCalc.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\Index.razor"
using P5DepricationCalc.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<P5DepricationCalc.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MyAssetApi api { get; set; }
    }
}
#pragma warning restore 1591

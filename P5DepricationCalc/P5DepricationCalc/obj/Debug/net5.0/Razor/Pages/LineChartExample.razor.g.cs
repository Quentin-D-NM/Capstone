#pragma checksum "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a998573f94d0da98a308e7469f2a1eb80808c8"
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
#line 2 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/line-chart")]
    public partial class LineChartExample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Radzen Blazor Chart with line series</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 my-5");
            __builder.OpenElement(7, "label");
            __builder.AddContent(8, "Smooth ");
            __Blazor.P5DepricationCalc.Pages.LineChartExample.TypeInference.CreateRadzenCheckBox_0(__builder, 9, 10, "smooth", 11, 
#nullable restore
#line 9 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                                        smooth

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => smooth = __value, smooth)), 13, () => smooth);
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(15);
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.P5DepricationCalc.Pages.LineChartExample.TypeInference.CreateRadzenLineSeries_1(__builder2, 17, 18, 
#nullable restore
#line 11 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                           smooth

#line default
#line hidden
#nullable disable
                , 19, 
#nullable restore
#line 11 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                                          revenue2019

#line default
#line hidden
#nullable disable
                , 20, "Date", 21, "2019", 22, 
#nullable restore
#line 11 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                                                                                                      LineType.Dashed

#line default
#line hidden
#nullable disable
                , 23, "Revenue", 24, (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(25);
                    __builder3.AddAttribute(26, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 12 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                               MarkerType.Square

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                );
                __builder2.AddMarkupContent(27, "\r\n                ");
                __Blazor.P5DepricationCalc.Pages.LineChartExample.TypeInference.CreateRadzenLineSeries_2(__builder2, 28, 29, 
#nullable restore
#line 14 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                           smooth

#line default
#line hidden
#nullable disable
                , 30, 
#nullable restore
#line 14 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                                          revenue2020

#line default
#line hidden
#nullable disable
                , 31, "Date", 32, "2020", 33, "Revenue", 34, (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(35);
                    __builder3.AddAttribute(36, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 15 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                               MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                );
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(38);
                __builder2.AddAttribute(39, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 17 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                             20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "FormatString", "{0:MMM}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(42);
                __builder2.AddAttribute(43, "Formatter", new System.Func<System.Object, System.String>(
#nullable restore
#line 18 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                             FormatAsUSD

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(45);
                    __builder3.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(48);
                    __builder3.AddAttribute(49, "Text", "Revenue in USD");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\qdye2\Desktop\Fall2021Books\C#2\VisualStudiosProjects\P5DepricationCalc\P5DepricationCalc\Pages\LineChartExample.razor"
       
    bool smooth = false;
    class DataItem
    {
        public DateTime Date { get; set; }
        public double Revenue { get; set; }
    }

    string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

    DataItem[] revenue2019 = new DataItem[] {
        new DataItem
        {
            Date = DateTime.Parse("2019-01-01"),
            Revenue = 234000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-02-01"),
            Revenue = 269000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-03-01"),
            Revenue = 233000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-04-01"),
            Revenue = 244000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-05-01"),
            Revenue = 214000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-06-01"),
            Revenue = 253000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-07-01"),
            Revenue = 274000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-08-01"),
            Revenue = 284000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-09-01"),
            Revenue = 273000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-10-01"),
            Revenue = 282000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-11-01"),
            Revenue = 289000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-12-01"),
            Revenue = 294000
        }
    };

    DataItem[] revenue2020 = new DataItem[] {
        new DataItem
        {
            Date = DateTime.Parse("2019-01-01"),
            Revenue = 334000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-02-01"),
            Revenue = 369000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-03-01"),
            Revenue = 333000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-04-01"),
            Revenue = 344000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-05-01"),
            Revenue = 314000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-06-01"),
            Revenue = 353000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-07-01"),
            Revenue = 374000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-08-01"),
            Revenue = 384000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-09-01"),
            Revenue = 373000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-10-01"),
            Revenue = 382000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-11-01"),
            Revenue = 389000
        },
        new DataItem
        {
            Date = DateTime.Parse("2019-12-01"),
            Revenue = 394000
        }
    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.P5DepricationCalc.Pages.LineChartExample
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Radzen.Blazor.LineType __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "LineType", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

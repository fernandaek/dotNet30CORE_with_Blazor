#pragma checksum "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18abac56248228677b96b1b5a1edd2dcead5e00f"
// <auto-generated/>
#pragma warning disable 1591
namespace Exercise1.Pages.Chapter_03
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Exercise1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\_Imports.razor"
using Exercise1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
using Exercises.Classes.Chapter_03;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/exercise-03-03")]
    public class Exercise03_03 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Enter Student Data</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "placeholder", "First Name");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
              firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "placeholder", "Last Name");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
              lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "placeholder", "Age");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
              age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn-sm btn-success");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
                                             CreateStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn-sm btn-danger");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
                                            ClearStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "h4");
            __builder.AddContent(30, 
#nullable restore
#line 14 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
     output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03_03.razor"
       
    string firstName, lastName, output;
    int age;


    void CreateStudent()
    {
        var student = new Student(firstName, lastName, age);
        output = $"{student.FullName} {student.age}";
    }

    void ClearStudent()
    {
        firstName = string.Empty;
        lastName = string.Empty;
        output = string.Empty;
        age = default;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

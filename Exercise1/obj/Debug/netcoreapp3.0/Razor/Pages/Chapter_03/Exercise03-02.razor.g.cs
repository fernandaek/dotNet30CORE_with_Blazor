#pragma checksum "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc397ecd31c2c0e3232b59b6d4e76288d33409f"
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
#line 9 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
using Exercises.Classes.Chapter_03;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exercise-03-02")]
    public class Exercise03_02 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Students</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Student 1: name: ");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
                     student1.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " age: ");
            __builder.AddContent(5, 
#nullable restore
#line 13 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
                                             student1.age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Student 2: name: ");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
                     student2.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " age: ");
            __builder.AddContent(11, 
#nullable restore
#line 14 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
                                             student2.age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_03\Exercise03-02.razor"
       

    Student student1 = new Student();
    Student student2 = new Student("Fernanda", "Ek", 30);


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c106dd04eaa90039ec118f16522835091ed0b96"
// <auto-generated/>
#pragma warning disable 1591
namespace Exercise1.Pages.Chapter_07
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
#line 4 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
using Exercise1.Classes.Chapter_07_Conditionals;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/exercise-07-01")]
    public class Exercise_07_01 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Calculator</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "readonly", true);
            __builder.AddAttribute(3, "style", "width:145px");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
              input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => input = __value, input));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AddOperation(Operators.Multiply)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(6)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AddOperation(Operators.Devide)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "/");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(7)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(8)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(9)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AddOperation(Operators.Subtract)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AppnedDigit(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "calc-btn-size-lg btn-sm btn-light");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                              el => AddOperation(Operators.Add)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                            ClearDigits

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "C");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(84, "style", "padding-left: 4px");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                                                      ClearCalculation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "CC");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                            AddDecimal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(91, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "class", "calc-btn-size-sm btn-sm btn-light");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
                                                            Calculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "=");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n");
            __builder.OpenElement(98, "p");
            __builder.AddContent(99, 
#nullable restore
#line 42 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
    output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor"
       


    string input = string.Empty;
    string output = string.Empty;

    Calculator calc = new Calculator();

    void AppnedDigit(int digit)
    {
        if (input.Length == 0 && digit == 0) return;
        if (calc.Operations.Count == 0) output = string.Empty;

        input = input + digit;
    }

    void AddOperation(Operators @operator)
    {
        if (input.Length.Equals(0) && @operator == Operators.Subtract)
        {
            input = "-";
            return;
        }
        var success = double.TryParse(input, out double value);
        if (success)
        {
            calc.AddOperation(new Operation(value, @operator));
            DisplayOutput();
            ClearDigits();
        }
    }

    void DisplayOutput()
    {
        output = string.Empty;
        foreach (var operations in calc.Operations)
        {
            output += $"{operations.Value} {operations.OperatorValue} ";
        }
        if (calc.Operations.Count() > 1)
        {
            var result = calc.Calculate();
            input = result.ToString();
            output = output.Substring(0, output.Length - 2);
            output += $"= {result}";
        }
    }

    void ClearDigits()
    {
        input = string.Empty;
    }

    void ClearCalculation()
    {
        calc = new Calculator();
        output = string.Empty;
        ClearDigits();
    }

    void AddDecimal()
    {
        if (!input.Contains("."))
        {
            input = input + ".";
        }
    }

    void Calculate()
    {
        var success = double.TryParse(input, out double value);

        if (success)
        {
            AddOperation(Operators.Equal);
            calc = new Calculator();
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
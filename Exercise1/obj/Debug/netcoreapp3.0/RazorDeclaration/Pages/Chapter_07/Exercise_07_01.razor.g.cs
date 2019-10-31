#pragma checksum "C:\Users\Fernanda Ek\Documents\EC Utbildning\C-Sharp\Exercise1\Exercise1\Pages\Chapter_07\Exercise_07_01.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c106dd04eaa90039ec118f16522835091ed0b96"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

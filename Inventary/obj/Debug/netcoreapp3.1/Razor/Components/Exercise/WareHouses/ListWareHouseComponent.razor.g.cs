#pragma checksum "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dbe77380cf3d6c1b3302494349d7b60fa5b7c8b"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Components.Exercise.WareHouses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Components.Exercise.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Components.Exercise.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Components.Exercise.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Components.Exercise.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\_Imports.razor"
using Inventary.Components.Exercise.WareHouses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListWareHouseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover table-bordered ");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<thead>\r\n            <tr>\r\n                <th>Referencias</th>\r\n                <th>Nombre</th>\r\n                <th>Direccion</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 15 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
             foreach (var warehouses in WareHouses)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 18 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
                         warehouses.WareHousesId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 19 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
                         warehouses.WareHousesName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
                         warehouses.WareHousesAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 22 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\WareHouses\ListWareHouseComponent.razor"
       
    List<WareHousesEntity> WareHouses = new List<WareHousesEntity>();

    protected override async Task OnInitializedAsync()
    {
        WareHouses = B_WareHouses.WareHousesList();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
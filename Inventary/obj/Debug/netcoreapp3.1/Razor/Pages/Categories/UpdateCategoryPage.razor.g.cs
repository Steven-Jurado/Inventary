#pragma checksum "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Pages\Categories\UpdateCategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84674530e8a2d7b10f1155926895423a44a469f1"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Pages.Categories
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/update/category/{IdCategory}")]
    public partial class UpdateCategoryPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Inventary.Components.Exercise.Categories.UpdateCategoryComponent>(0);
            __builder.AddAttribute(1, "IdCategory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Pages\Categories\UpdateCategoryPage.razor"
                                      IdCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Pages\Categories\UpdateCategoryPage.razor"
       
    [Parameter]
    public string IdCategory { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IdCategory = IdCategory;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

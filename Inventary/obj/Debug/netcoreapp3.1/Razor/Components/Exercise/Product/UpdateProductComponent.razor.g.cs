#pragma checksum "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be361fe0ddd88941d844f6b139b2f2dfe7308f2"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Components.Exercise.Product
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
#line 1 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                 OProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<label for=\"Name\">\r\n            Nombre Del Producto:\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "id", "Name");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                                OProduct.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OProduct.ProductName = __value, OProduct.ProductName))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OProduct.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.AddMarkupContent(19, "<label for=\"Description\">\r\n            Descripcion:\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "id", "Description");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                                    OProduct.ProductDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OProduct.ProductDescription = __value, OProduct.ProductDescription))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OProduct.ProductDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "label");
                __builder2.AddMarkupContent(32, "\r\n            Categoria:\r\n            ");
                __Blazor.Inventary.Components.Exercise.Product.UpdateProductComponent.TypeInference.CreateInputSelect_0(__builder2, 33, 34, "form-control", 35, 
#nullable restore
#line 21 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                                      OProduct.CategoryId

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OProduct.CategoryId = __value, OProduct.CategoryId)), 37, () => OProduct.CategoryId, 38, (__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n");
#nullable restore
#line 22 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                 foreach (var category in Categories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(40, "                    ");
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 24 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                                    category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(43, "\r\n                        ");
                    __builder3.AddContent(44, 
#nullable restore
#line 25 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                         category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(45, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n");
#nullable restore
#line 27 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(47, "            ");
                }
                );
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "class", "btn btn-primary");
                __builder2.AddAttribute(53, "value", "Actualizar Producto");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
                                                                                           UpdateProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\Product\UpdateProductComponent.razor"
      
    [Parameter]
    public string idProduct { get; set; }

    ProductEntity OProduct = new ProductEntity();
    List<CategoryEntity> Categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        Categories = B_Category.CategoryList();
        OProduct = B_Productcs.ProductsById(idProduct);
    }

    private void UpdateProduct()
    {
        B_Productcs.UpdateProduct(OProduct);
        NavManager.NavigateTo("product/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.Inventary.Components.Exercise.Product.UpdateProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
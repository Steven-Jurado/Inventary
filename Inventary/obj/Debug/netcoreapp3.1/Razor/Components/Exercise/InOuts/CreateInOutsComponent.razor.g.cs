#pragma checksum "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff5c91ccf0cd4bb85eba2986acc175545de2673f"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventary.Components.Exercise.InOuts
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
#line 1 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>Bodegas: </label>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                            OnChangeWareHouses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", true);
            __builder.AddContent(10, "Seleccione Una Opcion.. ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 8 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
         foreach (var warehouse in WareHouses)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 10 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                            warehouse.WareHousesId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                      warehouse.WareHousesName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 11 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                 OInOuts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Productos:</label>\r\n        ");
                __Blazor.Inventary.Components.Exercise.InOuts.CreateInOutsComponent.TypeInference.CreateInputSelect_0(__builder2, 29, 30, "form-control", 31, 
#nullable restore
#line 18 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                  OInOuts.StorageId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OInOuts.StorageId = __value, OInOuts.StorageId)), 33, () => OInOuts.StorageId, 34, (__builder3) => {
                    __builder3.AddMarkupContent(35, "\r\n            ");
                    __builder3.AddMarkupContent(36, "<option value>Seleccione Una Opcion.. </option>\r\n");
#nullable restore
#line 20 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
             foreach (var storage in Storages)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(37, "                ");
                    __builder3.OpenElement(38, "option");
                    __builder3.AddAttribute(39, "value", 
#nullable restore
#line 22 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                storage.StorageId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(40, " ");
                    __builder3.AddContent(41, 
#nullable restore
#line 22 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                     storage.Product.ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(42, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n");
#nullable restore
#line 23 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(44, "        ");
                }
                );
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group mt-3");
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<label>Cantidad: </label>\r\n        ");
                __Blazor.Inventary.Components.Exercise.InOuts.CreateInOutsComponent.TypeInference.CreateInputNumber_1(__builder2, 51, 52, "form-control", 53, 
#nullable restore
#line 28 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                       OInOuts.Quantity

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OInOuts.Quantity = __value, OInOuts.Quantity)), 55, () => OInOuts.Quantity);
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.AddMarkupContent(61, "<label> Es Una Entrada: ? </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                         OInOuts.IsInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OInOuts.IsInput = __value, OInOuts.IsInput))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => OInOuts.IsInput));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "type", "button");
                __builder2.AddAttribute(71, "class", "btn btn-primary");
                __builder2.AddAttribute(72, "value", 
#nullable restore
#line 34 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                         buttonValue

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
                                                                                SaveInOuts

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "text-center h4");
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.AddContent(79, 
#nullable restore
#line 38 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
     message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\yenny\Desktop\Cursos De PLATZI\Blazor And .Net\Inventary\Components\Exercise\InOuts\CreateInOutsComponent.razor"
       

    string message = "";
    string buttonValue => OInOuts.IsInput ? "Registar Entrada" : "Registrar Salidad";
    InputOutputEntity OInOuts = new InputOutputEntity();
    ProductEntity OProduct = new ProductEntity();
    StorageEntity OStorage = new StorageEntity();

    List<WareHousesEntity> WareHouses = new List<WareHousesEntity>();
    List<StorageEntity> Storages = new List<StorageEntity>();


    protected override async Task OnInitializedAsync()
    {
        WareHouses = B_WareHouses.WareHousesList();
    }

    private void OnChangeWareHouses(ChangeEventArgs eventArgs)
    {
        var idWareHouse = eventArgs.Value.ToString();

        Storages = B_Storage.StoragesProductWareHouses(idWareHouse);
    }

    private void SaveInOuts()
    {
        OStorage = Storages.LastOrDefault(s => s.StorageId == OInOuts.StorageId);
        OProduct = OStorage.Product;

        if (OInOuts.IsInput)
        {
            OStorage.PartialQuantity = OStorage.PartialQuantity + OInOuts.Quantity;
            B_Storage.UpdateStorage(OStorage);

            OProduct.TotalQuantity = OProduct.TotalQuantity + OInOuts.Quantity;
            B_Productcs.UpdateProduct(OProduct);

            message = $"El Producto {OProduct.ProductName} Ha Sido Actualizado";

        }
        else
        {
            if (IsBiggerThanZera(OInOuts.Quantity, OStorage.PartialQuantity))
            {
                OStorage.PartialQuantity = OStorage.PartialQuantity - OInOuts.Quantity;
                B_Storage.UpdateStorage(OStorage);

                OProduct.TotalQuantity = OProduct.TotalQuantity - OInOuts.Quantity;
                B_Productcs.UpdateProduct(OProduct);

                message = $"El Producto {OProduct.ProductName} Ha Sido Actualizado";

            }
            else
            {
                message = $"No Existe Cantidad Suficiente Para el Producto {OProduct.ProductName}";

            }
        }
    }

    private bool IsBiggerThanZera(int Quantity, int storaQuantity)
    {

        return storaQuantity > Quantity ? true : false;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventary.Components.Exercise.InOuts.CreateInOutsComponent
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
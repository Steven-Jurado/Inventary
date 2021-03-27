// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591

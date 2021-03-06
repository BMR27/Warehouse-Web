#pragma checksum "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b19b7df3d441b5dc0bd4431368abe760d17c4ed"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.InOuts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class CreateInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Bryan Mejia Ruiz\Desktop\Universidad\Platzi\Curso .Net Blazor\Inventory\Inventory\Components\InOuts\CreateInOutComponent.razor"
       
    InputOutputEntity oInOut = new InputOutputEntity();

    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();

    string message;

    string buttonValue => oInOut.IsInput ? "Registrar Entrada" : "Registrar Salida";

    protected override async Task OnInitializedAsync()
    {
        warehouses = Business.B_Warehouse.WarehouseList();
    }


    private void OnChangedWarehouse(ChangeEventArgs e)
    {
        var idWarehouse = e.Value.ToString();

        storages = Business.B_Storage.StorageListByWarehouse(idWarehouse);
    }

    private void SaveInOut()
    {
        oStorage = storages.LastOrDefault(s => s.StorageId == oInOut.StorageId);
        oProduct = oStorage.Product;

        if (oInOut.IsInput)
        {
            oStorage.PartialQuantity = oStorage.PartialQuantity + oInOut.Quantity;
            Business.B_Storage.UpdateStorage(oStorage);

            oProduct.TotalQuantity = oProduct.TotalQuantity + oInOut.Quantity;
            Business.B_Product.UpdateProduct(oProduct);

            message = $"El producto {oProduct.ProductName} ha sido actualizado";
        }
        else
        {
            if (IsBiggerThanZero(oInOut.Quantity, oStorage.PartialQuantity))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - oInOut.Quantity;
                Business.B_Storage.UpdateStorage(oStorage);

                oProduct.TotalQuantity = oProduct.TotalQuantity - oInOut.Quantity;
                Business.B_Product.UpdateProduct(oProduct);

                message = $"El producto{oProduct.ProductName} ha sido actualizado";
            }
            else
            {
                message = $"No existe la cantidad suficiente en bodega para el producto {oProduct.ProductName}";
            }


        }
    }

    private bool IsBiggerThanZero(int quantity, int storageQuantity)
    {
        if (storageQuantity > quantity)
        {
            return true;
        }

        return false;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

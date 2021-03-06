#pragma checksum "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9149eb8637b44ee3aa8d36ec91081d67ceec34cf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMVVMToDo.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using BlazorMVVMToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using BlazorMVVMToDo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using BlazorMVVMToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using BlazorMVVMToDo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\_Imports.razor"
using BlazorMVVMToDo.Components;

#line default
#line hidden
#nullable disable
    public partial class ToDoListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
 if (ViewModel?.ToDoItemList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 4 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-deck");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 8 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
         foreach (var todoitem in ViewModel.ToDoItemList.OrderBy(i => i.Date).ThenBy(i=>i.Done))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card" + " mb-3" + " " + (
#nullable restore
#line 10 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                    todoitem.Done ? "bg-light" : "text-white bg-dark" 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "min-width: 18rem; max-width: 18rem;");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-header");
            __builder.AddContent(13, 
#nullable restore
#line 11 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                           todoitem.Date?.ToShortDateString() ?? string.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "card-title");
            __builder.AddContent(20, 
#nullable restore
#line 13 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                            todoitem.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#nullable restore
#line 14 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                          todoitem.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 15 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                       ViewModel.IsBusy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn" + " " + (
#nullable restore
#line 15 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                                                      todoitem.Done ? "btn-secondary" : "btn-primary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
                                                                                                                                    () => SetToDoItem(todoitem)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 18 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 20 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoListComponent.razor"
       
    [CascadingParameter(Name = "ViewModel")]
    IToDoViewModel ViewModel { get; set; }

    void SetToDoItem(ToDoItem todoitem)
    {
        ViewModel.ToDoItem = todoitem;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

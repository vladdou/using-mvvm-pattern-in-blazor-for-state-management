#pragma checksum "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e119d30284e2afae484472e6d59c2c35f2ec4cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ToDoFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Components\ToDoFormComponent.razor"
       
    [CascadingParameter(Name = "ViewModel")]
    IToDoViewModel ViewModel { get; set; }

    void SaveTodoItem()
    {
        ViewModel.SaveToDoItem(ViewModel.ToDoItem);
        ViewModel.ToDoItem = new ToDoItem();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

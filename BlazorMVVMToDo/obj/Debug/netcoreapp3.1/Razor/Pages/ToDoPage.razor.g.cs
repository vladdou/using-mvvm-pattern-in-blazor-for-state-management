#pragma checksum "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Pages\ToDoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401a012c19578d612a3c05cb8753dbe50cb3f4e0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMVVMToDo.Pages
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
#nullable restore
#line 4 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Pages\ToDoPage.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDoPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Items to do: ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Pages\ToDoPage.razor"
                  ViewModel.ToDoItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __Blazor.BlazorMVVMToDo.Pages.ToDoPage.TypeInference.CreateCascadingValue_0(__builder, 4, 5, 
#nullable restore
#line 9 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Pages\ToDoPage.razor"
                       ViewModel

#line default
#line hidden
#nullable disable
            , 6, "ViewModel", 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<BlazorMVVMToDo.Components.ToDoListComponent>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<BlazorMVVMToDo.Components.ToDoFormComponent>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\WD\FromGitHub\using-mvvm-pattern-in-blazor-for-state-management\BlazorMVVMToDo\Pages\ToDoPage.razor"
       

    protected override async Task OnInitializedAsync()
    {
        ViewModel.PropertyChanged += async (sender, e) => {
            await InvokeAsync(() =>
            {
                StateHasChanged();
            });
        };
        await base.OnInitializedAsync();
    }

    async void OnPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
    {
        await InvokeAsync(() =>
        {
            StateHasChanged();
        });
    }

    public void Dispose()
    {
        ViewModel.PropertyChanged -= OnPropertyChangedHandler;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoViewModel ViewModel { get; set; }
    }
}
namespace __Blazor.BlazorMVVMToDo.Pages.ToDoPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

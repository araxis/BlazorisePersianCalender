// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCalendar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\BDatePicker.razor"
using DNTPersianUtils.Core;

#line default
#line hidden
#nullable disable
    public partial class BDatePicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\BDatePicker.razor"
           
        Dropdown _dropdown;

    

        [Parameter]
        public DateTime Date { get; set; } = DateTime.Now;

        [Parameter]
        public EventCallback<DateTime> DateChanged { get; set; }

        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public Size Size { get; set; } = Size.Small;

        void Toggle()
        {
            if(Disabled) return;
            _dropdown.Toggle();
          
        }


        [Parameter]
        public IEnumerable<SpecialDay> SpecialDays { get; set; }=new List<SpecialDay>();





        async Task OnDateChanged(DateTime date)
        {
            Toggle();
            Date = date;
          
            await DateChanged.InvokeAsync(date);

        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (Date == DateTime.MinValue)
            {
                Date = DateTime.Now;

            }
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Date == DateTime.MinValue)
            {
                Date = DateTime.Now;

            }
        }


    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

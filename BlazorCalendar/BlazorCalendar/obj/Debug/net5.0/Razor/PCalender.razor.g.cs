#pragma checksum "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884dafc7900a0b63ea2c17672fbed6d995039d98"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
using DNTPersianUtils.Core;

#line default
#line hidden
#nullable disable
    public partial class PCalender : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "date-header");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex justify-content-between align-items-center");
            __builder.OpenElement(5, "button");
            __builder.AddEventPreventDefaultAttribute(6, "onclick", 
#nullable restore
#line 6 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                             true

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(7, "onclick", 
#nullable restore
#line 6 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                                             _=>OnPrev()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn");
            __builder.AddMarkupContent(10, "&#10094;");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "text-center");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "text-center");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                            _pMonth.GetPersianMonthName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                <br>\r\n                ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "text-center");
            __builder.AddAttribute(20, "style", "font-size: 18px");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                   _year.ToPersianNumbers()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.OpenElement(23, "button");
            __builder.AddEventPreventDefaultAttribute(24, "onclick", 
#nullable restore
#line 17 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                             true

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(25, "onclick", 
#nullable restore
#line 17 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                                             _=>OnNext()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn");
            __builder.AddMarkupContent(28, "&#10095;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "day-row");
#nullable restore
#line 22 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
             foreach (var item in _weekDayNames)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "padding: 2px");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "text-center");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "day-name");
            __builder.AddContent(38, 
#nullable restore
#line 26 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                 item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "box-days border");
#nullable restore
#line 38 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
     foreach (var item in _days)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
             if (CanShow(item))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "padding: 2px;cursor: pointer;");
            __builder.AddAttribute(44, "class", "text-center");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                                                                           _ => DateSelected(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", 
#nullable restore
#line 44 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                                  GetItemClass(item)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(48, "span");
            __builder.AddContent(49, 
#nullable restore
#line 46 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
                             item.GetPersianDayOfMonth().ToPersianNumbers()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<div style=\"padding: 2px;\"></div>");
#nullable restore
#line 54 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
             
           
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(52, @"<style>

    .date-header {
        background-color: #1abc9c;
        padding: 5px
    }



    .box-days {
        min-width: 300px;
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        padding-left: 10px;
        padding-right: 10px;
    }
        .box-days > * {
            flex: 0 0 14.2857142857%;
           
        }

    .day-row {
        background-color: #1abc9c;
        min-width: 300px;
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        padding-left: 10px;
        padding-right: 10px;
    }
        .day-row > * {
            flex: 0 0 14.2857142857%;
        }
    .day-row .day-name{
        text-align: justify;
        font-weight: bold;
    }

    .box-days .today {
      
        background: #1abc9c;
        color: white !important;
    }

   
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Projects\Components\BlazorCalendar\BlazorCalendar\PCalender.razor"
       

    readonly IEnumerable<string> _weekDayNames = new List<string> { "ش", "ی", "د", "س", "چ", "پ", "ج" };
    List<DateTime> _days = new();


    int _year;
    int _pMonth;

    [Parameter]
    public DateTime Date { get; set; } = DateTime.Now;

    [Parameter]
    public IEnumerable<SpecialDay> SpecialDays { get; set; } = new List<SpecialDay>();

    [Parameter]
    public bool RenderSelectedDate { get; set; } = true;

    [Parameter]
    public bool RenderToday { get; set; } = true;


    [Parameter]
    public EventCallback<DateTime> DateChanged { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        var pc = new PersianCalendar();
        var month= pc.GetMonth(Date);
        var year = pc.GetYear(Date);

        var days= pc.GetDaysInMonth(year, month);
        var date = pc.ToDateTime(year, month, 1, 0, 0, 0,0);


        _year=date.GetPersianYear();
        _pMonth = date.GetPersianMonth();
        var startWeekDay = PersianDayOfWeek(date);
        date = pc.AddDays(date,-startWeekDay);

        for (var i = 0; i < days; i++)
        {
            _days.Add(pc.AddDays(date,i));
        }

    }

    void OnNext()
    {
        AddMonth(1);
    }

    int PersianDayOfWeek( DayOfWeek start)
    {
        return start switch
        {
            DayOfWeek.Saturday => 0,
            DayOfWeek.Sunday => 1,
            DayOfWeek.Monday => 2,
            DayOfWeek.Tuesday => 3,
            DayOfWeek.Wednesday => 4,
            DayOfWeek.Thursday => 5,
            _ => 6
        };
        // return start == DayOfWeek.Saturday ? 0 : ((int) start) + 1;

    }

    int PersianDayOfWeek( DateTime date)
    {
        return date.DayOfWeek.PersianDayOfWeek();
    }


    private void OnPrev()
    {
        AddMonth(-1);
    }

    private void AddMonth(int monthCount)
    {
        var pc = new PersianCalendar();
        var date = pc.ToDateTime(_year, _pMonth, 1, 0, 0, 0,0);
        date = pc.AddMonths(date, monthCount);

        _year =date.GetPersianYear();
        _pMonth = date.GetPersianMonth();
        var days = pc.GetDaysInMonth(_year, _pMonth);
        var startWeekDay = PersianDayOfWeek(date);
        date = pc.AddDays(date,-startWeekDay);
        _days.Clear();
        for (var i = 0; i < days; i++)
        {
            _days.Add(pc.AddDays(date,i));
        }
    }

    private async Task DateSelected(DateTime item)
    {
        await DateChanged.InvokeAsync(item);
    }




    private string GetItemClass(DateTime item)
    {
        var selectedCss = RenderSelectedDate && item.DayOfYear == Date.DayOfYear ? "border border-primary" : "";
        var specialDay = SpecialDays.FirstOrDefault(d => d.Date.DayOfYear == item.DayOfYear);

        if (specialDay != null)
        {
            var bg= specialDay.BackgroundColor switch {
                Color.Link => "bg-white",
                Color.None => "bg-transparent",
                Color.Primary => "bg-primary",
                Color.Secondary => "bg-secondary",
                Color.Success => "bg-success",
                Color.Danger => "bg-danger",
                Color.Warning => "bg-warning",
                Color.Info => "bg-info",
                Color.Light => "bg-light",
                Color.Dark => "bg-dark",
                _ => throw new ArgumentOutOfRangeException()};

            return $"text-center {bg} {selectedCss}";
        }

        var today= RenderToday && item.DayOfYear == DateTime.Now.DayOfYear ? "today" : "";

        return $"text-center {today} {selectedCss}";


    }

    private bool CanShow(DateTime date)
    {
        var pc = new PersianCalendar();
        var month = pc.GetMonth(date);
        return month == _pMonth;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
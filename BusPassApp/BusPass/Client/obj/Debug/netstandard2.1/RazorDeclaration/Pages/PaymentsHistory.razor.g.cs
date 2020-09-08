#pragma checksum "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PaymentsHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4307757bc5bfabb7113973a2487b622f561259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BusPass.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using BusPass.Shared.HelperEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PaymentsHistory.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PaymentsHistory.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paymentsHistory")]
    public partial class PaymentsHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "x:\Documents\GitHub\BusPass_QRcodeRegulator\BusPassApp\BusPass\Client\Pages\PaymentsHistory.razor"
       
    private PaymentWithRecap paymentsWithRecap;
    private ICollection<Year> yearsForComboBox;
    private ICollection<Year> years;
    private ICollection<PassType> types;
    private ICollection<PassType> typesForComboBox;
    private ICollection<Month> months;
    private ICollection<Month> monthsForComboBox;
    private string selectedYear;
    private string selectedMonth;
    private string selectedType;

    protected override async Task OnInitializedAsync () {
        if (AuthenticationService.checkIfAdmin ()) {
            try {
                this.years = await yearRepository.getYears ();
                this.months = await monthRepository.GetMonths ();
                this.types = await passportTypeRepository.getPassTypes ();
                this.createAllComboBox ();
                this.paymentsWithRecap = await this.getData ();

            } catch (Exception e) {
                Console.WriteLine (e);
            }
        } else {
            await AuthenticationService.Logout ();
        }
    }

    private void createAllComboBox () {
        this.createAllYear ();
        this.createAllMonth ();
        this.createAllType ();
    }

    private void createAllYear () {
        yearsForComboBox = new Collection<Year> ();

        Year allYear = new Year {
            YearId = 0,
            Name = "All",
            BusPassPayments = null
        };

        this.yearsForComboBox.Add (allYear);

        foreach (var year in this.years) {
            this.yearsForComboBox.Add (year);
        }
        this.selectedYear = this.years.LastOrDefault ().YearId.ToString ();
    }

    private void createAllMonth () {
        monthsForComboBox = new Collection<Month> ();

        Month allMonth = new Month {
            MonthId = 0,
            Name = "All",
            BusPassPayments = null
        };

        this.monthsForComboBox.Add (allMonth);

        foreach (var month in this.months) {
            this.monthsForComboBox.Add (month);
        }
        this.selectedMonth = "0";
    }

    private void createAllType () {
        typesForComboBox = new Collection<PassType> ();

        PassType allType = new PassType {
            PassTypeId = 0,
            Name = "All",
        };

        this.typesForComboBox.Add (allType);

        foreach (var type in this.types) {
            this.typesForComboBox.Add (type);
        }
        this.selectedType = "0";
    }

    private async void onChangeType (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        this.selectedType = args.Value;
        try {
            this.paymentsWithRecap = await getData ();
        } catch (Exception e) {
            Console.WriteLine (e);
        }
        StateHasChanged ();
    }

    private async void onChangeMonth (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        this.selectedMonth = args.Value;
        try {
            this.paymentsWithRecap = await getData ();
        } catch (Exception e) {
            Console.WriteLine (e);
        }
        StateHasChanged ();
    }

    private async void onChangeYear (Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args) {
        this.selectedYear = args.Value;
        try {
            this.paymentsWithRecap = await getData ();
        } catch (Exception e) {
            Console.WriteLine (e);
        }
        StateHasChanged ();
    }

    private async Task<PaymentWithRecap> getData () {
        string yearParamIndicator = this.selectedYear == "0" ? "0" : "1";
        string monthParamIndicator = this.selectedMonth == "0" ? "0" : "1";
        string typeParamIndicator = this.selectedType == "0" ? "0" : "1";

        string filterIndicators = yearParamIndicator + monthParamIndicator + typeParamIndicator;
        return await busPassPaymentRepository.getAllPaymentsWithFilters (filterIndicators, int.Parse (this.selectedYear), int.Parse (this.selectedMonth), int.Parse (this.selectedType));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonthRepository monthRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassportTypeRepository passportTypeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IYearRepository yearRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusPassPaymentRepository busPassPaymentRepository { get; set; }
    }
}
#pragma warning restore 1591

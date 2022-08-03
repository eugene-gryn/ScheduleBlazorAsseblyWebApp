using Microsoft.AspNetCore.Components;

namespace ScheduleBlazorAssemblyWebApp.Pages.MainPage;

public partial class PluseComponent : ComponentBase
{
    [Parameter]
    public string ImgUrl { get; set; } = "";

    [Parameter]
    public string TextBody { get; set; } = "";
    
    [Parameter]
    public bool Reverse { get; set; } = false;
}
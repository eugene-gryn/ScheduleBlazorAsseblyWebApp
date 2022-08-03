namespace ScheduleBlazorAssemblyWebApp.Localization;

public abstract class BaseLocalization
{
    public virtual string IndexGreetings { get; set; } = "Welcome to schedule web app";
    public virtual string SingUp { get; set; } = "SingUp";
    public virtual string SingIn { get; set; } = "SingIn";

    public virtual string IndexFirstPlusImageDescription { get; set; } =
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut porta fermentum nisi vitae porta. Etiam molestie ex tellus, nec rutrum sem ultricies nec. Etiam fermentum turpis a nulla pellentesque, eget rhoncus ligula volutpat. Vivamus eu orci egestas, porttitor mi vel, rhoncus est. Cras vel tellus sapien. Curabitur eu leo egestas, tincidunt lectus et, convallis felis. Integer suscipit eget ante vel aliquam. Nullam feugiat lectus risus, vel sodales nibh malesuada et. Nam cursus egestas eros ac mattis. Pellentesque sagittis urna libero, non feugiat tortor sagittis a.";

    public virtual string IndexSecondPlusImageDescription { get; set; } =
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut porta fermentum nisi vitae porta. Etiam molestie ex tellus, nec rutrum sem ultricies nec. Etiam fermentum turpis a nulla pellentesque, eget rhoncus ligula volutpat. Vivamus eu orci egestas, porttitor mi vel, rhoncus est. Cras vel tellus sapien. Curabitur eu leo egestas, tincidunt lectus et, convallis felis. Integer suscipit eget ante vel aliquam. Nullam feugiat lectus risus, vel sodales nibh malesuada et. Nam cursus egestas eros ac mattis. Pellentesque sagittis urna libero, non feugiat tortor sagittis a.";
}
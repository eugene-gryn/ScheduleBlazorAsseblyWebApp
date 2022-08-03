namespace ScheduleBlazorAssemblyWebApp.FilenameHandlers;

public class ImageHandler
{
    public string IndexBigLogo => "src/images/index/big-logo.png";

    public string FooterGitHubLogo => "/src/images/index/footer/github-logo.png";
    public string FooterInstaLogo => "/src/images/index/footer/Instagram.svg.png";
    public string FooterTGLogo => "/src/images/index/footer/telegram-logo.png";


    public List<string> AboutSectionImgs { get; } = new()
    {
        "src/images/index/about-section-img1.jpg",
        "src/images/index/about-section-img2.jpg"
    };

    public List<string> IndexUIsList { get; } = new()
    {
        "src/images/index/BlazorWebSite.png"
    };
}
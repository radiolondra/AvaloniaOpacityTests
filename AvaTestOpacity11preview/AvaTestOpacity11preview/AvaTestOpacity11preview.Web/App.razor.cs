using Avalonia.Web.Blazor;

namespace AvaTestOpacity11preview.Web
{
    public partial class App
    {
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            WebAppBuilder.Configure<AvaTestOpacity11preview.App>()
                .SetupWithSingleViewLifetime();
        }
    }
}
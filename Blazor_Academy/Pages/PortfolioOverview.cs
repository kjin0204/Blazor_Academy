using Microsoft.AspNetCore.Components;

namespace Blazor_Academy.Pages
{
    public partial class PortfolioOverview
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        //페이지 이동을 위해 주입받음.
        [Inject]
        NavigationManager NavigationManager { get; set; }


        protected void pageMoveToNaver()
        {
            NavigationManager.NavigateTo("https://naver.com");
        }


        protected void pageMoveToIndex()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}

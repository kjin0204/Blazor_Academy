namespace Blazor_Academy.Pages
{
    public partial class About
    {
        string title = "정보";
        string subTitle = "서브 타이틀";

        protected override void OnInitialized()
        {
            subTitle = System.DateTime.Now.ToLongTimeString();
        }
    }
}

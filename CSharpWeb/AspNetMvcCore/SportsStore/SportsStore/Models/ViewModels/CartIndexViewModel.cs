using SportsStore.Models;

//c Add CartIndexViewModel.cs which is used to store Cart object and ReturnUrl string and to display Cart state on the web page.

namespace SportsStore.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
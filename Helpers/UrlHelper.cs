namespace PizzaPalace.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UrlHelper
    {
        public string RedirectUrl { get; set; }

        public UrlHelper(int OrderId, int OrderItemId)
        {
            RedirectUrl = $"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}";
        }
    }
}

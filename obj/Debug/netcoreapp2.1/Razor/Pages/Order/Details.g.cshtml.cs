#pragma checksum "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cabfa23e070fb9e337d5d4614381fb0a4b64433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaPalace.Pages.Order.Pages_Order_Details), @"mvc.1.0.razor-page", @"/Pages/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Order/Details.cshtml", typeof(PizzaPalace.Pages.Order.Pages_Order_Details), null)]
namespace PizzaPalace.Pages.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\_ViewImports.cshtml"
using PizzaPalace;

#line default
#line hidden
#line 3 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cabfa23e070fb9e337d5d4614381fb0a4b64433", @"/Pages/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e51d8c2d844b1f40b3e916ece93d17ee5426c7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/PizzaOrder/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(180, 503, true);
            WriteLiteral(@"
<h2>Order Details</h2>
<div class=""row"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card-columns"">
                    <div class=""card bg-dark"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Add a Pizza</h5>
                            <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
");
            EndContext();
#line 20 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                              
                                var orderId = Model.Orders.OrderId;
                                var itemId = Model.Orders.OrderItem.FirstOrDefault().OrderItemId;
                            

#line default
#line hidden
            BeginContext(914, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(942, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3757642ac0734bcb869ce8e1b587e7f5", async() => {
                BeginContext(1079, 11, true);
                WriteLiteral("+ Add Pizza");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-OrderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                                                                                                               WriteLiteral(orderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                                                                                                                                                WriteLiteral(itemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderItemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderItemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderItemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1094, 2140, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div hidden=""hidden"" class=""card bg-dark"">
                        <div class=""card-body"">
                        </div>
                    </div>
                    <div class=""card bg-dark"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Add Beverage</h5>
                            <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <a class=""btn btn-outline-success"">+ Add Beverage</a>
                        </div>
                    </div>
                    <div hidden=""hidden"" class=""card bg-dark"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Add Beverage</h5>
                            <p class=""card-text"">This is a longer card with supporting text below as a natural l");
            WriteLiteral(@"ead-in to additional content. This content is a little bit longer.</p>
                        </div>
                    </div>
                    <div hidden=""hidden"" class=""card bg-dark"">
                        <div class=""card-body"">
                        </div>
                    </div>
                    <div class=""card bg-dark"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Add a Side</h5>
                            <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <a class=""btn btn-outline-success"">+ Add Side</a>
                        </div>
                    </div>
                </div>
                <div class=""card bg-dark"">
                    <div class=""card-header"">Items</div>
                    <div class=""card-body"">
                        <h5 class=""card-title"">
           ");
            WriteLiteral("                 Pizza items:\r\n                        </h5>\r\n                        <ol>\r\n");
            EndContext();
#line 63 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                             foreach (var pizzaOrder in @Model.OrderItem.PizzaOrder)
                            {

#line default
#line hidden
            BeginContext(3351, 66, true);
            WriteLiteral("                            <li>\r\n                                ");
            EndContext();
            BeginContext(3418, 64, false);
#line 66 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                           Write(Model.Pizza.Find(u => u.PizzaId == pizzaOrder.PizzaId).PizzaName);

#line default
#line hidden
            EndContext();
            BeginContext(3482, 242, true);
            WriteLiteral("\r\n                                <a class=\"btn btn-outline-info\" href=\"#\">Add Topping</a>\r\n                                <ol>\r\n                                    \r\n                                </ol>\r\n                            </li>\r\n");
            EndContext();
#line 72 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(3755, 133, true);
            WriteLiteral("                        </ol>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(4042, 100, true);
            WriteLiteral("\r\n<div hidden=\"hidden\" class=\"col-md-4\">\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4143, 52, false);
#line 88 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orders.OrderItem));

#line default
#line hidden
            EndContext();
            BeginContext(4195, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4239, 48, false);
#line 91 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orders.OrderItem));

#line default
#line hidden
            EndContext();
            BeginContext(4287, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4331, 52, false);
#line 94 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orders.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(4383, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4427, 48, false);
#line 97 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orders.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(4475, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4519, 51, false);
#line 100 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orders.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(4570, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4614, 57, false);
#line 103 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orders.Customer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(4671, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4715, 48, false);
#line 106 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Orders.Store));

#line default
#line hidden
            EndContext();
            BeginContext(4763, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4807, 52, false);
#line 109 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Orders.Store.StoreId));

#line default
#line hidden
            EndContext();
            BeginContext(4859, 40, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaPalace.Pages.Order.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPalace.Pages.Order.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPalace.Pages.Order.DetailsModel>)PageContext?.ViewData;
        public PizzaPalace.Pages.Order.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

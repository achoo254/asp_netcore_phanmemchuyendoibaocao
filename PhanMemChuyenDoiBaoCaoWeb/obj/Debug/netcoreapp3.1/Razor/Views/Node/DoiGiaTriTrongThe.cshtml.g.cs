#pragma checksum "C:\Users\quocd\Google Drive\Cong viec\Phan mem tu viet\PhanMemChuyenDoiBaoCaoWeb\PhanMemChuyenDoiBaoCaoWeb\Views\Node\DoiGiaTriTrongThe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2cc01dc8fc9a3b7a9b84b699458e48fb5ec8ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Node_DoiGiaTriTrongThe), @"mvc.1.0.view", @"/Views/Node/DoiGiaTriTrongThe.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\quocd\Google Drive\Cong viec\Phan mem tu viet\PhanMemChuyenDoiBaoCaoWeb\PhanMemChuyenDoiBaoCaoWeb\Views\_ViewImports.cshtml"
using PhanMemChuyenDoiBaoCaoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quocd\Google Drive\Cong viec\Phan mem tu viet\PhanMemChuyenDoiBaoCaoWeb\PhanMemChuyenDoiBaoCaoWeb\Views\_ViewImports.cshtml"
using PhanMemChuyenDoiBaoCaoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2cc01dc8fc9a3b7a9b84b699458e48fb5ec8ee", @"/Views/Node/DoiGiaTriTrongThe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eae45dd4d4d9b323c3f4c956d80d8103b22a1de", @"/Views/_ViewImports.cshtml")]
    public class Views_Node_DoiGiaTriTrongThe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\quocd\Google Drive\Cong viec\Phan mem tu viet\PhanMemChuyenDoiBaoCaoWeb\PhanMemChuyenDoiBaoCaoWeb\Views\Node\DoiGiaTriTrongThe.cshtml"
  
    ViewData["Title"] = "Đổi giá trị trong thẻ";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2cc01dc8fc9a3b7a9b84b699458e48fb5ec8ee3702", async() => {
                WriteLiteral(@"
    <table class=""table table-hover table-bordered"" id=""myTable"">
        <thead class=""thead-light border text-center"">
            <tr>
                <th>Tên thẻ</th>
                <th>Giá trị cũ</th>
                <th>Giá trị mới</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <input type=""text"" class=""form-control"" />
                </td>
                <td>
                    <input type=""text"" class=""form-control"" />
                </td>
                <td>
                    <input type=""text"" class=""form-control"" />
                </td>
            </tr>
        </tbody>
    </table>
    <div>
        <button type=""submit"" class=""btn btn-primary"">Thực hiện</button>
        <p>Thêm thẻ mới</p>
    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"p\").click(function () {\r\n            alert(\"The paragraph was clicked.\");\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

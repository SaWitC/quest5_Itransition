#pragma checksum "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020d30924afd2952d0bbd542995e659fcaf27fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_GoToChat), @"mvc.1.0.view", @"/Views/Chat/GoToChat.cshtml")]
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
#line 1 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\_ViewImports.cshtml"
using MyVkQuest5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\_ViewImports.cshtml"
using MyVkQuest5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"020d30924afd2952d0bbd542995e659fcaf27fab", @"/Views/Chat/GoToChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9470ba5fc5d1b551b9b9a64f4df69e961d014704", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_GoToChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyVkQuest5.ViewModel.ChatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/microsoft-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\"></div>\r\n\r\n    <div class=\"col-md-6\" data-spy=\"scroll\">\r\n\r\n\r\n        <div id=\"renderData\" style=\"overflow: auto; height:650px\">\r\n            ");
#nullable restore
#line 10 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml"
       Write(await Html.PartialAsync("_renderMessages.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <h6>new messages</h6>\r\n        <div id=\"notify\"></div>\r\n\r\n");
#nullable restore
#line 15 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml"
         using (Html.BeginForm("Create", "Message", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input hidden name=\"ChatId\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 570, "\"", 591, 1);
#nullable restore
#line 18 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml"
WriteAttributeValue("", 578, Model.ChatId, 578, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input hidden name=\"userId\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 644, "\"", 673, 1);
#nullable restore
#line 19 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml"
WriteAttributeValue("", 652, ViewBag.interlocutor, 652, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral(@"            <div class=""input-group mb-3"">
                <input type=""text"" class=""form-control"" name=""Message"" placeholder=""Message"" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
                <input class=""btn btn-outline-secondary"" type=""submit"" id=""button-addon2"" value=""Sent"" />
            </div>
");
#nullable restore
#line 25 "D:\FileCopy\MyVkQuest5\MyVkQuest5\Views\Chat\GoToChat.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\"></div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\" integrity=\"sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=\" crossorigin=\"anonymous\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "020d30924afd2952d0bbd542995e659fcaf27fab5943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .build();

    // получение сообщения от сервера
    hubConnection.on('Notify', function (message) {

        //$(""#renderData"").append(data);
        // создает элемент <p> для сообщения пользователя
        let elem = document.createElement(""p"");
        var elem2 = `<div class=""card"" style=""width:auto;"">
    <div class=""form-group"">
        
        <div class=""card-body bg-info btn-lg active w-100 h-auto"" role=""button"" aria-pressed=""true"">
            <button type=""button"" class=""btn btn-secondary btn-lg active"" data-bs-toggle=""tooltip"" data-bs-placement=""right"" title=""From:"">
                ?
            </button>
            <h5 class=""card-text text-wrap"">user</h5>
            <p class=""card-text text-wrap"">${message}</p>
        </div>
    </div>
</div>`
        elem.appendChild(document.createTextNode(message));

        document.getElementById(""notify"").appendChild(elem");
            WriteLiteral(@");
        $(""#notify"").html(elem2);


    });
    hubConnection.start();


    hubConnection.on(""UserConnected"", function (connectionId) {
        //$(""#users"").html();
        console.log(""connected "" +connectionId)
    });

    hubConnection.on(""UserConnected"", function (connectionId) {
        //$(""#users"").html();
        console.log(""Disconnected "" +connectionId)
    });
</script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyVkQuest5.ViewModel.ChatVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

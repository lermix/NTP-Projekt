#pragma checksum "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f68319290223230158c55298825486082034f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f68319290223230158c55298825486082034f51", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
  
    var urlHost = Context.Request.Host;
    var baseUrl = @"https://" + urlHost;

    var exampleUrl = baseUrl + @"/Status";
    // Response taken from StatusController.cs
    var exampleResponse = "OK";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f68319290223230158c55298825486082034f513149", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 13 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
      Write(CentralniServer.Properties.Resources.ServerTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <style>
        .text-center {
            text-align: center!important;
        }
        #options_table {
            width: 100%;
            max-width: 1200px;
        }
        #options_table > thead {
            text-align: center;
        }
        #options_table > thead > tr:first-child {
            font-weight: bold;
            padding: .5rem 1rem;
        }
        #options_table td {
            border: 1px solid rgba(0, 0, 0, 0.2);
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f68319290223230158c55298825486082034f514926", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1 class=\"text-center\">Welcome to ");
#nullable restore
#line 36 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
                                      Write(CentralniServer.Properties.Resources.ServerTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <p>The server is online!</p>\r\n    </div>\r\n    <div>\r\n        <ul>\r\n            <li>Example call: <pre><a");
                BeginWriteAttribute("href", " href=\"", 1058, "\"", 1076, 1);
#nullable restore
#line 41 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1065, exampleUrl, 1065, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 41 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
                                                                    Write(exampleUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></pre></li>\r\n            <li>Response: <pre>");
#nullable restore
#line 42 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
                          Write(exampleResponse);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</pre></li>
        </ul>
    </div>
    <div>
        <h3>List of requests and responses:</h3>
        <table id=""options_table"">
            <thead>
                <tr>
                    <td>
                        Method
                    </td>
                    <td>
                        Link
                    </td>
                    <td>
                        URL aguments (if any)
                    </td>
                    <td>
                        Response
                    </td>
                </tr>
            </thead>
            <tbody>
                <!-- Inserted through JavaScript -->
            </tbody>
        </table>
    </div>

    <template id=""template_options_tr"">
        <tr>
            <td>{method}</td>
            <td>{link}</td>
            <td>{body}</td>
            <td>{response}</td>
        </tr>
    </template>

    <script>
        var table_body = document.querySelector(""#options_table > tbody"");
        var op");
                WriteLiteral("tion_html = document.querySelector(\"#template_options_tr\").innerHTML;\r\n        var baseUrl = \"");
#nullable restore
#line 82 "C:\Users\stjep\OneDrive\Dokumenti\GitHub\NTP-Projekt\NTP_Muller_Salopek\CentralniServer\Views\Home\Index.cshtml"
                  Write(baseUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

        function addOption(method, link, body, response) {
            if (!body)
                body = ""No body."";

            table_body.insertAdjacentHTML(""beforeend"",
                option_html.replace('{method}', method).replace('{link}', link).replace('{body}', body).replace('{response}', response)
            );
        }

        function onLoad() {
            addOption(""GET"", baseUrl + "" (+ /Home/Index)"", null, 'HTML of this page.');
            addOption(""GET"", baseUrl + ""/Status"", null, '""OK"" (server is alive)');
            addOption(""POST"", baseUrl + ""/User/Login"", 'username=exampleUsername&amp;password=ExamplePassword',
                '""Y"" (correct) <br />
                ""N_Username"" (incorrect username) <br />
                ""N_Password"" (incorrect password)'
            );
            addOption(""GET"", baseUrl + ""/User/Get/id?"", '',
                '(id sent, one user): { id, name, surname, username, password, role }<br />(no id, all users): [{...}, {...}, ...]');");
                WriteLiteral(@"
            addOption(""POST"", baseUrl + ""/User/Delete/id?"", null, ""Y<br/>or<br/>N"");
            addOption(""POST"", baseUrl + ""/User/Add/?"", ""name=example_name&surname=example&username=example&<br/>hashedPassword=example&role=admin_or_worker"", ""Y (success)<br/>N_ERROR_NAME (Error name can be 'parameters' etc)"");
            addOption(""GET"", baseUrl + ""/Product (+ /Get)"", null, '[{""id"":1,""name"":""cocacola"",""buttonName"":""Cola"",""price"":13.2}, {...}, ...]');
            addOption(""GET"", baseUrl + ""/Product/Delete/id?"", null, ""Y<br/>or<br/>N"");
            addOption(""POST"", baseUrl + ""/Product/Add/?"", ""name=example_Name&buttonName=example&price=13.2"", ""Y (success)<br/>N_ERROR_NAME (error can be 'parameters' etc)"")
        }

        onLoad();
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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

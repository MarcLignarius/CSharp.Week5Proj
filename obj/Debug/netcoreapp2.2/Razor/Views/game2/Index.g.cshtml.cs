#pragma checksum "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ef5809cbfb1d38e5cca3947bcc249745ea0956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_game2_Index), @"mvc.1.0.view", @"/Views/game2/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/game2/Index.cshtml", typeof(AspNetCore.Views_game2_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ef5809cbfb1d38e5cca3947bcc249745ea0956", @"/Views/game2/Index.cshtml")]
    public class Views_game2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gamestyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ef5809cbfb1d38e5cca3947bcc249745ea09564732", async() => {
                BeginContext(29, 55, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>Game Site</title>\n  ");
                EndContext();
                BeginContext(84, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02ef5809cbfb1d38e5cca3947bcc249745ea09565163", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(164, 374, true);
                WriteLiteral(@"
  <link rel=""stylesheet"" href=""css/lightGallery.css"" type=""text/css"" media=""all"" />
  <link href=""https://fonts.googleapis.com/css?family=Rubik&display=swap"" rel=""stylesheet"">
  <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/all.js"" integrity=""sha384-xymdQtn1n3lH2wcu0qhcdaOpQwyoarkgLVxC/wZ5q7h9gHtxICrpcaSUfygqZGOe"" crossorigin=""anonymous""></script>
  ");
                EndContext();
                BeginContext(538, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02ef5809cbfb1d38e5cca3947bcc249745ea09567035", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(619, 49, true);
                WriteLiteral("\n  <link rel=\"stylesheet\" href=\"/css/xpbar.css\">\n");
                EndContext();
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
            EndContext();
            BeginContext(675, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(676, 5195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ef5809cbfb1d38e5cca3947bcc249745ea09569352", async() => {
                BeginContext(682, 1949, true);
                WriteLiteral(@"
  <div class=""hero-image"">
    <div class=""hero-text"">
      <h1>Flappy Dog</h1>
      <br>
      <button><a href=""/play3"">Play</a></button>
    </div>
  </div>
  <div class=""container"">
    <h3 class=""title"">About the game</h3>
    <p class=""subtitle"">This is fine</p>
    <br>
    <p>You've heard of flappy bird but not get ready for its harder cousin flappy dog. With a bigger jump and a bigger invisible hitbox make sure you avoid the dogs with your flame or else youre gonna have a bad time.<p>
    <br>
    <hr>
    <br>
    <h3 class=""title"">How to play</h3>
    <p class=""subtitle"">Dont kill the dogs</p>
    <br>
    <ul>
      <li>Use space to jump. Don't hit the dogs</li>
    </ul>
    <br>
    <hr>
    <br>
    <h3 class=""title"">Gallery</h3>
    <p class=""subtitle"">In game screenshots</p>
    <br>
    <div class=""gallery"">
      <div class=""grid-container"">
        <div class=""grid-item"">
           <img src=""../img/pic1.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <");
                WriteLiteral(@"img src=""../img/pic2.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/pic3.png"" alt=""game 1 image"">
        </div>
      </div>
      <div class=""grid-container"">
        <div class=""grid-item"">
           <img src=""../img/pic2.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/pic3.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/pic1.png"" alt=""game 1 image"">
        </div>
      </div>
      <div class=""grid-container"">
        <div class=""grid-item"">
           <img src=""../img/pic3.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/pic1.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/pic3.png"" alt=""game 1 image"">
        </div>
      </div>
    </div>
  </div>
");
                EndContext();
                BeginContext(2658, 1493, true);
                WriteLiteral(@"  <footer class=""gameindexfooter"">
    <div class=""grid-container"">
      <div class=""grid-item"">
        <h4 style=""text-align: left"">Epicodus Games</h4>
        <p>400 SW 6th Ave #800, Portland, OR 97204</p>
        <p>info@epicodusgames.com</p>
        <br>
      </div>
      <div class=""grid-item"">
        <ul class=""nav"" style=""text-align: center"">
          <button><a href=""/games"">Our Games</a></button>
          <button><a href=""/about"">About Us</a></button>
          <button><a href=""/contact"">Contact Us</a></button>
        </ul>
      </div>
      <div class=""grid-item"">
        <h4 style=""text-align: right "" class=""connect"">Connect with us:</h4>
        <div class=""rounded-social-buttons"">
          <a class=""social-button facebook"" href=""https://www.facebook.com/"" target=""_blank""><i class=""fab fa-facebook-f""></i></a>
          <a class=""social-button twitter"" href=""https://www.twitter.com/"" target=""_blank""><i class=""fab fa-twitter""></i></a>
          <a class=""social-button linkedin"" href=""https:");
                WriteLiteral(@"//www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin""></i></a>
          <a class=""social-button youtube"" href=""https://www.youtube.com/"" target=""_blank""><i class=""fab fa-youtube""></i></a>
          <a class=""social-button instagram"" href=""https://www.instagram.com/"" target=""_blank""><i class=""fab fa-instagram""></i></a>
        </div>
      </div>
    </div>
    <div id='account-bar-wrapper'>
      <div id='account-bar'>
        <div id='account-bar-name'>");
                EndContext();
                BeginContext(4152, 17, false);
#line 106 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
                              Write(Model.Accountname);

#line default
#line hidden
                EndContext();
                BeginContext(4169, 49, true);
                WriteLiteral("</div>\n        <div id=\'account-bar-level\'>Level ");
                EndContext();
                BeginContext(4219, 11, false);
#line 107 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
                                     Write(Model.Level);

#line default
#line hidden
                EndContext();
                BeginContext(4230, 33, true);
                WriteLiteral("</div>\n        <div id=\'xp-bar\'>\n");
                EndContext();
#line 109 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            
            if(Model.LevelBar * 10 >= 10){

#line default
#line hidden
                BeginContext(4319, 45, true);
                WriteLiteral("              <div id=\'xp-bar-fill10\'></div>\n");
                EndContext();
#line 112 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 9){

#line default
#line hidden
                BeginContext(4426, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill9\'></div>\n");
                EndContext();
#line 115 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 8){

#line default
#line hidden
                BeginContext(4532, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill8\'></div>\n");
                EndContext();
#line 118 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 7){

#line default
#line hidden
                BeginContext(4638, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill7\'></div>\n");
                EndContext();
#line 121 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 6){

#line default
#line hidden
                BeginContext(4744, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill6\'></div>\n");
                EndContext();
#line 124 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 5){

#line default
#line hidden
                BeginContext(4850, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill5\'></div>\n");
                EndContext();
#line 127 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 4){

#line default
#line hidden
                BeginContext(4956, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill4\'></div>\n");
                EndContext();
#line 130 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 3){

#line default
#line hidden
                BeginContext(5062, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill3\'></div>\n");
                EndContext();
#line 133 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
            }
            else if (Model.LevelBar * 10 >= 2){

#line default
#line hidden
                BeginContext(5168, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill2\'></div>\n");
                EndContext();
#line 136 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
              }else if (Model.LevelBar * 10 >= 1){

#line default
#line hidden
                BeginContext(5263, 46, true);
                WriteLiteral("                <div id=\'xp-bar-fill1\'></div>\n");
                EndContext();
#line 138 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
              }
              else{

#line default
#line hidden
                BeginContext(5345, 46, true);
                WriteLiteral("                <div id=\'xp-bar-fill0\'></div>\n");
                EndContext();
#line 141 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
              }
            

#line default
#line hidden
                BeginContext(5421, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(5468, 299, true);
                WriteLiteral(@"
            <div id='xp-increase-fx'><div id='xp-increase-fx-flicker'><div class='xp-increase-glow1'></div><div class='xp-increase-glow2'></div><div class='xp-increase-glow3'></div></div><div class='xp-increase-glow2'></div>
          </div>
        </div>
        <div id='account-bar-next-level'>");
                EndContext();
                BeginContext(5768, 15, false);
#line 147 "/Users/Guest/Desktop/TeamProject2/Views/game2/Index.cshtml"
                                    Write(Model.NextLevel);

#line default
#line hidden
                EndContext();
                BeginContext(5783, 43, true);
                WriteLiteral("</div>\n      </div>\n    </div>\n  </footer>\n");
                EndContext();
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
            EndContext();
            BeginContext(5871, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AeroViewr
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : http://aggeorgiev/kendo/demos/aeroviewr/ 
        /// </summary>
        public AeroViewrPage AeroViewr
        {
            get
            {
                return new AeroViewrPage("http://aggeorgiev/kendo/demos/aeroviewr/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.flickr.com/ 
        /// </summary>
        public WelcomeToFlickrPage WelcomeToFlickr
        {
            get
            {
                return new WelcomeToFlickrPage("http://www.flickr.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://login.yahoo.com/config/login?.src=flickrsignin&.pc=8190&.scrumb=0&.pd=c%3DJvVF95K62e6PzdPu7MBv2V8-&.intl=us&.done=https%3A%2F%2Flogin.yahoo.com%2Fconfig%2Fvalidate%3F.src%3Dflickrsignin%26.pc%3D8190%26.scrumb%3D0%26.pd%3Dc%253DJvVF95K62e6PzdPu7MBv2V8-%26.intl%3Dus%26.done%3Dhttp%253A%252F%252Fwww.flickr.com%252Fsignin%252Fyahoo%252F%253Fredir%253D%25252Fphoto_grease_postlogin.gne%25253Fd%25253Dhttp%25253A%25252F%25252Fwww.flickr.com%25252Flogout_ok.gne%25253Fy%25253D1 
        /// </summary>
        public SignInToYahoo0Page SignInToYahoo0
        {
            get
            {
                return new SignInToYahoo0Page(@"https://login.yahoo.com/config/login?.src=flickrsignin&.pc=8190&.scrumb=0&.pd=c%3DJvVF95K62e6PzdPu7MBv2V8-&.intl=us&.done=https%3A%2F%2Flogin.yahoo.com%2Fconfig%2Fvalidate%3F.src%3Dflickrsignin%26.pc%3D8190%26.scrumb%3D0%26.pd%3Dc%253DJvVF95K62e6PzdPu7MBv2V8-%26.intl%3Dus%26.done%3Dhttp%253A%252F%252Fwww.flickr.com%252Fsignin%252Fyahoo%252F%253Fredir%253D%25252Fphoto_grease_postlogin.gne%25253Fd%25253Dhttp%25253A%25252F%25252Fwww.flickr.com%25252Flogout_ok.gne%25253Fy%25253D1", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://login.yahoo.com/config/login?.src=flickrsignin&.pc=8190&.scrumb=0&.pd=c%3DJvVF95K62e6PzdPu7MBv2V8-&.intl=us&.done=https%3A%2F%2Flogin.yahoo.com%2Fconfig%2Fvalidate%3F.src%3Dflickrsignin%26.pc%3D8190%26.scrumb%3D0%26.pd%3Dc%253DJvVF95K62e6PzdPu7MBv2V8-%26.intl%3Dus%26.done%3Dhttp%253A%252F%252Fwww.flickr.com%252Fsignin%252Fyahoo%252F%253Fredir%253D%25252Fphoto_grease_postlogin.gne%25253Fd%25253Dhttp%25253A%25252F%25252Fwww.flickr.com%25252F%252526notpopup%25253D1 
        /// </summary>
        public SignInToYahooPage SignInToYahoo
        {
            get
            {
                return new SignInToYahooPage(@"https://login.yahoo.com/config/login?.src=flickrsignin&.pc=8190&.scrumb=0&.pd=c%3DJvVF95K62e6PzdPu7MBv2V8-&.intl=us&.done=https%3A%2F%2Flogin.yahoo.com%2Fconfig%2Fvalidate%3F.src%3Dflickrsignin%26.pc%3D8190%26.scrumb%3D0%26.pd%3Dc%253DJvVF95K62e6PzdPu7MBv2V8-%26.intl%3Dus%26.done%3Dhttp%253A%252F%252Fwww.flickr.com%252Fsignin%252Fyahoo%252F%253Fredir%253D%25252Fphoto_grease_postlogin.gne%25253Fd%25253Dhttp%25253A%25252F%25252Fwww.flickr.com%25252F%252526notpopup%25253D1", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.kendoui.com/aeroviewr/ 
        /// </summary>
        public AeroViewr0Page AeroViewr0
        {
            get
            {
                return new AeroViewr0Page("http://www.kendoui.com/aeroviewr/", _manager.ActiveBrowser.Find);
            }
        }
        public class AeroViewrPage : HtmlPage
        {
            public AeroViewrPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' footer][tagIndex 'Exact' a:4]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=footer", "|", "tagIndex=a:4");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' flatMostPopularPhotos] THEN UNDER NODE FIND [tagindex 'Exact' li:20][tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage SunriseShellImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=flatMostPopularPhotos", "|", "tagindex=li:20", "|", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' bigPhoto] AND [tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage BigPhotoImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=bigPhoto", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Hints]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor HintsLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("TextContent=Hints", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' p] AND [TextContent 'StartsWith' something andbu]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl SomethingPTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^something andbu", "tagname=p");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' p] AND [TextContent 'StartsWith' with youroracco]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl WithPTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^with youroracco", "tagname=p");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' photoWrap] AND [tagname 'Exact' section]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl PhotoWrapSectionTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=section", "id=photoWrap");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' flatMostPopularPhotos] THEN UNDER NODE FIND [tagIndex 'Exact' li:3][tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage TechnicolorImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=flatMostPopularPhotos", "|", "tagIndex=li:3", "|", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'StartsWith' exifButton][tagname 'Exact' h2]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl TechnicolorH2Tag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("id=^exifButton", "|", "tagname=h2");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' exifButton][tagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=exifButton", "|", "tagIndex=span:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'StartsWith' k-window-title] AND [tagname 'Exact' span]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan TechnicolorSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("tagname=span", "class=^k-window-title");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' searchBox] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SearchBoxText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=searchBox");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Search]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SearchLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=Search");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' noimages] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv NoimagesDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("tagname=div", "id=noimages");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Drag]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor DragLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("TextContent=Drag", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainTemplate][tagIndex 'Exact' a:9]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor x10Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=mainTemplate", "|", "tagIndex=a:9");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' signin] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SigninLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "id=signin");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainTemplate][tagIndex 'Exact' a:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor x1Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=mainTemplate", "|", "tagIndex=a:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainTemplate][tagIndex 'Exact' div:1]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv Div
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=mainTemplate", "|", "tagIndex=div:1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' main] AND [tagname 'Exact' section]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl MainSectionTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("id=main", "tagname=section");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainPhotoStrip][tagIndex 'Exact' img:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage Kendo4Image
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=mainPhotoStrip", "|", "tagIndex=img:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid] AND [tagname 'Exact' button]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton GridButtonTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("id=grid", "tagname=button");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainPhotoGrid][tagIndex 'Exact' img:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage BusujimaSaekoImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=mainPhotoGrid", "|", "tagIndex=img:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' viewslideshow][tagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=viewslideshow", "|", "tagIndex=span:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' em] AND [TextContent 'Exact' Pause]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl PauseEmTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=Pause", "tagname=em");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' em] AND [TextContent 'Exact' Play]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl PlayEmTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=Play", "tagname=em");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' flatMostPopularPhotos] THEN UNDER NODE FIND [tagindex 'Exact' li:0][tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage VisionImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=flatMostPopularPhotos", "|", "tagindex=li:0", "|", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' backButton] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor BackButtonLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "id=backButton");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' uploadphotos][tagIndex 'Exact' span:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span1
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=uploadphotos", "|", "tagIndex=span:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' h1] AND [TextContent 'StartsWith' You mustto uplo]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl YouMusttoH1Tag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^You mustto uplo", "tagname=h1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' uploadSignIn] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor UploadSignInLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=uploadSignIn", "tagname=a");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=footer", "|", "tagIndex=a:4");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SunriseShellImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=flatMostPopularPhotos", "|", "tagindex=li:20", "|", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BigPhotoImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=bigPhoto", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression HintsLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Hints", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SomethingPTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^something andbu", "tagname=p");
                public ArtOfTest.WebAii.Core.HtmlFindExpression WithPTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^with youroracco", "tagname=p");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PhotoWrapSectionTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=section", "id=photoWrap");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TechnicolorImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=flatMostPopularPhotos", "|", "tagIndex=li:3", "|", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TechnicolorH2Tag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=^exifButton", "|", "tagname=h2");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=exifButton", "|", "tagIndex=span:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TechnicolorSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=span", "class=^k-window-title");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SearchBoxText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=searchBox");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SearchLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=Search");
                public ArtOfTest.WebAii.Core.HtmlFindExpression NoimagesDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=div", "id=noimages");
                public ArtOfTest.WebAii.Core.HtmlFindExpression DragLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Drag", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x10Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainTemplate", "|", "tagIndex=a:9");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SigninLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=signin");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x1Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainTemplate", "|", "tagIndex=a:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainTemplate", "|", "tagIndex=div:1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MainSectionTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=main", "tagname=section");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Kendo4Image = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainPhotoStrip", "|", "tagIndex=img:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "tagname=button");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BusujimaSaekoImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainPhotoGrid", "|", "tagIndex=img:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=viewslideshow", "|", "tagIndex=span:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PauseEmTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Pause", "tagname=em");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PlayEmTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Play", "tagname=em");
                public ArtOfTest.WebAii.Core.HtmlFindExpression VisionImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=flatMostPopularPhotos", "|", "tagindex=li:0", "|", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BackButtonLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=backButton");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=uploadphotos", "|", "tagIndex=span:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression YouMusttoH1Tag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^You mustto uplo", "tagname=h1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression UploadSignInLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=uploadSignIn", "tagname=a");
            }
        }
        public class WelcomeToFlickrPage : HtmlPage
        {
            public WelcomeToFlickrPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [src 'Exact' http://l.yimg.com/g/images/buddyicon.jpg#62801568@N08] AND [tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage EditYourImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("src=http://l.yimg.com/g/images/buddyicon.jpg#62801568@N08", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' head-signin-link] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor HeadSigninLinkLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=head-signin-link", "tagname=a");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression EditYourImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("src=http://l.yimg.com/g/images/buddyicon.jpg#62801568@N08", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression HeadSigninLinkLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=head-signin-link", "tagname=a");
            }
        }
        public class SignInToYahoo0Page : HtmlPage
        {
            public SignInToYahoo0Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Contains' Sign in as a di]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SignInAsALink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "TextContent=~Sign in as a di");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' passwd] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswdPassword
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("id=passwd", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' .save] AND [tagname 'Exact' button]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton SaveButtonTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("id=.save", "tagname=button");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression SignInAsALink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "TextContent=~Sign in as a di");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswdPassword = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=passwd", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SaveButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=.save", "tagname=button");
            }
        }
        public class SignInToYahooPage : HtmlPage
        {
            public SignInToYahooPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' username] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText UsernameText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=username", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression UsernameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=username", "tagname=input");
            }
        }
        public class AeroViewr0Page : HtmlPage
        {
            public AeroViewr0Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' userInfo] AND [tagname 'Exact' span]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan UserInfoSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=userInfo", "tagname=span");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' em] AND [TextContent 'Exact' sign out]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl SignOutEmTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=em", "TextContent=sign out");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' signin] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SigninLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "id=signin");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' flatSetsStrip] THEN UNDER NODE FIND [tagindex 'Exact' li:2][tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage x5733159853Dcd6074b9eSJpgImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=flatSetsStrip", "|", "tagindex=li:2", "|", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' footer] AND [tagname 'Exact' section]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl FooterSectionTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("id=footer", "tagname=section");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' mainSetPhotoStrip][tagIndex 'Exact' img:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage TulipsImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=mainSetPhotoStrip", "|", "tagIndex=img:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' h2] AND [TextContent 'Exact' Tulips]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl TulipsH2Tag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=Tulips", "tagname=h2");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' backButton] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor BackButtonLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=backButton", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' searchBox] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SearchBoxText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=searchBox", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Search]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor SearchLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("TextContent=Search", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' setPhotoPager][tagIndex 'Exact' a:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor x1Link
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=setPhotoPager", "|", "tagIndex=a:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' em] AND [TextContent 'Exact' my set]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl MySetEmTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=my set", "tagname=em");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression UserInfoSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=userInfo", "tagname=span");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SignOutEmTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=em", "TextContent=sign out");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SigninLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=signin");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x5733159853Dcd6074b9eSJpgImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=flatSetsStrip", "|", "tagindex=li:2", "|", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FooterSectionTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=footer", "tagname=section");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TulipsImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=mainSetPhotoStrip", "|", "tagIndex=img:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TulipsH2Tag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Tulips", "tagname=h2");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BackButtonLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=backButton", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SearchBoxText = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=searchBox", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SearchLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Search", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x1Link = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=setPhotoPager", "|", "tagIndex=a:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MySetEmTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=my set", "tagname=em");
            }
        }
    }
}

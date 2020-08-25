using TechTalk.SpecFlow;
using WTW.TestAutomation.Common.Helpers.Json;
using WTW.TestAutomation.Common.Helpers.Setup;
using WTW.TestAutomation.Common.Helpers.UI_Helpers.HTMLControls;

namespace WTW.TestAutomation.MyProjectName.Pages.Pages_UI
{
    public class ToolsqaPage : BasePage<ToolsqaPage>
    {
        readonly JsonHelper jHelper = new JsonHelper();

        private const string ORName = "Toolsqa";
        //LNK_DemoqaCom

        private const string demoqacomLinkbyxpath = "LNK_DemoqaCom_ByXPath";
        public HtmlLink DemoqaComLinkByXPath => new HtmlLink(jHelper.GetOR(demoqacomLinkbyxpath, ORName));

        private const string demoqacomLinkbycss = "LNK_DemoqaCom_ByCSS";
        public HtmlLink DemoqaComLinkByCSS => new HtmlLink(jHelper.GetOR(demoqacomLinkbycss, ORName));


        //BTN_ImagesToolsqaJpg

        private const string imagestoolsqajpgButtonbyxpath = "BTN_ImagesToolsqaJpg_ByXPath";
        public HtmlButton ImagesToolsqaJpgButtonByXPath => new HtmlButton(jHelper.GetOR(imagestoolsqajpgButtonbyxpath, ORName));

        private const string imagestoolsqajpgButtonbycss = "BTN_ImagesToolsqaJpg_ByCSS";
        public HtmlButton ImagesToolsqaJpgButtonByCSS => new HtmlButton(jHelper.GetOR(imagestoolsqajpgButtonbycss, ORName));


        //LBL_Login

        private const string loginLabelbyxpath = "LBL_Login_ByXPath";
        public HtmlLabel LoginLabelByXPath => new HtmlLabel(jHelper.GetOR(loginLabelbyxpath, ORName));

        private const string loginLabelbytext = "LBL_Login_ByText";
        public HtmlLabel LoginLabelByText => new HtmlLabel(jHelper.GetOR(loginLabelbytext, ORName));

        private const string loginLabelbycss = "LBL_Login_ByCSS";
        public HtmlLabel LoginLabelByCSS => new HtmlLabel(jHelper.GetOR(loginLabelbycss, ORName));

        private const string loginLabelbyxpathlist = "LBL_Login_ByXPathList";
        public HtmlLabel LoginLabelByXPathList => new HtmlLabel(jHelper.GetOR(loginLabelbyxpathlist, ORName));


        //LBL_Elements

        private const string elementsLabelbyxpath = "LBL_Elements_ByXPath";
        public HtmlLabel ElementsLabelByXPath => new HtmlLabel(jHelper.GetOR(elementsLabelbyxpath, ORName));

        private const string elementsLabelbyxpathlist = "LBL_Elements_ByXPathList";
        public HtmlLabel ElementsLabelByXPathList => new HtmlLabel(jHelper.GetOR(elementsLabelbyxpathlist, ORName));


        //LBL_Elements2

        private const string elements2Labelbyxpath = "LBL_Elements2_ByXPath";
        public HtmlLabel Elements2LabelByXPath => new HtmlLabel(jHelper.GetOR(elements2Labelbyxpath, ORName));

        private const string elements2Labelbytext = "LBL_Elements2_ByText";
        public HtmlLabel Elements2LabelByText => new HtmlLabel(jHelper.GetOR(elements2Labelbytext, ORName));

        private const string elements2Labelbycss = "LBL_Elements2_ByCSS";
        public HtmlLabel Elements2LabelByCSS => new HtmlLabel(jHelper.GetOR(elements2Labelbycss, ORName));

        private const string elements2Labelbyxpathlist = "LBL_Elements2_ByXPathList";
        public HtmlLabel Elements2LabelByXPathList => new HtmlLabel(jHelper.GetOR(elements2Labelbyxpathlist, ORName));


        //LBL_Forms

        private const string formsLabelbyxpath = "LBL_Forms_ByXPath";
        public HtmlLabel FormsLabelByXPath => new HtmlLabel(jHelper.GetOR(formsLabelbyxpath, ORName));

        private const string formsLabelbycss = "LBL_Forms_ByCSS";
        public HtmlLabel FormsLabelByCSS => new HtmlLabel(jHelper.GetOR(formsLabelbycss, ORName));

        private const string formsLabelbyxpathlist = "LBL_Forms_ByXPathList";
        public HtmlLabel FormsLabelByXPathList => new HtmlLabel(jHelper.GetOR(formsLabelbyxpathlist, ORName));


        //LBL_Forms2

        private const string forms2Labelbyxpath = "LBL_Forms2_ByXPath";
        public HtmlLabel Forms2LabelByXPath => new HtmlLabel(jHelper.GetOR(forms2Labelbyxpath, ORName));

        private const string forms2Labelbytext = "LBL_Forms2_ByText";
        public HtmlLabel Forms2LabelByText => new HtmlLabel(jHelper.GetOR(forms2Labelbytext, ORName));

        private const string forms2Labelbycss = "LBL_Forms2_ByCSS";
        public HtmlLabel Forms2LabelByCSS => new HtmlLabel(jHelper.GetOR(forms2Labelbycss, ORName));

        private const string forms2Labelbyxpathlist = "LBL_Forms2_ByXPathList";
        public HtmlLabel Forms2LabelByXPathList => new HtmlLabel(jHelper.GetOR(forms2Labelbyxpathlist, ORName));


        //LBL_Alertsframe&Windows

        private const string alertsframewindowsLabelbyxpath = "LBL_Alertsframe&Windows_ByXPath";
        public HtmlLabel AlertsframeWindowsLabelByXPath => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbyxpath, ORName));

        private const string alertsframewindowsLabelbycss = "LBL_Alertsframe&Windows_ByCSS";
        public HtmlLabel AlertsframeWindowsLabelByCSS => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbycss, ORName));

        private const string alertsframewindowsLabelbyxpathlist = "LBL_Alertsframe&Windows_ByXPathList";
        public HtmlLabel AlertsframeWindowsLabelByXPathList => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbyxpathlist, ORName));


        //LBL_Alertsframe&Windows2

        private const string alertsframewindows2Labelbyxpath = "LBL_Alertsframe&Windows2_ByXPath";
        public HtmlLabel AlertsframeWindows2LabelByXPath => new HtmlLabel(jHelper.GetOR(alertsframewindows2Labelbyxpath, ORName));

        private const string alertsframewindows2Labelbytext = "LBL_Alertsframe&Windows2_ByText";
        public HtmlLabel AlertsframeWindows2LabelByText => new HtmlLabel(jHelper.GetOR(alertsframewindows2Labelbytext, ORName));

        private const string alertsframewindows2Labelbycss = "LBL_Alertsframe&Windows2_ByCSS";
        public HtmlLabel AlertsframeWindows2LabelByCSS => new HtmlLabel(jHelper.GetOR(alertsframewindows2Labelbycss, ORName));

        private const string alertsframewindows2Labelbyxpathlist = "LBL_Alertsframe&Windows2_ByXPathList";
        public HtmlLabel AlertsframeWindows2LabelByXPathList => new HtmlLabel(jHelper.GetOR(alertsframewindows2Labelbyxpathlist, ORName));


        //LBL_Widgets

        private const string widgetsLabelbyxpath = "LBL_Widgets_ByXPath";
        public HtmlLabel WidgetsLabelByXPath => new HtmlLabel(jHelper.GetOR(widgetsLabelbyxpath, ORName));

        private const string widgetsLabelbycss = "LBL_Widgets_ByCSS";
        public HtmlLabel WidgetsLabelByCSS => new HtmlLabel(jHelper.GetOR(widgetsLabelbycss, ORName));

        private const string widgetsLabelbyxpathlist = "LBL_Widgets_ByXPathList";
        public HtmlLabel WidgetsLabelByXPathList => new HtmlLabel(jHelper.GetOR(widgetsLabelbyxpathlist, ORName));


        //LBL_Widgets2

        private const string widgets2Labelbyxpath = "LBL_Widgets2_ByXPath";
        public HtmlLabel Widgets2LabelByXPath => new HtmlLabel(jHelper.GetOR(widgets2Labelbyxpath, ORName));

        private const string widgets2Labelbytext = "LBL_Widgets2_ByText";
        public HtmlLabel Widgets2LabelByText => new HtmlLabel(jHelper.GetOR(widgets2Labelbytext, ORName));

        private const string widgets2Labelbycss = "LBL_Widgets2_ByCSS";
        public HtmlLabel Widgets2LabelByCSS => new HtmlLabel(jHelper.GetOR(widgets2Labelbycss, ORName));

        private const string widgets2Labelbyxpathlist = "LBL_Widgets2_ByXPathList";
        public HtmlLabel Widgets2LabelByXPathList => new HtmlLabel(jHelper.GetOR(widgets2Labelbyxpathlist, ORName));


        //LBL_Interactions

        private const string interactionsLabelbyxpath = "LBL_Interactions_ByXPath";
        public HtmlLabel InteractionsLabelByXPath => new HtmlLabel(jHelper.GetOR(interactionsLabelbyxpath, ORName));

        private const string interactionsLabelbycss = "LBL_Interactions_ByCSS";
        public HtmlLabel InteractionsLabelByCSS => new HtmlLabel(jHelper.GetOR(interactionsLabelbycss, ORName));

        private const string interactionsLabelbyxpathlist = "LBL_Interactions_ByXPathList";
        public HtmlLabel InteractionsLabelByXPathList => new HtmlLabel(jHelper.GetOR(interactionsLabelbyxpathlist, ORName));


        //LBL_Interactions2

        private const string interactions2Labelbyxpath = "LBL_Interactions2_ByXPath";
        public HtmlLabel Interactions2LabelByXPath => new HtmlLabel(jHelper.GetOR(interactions2Labelbyxpath, ORName));

        private const string interactions2Labelbytext = "LBL_Interactions2_ByText";
        public HtmlLabel Interactions2LabelByText => new HtmlLabel(jHelper.GetOR(interactions2Labelbytext, ORName));

        private const string interactions2Labelbycss = "LBL_Interactions2_ByCSS";
        public HtmlLabel Interactions2LabelByCSS => new HtmlLabel(jHelper.GetOR(interactions2Labelbycss, ORName));

        private const string interactions2Labelbyxpathlist = "LBL_Interactions2_ByXPathList";
        public HtmlLabel Interactions2LabelByXPathList => new HtmlLabel(jHelper.GetOR(interactions2Labelbyxpathlist, ORName));


        //LBL_Bookstoreapplication

        private const string bookstoreapplicationLabelbyxpath = "LBL_Bookstoreapplication_ByXPath";
        public HtmlLabel BookstoreapplicationLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbyxpath, ORName));

        private const string bookstoreapplicationLabelbycss = "LBL_Bookstoreapplication_ByCSS";
        public HtmlLabel BookstoreapplicationLabelByCSS => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbycss, ORName));

        private const string bookstoreapplicationLabelbyxpathlist = "LBL_Bookstoreapplication_ByXPathList";
        public HtmlLabel BookstoreapplicationLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbyxpathlist, ORName));


        //LBL_Bookstoreapplication2

        private const string bookstoreapplication2Labelbyxpath = "LBL_Bookstoreapplication2_ByXPath";
        public HtmlLabel Bookstoreapplication2LabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreapplication2Labelbyxpath, ORName));

        private const string bookstoreapplication2Labelbytext = "LBL_Bookstoreapplication2_ByText";
        public HtmlLabel Bookstoreapplication2LabelByText => new HtmlLabel(jHelper.GetOR(bookstoreapplication2Labelbytext, ORName));

        private const string bookstoreapplication2Labelbycss = "LBL_Bookstoreapplication2_ByCSS";
        public HtmlLabel Bookstoreapplication2LabelByCSS => new HtmlLabel(jHelper.GetOR(bookstoreapplication2Labelbycss, ORName));

        private const string bookstoreapplication2Labelbyxpathlist = "LBL_Bookstoreapplication2_ByXPathList";
        public HtmlLabel Bookstoreapplication2LabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreapplication2Labelbyxpathlist, ORName));


        //LBL_Login2

        private const string login2Labelbyxpath = "LBL_Login2_ByXPath";
        public HtmlLabel Login2LabelByXPath => new HtmlLabel(jHelper.GetOR(login2Labelbyxpath, ORName));

        private const string login2Labelbytext = "LBL_Login2_ByText";
        public HtmlLabel Login2LabelByText => new HtmlLabel(jHelper.GetOR(login2Labelbytext, ORName));

        private const string login2Labelbyxpathlist = "LBL_Login2_ByXPathList";
        public HtmlLabel Login2LabelByXPathList => new HtmlLabel(jHelper.GetOR(login2Labelbyxpathlist, ORName));


        //LBL_Bookstore

        private const string bookstoreLabelbyxpath = "LBL_Bookstore_ByXPath";
        public HtmlLabel BookstoreLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreLabelbyxpath, ORName));

        private const string bookstoreLabelbytext = "LBL_Bookstore_ByText";
        public HtmlLabel BookstoreLabelByText => new HtmlLabel(jHelper.GetOR(bookstoreLabelbytext, ORName));

        private const string bookstoreLabelbyxpathlist = "LBL_Bookstore_ByXPathList";
        public HtmlLabel BookstoreLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreLabelbyxpathlist, ORName));


        //LBL_Profile

        private const string profileLabelbyxpath = "LBL_Profile_ByXPath";
        public HtmlLabel ProfileLabelByXPath => new HtmlLabel(jHelper.GetOR(profileLabelbyxpath, ORName));

        private const string profileLabelbytext = "LBL_Profile_ByText";
        public HtmlLabel ProfileLabelByText => new HtmlLabel(jHelper.GetOR(profileLabelbytext, ORName));

        private const string profileLabelbyxpathlist = "LBL_Profile_ByXPathList";
        public HtmlLabel ProfileLabelByXPathList => new HtmlLabel(jHelper.GetOR(profileLabelbyxpathlist, ORName));


        //LBL_Bookstoreapi

        private const string bookstoreapiLabelbyxpath = "LBL_Bookstoreapi_ByXPath";
        public HtmlLabel BookstoreapiLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbyxpath, ORName));

        private const string bookstoreapiLabelbytext = "LBL_Bookstoreapi_ByText";
        public HtmlLabel BookstoreapiLabelByText => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbytext, ORName));

        private const string bookstoreapiLabelbyxpathlist = "LBL_Bookstoreapi_ByXPathList";
        public HtmlLabel BookstoreapiLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbyxpathlist, ORName));


        //LBL_Username

        private const string usernameLabelbyxpath = "LBL_Username_ByXPath";
        public HtmlLabel UsernameLabelByXPath => new HtmlLabel(jHelper.GetOR(usernameLabelbyxpath, ORName));

        private const string usernameLabelbytext = "LBL_Username_ByText";
        public HtmlLabel UsernameLabelByText => new HtmlLabel(jHelper.GetOR(usernameLabelbytext, ORName));

        private const string usernameLabelbycss = "LBL_Username_ByCSS";
        public HtmlLabel UsernameLabelByCSS => new HtmlLabel(jHelper.GetOR(usernameLabelbycss, ORName));

        private const string usernameLabelbyxpathlist = "LBL_Username_ByXPathList";
        public HtmlLabel UsernameLabelByXPathList => new HtmlLabel(jHelper.GetOR(usernameLabelbyxpathlist, ORName));


        //TXT_Username2

        private const string username2Textbyxpath = "TXT_Username2_ByXPath";
        public HtmlText Username2TextByXPath => new HtmlText(jHelper.GetOR(username2Textbyxpath, ORName));

        private const string username2Textbycss = "TXT_Username2_ByCSS";
        public HtmlText Username2TextByCSS => new HtmlText(jHelper.GetOR(username2Textbycss, ORName));


        //LBL_Password

        private const string passwordLabelbyxpath = "LBL_Password_ByXPath";
        public HtmlLabel PasswordLabelByXPath => new HtmlLabel(jHelper.GetOR(passwordLabelbyxpath, ORName));

        private const string passwordLabelbytext = "LBL_Password_ByText";
        public HtmlLabel PasswordLabelByText => new HtmlLabel(jHelper.GetOR(passwordLabelbytext, ORName));

        private const string passwordLabelbycss = "LBL_Password_ByCSS";
        public HtmlLabel PasswordLabelByCSS => new HtmlLabel(jHelper.GetOR(passwordLabelbycss, ORName));

        private const string passwordLabelbyxpathlist = "LBL_Password_ByXPathList";
        public HtmlLabel PasswordLabelByXPathList => new HtmlLabel(jHelper.GetOR(passwordLabelbyxpathlist, ORName));


        //TXT_Password2

        private const string password2Textbyxpath = "TXT_Password2_ByXPath";
        public HtmlText Password2TextByXPath => new HtmlText(jHelper.GetOR(password2Textbyxpath, ORName));

        private const string password2Textbycss = "TXT_Password2_ByCSS";
        public HtmlText Password2TextByCSS => new HtmlText(jHelper.GetOR(password2Textbycss, ORName));


        //BTN_Newuser

        private const string newuserButtonbyxpath = "BTN_Newuser_ByXPath";
        public HtmlButton NewuserButtonByXPath => new HtmlButton(jHelper.GetOR(newuserButtonbyxpath, ORName));

        private const string newuserButtonbytext = "BTN_Newuser_ByText";
        public HtmlButton NewuserButtonByText => new HtmlButton(jHelper.GetOR(newuserButtonbytext, ORName));

        private const string newuserButtonbycss = "BTN_Newuser_ByCSS";
        public HtmlButton NewuserButtonByCSS => new HtmlButton(jHelper.GetOR(newuserButtonbycss, ORName));

        private const string newuserButtonbyxpathlist = "BTN_Newuser_ByXPathList";
        public HtmlButton NewuserButtonByXPathList => new HtmlButton(jHelper.GetOR(newuserButtonbyxpathlist, ORName));


        //BTN_Login3

        private const string login3Buttonbyxpath = "BTN_Login3_ByXPath";
        public HtmlButton Login3ButtonByXPath => new HtmlButton(jHelper.GetOR(login3Buttonbyxpath, ORName));

        private const string login3Buttonbytext = "BTN_Login3_ByText";
        public HtmlButton Login3ButtonByText => new HtmlButton(jHelper.GetOR(login3Buttonbytext, ORName));

        private const string login3Buttonbycss = "BTN_Login3_ByCSS";
        public HtmlButton Login3ButtonByCSS => new HtmlButton(jHelper.GetOR(login3Buttonbycss, ORName));

        private const string login3Buttonbyxpathlist = "BTN_Login3_ByXPathList";
        public HtmlButton Login3ButtonByXPathList => new HtmlButton(jHelper.GetOR(login3Buttonbyxpathlist, ORName));


        //LNK_ReflectRunUtmSource

        private const string reflectrunutmsourceLinkbyxpath = "LNK_ReflectRunUtmSource_ByXPath";
        public HtmlLink ReflectRunUtmSourceLinkByXPath => new HtmlLink(jHelper.GetOR(reflectrunutmsourceLinkbyxpath, ORName));

        private const string reflectrunutmsourceLinkbycss = "LNK_ReflectRunUtmSource_ByCSS";
        public HtmlLink ReflectRunUtmSourceLinkByCSS => new HtmlLink(jHelper.GetOR(reflectrunutmsourceLinkbycss, ORName));


        //BTN_ImagesReflectDemoqaAdx2

        private const string imagesreflectdemoqaadx2Buttonbyxpath = "BTN_ImagesReflectDemoqaAdx2_ByXPath";
        public HtmlButton ImagesReflectDemoqaAdx2ButtonByXPath => new HtmlButton(jHelper.GetOR(imagesreflectdemoqaadx2Buttonbyxpath, ORName));

        private const string imagesreflectdemoqaadx2Buttonbycss = "BTN_ImagesReflectDemoqaAdx2_ByCSS";
        public HtmlButton ImagesReflectDemoqaAdx2ButtonByCSS => new HtmlButton(jHelper.GetOR(imagesreflectdemoqaadx2Buttonbycss, ORName));


        //LBL_20132020Toolsqacom

        private const string toolsqacomLabelbyxpath = "LBL_20132020Toolsqacom_ByXPath";
        public HtmlLabel ToolsqacomLabelByXPath => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbyxpath, ORName));

        private const string toolsqacomLabelbytext = "LBL_20132020Toolsqacom_ByText";
        public HtmlLabel ToolsqacomLabelByText => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbytext, ORName));

        private const string toolsqacomLabelbyxpathlist = "LBL_20132020Toolsqacom_ByXPathList";
        public HtmlLabel ToolsqacomLabelByXPathList => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbyxpathlist, ORName));
    }
}

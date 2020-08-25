using TechTalk.SpecFlow;
using OpenQA.Selenium;
using WTW.TestAutomation.Common.Helpers.UI_Helpers;
using WTW.TestAutomation.Common.Helpers.Files;
using WTW.TestAutomation.GPD.Pages.Pages_Data;
using WTW.TestAutomation.GPD.Pages.Pages_UI;

namespace WTW.TestAutomation.MyProjectName.StepDefinitions.StepDefinitions_UI
{
    [Binding]
    public class ToolsqaSteps : UIFramework
    {
        readonly ToolsqaPage toolsqaPage;

        public ToolsqaSteps(IWebDriver driver)
        {
            {
                UIController.Instance.Driver = driver;
                toolsqaPage = Page<ToolsqaPage>();
            }
        }
        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void ClickDemoqaComLink()
        {
            ToolsqaPage.DemoqaComLinkByXPath.Click();
        }

        public void ClickImagesToolsqaJpgButton()
        {
            ToolsqaPage.ImagesToolsqaJpgButtonByXPath.Click();
        }

        public void VerifyElementTextLoginLabel()
        {
            ToolsqaPage.LoginLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextElementsLabel()
        {
            ToolsqaPage.ElementsLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextElements2Label()
        {
            ToolsqaPage.Elements2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextFormsLabel()
        {
            ToolsqaPage.FormsLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextForms2Label()
        {
            ToolsqaPage.Forms2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextAlertsframeWindowsLabel()
        {
            ToolsqaPage.AlertsframeWindowsLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextAlertsframeWindows2Label()
        {
            ToolsqaPage.AlertsframeWindows2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextWidgetsLabel()
        {
            ToolsqaPage.WidgetsLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextWidgets2Label()
        {
            ToolsqaPage.Widgets2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextInteractionsLabel()
        {
            ToolsqaPage.InteractionsLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextInteractions2Label()
        {
            ToolsqaPage.Interactions2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextBookstoreapplicationLabel()
        {
            ToolsqaPage.BookstoreapplicationLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextBookstoreapplication2Label()
        {
            ToolsqaPage.Bookstoreapplication2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextLogin2Label()
        {
            ToolsqaPage.Login2LabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextBookstoreLabel()
        {
            ToolsqaPage.BookstoreLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextProfileLabel()
        {
            ToolsqaPage.ProfileLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextEmptyVariableNameLabel()
        {
            ToolsqaPage.EmptyVariableNameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextBookstoreapiLabel()
        {
            ToolsqaPage.BookstoreapiLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void VerifyElementTextUsernameLabel()
        {
            ToolsqaPage.UsernameLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void SetTextUsername2Text()
        {
            ToolsqaPage.Username2TextByXPath.SetText(pageDataObject.TestData);
        }

        public void VerifyElementTextPasswordLabel()
        {
            ToolsqaPage.PasswordLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }

        public void SetTextPassword2Text()
        {
            ToolsqaPage.Password2TextByXPath.SetText(pageDataObject.TestData);
        }

        public void ClickNewuserButton()
        {
            ToolsqaPage.NewuserButtonByXPath.Click();
        }

        public void ClickLogin3Button()
        {
            ToolsqaPage.Login3ButtonByXPath.Click();
        }

        public void ClickReflectRunUtmSourceLink()
        {
            ToolsqaPage.ReflectRunUtmSourceLinkByXPath.Click();
        }

        public void ClickImagesReflectDemoqaAdx2Button()
        {
            ToolsqaPage.ImagesReflectDemoqaAdx2ButtonByXPath.Click();
        }

        public void VerifyElementTextToolsqacomLabel()
        {
            ToolsqaPage.ToolsqacomLabelByXPath.VerifyElementText(pageDataObject.TestData);
        }
    }
}

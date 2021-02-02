// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UserInfoErrorsFeature : Xunit.IClassFixture<UserInfoErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserInfoErrors.feature"
#line hidden
        
        public UserInfoErrorsFeature(UserInfoErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserInfoErrors", "\tCheck the errors returned by the UserInfo endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP GET)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPGET()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP GET)", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table220 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table220, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP POST + FORMURLENCODED)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP POST + FORMURLENCODED)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPPOSTFORMURLENCODED()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP POST + FORMURLENCODED)", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table221 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 14
 testRunner.When("execute HTTP POST request \'http://localhost/userinfo\'", ((string)(null)), table221, "When ");
#line 17
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP POST + JSON)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP POST + JSON)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPPOSTJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP POST + JSON)", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table222 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 23
 testRunner.When("execute HTTP POST JSON request \'http://localhost/userinfo\'", ((string)(null)), table222, "When ");
#line 26
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'error_description\'=\'the content-type is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is incorrect")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is incorrect")]
        public virtual void ErrorIsReturnedWhenTokenIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is incorrect", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table223 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table223.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst tst"});
#line 32
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table223, "When ");
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is not well formatted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is not well formatted")]
        public virtual void ErrorIsReturnedWhenTokenIsNotWellFormatted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is not well formatted", null, ((string[])(null)));
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table224 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table224.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst"});
#line 42
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table224, "When ");
#line 46
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("JSON \'error\'=\'invalid_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.Then("JSON \'error_description\'=\'bad token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the user is unknown")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the user is unknown")]
        public virtual void ErrorIsReturnedWhenTheUserIsUnknown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the user is unknown", null, ((string[])(null)));
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table225 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table225.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table225.AddRow(new string[] {
                        "scope",
                        "email"});
#line 52
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table225, "When ");
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table226 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table226.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 60
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table226, "And ");
#line hidden
            TechTalk.SpecFlow.Table table227 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table227.AddRow(new string[] {
                        "sub",
                        "unknown"});
            table227.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 64
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table227, "And ");
#line hidden
            TechTalk.SpecFlow.Table table228 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table228.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 69
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table228, "And ");
#line 73
 testRunner.Then("HTTP status code equals to \'401\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when there is not valid audience in the token")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when there is not valid audience in the token")]
        public virtual void ErrorIsReturnedWhenThereIsNotValidAudienceInTheToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when there is not valid audience in the token", null, ((string[])(null)));
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table229 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table229.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table229.AddRow(new string[] {
                        "scope",
                        "email"});
#line 76
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table229, "When ");
#line 81
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table230 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table230.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 84
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table230, "And ");
#line hidden
            TechTalk.SpecFlow.Table table231 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table231.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table231.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 88
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table231, "And ");
#line hidden
            TechTalk.SpecFlow.Table table232 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table232.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 93
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table232, "And ");
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("JSON \'error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("JSON \'error_description\'=\'invalid audiences\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when no consent has been accepted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when no consent has been accepted")]
        public virtual void ErrorIsReturnedWhenNoConsentHasBeenAccepted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when no consent has been accepted", null, ((string[])(null)));
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table233 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table233.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table233.AddRow(new string[] {
                        "scope",
                        "email"});
#line 104
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table233, "When ");
#line 109
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table234 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table234.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 112
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table234, "And ");
#line hidden
            TechTalk.SpecFlow.Table table235 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table235.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table235.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table235.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 116
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table235, "And ");
#line hidden
            TechTalk.SpecFlow.Table table236 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table236.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 122
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table236, "And ");
#line 126
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("JSON \'error_description\'=\'no consent has been accepted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UserInfoErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UserInfoErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

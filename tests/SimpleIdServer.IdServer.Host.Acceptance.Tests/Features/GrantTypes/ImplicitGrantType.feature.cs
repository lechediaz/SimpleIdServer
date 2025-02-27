﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ImplicitGrantTypeFeature : object, Xunit.IClassFixture<ImplicitGrantTypeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ImplicitGrantType.feature"
#line hidden
        
        public ImplicitGrantTypeFeature(ImplicitGrantTypeFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "ImplicitGrantType", "\tCheck all the alternatives scenarios in implicit grant-type (RFC : https://www.r" +
                    "fc-editor.org/rfc/rfc8707.html#name-access-token-request)", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="No access token is issued then resulting claims are returned in the ID Token")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "No access token is issued then resulting claims are returned in the ID Token")]
        public void NoAccessTokenIsIssuedThenResultingClaimsAreReturnedInTheIDToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No access token is issued then resulting claims are returned in the ID Token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table325 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table325.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table325.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table325.AddRow(new string[] {
                            "state",
                            "state"});
                table325.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table325.AddRow(new string[] {
                            "scope",
                            "openid email role address"});
                table325.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table325.AddRow(new string[] {
                            "nonce",
                            "nonce"});
#line 6
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table325, "When ");
#line hidden
#line 16
 testRunner.And("extract parameter \'id_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("extract payload from JWT \'$id_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("redirection url doesn\'t contain the parameter \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.Then("JWT contains \'iss\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then("JWT contains \'iat\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("JWT contains \'exp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JWT contains \'azp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.Then("JWT contains \'aud\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Then("JWT has \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("JWT has \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then("JWT has \'role\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("JWT has \'role\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("JWT has \'nonce\'=\'nonce\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("JWT has address street \'street\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Then("JWT has address locality \'locality\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.Then("JWT has address region \'region\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.Then("JWT has address postal code \'postalcode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Then("JWT has address country \'country\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.Then("JWT has formatted address \'formatted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Display parameter is passed in the redirection url")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "Display parameter is passed in the redirection url")]
        public void DisplayParameterIsPassedInTheRedirectionUrl()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display parameter is passed in the redirection url", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table326 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table326.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table326.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table326.AddRow(new string[] {
                            "state",
                            "state"});
                table326.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table326.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table326.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table326.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table326.AddRow(new string[] {
                            "display",
                            "popup"});
#line 39
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table326, "When ");
#line hidden
#line 50
 testRunner.Then("redirection url contains the parameter value \'display\'=\'popup\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
            "n when resource parameter is specified with no scope")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
            "n when resource parameter is specified with no scope")]
        public void ScopesAdminAndCalendarAndValidAudiencesAreReturnedInTheAccessTokenWhenResourceParameterIsSpecifiedWithNoScope()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
                    "n when resource parameter is specified with no scope", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 52
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 53
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table327 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table327.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table327.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table327.AddRow(new string[] {
                            "state",
                            "state"});
                table327.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table327.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table327.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table327.AddRow(new string[] {
                            "claims",
                            "{ \"id_token\": { \"acr\": { \"essential\" : true, \"value\": \"urn:openbanking:psd2:ca\" }" +
                                " } }"});
                table327.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table327.AddRow(new string[] {
                            "resource",
                            "https://contacts.example.com"});
#line 55
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table327, "When ");
#line hidden
#line 67
 testRunner.And("extract parameter \'access_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("extract payload from JWT \'$access_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("JWT has \'aud\'=\'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("JWT has \'aud\'=\'https://contacts.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.Then("JWT has \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.Then("JWT has \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization details are returned in the access token")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "authorization details are returned in the access token")]
        public void AuthorizationDetailsAreReturnedInTheAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization details are returned in the access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 76
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table328 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table328.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table328.AddRow(new string[] {
                            "client_id",
                            "fiftyFiveClient"});
                table328.AddRow(new string[] {
                            "state",
                            "state"});
                table328.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table328.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table328.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table328.AddRow(new string[] {
                            "authorization_details",
                            "{ \"type\" : \"firstDetails\", \"actions\": [ \"read\" ] }"});
#line 78
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table328, "When ");
#line hidden
#line 88
 testRunner.And("extract parameter \'access_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("extract payload from JWT \'$access_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("JWT has authorization_details type \'firstDetails\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.Then("JWT has authorization_details action \'read\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Roles coming from group are returned")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "Roles coming from group are returned")]
        public void RolesComingFromGroupAreReturned()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Roles coming from group are returned", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 94
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 95
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table329 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table329.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table329.AddRow(new string[] {
                            "client_id",
                            "fiftySixClient"});
                table329.AddRow(new string[] {
                            "state",
                            "state"});
                table329.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table329.AddRow(new string[] {
                            "scope",
                            "openid role"});
                table329.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table329.AddRow(new string[] {
                            "nonce",
                            "nonce"});
#line 96
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table329, "When ");
#line hidden
#line 106
 testRunner.And("extract parameter \'id_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.And("extract payload from JWT \'$id_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.Then("redirection url doesn\'t contain the parameter \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.Then("JWT contains \'iss\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.Then("JWT contains \'iat\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 112
 testRunner.Then("JWT contains \'exp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.Then("JWT contains \'azp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 114
 testRunner.Then("JWT contains \'aud\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.Then("JWT has \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Then("JWT has \'role\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.Then("JWT has \'role\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.Then("JWT has \'role\'=\'fiftySixClient/admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ImplicitGrantTypeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ImplicitGrantTypeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

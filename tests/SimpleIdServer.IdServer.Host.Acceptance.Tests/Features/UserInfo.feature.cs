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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UserInfoFeature : object, Xunit.IClassFixture<UserInfoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserInfo.feature"
#line hidden
        
        public UserInfoFeature(UserInfoFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UserInfo", "\tCheck the userinfo endpoint", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Claims are returned in JSON format (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Claims are returned in JSON format (HTTP GET)")]
        public void ClaimsAreReturnedInJSONFormatHTTPGET()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claims are returned in JSON format (HTTP GET)", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table547 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table547.AddRow(new string[] {
                            "response_type",
                            "code"});
                table547.AddRow(new string[] {
                            "client_id",
                            "thirtySevenClient"});
                table547.AddRow(new string[] {
                            "state",
                            "state"});
                table547.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table547.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table547.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table547.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table547.AddRow(new string[] {
                            "display",
                            "popup"});
#line 6
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table547, "When ");
#line hidden
#line 17
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table548 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table548.AddRow(new string[] {
                            "client_id",
                            "thirtySevenClient"});
                table548.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table548.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table548.AddRow(new string[] {
                            "code",
                            "$code$"});
                table548.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 19
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table548, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table549 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table549.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 30
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table549, "And ");
#line hidden
#line 34
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.Then("JSON \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Then("JSON \'$.role[0]\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("JSON \'$.role[1]\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.Then("JSON \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Claims are returned in JSON format (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Claims are returned in JSON format (HTTP POST)")]
        public void ClaimsAreReturnedInJSONFormatHTTPPOST()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claims are returned in JSON format (HTTP POST)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table550 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table550.AddRow(new string[] {
                            "response_type",
                            "code"});
                table550.AddRow(new string[] {
                            "client_id",
                            "thirtySevenClient"});
                table550.AddRow(new string[] {
                            "state",
                            "state"});
                table550.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table550.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table550.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table550.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table550.AddRow(new string[] {
                            "display",
                            "popup"});
#line 45
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table550, "When ");
#line hidden
#line 56
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table551 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table551.AddRow(new string[] {
                            "client_id",
                            "thirtySevenClient"});
                table551.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table551.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table551.AddRow(new string[] {
                            "code",
                            "$code$"});
                table551.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 58
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table551, "And ");
#line hidden
#line 66
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table552 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table552.AddRow(new string[] {
                            "access_token",
                            "$access_token$"});
#line 69
 testRunner.And("execute HTTP POST request \'http://localhost/userinfo\'", ((string)(null)), table552, "And ");
#line hidden
#line 73
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.Then("JSON \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.Then("JSON \'$.role[0]\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.Then("JSON \'$.role[1]\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.Then("JSON \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Claims are returned in JWS token")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Claims are returned in JWS token")]
        public void ClaimsAreReturnedInJWSToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claims are returned in JWS token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 82
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 83
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table553 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table553.AddRow(new string[] {
                            "response_type",
                            "code"});
                table553.AddRow(new string[] {
                            "client_id",
                            "thirtyEightClient"});
                table553.AddRow(new string[] {
                            "state",
                            "state"});
                table553.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table553.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table553.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table553.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table553.AddRow(new string[] {
                            "display",
                            "popup"});
#line 84
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table553, "When ");
#line hidden
#line 95
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table554 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table554.AddRow(new string[] {
                            "client_id",
                            "thirtyEightClient"});
                table554.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table554.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table554.AddRow(new string[] {
                            "code",
                            "$code$"});
                table554.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 97
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table554, "And ");
#line hidden
#line 105
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table555 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table555.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 108
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table555, "And ");
#line hidden
#line 112
 testRunner.And("extract payload from HTTP body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/jwt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Then("JWT alg = \'RS256\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.Then("JWT has \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.Then("JWT has \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.Then("JWT has \'role\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 120
 testRunner.Then("JWT has \'role\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Claims are returned in JWE token")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Claims are returned in JWE token")]
        public void ClaimsAreReturnedInJWEToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claims are returned in JWE token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 122
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 123
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table556 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table556.AddRow(new string[] {
                            "response_type",
                            "code"});
                table556.AddRow(new string[] {
                            "client_id",
                            "thirtyNineClient"});
                table556.AddRow(new string[] {
                            "state",
                            "state"});
                table556.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table556.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table556.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table556.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table556.AddRow(new string[] {
                            "display",
                            "popup"});
#line 124
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table556, "When ");
#line hidden
#line 135
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table557 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table557.AddRow(new string[] {
                            "client_id",
                            "thirtyNineClient"});
                table557.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table557.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table557.AddRow(new string[] {
                            "code",
                            "$code$"});
                table557.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 137
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table557, "And ");
#line hidden
#line 145
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table558 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table558.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 148
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table558, "And ");
#line hidden
#line 152
 testRunner.And("extract payload from HTTP body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 155
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/jwt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 156
 testRunner.Then("JWT is encrypted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 157
 testRunner.Then("JWT alg = \'RSA1_5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 158
 testRunner.Then("JWT enc = \'A128CBC-HS256\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Essential claims \'name\' and \'email\' are returned by the userinfo endpoint")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Essential claims \'name\' and \'email\' are returned by the userinfo endpoint")]
        public void EssentialClaimsNameAndEmailAreReturnedByTheUserinfoEndpoint()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Essential claims \'name\' and \'email\' are returned by the userinfo endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 160
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 161
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table559 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table559.AddRow(new string[] {
                            "response_type",
                            "code"});
                table559.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table559.AddRow(new string[] {
                            "state",
                            "state"});
                table559.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table559.AddRow(new string[] {
                            "scope",
                            "openid"});
                table559.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table559.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table559.AddRow(new string[] {
                            "display",
                            "popup"});
                table559.AddRow(new string[] {
                            "claims",
                            "{ \"userinfo\" : { \"name\":  { \"essential\": true } , \"email\" : { \"essential\" : true " +
                                "} } }"});
#line 162
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table559, "When ");
#line hidden
#line 174
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table560 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table560.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table560.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table560.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table560.AddRow(new string[] {
                            "code",
                            "$code$"});
                table560.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 176
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table560, "And ");
#line hidden
#line 184
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 185
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table561 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table561.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 187
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table561, "And ");
#line hidden
#line 191
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 193
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 194
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 195
 testRunner.Then("JSON \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 196
 testRunner.Then("JSON \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Claims are returned in JSON format (HTTP GET & Reference Access token)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Claims are returned in JSON format (HTTP GET & Reference Access token)")]
        public void ClaimsAreReturnedInJSONFormatHTTPGETReferenceAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claims are returned in JSON format (HTTP GET & Reference Access token)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 199
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 200
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table562 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table562.AddRow(new string[] {
                            "response_type",
                            "code"});
                table562.AddRow(new string[] {
                            "client_id",
                            "seventyClient"});
                table562.AddRow(new string[] {
                            "state",
                            "state"});
                table562.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table562.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table562.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table562.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table562.AddRow(new string[] {
                            "display",
                            "popup"});
#line 201
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table562, "When ");
#line hidden
#line 212
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table563 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table563.AddRow(new string[] {
                            "client_id",
                            "seventyClient"});
                table563.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table563.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table563.AddRow(new string[] {
                            "code",
                            "$code$"});
                table563.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 214
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table563, "And ");
#line hidden
#line 222
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 223
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table564 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table564.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 225
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table564, "And ");
#line hidden
#line 229
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 231
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 232
 testRunner.Then("HTTP header has \'Content-Type\'=\'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 233
 testRunner.Then("JSON \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 234
 testRunner.Then("JSON \'$.role[0]\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 235
 testRunner.Then("JSON \'$.role[1]\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 236
 testRunner.Then("JSON \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UserInfoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UserInfoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

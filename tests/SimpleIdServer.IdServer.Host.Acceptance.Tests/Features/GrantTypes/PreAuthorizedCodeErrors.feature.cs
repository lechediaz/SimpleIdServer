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
    public partial class PreAuthorizedCodeErrorsFeature : object, Xunit.IClassFixture<PreAuthorizedCodeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PreAuthorizedCodeErrors.feature"
#line hidden
        
        public PreAuthorizedCodeErrorsFeature(PreAuthorizedCodeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "PreAuthorizedCodeErrors", "\tCheck errors returned when using \'urn:ietf:params:oauth:grant-type:pre-authorize" +
                    "d_code\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="client_id is required")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client_id is required")]
        public void Client_IdIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client_id is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table301 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table301.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table301, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="client must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client must exists")]
        public void ClientMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table302 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table302.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table302.AddRow(new string[] {
                            "client_id",
                            "invalid"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table302, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'unknown client invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="client must supports the grant-type")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client must supports the grant-type")]
        public void ClientMustSupportsTheGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client must supports the grant-type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table303 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table303.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table303.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table303, "When ");
#line hidden
#line 31
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("JSON \'$.error_description\'=\'grant type urn:ietf:params:oauth:grant-type:pre-autho" +
                        "rized_code is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="pre-authorized code is required")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "pre-authorized code is required")]
        public void Pre_AuthorizedCodeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("pre-authorized code is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table304 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table304.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table304.AddRow(new string[] {
                            "client_id",
                            "fiftyNineClient"});
#line 37
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table304, "When ");
#line hidden
#line 42
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("JSON \'$.error_description\'=\'missing parameter pre-authorized_code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="when user_pin is true then pin is required")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "when user_pin is true then pin is required")]
        public void WhenUser_PinIsTrueThenPinIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("when user_pin is true then pin is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table305 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table305.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table305.AddRow(new string[] {
                            "client_id",
                            "sixtyClient"});
                table305.AddRow(new string[] {
                            "pre-authorized_code",
                            "code"});
#line 48
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table305, "When ");
#line hidden
#line 54
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("JSON \'$.error_description\'=\'missing parameter user_pin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="pre-authorized must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "pre-authorized must exists")]
        public void Pre_AuthorizedMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("pre-authorized must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table306 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table306.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table306.AddRow(new string[] {
                            "client_id",
                            "fiftyNineClient"});
                table306.AddRow(new string[] {
                            "pre-authorized_code",
                            "code"});
#line 60
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table306, "When ");
#line hidden
#line 66
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("JSON \'$.error_description\'=\'either the pre-authorized code has expired or is inva" +
                        "lid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="format is required in the authorization_details")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "format is required in the authorization_details")]
        public void FormatIsRequiredInTheAuthorization_Details()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("format is required in the authorization_details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 71
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 72
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table307 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table307.AddRow(new string[] {
                            "wallet_client_id",
                            "fiftyNineClient"});
                table307.AddRow(new string[] {
                            "credential_template_id",
                            "credTemplate"});
#line 74
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer/share\'", ((string)(null)), table307, "When ");
#line hidden
#line 79
 testRunner.And("extract query parameters into JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And("extract query parameter \'credential_offer\' into JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("extract parameter \'$.grants.urn:ietf:params:oauth:grant-type:pre-authorized_code." +
                        "pre-authorized_code\' from JSON body into \'preAuthorizedCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table308 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table308.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table308.AddRow(new string[] {
                            "client_id",
                            "fiftyNineClient"});
                table308.AddRow(new string[] {
                            "pre-authorized_code",
                            "$preAuthorizedCode$"});
                table308.AddRow(new string[] {
                            "authorization_details",
                            "{ \"type\" : \"openid_credential\" }"});
#line 83
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table308, "And ");
#line hidden
#line 90
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("JSON \'$.error_description\'=\'the authorization_details must contain a format\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="format must be supported in the authorization_details")]
        [Xunit.TraitAttribute("FeatureTitle", "PreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "format must be supported in the authorization_details")]
        public void FormatMustBeSupportedInTheAuthorization_Details()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("format must be supported in the authorization_details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 95
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 96
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table309 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table309.AddRow(new string[] {
                            "wallet_client_id",
                            "fiftyNineClient"});
                table309.AddRow(new string[] {
                            "credential_template_id",
                            "credTemplate"});
#line 98
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer/share\'", ((string)(null)), table309, "When ");
#line hidden
#line 103
 testRunner.And("extract query parameters into JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("extract query parameter \'credential_offer\' into JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And("extract parameter \'$.grants.urn:ietf:params:oauth:grant-type:pre-authorized_code." +
                        "pre-authorized_code\' from JSON body into \'preAuthorizedCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table310 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table310.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:pre-authorized_code"});
                table310.AddRow(new string[] {
                            "client_id",
                            "fiftyNineClient"});
                table310.AddRow(new string[] {
                            "pre-authorized_code",
                            "$preAuthorizedCode$"});
                table310.AddRow(new string[] {
                            "authorization_details",
                            "{ \"type\" : \"openid_credential\", \"format\" : \"invalid\" }"});
#line 107
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table310, "And ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("JSON \'$.error_description\'=\'credential formats invalid are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                PreAuthorizedCodeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PreAuthorizedCodeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

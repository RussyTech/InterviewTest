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
namespace InterviewProjectTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register")]
    public partial class RegisterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Register", "Test the register endpoint to ensure that user can successfully register", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with invalid password")]
        [NUnit.Framework.TestCaseAttribute("User creation failed! Passwords must have at least one non alphanumeric character" +
            ".  Passwords must have at least one digit (\'0\'-\'9\').", null)]
        public void RegisterWithInvalidPassword(string errMsg, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ErrMsg", errMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with invalid password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table3.AddRow(new string[] {
                            "Tester1",
                            "Tester1@example.com",
                            "Tester"});
#line 7
 testRunner.Given("I perform a POST request to the \"/Authenticate/register\" endpoint with Table", ((string)(null)), table3, "Given ");
#line hidden
#line 10
 testRunner.Then("a \"500\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", errMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with No alphanumeric characters for password")]
        [NUnit.Framework.TestCaseAttribute("User creation failed! Passwords must have at least one non alphanumeric character" +
            ".", null)]
        public void RegisterWithNoAlphanumericCharactersForPassword(string errMsg, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ErrMsg", errMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with No alphanumeric characters for password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table4.AddRow(new string[] {
                            "Tester1",
                            "Tester1@example.com",
                            "Tester101"});
#line 19
 testRunner.Given("I perform a POST request to the \"/Authenticate/register\" endpoint with Table", ((string)(null)), table4, "Given ");
#line hidden
#line 22
 testRunner.Then("a \"500\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", errMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully register")]
        [NUnit.Framework.TestCaseAttribute("User created successfully!", "User deleted successfully!", null)]
        public void SuccessfullyRegister(string successMsg, string deleteSuccessMsg, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("SuccessMsg", successMsg);
            argumentsOfScenario.Add("DeleteSuccessMsg", deleteSuccessMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully register", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table5.AddRow(new string[] {
                            "Tester1",
                            "Tester1@example.com",
                            "Tester101."});
#line 32
 testRunner.Given("I perform a POST request to the \"/Authenticate/register\" endpoint with Table", ((string)(null)), table5, "Given ");
#line hidden
#line 35
 testRunner.Then("a \"200\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", successMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName"});
                table6.AddRow(new string[] {
                            "Tester1"});
#line 37
 testRunner.Then("I peform a POST request to the \"/Authenticate/delete\" endpoint to delete newly cr" +
                        "eated user", ((string)(null)), table6, "Then ");
#line hidden
#line 40
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", deleteSuccessMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register Admin user with invalid password")]
        [NUnit.Framework.TestCaseAttribute("User creation failed! Please check user details and try again.", null)]
        public void RegisterAdminUserWithInvalidPassword(string errMsg, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ErrMsg", errMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register Admin user with invalid password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table7.AddRow(new string[] {
                            "Tester1",
                            "Tester1@example.com",
                            "Tester"});
#line 47
 testRunner.Given("I perform a POST request to the \"/Authenticate/register\" endpoint with Table", ((string)(null)), table7, "Given ");
#line hidden
#line 50
 testRunner.Then("a \"500\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", errMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully register Admin user")]
        [NUnit.Framework.TestCaseAttribute("User created successfully!", "User deleted successfully!", null)]
        public void SuccessfullyRegisterAdminUser(string successMsg, string deleteSuccessMsg, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("SuccessMsg", successMsg);
            argumentsOfScenario.Add("DeleteSuccessMsg", deleteSuccessMsg);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully register Admin user", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 57
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table8.AddRow(new string[] {
                            "Tester2Admin",
                            "TesterAdmin@example.com",
                            "Tester101."});
#line 59
 testRunner.Given("I perform a POST request to the \"/Authenticate/register-admin\" endpoint with Tabl" +
                        "e", ((string)(null)), table8, "Given ");
#line hidden
#line 62
 testRunner.Then("a \"200\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", successMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName"});
                table9.AddRow(new string[] {
                            "Tester1"});
#line 64
 testRunner.Then("I peform a POST request to the \"/Authenticate/delete\" endpoint to delete newly cr" +
                        "eated user", ((string)(null)), table9, "Then ");
#line hidden
#line 67
 testRunner.And(string.Format("I confirm the \"message\" field is \"{0}\"", deleteSuccessMsg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with invalid email")]
        public void RegisterWithInvalidEmail()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with invalid email", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "UserName",
                            "Email",
                            "Password"});
                table10.AddRow(new string[] {
                            "Tester1",
                            "Tester1example.com",
                            "Tester101"});
#line 75
 testRunner.Given("I perform a POST request to the \"/Authenticate/register\" endpoint with Table", ((string)(null)), table10, "Given ");
#line hidden
#line 78
 testRunner.Then("a \"400\" response is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

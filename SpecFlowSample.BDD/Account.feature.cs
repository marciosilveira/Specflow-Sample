﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowSample.BDD
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TestarAsOperacoesBasicasDeContaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Account.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Testar as operacoes basicas de conta", @"	O sistema deve prover o saque e deposito na conta de forma correta.
	Seguindo as seguintes restrições:
	1) Só libera o saque, se o valor do saque for menor ou igual ao valor 
		do saldo disponível na conta
	2) Só libera o deposito, se o valor do deposito for menor ou igual ao 
		valor do limite disponível na conta", ProgrammingLanguage.CSharp, new string[] {
                        "ContaTeste"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Testar as operacoes basicas de conta")))
            {
                global::SpecFlowSample.BDD.TestarAsOperacoesBasicasDeContaFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void TestarSaqueEDeposito(string dono, string numero, string limite, string saldo, string deposito, string primeiro_Saque, string segundo_Saque, string saldo_Esperado, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Testar saque e deposito", exampleTags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
    testRunner.Given(string.Format("a conta criada para o dono \"{0}\" de numero {1} com o limite {2} e saldo {3}", dono, numero, limite, saldo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 12
    testRunner.When(string.Format("o dono realiza o deposito no valor de {0} na conta", deposito), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 13
    testRunner.And(string.Format("o dono realiza o primeiro saque no valor de {0} na conta", primeiro_Saque), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
    testRunner.And(string.Format("o dono realiza o segundo saque no valor de {0} na conta", segundo_Saque), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
    testRunner.Then(string.Format("o dono tem o saldo no valor de {0} na conta", saldo_Esperado), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Testar saque e deposito: Brendo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Testar as operacoes basicas de conta")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ContaTeste")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Brendo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dono", "Brendo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:numero", "111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:limite", "1000")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:saldo", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:deposito", "100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:primeiro_saque", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:segundo_saque", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:saldo_esperado", "80")]
        public virtual void TestarSaqueEDeposito_Brendo()
        {
#line 10
this.TestarSaqueEDeposito("Brendo", "111", "1000", "0", "100", "10", "10", "80", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Testar saque e deposito: Hiago")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Testar as operacoes basicas de conta")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ContaTeste")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Hiago")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dono", "Hiago")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:numero", "222")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:limite", "1000")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:saldo", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:deposito", "200")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:primeiro_saque", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:segundo_saque", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:saldo_esperado", "180")]
        public virtual void TestarSaqueEDeposito_Hiago()
        {
#line 10
this.TestarSaqueEDeposito("Hiago", "222", "1000", "0", "200", "10", "10", "180", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion

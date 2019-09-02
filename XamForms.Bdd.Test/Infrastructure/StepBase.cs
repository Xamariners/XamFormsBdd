using System.Linq;
using TechTalk.SpecFlow;
using XamForms.Bdd.ViewModels;

namespace XamForms.Bdd.Test.Infrastructure
{
    public class StepBase
    {
        protected readonly ScenarioContext ScenarioContext;

        public StepBase(ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
        }

        public TViewModel GetCurrentViewModel<TViewModel>() where TViewModel : class
        {
            return SetupHooks.Application?.MainPage?.Navigation?.NavigationStack?
                    .LastOrDefault()?.BindingContext as TViewModel;
        }
    }
}

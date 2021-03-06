using System;
using NSubstitute;
using Specify.Configuration;

namespace Specify.Tests.Configuration
{
    internal class TestableTestRunner : TestRunner
    {
        private readonly IScenario _specification;

        public  TestableTestRunner(IScenario specification)
            : base(new StubConfig(), Substitute.For<IApplicationContainer>(),
            Substitute.For<ITestEngine>())
        {
            _specification = specification;
            ChildContainer = Substitute.For<IScenarioContainer>();
            this.ApplicationContainer
                .CreateChildContainer()
                .Returns(ChildContainer);
            ChildContainer
                .Resolve(Arg.Any<Type>())
                .Returns(_specification);
        }

        public IScenarioContainer ChildContainer;
    }
}
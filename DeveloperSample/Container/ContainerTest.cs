using Xunit;

namespace DeveloperSample.Container
{
    public interface IContainerTestInterface
    {
    }

    internal class ContainerTestClass : IContainerTestInterface
    {
    }

    public class ContainerTest
    {
        [Fact]
        public void CanBindAndGetService()
        {
            var container = new Container();
            container.Bind(typeof(IContainerTestInterface), typeof(ContainerTestClass));
            var testInstance = container.Get<ContainerTestClass>();
            Assert.IsType<ContainerTestClass>(testInstance);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace Teste_Software_2024_Carvalho_Pedro
{
    public interface ISomeInterface
    {
        Task DoSomethingAsync();
    }

    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public async Task MyAsyncTest()
        {
            var mock = new Mock<ISomeInterface>();

            // Incorrect setup
            //mock.Setup(arg => arg.DoSomethingAsync()).Callback(() => { /* some code */ });

            // Correct setup
            mock.Setup(arg => arg.DoSomethingAsync()).Returns(Task.CompletedTask);

            // Execute code
            await mock.Object.DoSomethingAsync();
        }
    }
}

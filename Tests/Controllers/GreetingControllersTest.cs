using Xunit;
using AHello.Controllers;
using AHello;

namespace Tests.Controllers {
    public class ScaryControllerTest {

        ScaryController controller; 

        public ScaryControllerTest() {
            controller = new ScaryController(null);
        }

        [Fact]
        public void Get_success() {
            Greeting greeting = controller.Get();
            Assert.NotNull(greeting);
            Assert.Equal(greeting.greeting, "Hello Scary World!");
        }


    }

    public class SafeControllerTest {

        SafeController controller; 

        public SafeControllerTest() {
            controller = new SafeController(null);
        }

        [Fact]
        public void Get_success() {
            Greeting greeting = controller.Get();
            Assert.NotNull(greeting);
            Assert.Equal(greeting.greeting, "Hello Safe World!");
        }


    }


}
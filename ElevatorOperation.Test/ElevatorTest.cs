using Xunit;
using Bunit;
using ElevatorOperation.WebApp.Components.Pages;

namespace ElevatorOperation.Test
{
    public class ElevatorTest : TestContext
    {
        [Fact]
        public void GetDestinationFloorTest()
        {
            //Arrange
            var cut = RenderComponent<Elevator>();

            // Act
            cut.Instance.GetDestinationFloor(5);

            //Assert
            Assert.True(cut.Instance.DestinationFloorNumber == 5);

            //Act
            cut.Instance.GetDestinationFloor(3);

            //Assert
            Assert.True(cut.Instance.DestinationFloorNumber == 3);
        }


        [Fact]
        public void H5ElementTest()
        {
            //Arrange
            var cut = RenderComponent<Elevator>();

            // Act
            var h5Element = cut.Find("h5");

            // Assert
            h5Element.MarkupMatches("<h5>Left</h5>");
        }
    }
}
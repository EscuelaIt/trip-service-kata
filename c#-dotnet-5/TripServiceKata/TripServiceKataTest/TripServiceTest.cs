using Xunit;
using FluentAssertions;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TripServiceTest
    {
        // Step 1: the easiest test is the one from the not logged in user
        [Fact]
        public void Foo()
        {
            var sut = new TripService();
            true.Should().Be(false);
        }
    }
}

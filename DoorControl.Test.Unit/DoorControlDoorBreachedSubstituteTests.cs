using System.Configuration;
using System.Runtime.InteropServices;
using DoorControl.Test.Unit.Mocks;
using NSubstitute;
using NUnit.Framework;


namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlDoorBreachedSubstituteTests
    {
        private IDoorControlFactory _factory;
        private DoorControl _uut;
        
        [SetUp]
        public void Setup()
        {
            _factory = Substitute.For<IDoorControlFactory>();
            _uut = Substitute.For<DoorControl>();
        }

        [Test]
        public void DoorBreached_DoorStateIsBreached()
        {
            _uut.DoorOpened();  // Breach door
            _uut.Received().DoorOpened();
        }
    }
}
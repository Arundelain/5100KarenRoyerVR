using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLogic;
using CoreLogicTest;
using Xunit;

namespace CoreLogicTest
{
    public class CoreLogicTest
    {
        private ShellGameLogic CreateCoreLogic()
        {
            return new ShellGameLogic();
        }
        [Fact]
        public void FirstTest()
        {
            //Arrange - s ystem u nder t est
            ShellGameLogic sut = CreateCoreLogic();


            //Act
            bool result = sut.CheckForItem(2);

            //Assert
            Assert.True(result);
        }
    }
}

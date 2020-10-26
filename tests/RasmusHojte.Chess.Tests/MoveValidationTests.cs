using RasmusHojte.Chess.RuleEngine;
using System;
using Xunit;

namespace RasmusHojte.Chess.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var moveValidator = new MoveValidator();
            Assert.True(moveValidator.IsMoveValid());
        }
    }
}

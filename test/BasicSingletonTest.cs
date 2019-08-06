using System;
using FluentAssertions;
using SingletonDesignPattern;
using Xunit;

namespace test
{
    public class BasicSingletonTest
    {
        [Fact]
        public void ShouldCreateInstance()
        {
            var instance = BasicSingleton.GetInstance();

            instance.Should().NotBeNull();
            instance.Should().BeOfType<BasicSingleton>();
        }

        [Fact]
        public void ShouldCReturnTheSameInstance()
        {
            var instance1 = BasicSingleton.GetInstance();
            var instance2 = BasicSingleton.GetInstance();

            instance1.Should().BeSameAs(instance2);
        }
    }
}

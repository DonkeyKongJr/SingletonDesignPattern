using System;
using FluentAssertions;
using SingletonDesignPattern;
using Xunit;

namespace test
{
    public class ThreadSafeSingletonTest
    {
        [Fact]
        public void ShouldCreateInstance()
        {
            var instance = ThreadSafeSingleton.GetInstance();

            instance.Should().NotBeNull();
            instance.Should().BeOfType<ThreadSafeSingleton>();
        }

        [Fact]
        public void ShouldCReturnTheSameInstance()
        {
            var instance1 = ThreadSafeSingleton.GetInstance();
            var instance2 = ThreadSafeSingleton.GetInstance();

            instance1.Should().BeSameAs(instance2);
        }
    }
}

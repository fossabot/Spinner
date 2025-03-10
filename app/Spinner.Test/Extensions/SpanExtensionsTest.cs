﻿using System;
using Xunit;
using Spinner.Extencions;

namespace Spinner.Test.Extensions
{
    public class SpanExtensionsTest
    {
        [Theory]
        [InlineData("Spinner", "***Spinner", 10)]
        [InlineData("Spinner", "********Spinner", 15)]
        [InlineData("Spinner", "Spinner", 7)]
        public void Should_PadLeft(string value, string expected, ushort numberOfPad)
        {
            // Arrenge
            ReadOnlySpan<char> array = value.AsSpan();

            // Act
            var result = array.PadLeft(numberOfPad, '*');

            //Assert
            Assert.Equal(numberOfPad, result.Length);
            Assert.Equal(expected, result.ToString());
        }

        [Theory]
        [InlineData("Spinner", "Spinner***", 10)]
        [InlineData("Spinner", "Spinner********", 15)]
        [InlineData("Spinner", "Spinner", 7)]
        public void Should_PadRight(string value, string expected, ushort numberOfPad)
        {
            // Arrenge
            ReadOnlySpan<char> array = value.AsSpan();

            // Act
            var result = array.PadRight(numberOfPad, '*');

            //Assert
            Assert.Equal(numberOfPad, result.Length);
            Assert.Equal(expected, result.ToString());
        }
    }
}

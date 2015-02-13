﻿using NUnit.Framework;

namespace Amp.LocalizationTool.Tests
{
    [TestFixture]
    public class ResxResourceFileHandlerFixture
    {
        [Test]
        public void Ctor_WithFile_CorrectlyInitialized()
        {
            var sut = new ResxResourceFileHandler("ResxFileHandlerResourceTestData.resx");

            Assert.That(sut.Keys.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetText_WithFile_CorrectlyInitialized()
        {
            var sut = new ResxResourceFileHandler("ResxFileHandlerResourceTestData.resx");

            //sut.GetText();

            Assert.That(sut.Keys.Count, Is.EqualTo(2));
        }
    }
}
﻿// <auto-generated />
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace NotificationService.UnitTests.BusinessLibrary.Trackers.UserConnectionCacheTracker_Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NotificationService.BusinessLibrary.Trackers;
    using NUnit.Framework;

    /// <summary>
    /// Base Test Class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Ctor_Tests : UserConnectionCacheTrackerBaseTests
    {
        /// <summary>
        /// Ctors the null logger.
        /// </summary>
        [Test]
        public void Ctor_NullLogger()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new UserConnectionCacheTracker(this.distributedCacheMock.Object, logger: null));
            Assert.IsTrue(ex.ParamName.Equals("logger", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void Ctor_NullCache()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new UserConnectionCacheTracker(null, logger: null));
            Assert.IsTrue(ex.ParamName.Equals("distributedCache", StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Ctors the valid input.
        /// </summary>
        [Test]
        public void Ctor_ValidInput()
        {
            this.SetupBase();
            var userTracker = new UserConnectionCacheTracker(this.distributedCacheMock.Object, this.loggerMock.Object);
            Assert.IsInstanceOf<UserConnectionCacheTracker>(userTracker);
        }
    }
}

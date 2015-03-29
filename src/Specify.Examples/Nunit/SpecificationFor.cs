﻿using NUnit.Framework;
using Specify.Stories;

namespace Specify.Examples.Nunit
{
    [TestFixture]
    public abstract class SpecificationFor<TSut, TStory> : Specify.SpecificationFor<TSut, TStory>
        where TSut : class
        where TStory : Story, new()
    {
        [Test]
        public override void Specify()
        {
            base.Specify();
        }
    }

    [TestFixture]
    public abstract class SpecificationFor<TSut> : Specify.SpecificationFor<TSut> 
        where TSut : class
    {
        [Test]
        public override void Specify()
        {
            base.Specify();
        }
    }
}
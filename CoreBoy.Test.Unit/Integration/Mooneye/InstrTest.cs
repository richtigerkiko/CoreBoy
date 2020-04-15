﻿using System.IO;
using CoreBoy.Test.Unit.Integration.Support;
using NUnit.Framework;

namespace CoreBoy.Test.Unit.Integration.Mooneye
{
    [TestFixture, Timeout(1000 * 60)]
    public class InstrTest
    {
        public static object[] RomsFrom => ParametersProvider.getParameters("mooneye/acceptance/instr");

        [Test, Parallelizable(ParallelScope.All)]
        [TestCaseSource(nameof(RomsFrom))]
        public void Execute(string filePath)
        {
            var rom = new FileInfo(filePath);
            RomTestUtils.testMooneyeRom(rom);
        }
    }
}
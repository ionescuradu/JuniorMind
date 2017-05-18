﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class ParquetTests
    {
        [TestMethod]
        public void RoomTenByTen()
        {
            decimal totalParquet = parquet(10, 10, 2, 3);
            Assert.AreEqual(20, totalParquet);
        }

        decimal parquet(decimal roomDimensionOne, decimal roomDimensionTwo, decimal parquetDimensionOne, decimal parquetDimensionTwo)
        {
            decimal roomArea = roomDimensionOne * roomDimensionTwo;
            decimal parquetArea = parquetDimensionOne * parquetDimensionTwo;
            decimal loses = 1.15m;
            return Math.Ceiling( roomArea / parquetArea * loses );
        }
    }
}

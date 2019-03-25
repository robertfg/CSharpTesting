using Xunit;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    public class MapTests1
    {
        [Fact()]
        public void MapTest()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Map(0, 3));
            //Assert.True(false, "This test needs an implementation");
        }

        //[Fact()]
        [Fact]
        public void OnMapTest()
        {
            int Width = 5;
            int Height = 6;

            var point = new Point(3, 5);

            var map = new Map(Width, Height);

            bool onMap = map.OnMap(point);

            Assert.True(onMap);

            //Assert.True(false, "This test needs an implementation");
        }
    }
}
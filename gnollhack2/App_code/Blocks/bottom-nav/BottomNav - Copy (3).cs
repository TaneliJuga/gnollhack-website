//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace BemModels
//{
//    public class BottomNav : Block
//    {
//        static string NAME = "bottom-nav";

//        public BottomNav() : base(NAME)
//        {
//        }

//        public String Style { get; set; }

//        public IEnumerable<String> NavItems { get; set; }

//        public static IEnumerable<Column> GetColumns(int itemCount)
//        {
//            Column xs = new Column(6, "xs", itemCount);
//            Column sm = new Column(3, "sm", itemCount);
//            Column md = new Column(1, "md", itemCount);
//            Column[] colSizes = { xs, sm, md };
            
//            return colSizes;
//        }


//        public class Column
//        {
//            public string Cls { get; }
//            private int[] PossibleColWidths { get; }
//            private int[] PossibleColCounts { get; }
//            public int[] ColWidths { get;}
//            public int[] ColCounts { get;}

//            static readonly int maxCols = 12;

//            static readonly int[] colWidths = { 1, 2, 3, 4, 6, 12 };

//            public Column(int minWidth, string cls, int itemCount)
//            {
//                this.Cls = cls;
//                //int maxCount = 24 / minWidth;
//                int count = Math.Min(itemCount, maxCols);
//                this.PossibleColWidths = colWidths.Where(e =>
//                {
//                    return e >= minWidth;
//                }).ToArray();
//                this.PossibleColCounts = this.PossibleColWidths.Select(e => (12 / e)).ToArray();

//                if (PossibleColCounts.Contains(count))
//                {
//                    ColWidths = new int[] { (12 / count) };
//                    ColCounts = new int[] { count };
//                    return;
//                }
//                Dictionary<float, List<Col>> offsetMap = new Dictionary<float, List<Col>>();
//                int[] colCounts = (int[])PossibleColCounts.Clone();

//                int numOfRows = 2;
//                float averageColCount = count / numOfRows;
//                Col[] offsets = colCounts.Select(e =>
//                {
//                    float offset = Math.Abs(averageColCount - e);
//                    return new Col(e, offset);
//                }).ToArray();

//                foreach (Col offset in offsets)
//                {
//                    offsetMap.Add(offset.Offset, new List<Col>());
//                }

//                foreach (Col offset in offsets)
//                {
//                    offsetMap[offset.Offset].Add(offset);
//                }

//                offsets = offsets.Where(e =>
//                {
//                    return offsetMap[e.Offset].Count() == numOfRows;
//                }).ToArray();

//                List<KeyValuePair<int, List<Col>>> entries = new List<KeyValuePair<int, List<Col>>>();
//                foreach (KeyValuePair<float, List<Col>> entry in offsetMap)
//                {
//                    int val1 = entry.Value[0].ColCount;
//                    int val2 = entry.Value[1].ColCount;
//                    int countDif = Math.Abs(val1 - val2);
//                    entries.Add(new KeyValuePair<int, List<Col>>(countDif, entry.Value));
//                }

//                entries.Sort((i1, i2) =>
//                {
//                    return i1.Key - i2.Key;
//                });

//                KeyValuePair<int, List<Col>> entryWithSmallesCountDif = entries.First();
//                List<Col> columnListWithSmallestCountDif = entries.First().Value;
//                int[] colCountsWithSmallestCountDif = columnListWithSmallestCountDif.Select(e =>
//                {
//                    return e.ColCount;
//                }).ToArray();
//                Array.Sort(colCountsWithSmallestCountDif);
//                ColCounts = colCountsWithSmallestCountDif;
//                ColWidths = ColCounts.Select(e => (12 / e)).ToArray();
//            }

//            private class Col
//            {
//                public int ColCount { get; }
//                public float Offset { get; }

//                public Col(int colCount, float offset)
//                {
//                    this.ColCount = colCount;
//                    this.Offset = offset;
//                }
//            }
//        }
//    }
//}



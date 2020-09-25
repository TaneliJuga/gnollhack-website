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


//        private class Column
//        {
//            string Cls { get; }
//            int MinWidth { get; }
//            int MaxCount { get; }

//            static readonly int[] colWidths = { 1, 2, 3, 4, 6, 12 };
//            int[] PossibleColWidths { get; }
//            int[] PossibleColCounts { get; }
//            int[] ColWidths { get; set; }
//            int[] ColCounts { get; set; }

//            Column(int minWidth, string cls)
//            {
//                this.Cls = cls;
//                this.MinWidth = minWidth;
//                this.MaxCount = 24 / minWidth;
//                this.PossibleColWidths = colWidths.Where(e =>
//                {
//                    return e >= minWidth;
//                }).ToArray();
//                this.PossibleColCounts = this.PossibleColWidths.Select(e => (12 / e)).ToArray();
//            }

//            private class Col
//            {
//                int ColCount { get; }
//                float Offset { get; }

//                Col(int colCount, float offset)
//                {
//                    this.ColCount = colCount;
//                    this.Offset = offset;
//                }

//                public static void Content(int itemCount)
//                {
//                    int maxCols = 12;

//                    if (itemCount <= 0)
//                    {
//                        return;
//                    }

//                    int count = Math.Min(itemCount, maxCols);
//                    int[] colWidths = { 1, 2, 3, 4, 6, 12 };


//                    Column xs = new Column(6, "xs");
//                    Column sm = new Column(3, "sm");
//                    Column md = new Column(1, "md");
//                    Column[] colSizes = { xs, sm, md };

//                    foreach (Column column in colSizes)
//                    {
//                        if (column.PossibleColCounts.Contains(count))
//                        {
//                            column.ColWidths = new int[] { (12 / count) };
//                            column.ColCounts = new int[] { count };
//                            return;
//                        }
//                        Dictionary<float, List<Col>> offsetMap = new Dictionary<float, List<Col>>();
//                        int[] colCounts = (int[])column.PossibleColCounts.Clone();

//                        int numOfRows = 2;
//                        float averageColCount = count / numOfRows;
//                        Col[] offsets = colCounts.Select(e =>
//                        {
//                            float offset = Math.Abs(averageColCount - e);
//                            return new Col(e, offset);
//                        }).ToArray();

//                        foreach (Col offset in offsets)
//                        {
//                            offsetMap.Add(offset.Offset, new List<Col>());
//                        }

//                        foreach (Col offset in offsets)
//                        {
//                            offsetMap[offset.Offset].Add(offset);
//                        }

//                        offsets = offsets.Where(e =>
//                        {
//                            return offsetMap[e.Offset].Count() == 2;
//                        }).ToArray();

//                        List<KeyValuePair<int, List<Col>>> entries = new List<KeyValuePair<int, List<Col>>>();
//                        foreach (KeyValuePair<float, List<Col>> entry in offsetMap)
//                        {
//                            int val1 = entry.Value[0].ColCount;
//                            int val2 = entry.Value[1].ColCount;
//                            int countDif = Math.Abs(val1 - val2);
//                            entries.Add(new KeyValuePair<int, List<Col>>(countDif, entry.Value));
//                        }

//                        entries.Sort((i1, i2) =>
//                        {
//                            return i1.Key - i2.Key;
//                        });

//                        KeyValuePair<int, List<Col>> entryWithSmallesCountDif = entries.First();
//                        List<Col> columnListWithSmallestCountDif = entries.First().Value;
//                        int[] colCountsWithSmallestCountDif = columnListWithSmallestCountDif.Select(e =>
//                        {
//                            return e.ColCount;
//                        }).ToArray();
//                        Array.Sort(colCountsWithSmallestCountDif);
//                        column.ColCounts = colCountsWithSmallestCountDif;
//                        column.ColWidths = column.ColCounts.Select(e => (12 / e)).ToArray();
//                    }
//                }

//            }
//        }
//    }

//}

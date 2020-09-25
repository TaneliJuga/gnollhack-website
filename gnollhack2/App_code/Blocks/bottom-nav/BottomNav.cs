using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
{
    public class BottomNav : Block
    {
        static string NAME = "bottom-nav";

        public BottomNav() : base(NAME)
        {
        }

        public String Style { get; set; }

        public IEnumerable<String> NavItems { get; set; }

        public static IEnumerable<Column> GetColumns(int itemCount)
        {
            Column xs = new Column(6, "xs", itemCount);
            Column sm = new Column(3, "sm", itemCount);
            Column md = new Column(1, "md", itemCount);
            Column[] colSizes = { xs, sm, md };
            
            return colSizes;
        }

        private sealed class FloatEqualityComparer : IEqualityComparer<float>
        {
            public bool Equals(float x, float y) => Math.Round(x, 3) == Math.Round(y, 3);

            public int GetHashCode(float f) => Math.Round(f, 3).GetHashCode();
        }
        public class Column
        {
            public string Cls { get; }
            public int[] PossibleColWidths { get; }
            public int[] PossibleColCounts { get; }
            public int[] ColWidths { get; }
            public int[] ColCounts { get; }
            public Dictionary<float, List<Col>> OffsetMap { get; }
            public float[] Offsets { get; }

            public int[] Cols { get; }

            static readonly int maxCols = 12;

            static readonly int[] colWidths = { 1, 2, 3, 4, 6, 12 };

            public Column(int minWidth, string cls, int itemCount)
            {
                this.Cls = cls;
                int count = Math.Min(itemCount, maxCols);
                this.PossibleColWidths = colWidths.Where(e =>
                {
                    return e >= minWidth;
                }).ToArray();
                this.PossibleColCounts = this.PossibleColWidths.Select(e => (12 / e)).ToArray();

                if (PossibleColCounts.Contains(count))
                {
                    ColWidths = new int[] { (12 / count) };
                    ColCounts = new int[] { count };
                    Cols = MakeCols(ColCounts, ColWidths);
                    return;
                }

                Dictionary<float, List<Col>> offsetMap = new Dictionary<float, List<Col>>(new FloatEqualityComparer());
                int[] colCounts = (int[])PossibleColCounts.Clone();

                int numOfRows = 2;
                float averageColCount = (float)((float)count / (float)numOfRows);
                Col[] offsets = colCounts.Select(e =>
                {
                    float offset = Math.Abs(averageColCount - e);
                    return new Col(e, offset);
                }).ToArray();
                Offsets = offsets.Select(e => e.Offset).ToArray();

                foreach (Col col in offsets)
                {
                    if (!offsetMap.ContainsKey(col.Offset) || offsetMap[col.Offset] == null)
                    {
                        offsetMap.Add(col.Offset, new List<Col>());
                    }
                    offsetMap[col.Offset].Add(col);
                }

                OffsetMap = offsetMap;

                IEnumerable<Col>[] filteredCols = offsetMap.Where(e =>
                {
                    return e.Value.Count == numOfRows;
                }).Select(e => {
                    return e.Value;
                }).ToArray();

                if (filteredCols.Length == 0)
                {
                    int colCount1 = offsets.Aggregate<Col>((prev, cur) => {
                        return prev.Offset < cur.Offset ? prev : cur;
                    }).ColCount;
                    int colCount2 = count - colCount1;
                    ColCounts = new int[] { colCount1, colCount2 };
                    ColWidths = ColCounts.Select(e => (12 / e)).ToArray();
                    Cols = MakeCols(ColCounts, ColWidths);
                    return;
                }

                List<KeyValuePair<int, List<Col>>> entries = new List<KeyValuePair<int, List<Col>>>();
                foreach (Col[] cols in filteredCols)
                {
                    int val1 = cols[0].ColCount;
                    int val2 = cols[1].ColCount;
                    int countDif = Math.Abs(val1 - val2);
                    entries.Add(new KeyValuePair<int, List<Col>>(countDif, cols.ToList()));
                }

                entries.Sort((i1, i2) =>
                {
                    return i1.Key - i2.Key;
                });

                KeyValuePair<int, List<Col>> entryWithSmallesCountDif = entries.First();
                List<Col> columnListWithSmallestCountDif = entries.First().Value;
                int[] colCountsWithSmallestCountDif = columnListWithSmallestCountDif.Select(e =>
                {
                    return e.ColCount;
                }).ToArray();
                Array.Sort(colCountsWithSmallestCountDif);
                ColCounts = colCountsWithSmallestCountDif;
                ColWidths = ColCounts.Select(e => (12 / e)).ToArray();
                Cols = MakeCols(ColCounts, ColWidths);
            }

            private int[] MakeCols(int[] colCounts, int[] colWidths)
            {
                int[] asd = new int[] { 11, 12, 13 };
                if (colCounts.Length != colWidths.Length)
                {
                    return asd;
                }

                List<int> res = new List<int>();
                for (int i = 0; i < colWidths.Length; i++)
                {
                    for (int j = 0; j < colCounts[i]; j++)
                    {
                        res.Add(colWidths[i]);
                    }
                }

                return res.ToArray();
            }

            public class Col
            {
                public int ColCount { get; }
                public float Offset { get; }

                public Col(int colCount, float offset)
                {
                    this.ColCount = colCount;
                    this.Offset = offset;
                }
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedModels
{
    public class TableColumn
    {
        public TableColumn(string columnHeader, IHtmlString[] cellData)
        {
            ColumnHeader = columnHeader;
            CellData = cellData;
        }

        public string ColumnHeader { get; }
        public IHtmlString[] CellData { get; }

    }
}
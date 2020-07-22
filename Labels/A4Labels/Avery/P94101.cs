using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpPDFLabel.Labels.A4Labels.Avery
{
    /// <summary>
    /// Dimensions: 63.5mm x 38.1mm 
    /// Per Sheet: 21 per sheet 
    /// Inkjet code: J8160
    /// </summary>
    public class P94101 : LabelDefinition
    {
        public P94101()
        {
            _Width = 76.2;
            _Height = 76.2;
            _HorizontalGapWidth = 31.75;
            _VerticalGapHeight = 6.35;

            _PageMarginTop = 15.875;
            _PageMarginBottom = 15.875;
            _PageMarginLeft = 15.875;
            _PageMarginRight = 15.875;

            PageSize = Enums.PageSize.Letter;
            LabelsPerRow = 2;
            LabelRowsPerPage = 3;
        }
    }
}

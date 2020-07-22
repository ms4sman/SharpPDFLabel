namespace SharpPDFLabel.Labels.LetterLabels.Presta
{
    public class P94101 : LabelDefinition
    {
        public P94101()
        {
            _Width = 76.2;
            _Height = 76.2;
            _HorizontalGapWidth = 31.75;
            _VerticalGapHeight = 9.525;

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

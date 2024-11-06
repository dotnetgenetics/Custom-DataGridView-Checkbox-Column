namespace CustomDataGridViewCheckboxColumn.CustomCheckbox
{
    public class DatagridviewCustomCheckboxColumn : DataGridViewCheckBoxColumn
    {
        public DatagridviewCustomCheckboxColumn()
        {
            this.CellTemplate = new DatagridviewCheckboxCustomCell();
        }
    }

    internal class DatagridviewCheckboxCustomCell : DataGridViewCheckBoxCell
    {
        public int row_index { get; set; }

        public int CheckboxHeight
        {
            get
            {
                int height = 13;
                if (row_index == 0)
                {
                    if (this.ContentBounds.Height > 0)
                    {
                        height = this.ContentBounds.Height;
                    }
                }
                else
                {
                    height = 13;
                }
                return height;
            }
        }

        public int CheckboxWidth
        {
            get
            {
                int width = 14;
                if (row_index == 0)
                {
                    if (this.ContentBounds.Width > 0)
                    {
                        width = this.ContentBounds.Width + 1;
                    }
                }
                else
                {
                    width = 14;
                }
                return width;
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        public DatagridviewCheckboxCustomCell()
        {
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState,
            object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            this.row_index = rowIndex;
            Rectangle rect = new Rectangle();
            rect.Height = this.CheckboxHeight;
            rect.Width = this.CheckboxWidth;
            rect.X = (cellBounds.X + (cellBounds.Width / 2)) - (this.CheckboxWidth / 2);
            rect.Y = cellBounds.Y + 4;

            if (value != null)
            {
                if ((bool)value)
                {
                    graphics.FillRectangle(Brushes.Blue, rect);
                }
                else
                {
                    graphics.FillRectangle(Brushes.Green, rect);
                }
            }
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseClick(e);
        }
    }
}

# How to get a cell value in DetailsViewDataGrid in DataGrid(SfDataGrid)?

## About the sample
This example illustrates how to get a cell value in DetailsViewDataGrid in DataGrid(SfDataGrid)?

Get the cell value of nested level DetailsViewDataGrid by using the SfDataGrid.CellClick event. 

```C#
(this.sfDataGrid1.DetailsViewDefinitions[0] as GridViewDefinition).DataGrid.CellClick += DataGrid_CellClick;

(this.childGrid.DetailsViewDefinitions[0] as GridViewDefinition).DataGrid.CellClick += childGrid_CellClick;

private void childGrid_CellClick(object sender, CellClickEventArgs e)
{
        // Get the row index value        
        var rowIndex = e.DataRow.RowIndex;
        //Get the column index value
        var columnIndex = e.DataColumn.ColumnIndex;
        //Get the cell value            
        var cellValue = (e.OriginalSender as DetailsViewDataGrid).View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, e.DataColumn.GridColumn.MappingName);
        MessageBox.Show("Cell Value \t:    " + cellValue + "\n" + "Row Index \t:    " + rowIndex + "\n" + "Column Index \t:    " + columnIndex, "Cell Value");
}

private void DataGrid_CellClick(object sender, CellClickEventArgs e)
{
       // Get the row index value        
       var rowIndex = e.DataRow.RowIndex;
       //Get the column index value
       var columnIndex = e.DataColumn.ColumnIndex;
       //Get the cell value            
       var cellValue = (e.OriginalSender as DetailsViewDataGrid).View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, e.DataColumn.GridColumn.MappingName);
       MessageBox.Show("Cell Value \t:    " + cellValue + "\n" + "Row Index \t:    " + rowIndex + "\n" + "Column Index \t:    " + columnIndex, "Cell Value");           
} 
```

## Requirements to run the demo
Visual Studio 2015 and above versions

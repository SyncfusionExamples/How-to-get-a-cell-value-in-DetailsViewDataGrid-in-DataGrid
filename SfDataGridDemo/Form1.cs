#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsView
{
    public partial class Form1 : Form
    {
        SfDataGrid childGrid;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SampleCustomization();
        }
        
        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {            
            OrderInfoRepository order = new OrderInfoRepository();
            List<OrderInfo> orderDetails = order.GetOrdersDetails(100);
            this.sfDataGrid1.DataSource = orderDetails;
            childGrid = new SfDataGrid();
            GridViewDefinition orderDetailsView = new GridViewDefinition();
            orderDetailsView.RelationalColumn = "OrderDetails";


            GridViewDefinition employeeDetailsView = new GridViewDefinition();
            employeeDetailsView.RelationalColumn = "EmployeeDetails";

            childGrid.AutoGenerateColumns = false;
            childGrid.RowHeight = 21;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = nfi });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", NumberFormatInfo = nfi });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity" });
            childGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Percent });
            childGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID"});
            childGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });

            childGrid.DetailsViewDefinitions.Add(employeeDetailsView);

            orderDetailsView.DataGrid = childGrid;

            this.sfDataGrid1.DetailsViewDefinitions.Add(orderDetailsView);            

            this.sfDataGrid1.ExpandAllDetailsView();            
                      
            (this.sfDataGrid1.DetailsViewDefinitions[0] as GridViewDefinition).DataGrid.CellClick += DataGrid_CellClick;

            (this.childGrid.DetailsViewDefinitions[0] as GridViewDefinition).DataGrid.CellClick += childGrid_CellClick;
        }

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
    }
}

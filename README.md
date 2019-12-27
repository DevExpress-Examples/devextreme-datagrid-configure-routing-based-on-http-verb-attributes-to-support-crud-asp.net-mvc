# DataGrid - ASP.NET MVC - How to configure routing based on Http[Verb] attributes to support CRUD operations

This example demonstrates how to configure routing based on Http[Verb] attributes to support CRUD operations in DataGrid.

Set the Controller, LoadAction, UpdateAction, InsertAction, and DeleteAction options to **true** so that dxDataGrid's data source can access corresponding actions in a controller.

```CS
.DataSource(d => d.WebApi()
        .Controller("DataGridEmployees")
        .LoadAction(true)
        .UpdateAction(true)
        .InsertAction(true)
        .DeleteAction(true)
        .Key("ID")
    )
```

In the controller, implement data operations in these actions.

See also:
* [Web API Controllers](https://docs.devexpress.com/DevExtremeAspNetMvc/401315/concepts/bind-controls-to-data/controllers#web-api-controllers)
* [Attribute Routing in ASP.NET Web API 2](https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2)

<!-- default file list -->
*Files to look at*:

* [Index.cshtml](./CS/SampleProject/SampleProject/Views/Home/Index.cshtml)
* [HomeController.cs](./CS/SampleProject/SampleProject/Controllers/HomeController.cs)
* [DataGridEmployeesController.cs](./CS/SampleProject/SampleProject/Controllers/DataGridEmployeesController.cs)

<!-- default file list end -->

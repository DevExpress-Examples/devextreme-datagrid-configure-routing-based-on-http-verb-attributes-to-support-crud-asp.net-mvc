<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230453554/19.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848628)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# ASP.NET DataGrid for DevExtreme - How to configure routing based on Http[Verb] attributes to support CRUD operations

This example demonstrates how to configure routing based on Http[Verb] attributes to support CRUD operations in DataGrid.

## Implementation Details

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

## Files to Review

- [Index.cshtml](./CS/SampleProject/SampleProject/Views/Home/Index.cshtml)
- [HomeController.cs](./CS/SampleProject/SampleProject/Controllers/HomeController.cs)
- [DataGridEmployeesController.cs](./CS/SampleProject/SampleProject/Controllers/DataGridEmployeesController.cs)

## Documentation

- [Web API Controllers](https://docs.devexpress.com/DevExtremeAspNetMvc/401315/concepts/bind-controls-to-data/controllers#web-api-controllers)
- [Attribute Routing in ASP.NET Web API 2](https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-configure-routing-based-on-http-verb-attributes-to-support-crud-asp.net-mvc&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-datagrid-configure-routing-based-on-http-verb-attributes-to-support-crud-asp.net-mvc&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using SampleProject.Models;

namespace SampleProject.Controllers {
    [Route("api/DataGridEmployees", Name = "DataGridEmployeesApi")]
    //Or you can use a route prefix:
    //[RoutePrefix("api/Actions")]
    public class DataGridEmployeesController : ApiController {
        InMemoryEmployeesDataContext _data = new InMemoryEmployeesDataContext();

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(_data.Employees, loadOptions));
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]FormDataCollection form) {
            var values = form.Get("values");
            var newEmployee = new Employee();
            JsonConvert.PopulateObject(values, newEmployee);

            Validate(newEmployee);
            if(!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());

            _data.Employees.Add(newEmployee);
            _data.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form) {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var employee = _data.Employees.First(a => a.ID == key);
            JsonConvert.PopulateObject(values, employee);

            Validate(employee);
            if(!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());

            _data.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void Delete(FormDataCollection form) {
            var key = Convert.ToInt32(form.Get("key"));
            var employee = _data.Employees.First(a => a.ID == key);

            _data.Employees.Remove(employee);
            _data.SaveChanges();
        }
    }
}
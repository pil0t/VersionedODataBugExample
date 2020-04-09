using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace ModelAndControllers
{
    public class BaseController<T> : ODataController
    {
        public IActionResult Post([FromBody] T item)
        {
            return Created(item);
        }
    }
}
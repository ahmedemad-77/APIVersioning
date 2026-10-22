using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Contracts.V1;

namespace VersioningDemo.Controllers.V1;

[ApiController]
[ApiVersion(1.0)]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public ActionResult<ProductResponse> Get()
    {
        var product = new ProductResponse(
            Id: 1,
            Name: "Laptop",
            Price: 25000m);

        return Ok(product);
    }
}

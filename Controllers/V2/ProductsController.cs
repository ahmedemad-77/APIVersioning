using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Contracts.V2;

namespace VersioningDemo.Controllers.V2;

[ApiController]
[ApiVersion(2.0)]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public ActionResult<ProductResponse> Get()
    {
        var product = new ProductResponse(
            Id: 1,
            Name: "Laptop",
            Price: 25000m,
            CategoryName: "Electronics");

        return Ok(product);
    }
}

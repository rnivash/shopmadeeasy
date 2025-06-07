using Microsoft.AspNetCore.Mvc;
using Service.Core;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly IProductService _productService;

    public ProductController(IProductService productService){
        this._productService = productService;
    }

    public IActionResult  Get()
    {
        return Ok(_productService.GetProduct());
    }

}
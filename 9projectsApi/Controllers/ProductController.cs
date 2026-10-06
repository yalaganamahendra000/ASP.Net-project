using Microsoft.AspNetCore.Mvc;

namespace productrecord.Api;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Get()
    {
        Product product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 75000,
            Brand = "Dell"
        };

        return product;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Brand { get; set; }
}
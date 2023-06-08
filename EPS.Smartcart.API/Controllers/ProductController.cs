using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class ProductController : AbstractController
{
    public ProductController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] ProductFilter productFilter, [FromQuery] PaginationFilter<Product> paginationFilter)
    {
        var products = await _mediator.Send(new GetAllProductsQuery(productFilter, paginationFilter));
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(id));
        return Ok(product);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateProductDTO product)
    {
        var result = await _mediator.Send(new CreateProductCommand(product));
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateProductDTO product)
    {
        var result = await _mediator.Send(new UpdateProductCommand(product));
        return Ok(result);
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductDTO product)
    {
        var result = await _mediator.Send(new DeleteProductCommand(product));
        return Ok(result);
    }
    
    [HttpGet("barcode")]
    public async Task<IActionResult> GetByBarcode([FromQuery] GetProductByBarcodeDTO getProductByBarcodeDTO)
    {
        var product = await _mediator.Send(new GetProductByBarcodeQuery(getProductByBarcodeDTO));
        return Ok(product);
    }
}
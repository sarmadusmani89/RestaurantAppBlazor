using ECommerceApi.Data;
using ECommerceApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult> CreateOrder([FromBody] Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        return Ok(order);
    }
}

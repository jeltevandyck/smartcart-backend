﻿using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.DTO.Order;

public class UpdateOrderDTO
{
    public string Id { get; set; }
    public string? CartId { get; set; }
    public OrderStatus? OrderStatus { get; set; }
}
﻿using System.Text.Json.Serialization;
using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Domain;

public class Cart : Entity
{
    public CartStatus Status { get; set; }
    public string? Code { get; set; }
    public Boolean IsClaimed { get; set; }
    public string StoreId { get; set; }
    public Store Store { get; set; }
    public string? UserId { get; set; }
    public string? OrderId { get; set; }
    public string? GroceryListId { get; set; }
}
﻿namespace EPS.Smartcart.Domain;

public class GroceryItem : Entity
{
    public int Amount { get; set; }
    public bool IsCollected { get; set; }
    public string GroceryListId { get; set; }
}
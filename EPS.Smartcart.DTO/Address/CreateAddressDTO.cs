﻿namespace EPS.Smartcart.DTO.Address;

public class CreateAddressDTO
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string? Extra { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
}
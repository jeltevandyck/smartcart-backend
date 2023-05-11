using AutoMapper;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Address;
using EPS.Smartcart.DTO.Cart;
using EPS.Smartcart.DTO.GroceryItem;
using EPS.Smartcart.DTO.GroceryList;
using EPS.Smartcart.DTO.Order;
using EPS.Smartcart.DTO.OrderItem;
using EPS.Smartcart.DTO.Product;
using EPS.Smartcart.DTO.Store;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Application.Mappers;

public class Mappings : Profile
{
    public Mappings()
    {
        CreateMap<CreateUserDTO, User>().ReverseMap();
        CreateMap<UpdateUserDTO, User>().ReverseMap();
        CreateMap<DeleteUserDTO, User>().ReverseMap();
        
        CreateMap<CreateAddressDTO, Address>().ReverseMap();
        CreateMap<UpdateAddressDTO, Address>().ReverseMap();
        CreateMap<DeleteAddressDTO, Address>().ReverseMap();
        
        CreateMap<CreateStoreDTO, Store>().ReverseMap();
        CreateMap<UpdateStoreDTO, Store>().ReverseMap();
        CreateMap<DeleteStoreDTO, Store>().ReverseMap();
        
        CreateMap<CreateProductDTO, Product>().ReverseMap();
        CreateMap<UpdateProductDTO, Product>().ReverseMap();
        CreateMap<DeleteProductDTO, Product>().ReverseMap();

        CreateMap<CreateCartDTO, Cart>().ReverseMap();
        CreateMap<UpdateCartDTO, Cart>().ReverseMap();
        CreateMap<DeleteCartDTO, Cart>().ReverseMap();
        
        CreateMap<CreateOrderDTO, Order>().ReverseMap();
        CreateMap<UpdateOrderDTO, Order>().ReverseMap();
        CreateMap<DeleteOrderDTO, Order>().ReverseMap();

        CreateMap<CreateGroceryItemDTO, GroceryItem>().ReverseMap();
        CreateMap<UpdateGroceryItemDTO, GroceryItem>().ReverseMap();
        CreateMap<DeleteGroceryItemDTO, GroceryItem>().ReverseMap();
        
        CreateMap<CreateOrderItemDTO, OrderItem>().ReverseMap();
        CreateMap<UpdateOrderItemDTO, OrderItem>().ReverseMap();
        CreateMap<DeleteOrderItemDTO, OrderItem>().ReverseMap();
        
        CreateMap<CreateGroceryListDTO, GroceryList>().ReverseMap();
        CreateMap<UpdateGroceryListDTO, GroceryList>().ReverseMap();
        CreateMap<DeleteGroceryListDTO, GroceryList>().ReverseMap();
    }
}
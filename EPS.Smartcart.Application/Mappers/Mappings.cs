using AutoMapper;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Address;
using EPS.Smartcart.DTO.Cart;
using EPS.Smartcart.DTO.Order;
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
    }
}
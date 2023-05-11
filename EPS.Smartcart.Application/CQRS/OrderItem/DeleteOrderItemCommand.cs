﻿using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.OrderItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.OrderItem;

public class DeleteOrderItemCommand : IRequest<Domain.OrderItem>
{
    public DeleteOrderItemDTO OrderItemDTO { get; }
    
    public DeleteOrderItemCommand(DeleteOrderItemDTO orderItemDTO)
    {
        OrderItemDTO = orderItemDTO;
    }
}

public class DeleteOrderItemCommandHandler : AbstractHandler, IRequestHandler<DeleteOrderItemCommand, Domain.OrderItem>
{
    public DeleteOrderItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.OrderItem> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
    {
        var orderItem = await _uow.OrderItemRepository.GetById(request.OrderItemDTO.Id);

        _uow.OrderItemRepository.Delete(orderItem);
        await _uow.Commit();
        
        return orderItem;
    }
}
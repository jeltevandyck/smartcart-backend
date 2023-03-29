using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Order;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Order;

public class DeleteOrderCommand : IRequest<Domain.Order>
{
    public DeleteOrderDTO OrderDTO { get; }
    
    public DeleteOrderCommand(DeleteOrderDTO orderDTO)
    {
        OrderDTO = orderDTO;
    }
}

public class DeleteOrderCommandHandler : AbstractHandler, IRequestHandler<DeleteOrderCommand, Domain.Order>
{
    public DeleteOrderCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _uow.OrderRepository.GetById(request.OrderDTO.Id);
        
        order = _mapper.Map(request.OrderDTO, order);
        
        _uow.OrderRepository.Delete(order);
        await _uow.Commit();
        return order;
    }
}

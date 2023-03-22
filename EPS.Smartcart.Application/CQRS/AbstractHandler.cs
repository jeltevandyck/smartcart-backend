using AutoMapper;
using EPS.Smartcart.Application.Interfaces;

namespace EPS.Smartcart.Application.CQRS;

public abstract class AbstractHandler
{
    protected readonly IUnitOfWork _uow;
    protected readonly IMapper _mapper;
    
    public AbstractHandler(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
}
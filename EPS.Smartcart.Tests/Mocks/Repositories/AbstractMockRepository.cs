using System.Linq.Expressions;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using Moq;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public abstract class AbstractMockRepository<F, E, R> where F : IFilter<E> where R : class, IRepository<E> where E : Entity
{
    public Mock<R> GetRepository()
    {
        Mock<R> mockRepo = new Mock<R>();

        var entities = CreateData();

        mockRepo.Setup(x => x.GetAll(It.IsAny<F>(), It.IsAny<PaginationFilter<E>>())).ReturnsAsync((F filter, PaginationFilter<E> PaginationFilter) =>
        {
            var es = entities.AsQueryable();

            es = filter.Apply(es);

            es = PaginationFilter.Apply(es);

            return es.ToList();
        });
        mockRepo.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync((string id) => entities.FirstOrDefault(e => e.Id == id));
        mockRepo.Setup(x => x.Update(It.IsAny<E>())).Returns((E entity) => entities[entities.FindIndex(e => e.Id == entity.Id)] = entity);
        mockRepo.Setup(x => x.Create(It.IsAny<E>())).Returns((E entity) => {
            entities.Add(entity);
            return entity;
        });
        mockRepo.Setup(x => x.Delete(It.IsAny<E>())).Callback((E entity) => entities.Remove(entity));

        return mockRepo;
    }

    public abstract List<E> CreateData();
}
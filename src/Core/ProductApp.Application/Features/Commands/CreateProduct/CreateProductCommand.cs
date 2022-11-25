using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Features.Commands.CreateProduct;

public class CreateProductCommand : IRequest<ServiceResponse<int>>
{
    public string Name { get; set; }
    public decimal Value { get; set; }
    public int Quantity { get; set; }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<int>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper Mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            Mapper = mapper;
        }

        public async Task<ServiceResponse<int>> Handle(CreateProductCommand request,
            CancellationToken cancellationToken)
        {
            var product = Mapper.Map<Product>(request);
            await _productRepository.AddAsync(product);
            return new ServiceResponse<int>(product.Id);
        }
    }
}
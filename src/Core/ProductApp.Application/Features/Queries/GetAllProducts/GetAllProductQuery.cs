using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetAllProducts;

public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper Mapper;

        public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            Mapper = mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductQuery request,
            CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            var viewModels = Mapper.Map<List<ProductViewDto>>(products);
            return new ServiceResponse<List<ProductViewDto>>(viewModels);
        }
    }
}
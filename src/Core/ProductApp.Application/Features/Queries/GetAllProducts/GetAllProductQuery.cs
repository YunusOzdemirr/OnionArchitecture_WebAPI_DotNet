using System;
using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<List<ProductViewDto>>
    {

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductViewDto>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper Mapper;
            public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                Mapper = mapper;
            }

            public async Task<List<ProductViewDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();
                var viewModels = Mapper.Map<List<ProductViewDto>>(products);
                return viewModels;
            }
        }
    }
}


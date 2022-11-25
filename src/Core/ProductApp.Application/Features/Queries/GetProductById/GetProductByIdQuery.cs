using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDto>>
{
    public int Id { get; set; }

    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper Mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            Mapper = mapper;
        }

        public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request,
            CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetByIdAsync(request.Id);
            var productViewDto = Mapper.Map<ProductViewDto>(result);
            return new ServiceResponse<ProductViewDto>(productViewDto);
        }
    }
}
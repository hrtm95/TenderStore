﻿using TS.Domain.Core.Contracts.Service;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Domain.Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task Active(int categoryId, CancellationToken cancellationToken)
        {
            await _categoryService.Active(categoryId, cancellationToken);
        }

        public async Task Create(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            await _categoryService.Create(categoryDto, cancellationToken);
        }

        public async Task DeActive(int categoryId, CancellationToken cancellationToken)
        {
            await _categoryService.DeActive(categoryId, cancellationToken);
        }

        public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
        => await _categoryService.GetAll(cancellationToken);

        public async Task<Category> GetBy(int id, CancellationToken cancellationToken)
        => await _categoryService.GetBy(id, cancellationToken);

        public async Task Update(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            await _categoryService.Update(categoryDto, cancellationToken);
        }
    }
}

using Mango.Services.ProductAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Mango.Services.ProductAPI.Repository.Interfaces;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        protected ResponseDto _responseDto;
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetAll()
        {
            try
            {
                var productDtos = await _productRepository.GetAll();
                _responseDto.Result = productDtos;
            }
            catch (Exception ex)
            {
                SetErrorResponse(ex);
            }

            return Ok(_responseDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<object>> Get([FromRoute] Guid id)
        {
            try
            {
                var productDto = await _productRepository.Get(id);
                _responseDto.Result = productDto;
            }
            catch (Exception ex)
            {
                SetErrorResponse(ex);
            }

            return Ok(_responseDto);
        }

        [HttpPost]
        public async Task<ActionResult<object>> Create([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var dto = await _productRepository.Create(productDto);
                _responseDto.Result = productDto;
            }
            catch (Exception ex)
            {
                SetErrorResponse(ex);
            }

            return Ok(_responseDto);
        }

        [HttpPut]
        public async Task<ActionResult<object>> Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto.Id == Guid.Empty)
                    return BadRequest("The Id is Required.");

                var dto = await _productRepository.Put(productDto);

                _responseDto.Result = productDto;
            }
            catch (Exception ex)
            {
                SetErrorResponse(ex);
            }

            return Ok(_responseDto);
        }

        [HttpDelete]
        public async Task<object> Delete([FromRoute] Guid id)
        {
            try
            {
                var result = await _productRepository.Delete(id);
                _responseDto.Result = result;
            }
            catch (Exception ex)
            {
                SetErrorResponse(ex);
            }

            return Ok(_responseDto);
        }

        private void SetErrorResponse(Exception ex)
        {
            _responseDto.IsSuccess = false;

            _responseDto.ErrorMessages = new List<string>()
            {
                ex.ToString()
            };
        }
    }
}

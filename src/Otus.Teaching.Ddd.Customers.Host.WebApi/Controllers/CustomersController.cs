using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Otus.Teaching.Ddd.Customers.Core.Application.Services.Abstractions;
using Otus.Teaching.Ddd.Customers.Core.Domain.Dto;

 namespace Otus.Teaching.Ddd.Customers.Host.WebApi.Controllers
{
    /// <summary>
    /// API клиентов
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        /// <summary>
        /// Получить список клиентов
        /// </summary>
        [HttpGet("list")]
        [ProducesResponseType(typeof(CustomersForListDto),StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomers()
        {
            return this.Ok(await this._customerService.GetCustomersForListAsync());
        }

        /// <summary>
        /// Получить клиента по Id
        /// </summary>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            return this.Ok(await this._customerService.GetCustomerAsync(id));
        }

        /// <summary>
        /// Создать нового клиента
        /// </summary>
        [HttpPost("create")]
        [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ModelStateDictionary), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto dto)
        {
            var outputDto = await this._customerService.CreateCustomerAsync(dto);
            return this.Ok(outputDto);
        }

        /// <summary>
        /// Изменить существующего клиента
        /// </summary>
        [HttpPost("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ModelStateDictionary), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EditCustomer(EditCustomerDto dto)
        {
            await this._customerService.EditCustomerAsync(dto);
            return this.Ok();
        }
    }
}

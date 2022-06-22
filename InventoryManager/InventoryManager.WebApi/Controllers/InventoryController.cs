using InventoryManager.Application.Services;
using InventoryManager.Domain.Inventory;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryManager.WebApi.Controllers
{
    /// <summary>
    /// Used to manage a inventory.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IInventoryService inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
        }

        ///// <summary>
        ///// Method used to get all inventory items.
        ///// </summary>
        ///// <returns>Returns a list of inventory items.</returns>
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    this.inventoryService.GetInventoryItems();
        //    return new string[] { "value1", "value2" };
        //}

        ///// <summary>
        ///// Method used to save all inventory items.
        ///// </summary>
        ///// <returns>Returns a list of inventory items.</returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public IActionResult Post([FromBody] InventoryItemDto inventoryItemDto)
        {
            return Ok(this.inventoryService.Save(inventoryItemDto));
        }

        ///// <summary>
        ///// Method used to get all inventory items.
        ///// </summary>
        ///// <returns>Returns a list of inventory items.</returns>
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        /// <summary>
        /// Method used to get all inventory items.
        /// </summary>
        /// <returns>Returns a list of inventory items.</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{inventoryItemId}")]
        public void Delete(Guid inventoryItemId)
        {
            this.inventoryService.Delete(inventoryItemId);
        }
    }
}

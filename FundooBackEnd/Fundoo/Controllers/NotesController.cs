using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.NotesModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    /// <summary>
    /// Notes Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The notes
        /// </summary>
        public readonly INotes notes;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesController(INotes notes)
        {
            this.notes = notes;
        }

        /// <summary>
        /// Adds the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("adds")]
        public async Task<IActionResult> Add([FromBody]NotesModel notesModel)
        {
            try
            {
                var result = await this.notes.AddAsync(notesModel);
                return this.Ok(new { result });
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletes")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await this.notes.DeleteAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Updates the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("updates")]
        public async Task<IActionResult> Update([FromBody]NotesModel notesModel)
        {
            try
            {
                var result = await this.notes.UpdateAsync(notesModel);
                return Ok(new { result });
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("views")]
        public List<NotesModel> List()
        {
            return this.notes.GetAllListAsync();
        }

        /// <summary>
        /// Lists the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("note")]
        public List<NotesModel> List(int id)
        {
            return this.notes.GetNotesAsync(id);
        }
    }
}

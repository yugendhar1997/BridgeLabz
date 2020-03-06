using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    /// <summary>
    /// Collaborator Label
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorsController : ControllerBase
    {
        /// <summary>
        /// The collaborator
        /// </summary>
        private readonly ICollaborator collaborator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorsController"/> class.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        public CollaboratorsController(ICollaborator collaborator)
        {
            this.collaborator = collaborator;
        }

        /// <summary>
        /// Adds the specified collaborators model.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody]CollaboratorsModel collaboratorsModel)
        {
            try
            {
                var result = await this.collaborator.AddCollaboratorAsync(collaboratorsModel);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the specified collaborators model.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> Delete(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                var result = await this.collaborator.RemoveCollaboratorAsync(collaboratorsModel);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }
    }
}

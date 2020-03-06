using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interface
{
    /// <summary>
    /// Collaborator Interface
    /// </summary>
    public interface ICollaborator
    {
        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        Task<string> AddCollaboratorAsync(CollaboratorsModel collaboratorsModel);

        /// <summary>
        /// Removes the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        Task<string> RemoveCollaboratorAsync(CollaboratorsModel collaboratorsModel);
    }
}

using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// Collaborator Repository Interface
    /// </summary>
    public interface ICollaboratorRepository
    {
        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel);

        /// <summary>
        /// Deletes the collaborators notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        Task DeleteCollaboratorsNotes(CollaboratorsModel collaboratorsModel);
    }
}

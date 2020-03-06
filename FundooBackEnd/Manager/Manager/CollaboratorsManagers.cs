using Manager.Interface;
using Model.Collaborator;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// Collaborator Manager
    /// </summary>
    /// <seealso cref="Manager.Interface.ICollaborator" />
    public class CollaboratorsManagers : ICollaborator
    {
        /// <summary>
        /// The Collaborator Repository
        /// </summary>
        private readonly ICollaboratorRepository collaboratorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorsManagers"/> class.
        /// </summary>
        /// <param name="collaboratorRepository">The collaborator repository.</param>
        public CollaboratorsManagers(ICollaboratorRepository collaboratorRepository)
        {
            this.collaboratorRepository = collaboratorRepository;
        }

        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> AddCollaboratorAsync(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                await this.collaboratorRepository.AddCollaboratorsToNotes(collaboratorsModel);
                return "COLLABORATION ADDED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Removes the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RemoveCollaboratorAsync(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                await this.collaboratorRepository.DeleteCollaboratorsNotes(collaboratorsModel);
                return "COLLABORATION DELETED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}

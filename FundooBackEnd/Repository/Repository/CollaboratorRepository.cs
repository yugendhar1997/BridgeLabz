using Model.Collaborator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// Collaboratory Repository
    /// </summary>
    /// <seealso cref="Repository.Repository.ICollaboratorRepository" />
    public class CollaboratorRepository : ICollaboratorRepository
    {
        /// <summary>
        /// The usercontext
        /// </summary>
        private readonly UserContext usercontext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public CollaboratorRepository(UserContext userContext)
        {
            this.usercontext = userContext;
        }

        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                bool result = this.usercontext.Notes.Any(r=>r.Email == collaboratorsModel.SenderEmail && r.Id == collaboratorsModel.NoteId);
                if(result)
                {
                    var user = this.usercontext.UserData.Where(u => u.Email == collaboratorsModel.ReciverEmail).SingleOrDefault();
                    {
                        var collaborators = new CollaboratorsModel()
                        {
                            NoteId = collaboratorsModel.NoteId,
                            SenderEmail = collaboratorsModel.SenderEmail,
                            ReciverEmail = collaboratorsModel.ReciverEmail
                        };
                        usercontext.Collaborators.Add(collaboratorsModel);
                    }
                }
                return Task.Run(()=> usercontext.SaveChanges());
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the collaborators notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task DeleteCollaboratorsNotes(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                var result = this.usercontext.Collaborators.Where(r => r.NoteId == collaboratorsModel.NoteId).Single();
                this.usercontext.Collaborators.Remove(result);
                return Task.Run(() => usercontext.SaveChanges());
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}

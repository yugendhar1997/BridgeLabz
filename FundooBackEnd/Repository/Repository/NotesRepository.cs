using Model.NotesModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// Notes Repository
    /// </summary>
    /// <seealso cref="Repository.Interface.INotesRepository" />
    public class NotesRepository : INotesRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public NotesRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        public Task AddNotes(NotesModel notesModel)
        {
            NotesModel notes = new NotesModel()
            {
                Email = notesModel.Email,
                Title = notesModel.Title,
                Description = notesModel.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };
            userContext.Notes.Add(notes);
            return Task.Run(() => userContext.SaveChanges());
        }

        /// <summary>
        /// Deletes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task DeleteNotes(int id)
        {
            var notes = userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if (notes != null)
            {
                userContext.Notes.Remove(notes);
                userContext.SaveChanges();
                return Task.Run(() => userContext.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        public Task UpdateNotes(NotesModel notesModel)
        {
            var note = userContext.Notes.Where(r => r.Id == notesModel.Id).SingleOrDefault();
            if(note!=null)
            {
                note.Email = notesModel.Email;
                note.Title = notesModel.Title;
                note.Description = notesModel.Description;
                note.CreatedDate = notesModel.CreatedDate;
                note.ModifiedDate = notesModel.ModifiedDate;
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> GetList()
        {
            return this.userContext.Notes.ToList<NotesModel>();
            ////return this.userContext.Notes.ToList<NotesModel>();
        }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="note">The identifier.</param>
        /// <returns></returns>
        public List<NotesModel> GetNotes(int id)
        {
            var notes = userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if(notes!=null)
            {
                return userContext.Notes.Where(r => r.Id == id).ToList();
            }
            return null;
        }
    }
}

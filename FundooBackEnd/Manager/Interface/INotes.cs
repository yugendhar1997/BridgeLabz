using Model.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interface
{
    /// <summary>
    /// Notes Manager Interface
    /// </summary>
    public interface INotes
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task<string> AddAsync(NotesModel notesModel);

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> DeleteAsync(int id);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task<string> UpdateAsync(NotesModel notesModel);

        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetAllListAsync();

        /// <summary>
        /// Gets the notes asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<NotesModel> GetNotesAsync(int id);
    }
}

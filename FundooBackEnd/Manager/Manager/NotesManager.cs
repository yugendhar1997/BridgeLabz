// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesManager.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Microsoft.AspNetCore.Http;
using Model.NotesModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// Notes Manager class
    /// </summary>
    /// <seealso cref="Manager.Interface.INotes" />
    public class NotesManager : INotes
    {
        /// <summary>
        /// The notes repository
        /// </summary>
        private readonly INotesRepository notesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="notesRepository">The notes repository.</param>
        public NotesManager(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> AddAsync(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.AddNotes(notesModel);
                return "NOTES ADDED SUCCESSFULLY";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> DeleteAsync(int id)
        {
            try
            {
                await this.notesRepository.DeleteNotes(id);
                return "NOTES DELETED SUCESSFULLY";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UpdateAsync(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.UpdateNotes(notesModel);
                return "NOTES DETAILS UPDATED SUCCESSFULLY";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NotesModel> GetAllListAsync()
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets the notes asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NotesModel> GetNotesAsync(int id)
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.GetNotes(id);
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Determines whether [is archive asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> IsArchiveAsync(int id)
        {
            try
            {
                await this.notesRepository.IsArchive(id);
                return "ARCHIVE SUCCESSFUL";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Uns the archive asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UnArchiveAsync(int id)
        {
            try
            {
                await this.notesRepository.UnArchive(id);
                return "UNARCHIVE SUCCESSFUL";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NotesModel> GetArchiveList()
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.ArchiveList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Determines whether [is trash asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> IsTrashAsync(int id)
        {
            try
            {
                await this.notesRepository.IsTrash(id);
                return "UPDATES SUCCESSFULLY";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Trashes the list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NotesModel> TrashList()
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.GetTrashList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Restores the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RestoreAsync(int id)
        {
            try
            {
                await this.notesRepository.Restore(id);
                return "UPDATES SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Restores all note.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RestoreAllNote()
        {
            try
            {
                await this.notesRepository.RestoreAll();
                return "RESTORE SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Removes all trash.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RemoveAllTrash()
        {
            try
            {
                await this.notesRepository.RemoveTrash();
                return "TRASH REMOVED";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Determines whether [is pin asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> IsPinAsync(int id)
        {
            try
            {
                await this.notesRepository.IsPin(id);
                return "UPDATES SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Uns the pin asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UnPinAsync(int id)
        {
            try
            {
                await this.notesRepository.UnPin(id);
                return "UPDATES SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Reminders the value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The reminder.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string ReminderValue(int id, string reminder)
        {
            try
            {
                //// await this.notesRepository.Remainder(id, reminder);
                this.notesRepository.Reminder(id, reminder);
                return "REMINDER UPDATED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> SetColor(int id, string color)
        {
            try
            {
                await this.notesRepository.Color(id, color);
                return "COLOR UPDATES SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string UploadImages(int id, IFormFile image)
        {
            try
            {
                this.notesRepository.UploadImages(id, image);
                return "IMAGE UPLOADED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}

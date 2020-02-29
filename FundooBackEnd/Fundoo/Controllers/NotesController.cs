﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesController.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Microsoft.AspNetCore.Http;
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
            catch (Exception e)
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
            catch (Exception exception)
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

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("trash")]
        public async Task<IActionResult> IsTrash(int id)
        {
            try
            {
                var result = await this.notes.IsTrashAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Alls the trash list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("trashlist")]
        public List<NotesModel> AllTrashList()
        {
            return this.notes.TrashList();
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("restore")]
        public async Task<IActionResult> Restore(int id)
        {
            try
            {
                var result = await this.notes.RestoreAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("restoreall")]
        public async Task<IActionResult> RestoreAll()
        {
            try
            {
                var result = await this.notes.RestoreAllNote();
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Removes all.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("removetrash")]
        public async Task<IActionResult> RemoveAll()
        {
            try
            {
                var result = await this.notes.RemoveAllTrash();
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("isarchive")]
        public async Task<IActionResult> IsArchive(int id)
        {
            try
            {
                var result = await this.notes.IsArchiveAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unarchive")]
        public async Task<IActionResult> UnArchive(int id)
        {
            try
            {
                var result = await this.notes.UnArchiveAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Archives the list all.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("archivelist")]
        public List<NotesModel> ArchiveListAll()
        {
            return this.notes.GetArchiveList();
        }

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("ispin")]
        public async Task<IActionResult> IsPin(int id)
        {
            try
            {
                var result = await this.notes.IsPinAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unpin")]
        public async Task<IActionResult> UnPin(int id)
        {
            try
            {
                var result = await this.notes.UnPinAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Reminders the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The reminder.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("reminder")]
        public IActionResult Reminder(int id, string reminder)
        {
            try
            {
                var result = this.notes.ReminderValue(id, reminder);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("color")]
        public async Task<IActionResult> Color(int id, string color)
        {
            try
            {
                var result = await this.notes.SetColor(id, color);
                return this.Ok(new { result });
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        [HttpPost]
        [Route("upload")]
        public  IActionResult Upload(int id ,IFormFile image)
        {
            try
            {
                var result =  this.notes.UploadImages(id, image);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }
    }
}

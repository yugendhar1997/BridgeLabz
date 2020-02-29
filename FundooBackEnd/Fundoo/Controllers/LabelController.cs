// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelController.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.LabelModel;
using System;
using System.Collections.Generic;

namespace Fundoo.Controllers
{
    /// <summary>
    /// Label Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        /// <summary>
        /// The label
        /// </summary>
        public readonly ILabel label;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelController"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public LabelController([FromBody]ILabel label)
        {
            this.label = label;
        }

        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]LabelModel labelModel)
        {
            try
            {
                var result = this.label.Add(labelModel);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = this.label.Delete(id);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody]LabelModel labelModel)
        {
            try
            {
                var result = this.label.Update(labelModel);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("view")]
        public List<LabelModel> List()
        {
            return this.label.GetAllList();
        }

        [HttpGet]
        [Route("label")]
        public List<LabelModel> List(int id)
        {
            return this.label.GetLabel(id);
        }
    }
}

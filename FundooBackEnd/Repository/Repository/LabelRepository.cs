﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepository.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Yugendhar Pyata"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.LabelModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    /// <summary>
    /// Label Repository
    /// </summary>
    /// <seealso cref="Repository.Interface.ILabelRepository" />
    public class LabelRepository : ILabelRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepository"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public LabelRepository(UserContext user)
        {
            this.userContext = user;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string AddLabel(LabelModel labelModel)
        {
            LabelModel add = new LabelModel()
            {
                Email = labelModel.Email,
                Label = labelModel.Label
            };

            this.userContext.Labels.Add(add);
            this.userContext.SaveChanges();
            return "DONE";
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string DeleteLabel(int id)
        {
            var label = userContext.Labels.Where(r => r.Id == id).SingleOrDefault();
            if (label != null)
            {
                userContext.Labels.Remove(label);
            }
            userContext.SaveChanges();
            return "DONE";
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public List<LabelModel> GetLabel(int id)
        {
            var note = userContext.Labels.Where(r => r.Id == id).SingleOrDefault();
            if (note != null)
            {
                return userContext.Labels.Where(r => r.Id == id).ToList();
            }
            return null;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public List<LabelModel> GetList()
        {
            return this.userContext.Labels.ToList<LabelModel>();
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string UpdateLabel(LabelModel labelModel)
        {
            var result = userContext.Labels.Where(r => r.Id == labelModel.Id).SingleOrDefault();
            if (result != null)
            {
                result.Email = labelModel.Email;
                result.Label = labelModel.Label;

                userContext.Labels.Update(result);
            }
            userContext.SaveChanges();
            return "DONE";
        }
    }
}

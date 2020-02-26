using Manager.Interface;
using Model.LabelModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Manager
{
    /// <summary>
    /// Label Manager Class
    /// </summary>
    /// <seealso cref="Manager.Interface.ILabel" />
    public class LabelManager : ILabel
    {
        /// <summary>
        /// The label repository
        /// </summary>
        public readonly ILabelRepository labelRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        /// <param name="labelRepository">The label repository.</param>
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }

        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Add(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.AddLabel(labelModel);
                return "LABEL ADDED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Delete(int id)
        {
            try
            {
                this.labelRepository.DeleteLabel(id);
                return "LABEL DELETED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets all list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<LabelModel> GetAllList()
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetList();
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
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<LabelModel> GetLabel(int id)
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetLabel(id);
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
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Update(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.UpdateLabel(labelModel);
                return "LABEL UPDATED SUCCESSFULLY";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}

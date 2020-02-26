using Model.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    /// <summary>
    /// Label Repository
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string AddLabel(LabelModel labelModel);

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string UpdateLabel(LabelModel labelModel);

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string DeleteLabel(int id);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        List<LabelModel> GetList();

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<LabelModel> GetLabel(int id);
    }
}

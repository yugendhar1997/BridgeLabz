using Model.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    /// <summary>
    /// Label Manager interface
    /// </summary>
    public interface ILabel
    {
        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string Add(LabelModel labelModel);

        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string Update(LabelModel labelModel);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string Delete(int id);

        /// <summary>
        /// Gets all list.
        /// </summary>
        /// <returns></returns>
        List<LabelModel> GetAllList();

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<LabelModel> GetLabel(int id);
    }
}

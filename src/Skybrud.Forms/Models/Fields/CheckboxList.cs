using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a <c>checkboxList</c> list based field.
    /// </summary>
    public class CheckboxList : ListBase {

        /// <summary>
        /// Gets the type of buttons based on <see cref="CheckboxList"/>.
        /// </summary>
        protected const string FieldType = "checkboxList";

        #region Constructors

        /// <summary>
        /// Initializes a new checkbox list with default values.
        /// </summary>
        public CheckboxList() : base(FieldType) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        public CheckboxList(string name) : base(FieldType, name) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        /// <param name="items">The items that should make up the checkbox list.</param>
        public CheckboxList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        /// <param name="items">The items that should make up the checkbox list.</param>
        public CheckboxList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        /// <param name="label">The label of the checkbox list.</param>
        public CheckboxList(string name, string label) : base(FieldType, name, label) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        /// <param name="label">The label of the checkbox list.</param>
        /// <param name="items">The items that should make up the checkbox list.</param>
        public CheckboxList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        /// <summary>
        /// Initializes a new checkbox list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the checkbox list.</param>
        /// <param name="label">The label of the checkbox list.</param>
        /// <param name="items">The items that should make up the checkbox list.</param>
        public CheckboxList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {
    
    /// <summary>
    /// Class representing a <c>dropdown</c> list based field.
    /// </summary>
    public class DropDownList : ListBase {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="DropDownList"/>.
        /// </summary>
        protected const string FieldType = "dropdown";

        #region Constructors
        
        /// <summary>
        /// Initializes a new drop-down list with default values.
        /// </summary>
        public DropDownList() : base(FieldType) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        public DropDownList(string name) : base(FieldType, name) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        /// <param name="items">The items that should make up the drop-down list.</param>
        public DropDownList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        /// <param name="items">The items that should make up the drop-down list.</param>
        public DropDownList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        /// <param name="label">The label of the drop-down list.</param>
        public DropDownList(string name, string label) : base(FieldType, name, label) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        /// <param name="label">The label of the drop-down list.</param>
        /// <param name="items">The items that should make up the drop-down list.</param>
        public DropDownList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }
        
        /// <summary>
        /// Initializes a new drop-down list with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="name">The name of the drop-down list.</param>
        /// <param name="label">The label of the drop-down list.</param>
        /// <param name="items">The items that should make up the drop-down list.</param>
        public DropDownList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
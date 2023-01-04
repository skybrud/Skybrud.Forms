using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Abstract class serving as a common base for list based fields like <see cref="CheckboxList"/>, <see cref="DropDownList"/> and <see cref="RadioList"/>.
    /// </summary>
    public abstract class ListBase : FieldBase {

        #region Properties

        /// <summary>
        /// Gets or sets the placeholder text of the field.
        /// </summary>
        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or sets the items making up the list.
        /// </summary>
        [JsonProperty("items", Order = 510)]
        public List<ListItem> Items { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        protected ListBase(string type) : base(type, null) {
            Items = new List<ListItem>();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/> nad <paramref name="name"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        protected ListBase(string type, string name) : base(type, name) {
            Items = new List<ListItem>();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="label"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        protected ListBase(string type, string name, string label) : base(type, name) {
            Label = label;
            Items = new List<ListItem>();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>, <paramref name="name"/>,
        /// <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the field.</param>
        protected ListBase(string type, string name, string label, IEnumerable<ListItem> items) : base(type, name) {
            Label = label;
            Items = items?.ToList() ?? new List<ListItem>();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>, <paramref name="name"/>,
        /// <paramref name="label"/> and <paramref name="items"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the field.</param>
        protected ListBase(string type, string name, string label, params ListItem[] items) : base(type, name) {
            Label = label;
            Items = items?.ToList() ?? new List<ListItem>();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/> and <paramref name="name"/>. The items will be based on the fields defined by the type of <paramref name="defaultItem"/>, and with <paramref name="defaultItem"/> preselected.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="defaultItem">The default item.</param>
        protected ListBase(string type, string name, Enum defaultItem) : base(type, name) {

            Items = new List<ListItem>();

            foreach (Enum value in Enum.GetValues(defaultItem.GetType())) {
                Items.Add(new ListItem(value, Equals(value, defaultItem)));
            }

        }

        #endregion

    }

}
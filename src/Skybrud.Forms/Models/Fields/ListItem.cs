using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing an item in a list based field.
    /// </summary>
    public class ListItem {

        #region Properties

        /// <summary>
        /// Gets or sets the value of the item.
        /// </summary>
        [JsonProperty("value", Order = -99)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the label of the item.
        /// </summary>
        [JsonProperty("label", Order = -98)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets whether the item should be checked.
        /// </summary>
        [JsonProperty("checked", Order = 99)]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        public ListItem(int value, string label) {
            Value = value.ToString();
            Label = label;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        public ListItem(long value, string label) {
            Value = value.ToString();
            Label = label;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        public ListItem(int value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        public ListItem(Guid value, string label) {
            Value = value.ToString();
            Label = label;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        public ListItem(Guid value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        public ListItem(string value, string label) {
            Value = value;
            Label = label;
        }

        /// <summary>
        /// Initializes a new item with the specified <paramref name="value"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        public ListItem(string value, string label, bool isChecked) {
            Value = value;
            Label = label;
            IsChecked = isChecked;
        }

        /// <summary>
        /// Initializes a new item based on the specified enum <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <remarks>If the enum field has a <see cref="DescriptionAttribute"/>, the items name will be derived from
        /// the value of that attribute; otherwise the name will be based on the name of the enum field.</remarks>
        public ListItem(Enum value) {
            Value = value.ToCamelCase();
            Label = value.HasCustomAttribute(out DescriptionAttribute? result) ? result.Description : value.ToString();
        }

        /// <summary>
        /// Initializes a new item based on the specified enum <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        /// <remarks>If the enum field has a <see cref="DescriptionAttribute"/>, the items name will be derived from
        /// the value of that attribute; otherwise the name will be based on the name of the enum field.</remarks>
        public ListItem(Enum value, bool isChecked) : this(value) {
            IsChecked = isChecked;
        }

        #endregion

    }

}
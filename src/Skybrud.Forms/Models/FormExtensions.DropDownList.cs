using System.Collections.Generic;
using System;
using System.Linq;
using Skybrud.Forms.Models.Fields;

namespace Skybrud.Forms.Models {

    public partial class FormExtensions {

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, IEnumerable<ListItem> items, string id = null, string label = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new DropDownList(name, items) {
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new DropDownList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, string label, IEnumerable<ListItem> items, string id = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new DropDownList(name, items) {
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new DropDownList(name, label, items));
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T, TItem>(this T form, string name, IEnumerable<TItem> items, Func<TItem, ListItem> function, string id = null, string label = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new DropDownList(name, items?.Select(function)) {
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T, TItem>(this T form, string name, string label, IEnumerable<TItem> items, Func<TItem, ListItem> function, string id = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form {
            // TODO: Maybe remove this overload?
            if (form == null) return null;
            form.Fields.Add(new DropDownList(name, items?.Select(function)) {
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T, TEnum>(this T form, string name, string id = null, string label = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form where TEnum : Enum {

            if (form is null) return null;

            // Initialize a new drop-down list
            var ddl = new DropDownList(name, label) {
                Id = id,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            };

            // Append items based on the fields of "TEnum"
            ddl.AddItems<DropDownList, TEnum>();

            // Append the drop-down list to "form"
            form.Fields.Add(ddl);

            return form;

        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="defaultValue">An enum value indicating the default value whose corresponding item should be initially checked.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T, TEnum>(this T form, string name, string label, TEnum defaultValue, string id = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form where TEnum : Enum {

            // TODO: Maybe remove this overload?

            if (form is null) return null;

            // Initialize a new drop-down list
            var ddl = new DropDownList(name, label) {
                Id = id,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            };

            // Append items based on the fields of "defaultValue"
            ddl.AddItems(defaultValue);

            // Append the drop-down list to "form"
            form.Fields.Add(ddl);

            return form;

        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="defaultValue">An enum value indicating the default value whose corresponding item should be initially checked.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field</param>
        /// <param name="placeholder">A placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="required">Whether the drop-down list is required.</param>
        /// <param name="disabled">Whether the drop-down list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        public static T AddDropDownList<T, TEnum>(this T form, string name, TEnum defaultValue, string id = null, string label = null, string description = null, string placeholder = null, object value = null, bool required = false, bool disabled = false) where T : Form where TEnum : Enum {

            if (form is null) return null;

            // Initialize a new drop-down list
            var ddl = new DropDownList(name, label) {
                Id = id,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            };

            // Append items based on the fields of "defaultValue"
            ddl.AddItems(defaultValue);

            // Append the drop-down list to "form"
            form.Fields.Add(ddl);

            return form;

        }

    }

}
using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Skybrud.Forms.Models.Fields;

namespace Skybrud.Forms.Models {

    public partial class FormExtensions {

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual items of the list.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T>(this T? form, string name, string? label = null, IEnumerable<ListItem>? items = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false) where T : Form {
            form?.Fields.Add(new RadioList(name, items) {
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                IsRequired = required is true,
                IsDisabled = disabled is true
            });
            return form;
        }

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <param name="items">The items that should make up the índividual items of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false, params ListItem[] items) where T : Form {
            return AddRadioList(form, name, label, items, description, placeholder, value, id, required, disabled);
        }

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T, TItem>(this T? form, string name, IEnumerable<TItem>? items, Func<TItem, ListItem> function, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false) where T : Form {
            return AddRadioList(form, name, label, items?.Select(function), description, placeholder, value, id, required, disabled);
        }

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T, TItem>(this T? form, string name, string? label, IEnumerable<TItem>? items, Func<TItem, ListItem> function, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool? required = false, bool? disabled = false) where T : Form {
            return AddRadioList(form, name, label, items?.Select(function), description, placeholder, value, id, required, disabled);
        }

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T, TEnum>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool required = false, bool disabled = false) where T : Form where TEnum : Enum {
            return AddRadioList(form, name, label, ListBase.GetItems<TEnum>(), description, placeholder, value, id, required, disabled);
        }

        /// <summary>
        /// Appends a new radio list field to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="defaultValue">An enum value indicating the default value whose corresponding item should be initially checked.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field list is required.</param>
        /// <param name="disabled">Whether the field list is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddRadioList<T, TEnum>(this T? form, string name, string? label = null, TEnum? defaultValue = default, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool required = false, bool disabled = false) where T : Form where TEnum : Enum {
            return AddRadioList(form, name, label, ListBase.GetItems(defaultValue), description, placeholder, value, id, required, disabled);
        }

    }

}
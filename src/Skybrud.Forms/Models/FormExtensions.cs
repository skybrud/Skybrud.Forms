using System;
using System.Collections.Generic;
using System.Linq;
using Skybrud.Forms.Models.Fields;

// ReSharper disable InconsistentNaming

namespace Skybrud.Forms.Models {

    /// <summary>
    /// Various extension methods for <see cref="Form"/> (and classes extending <see cref="Form"/>).
    /// </summary>
    public static class FormExtensions {

        /// <summary>
        /// Sets the title of <paramref name="form"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="title">The new title.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T SetTitle<T>(this T form, string title) where T : Form {
            if (form != null) form.Title = title;
            return form;
        }

        /// <summary>
        /// Sets the endpoint URL of <paramref name="form"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="endpointUrl">The new endpoint URL.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T SetEndpointUrl<T>(this T form, string endpointUrl) where T : Form {
            if (form != null) form.EndpointUrl = endpointUrl;
            return form;
        }

        /// <summary>
        /// Appends the specified <paramref name="field"/> to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="field">The field to be added.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddField<T>(this T form, FieldBase field) where T : Form {
            form?.Fields.Add(field);
            return form;
        }

        /// <summary>
        /// Appends a new <c>hidden</c> input field field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddHiddenField<T>(this T form, string name, object value) where T : Form {
            form?.Fields.Add(new HiddenField(name, value));
            return form;
        }

        /// <summary>
        /// Appends a new <c>email</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddEmailField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new EmailField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>text</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddTextField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new TextField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>password</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddPasswordField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new PasswordField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>date</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDateField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new PasswordField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>&lt;textarea&gt;</c> field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the textarea.</param>
        /// <param name="value">The value of the textarea.</param>
        /// <param name="placeholder">The placeholder text of the textarea.</param>
        /// <param name="label">The label of the textarea.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the textarea.</param>
        /// <param name="rows">The textarea's height in rows.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddTextarea<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, int? rows = null, bool required = false) where T : Form {
            form?.Fields.Add(new TextArea {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Size = size,
                Rows = rows,
                IsRequired = required
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>tel</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddTelField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false) where T : Form {
            form?.Fields.Add(new TelField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Size = size,
                IsRequired = required
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>tel</c> input field to <paramref name="form"/>'s list list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="min">The value for the input field's <c>min</c> attribute.</param>
        /// <param name="max">The value for the input field's <c>max</c> attribute.</param>
        /// <param name="step">The value for the input field's <c>step</c> attribute.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number</cref>
        /// </see>
        public static T AddNumberField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? min = null, int? max = null, int? step = null, int? size = null, bool required = false) where T : Form {
            form?.Fields.Add(new NumberField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Min = min,
                Max = max,
                Step = step,
                Size = size,
                IsRequired = required
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>checkbox</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="description">The description of the field.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/checkbox</cref>
        /// </see>
        public static T AddCheckbox<T>(this T form, string name, string value = null, string label = null, bool required = false, string description = null) where T : Form {
            form?.Fields.Add(new Checkbox(name, value) {
                Label = label,
                IsRequired = required,
                Description = description
            });
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, label, items));
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, label, items));
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T, TItem>(this T form, string name, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new CheckboxList(name, items?.Select(function)));
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T, TItem>(this T form, string name, string label, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new CheckboxList(name, label, items?.Select(function)));
            return form;
        }
        
        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new CheckboxList(name, label).AddItems<CheckboxList, TEnum>());
            return form;
        }

        /// <summary>
        /// Appends a new checkbox list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="defaultValue">An enum value indicating the default value whose corresponding item should be initially checked.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddCheckboxList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new CheckboxList(name, label).AddItems(defaultValue));
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new DropDownList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new drop-down list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new DropDownList(name, label, items));
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T, TItem>(this T form, string name, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new DropDownList(name, items?.Select(function)));
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T, TItem>(this T form, string name, string label, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new DropDownList(name, label, items?.Select(function)));
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new DropDownList(name, label).AddItems<DropDownList, TEnum>());
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
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddDropDownList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new DropDownList(name, label).AddItems(defaultValue));
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new RadioList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new RadioList(name, items));
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new RadioList(name, label, items));
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new RadioList(name, label, items));
            return form;
        }

        /// <summary>
        /// Appends a new radio list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T, TItem>(this T form, string name, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new RadioList(name, items?.Select(function)));
            return form;
        }

        /// <summary>
        /// Appends a new radio list to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="items">The items that should make up the índividual checkboxes of the list.</param>
        /// <param name="function">At callback function used for converting each <typeparamref name="TItem"/> item to <see cref="ListItem"/>.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T, TItem>(this T form, string name, string label, IEnumerable<TItem> items, Func<TItem, ListItem> function) where T : Form {
            if (form == null) return null;
            form.Fields.Add(new RadioList(name, label, items?.Select(function)));
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new RadioList(name, label).AddItems<RadioList, TEnum>());
            return form;
        }

        /// <summary>
        /// Appends a new radio list list to <paramref name="form"/>'s list of fields with the values based on <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <typeparam name="TEnum">The type of the enum on which the items for this field should be based.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="defaultValue">An enum value indicating the default value whose corresponding item should be initially checked.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddRadioList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new RadioList(name, label).AddItems(defaultValue));
            return form;
        }

        /// <summary>
        /// Appends a new <c>button</c> button to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the button.</param>
        /// <param name="label">The label of the button.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new Button { Name = name, Label = label });
            return form;
        }

        /// <summary>
        /// Appends a new <c>reset</c> button to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the button.</param>
        /// <param name="label">The label of the button.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddResetButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new ResetButton { Name = name, Label = label });
            return form;
        }

        /// <summary>
        /// Appends a new <c>submit</c> button to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the button.</param>
        /// <param name="label">The label of the button.</param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddSubmitButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new SubmitButton { Name = name, Label = label });
            return form;
        }

        /// <summary>
        /// Adds a new label with the specified <paramref name="name"/> and <paramref name="value"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the label.</param>
        /// <param name="value"></param>
        /// <returns><paramref name="form"/> - which may be used for mehtod chaining.</returns>
        public static T AddLabel<T>(this T form, string name, string value) where T : Form {
            form.Labels[name] = value;
            return form;
        }

    }

}
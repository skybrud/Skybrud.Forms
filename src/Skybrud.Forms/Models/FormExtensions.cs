using System.Diagnostics.CodeAnalysis;
using Skybrud.Forms.Models.Fields;

// ReSharper disable MethodOverloadWithOptionalParameter
// ReSharper disable InconsistentNaming

namespace Skybrud.Forms.Models {

    /// <summary>
    /// Various extension methods for <see cref="Form"/> (and classes extending <see cref="Form"/>).
    /// </summary>
    public static partial class FormExtensions {

        /// <summary>
        /// Sets the title of <paramref name="form"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="title">The new title.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? SetTitle<T>(this T? form, string? title) where T : Form {
            if (form != null) form.Title = title;
            return form;
        }

        /// <summary>
        /// Sets the endpoint URL of <paramref name="form"/>.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="endpointUrl">The new endpoint URL.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? SetEndpointUrl<T>(this T? form, string? endpointUrl) where T : Form {
            if (form != null) form.EndpointUrl = endpointUrl;
            return form;
        }

        /// <summary>
        /// Appends the specified <paramref name="field"/> to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="field">The field to be added.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddField<T>(this T? form, FieldBase field) where T : Form {
            form?.Fields.Add(field);
            return form;
        }

        /// <summary>
        /// Appends a new <c>hidden</c> input field field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddHiddenField<T>(this T? form, string name, object? value, string? id = null) where T : Form {
            form?.Fields.Add(new HiddenField(name, value) { Id = id });
            return form;
        }

        /// <summary>
        /// Appends a new <c>email</c> input field to <paramref name="form"/>'s list of fields.
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
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddEmailField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new EmailField {
                Name = name,
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
        /// Appends a new <c>text</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddTextField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, string? pattern = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new TextField {
                Name = name,
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                Pattern = pattern,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>password</c> input field to <paramref name="form"/>'s list of fields.
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
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddPasswordField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new PasswordField {
                Name = name,
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
        /// Appends a new <c>date</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text to be used for the field.</param>
        /// <param name="value">The initial value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddDateField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new DateField {
                Name = name,
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>&lt;textarea&gt;</c> field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the textarea.</param>
        /// <param name="label">The label of the textarea.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text of the textarea.</param>
        /// <param name="value">The value of the textarea.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the textarea.</param>
        /// <param name="rows">The textarea's height in rows.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddTextarea<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, string? pattern = null, int? size = null, int? rows = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new TextArea {
                Name = name,
                Id = id,
                Value = value,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Pattern = pattern,
                Size = size,
                Rows = rows,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>tel</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddTelField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, string? pattern = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new TelField {
                Name = name,
                Id = id,
                Value = value,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Pattern = pattern,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>tel</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="placeholder">The placeholder text of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="pattern">A regex pattern the value should match.</param>
        /// <param name="min">The value for the input field's <c>min</c> attribute.</param>
        /// <param name="max">The value for the input field's <c>max</c> attribute.</param>
        /// <param name="step">The value for the input field's <c>step</c> attribute.</param>
        /// <param name="size">The size of the input field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number</cref>
        /// </see>
        [return: NotNullIfNotNull("form")]
        public static T? AddNumberField<T>(this T? form, string name, string? label = null, string? description = null, string? placeholder = null, object? value = null, string? id = null, string? pattern = null, int? min = null, int? max = null, int? step = null, int? size = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new NumberField {
                Name = name,
                Id = id,
                Label = label,
                Description = description,
                Placeholder = placeholder,
                Value = value,
                Pattern = pattern,
                Min = min,
                Max = max,
                Step = step,
                Size = size,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>checkbox</c> input field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="description">The description of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="id">The ID of the field.</param>
        /// <param name="required">Whether the field is required.</param>
        /// <param name="disabled">Whether the field is disabled.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/checkbox</cref>
        /// </see>
        [return: NotNullIfNotNull("form")]
        public static T? AddCheckbox<T>(this T? form, string name, string? id = null, string? label = null, string? description = null, object? value = null, bool required = false, bool disabled = false) where T : Form {
            form?.Fields.Add(new Checkbox(name, label) {
                Id = id,
                Label = label,
                Description = description,
                Value = value,
                IsRequired = required,
                IsDisabled = disabled
            });
            return form;
        }

        /// <summary>
        /// Appends a new <c>button</c> button to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="name">The name of the button.</param>
        /// <param name="label">The label of the button.</param>
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddButton<T>(this T? form, string name, string? label) where T : Form {
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
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddResetButton<T>(this T? form, string name, string? label) where T : Form {
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
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddSubmitButton<T>(this T? form, string name, string? label) where T : Form {
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
        /// <returns><paramref name="form"/> - which may be used for method chaining.</returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddLabel<T>(this T? form, string name, string? value) where T : Form {
            if (form is null) return null;
            if (value is null) {
                form.Labels.Remove(name);
            } else {
                form.Labels[name] = value;
            }
            return form;
        }

        /// <summary>
        /// Appends a new <c>caption</c> field to <paramref name="form"/>'s list of fields.
        /// </summary>
        /// <typeparam name="T">The type of the form.</typeparam>
        /// <param name="form">The form.</param>
        /// <param name="title">The title of the caption field.</param>
        /// <param name="description">The description of the caption field.</param>
        /// <returns></returns>
        [return: NotNullIfNotNull("form")]
        public static T? AddCaption<T>(this T? form, string? title = null, string? description = null) where T : Form {
            form?.Fields.Add(new Caption(title, description));
            return form;
        }

    }

}
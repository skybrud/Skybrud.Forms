using System;
using System.Collections.Generic;
using Skybrud.Forms.Models.Fields;

// ReSharper disable InconsistentNaming

namespace Skybrud.Forms.Models {
    
    /// <summary>
    /// Various extension methos for <see cref="Form"/> (and classes extending <see cref="Form"/>).
    /// </summary>
    public static class FormExtensions {

        public static T SetTitle<T>(this T form, string title) where T : Form {
            if (form != null) form.Title = title;
            return form;
        }

        public static T SetUrl<T>(this T form, string url) where T : Form {
            if (form != null) form.Url = url;
            return form;
        }

        public static T SetEndpointUrl<T>(this T form, string endpointUrl) where T : Form {
            if (form != null) form.EndpointUrl = endpointUrl;
            return form;
        }

        public static T AddField<T>(this T form, FieldBase field) where T : Form {
            form?.Fields.Add(field);
            return form;
        }

        public static T AddField<T>(this T form, string type, string name, object value) where T : Form {
            form?.Fields.Add(new FieldBase(type, name, value));
            return form;
        }

        public static T AddHiddenField<T>(this T form, string name, object value) where T : Form {
            form?.Fields.Add(new HiddenField(name, value));
            return form;
        }

        public static T AddEmailField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, bool required = false) where T : Form {
            form?.Fields.Add(new EmailField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                IsRequired = required
            });
            return form;
        }

        public static T AddTextField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false) where T : Form {
            form?.Fields.Add(new TextField {
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

        public static T AddTextarea<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false) where T : Form {
            form?.Fields.Add(new TextArea {
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

        public static T AddTelField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, bool required = false) where T : Form {
            form?.Fields.Add(new TelField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                IsRequired = required
            });
            return form;
        }

        public static T AddNumberField<T>(this T form, string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? min = null, int? max = null, int? size = null, bool required = false) where T : Form {
            form?.Fields.Add(new NumberField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Min = min,
                Max = max,
                Size = size,
                IsRequired = required
            });
            return form;
        }

        public static T AddCheckbox<T>(this T form, string name, string value = null, string label = null, bool required = false, string description = null) where T : Form {
            form?.Fields.Add(new Checkbox(name, value) {
                Label = label,
                IsRequired = required,
                Description = description
            });
            return form;
        }

        public static T AddCheckboxList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, items));
            return form;
        }

        public static T AddCheckboxList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, items));
            return form;
        }

        public static T AddCheckboxList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, label, items));
            return form;
        }

        public static T AddCheckboxList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new CheckboxList(name, label, items));
            return form;
        }

        public static T AddCheckboxList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new CheckboxList(name, label).AddItems<CheckboxList, TEnum>());
            return form;
        }

        public static T AddCheckboxList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new CheckboxList(name, label).AddItems(defaultValue));
            return form;
        }

        public static T AddDropDownList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new DropDownList(name, items));
            return form;
        }

        public static T AddDropDownList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new DropDownList(name, items));
            return form;
        }

        public static T AddDropDownList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new DropDownList(name, label, items));
            return form;
        }

        public static T AddDropDownList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new DropDownList(name, label, items));
            return form;
        }

        public static T AddDropDownList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new DropDownList(name, label).AddItems<DropDownList, TEnum>());
            return form;
        }

        public static T AddDropDownList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new DropDownList(name, label).AddItems(defaultValue));
            return form;
        }

        public static T AddRadioList<T>(this T form, string name, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new RadioList(name, items));
            return form;
        }

        public static T AddRadioList<T>(this T form, string name, params ListItem[] items) where T : Form {
            form?.Fields.Add(new RadioList(name, items));
            return form;
        }

        public static T AddRadioList<T>(this T form, string name, string label, IEnumerable<ListItem> items) where T : Form {
            form?.Fields.Add(new RadioList(name, label, items));
            return form;
        }

        public static T AddRadioList<T>(this T form, string name, string label, params ListItem[] items) where T : Form {
            form?.Fields.Add(new RadioList(name, label, items));
            return form;
        }

        public static T AddRadioList<T, TEnum>(this T form, string name, string label) where T : Form where TEnum : Enum {
            form?.Fields.Add(new RadioList(name, label).AddItems<RadioList, TEnum>());
            return form;
        }

        public static T AddRadioList<T, TEnum>(this T form, string name, string label, TEnum defaultValue) where T : Form where TEnum : Enum {
            form?.Fields.Add(new RadioList(name, label).AddItems(defaultValue));
            return form;
        }

        public static T AddButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new Button { Name = name, Label = label });
            return form;
        }

        public static T AddResetButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new ResetButton { Name = name, Label = label });
            return form;
        }

        public static T AddSubmitButton<T>(this T form, string name, string label) where T : Form {
            form?.Fields.Add(new SubmitButton { Name = name, Label = label });
            return form;
        }

    }

}
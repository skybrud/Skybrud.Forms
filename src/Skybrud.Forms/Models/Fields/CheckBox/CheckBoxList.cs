using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Forms.Models.Fields.CheckBox {

    public class CheckBoxList : FieldBase {

        protected const string FieldType = "checkboxList";

        #region Properties

        [JsonProperty("value", Order = 500)]
        public new List<CheckBoxListItem> Value { get; set; }

        #endregion

        #region Constructors

        public CheckBoxList() : base(FieldType, null) {
            Value = new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, string label = null, bool required = false) : base(FieldType, name) {
            IsRequired = required;
            Label = label;
            Value = new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, IEnumerable<CheckBoxListItem> value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, params CheckBoxListItem[] value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, string label) : base(FieldType, name) {
            Label = label;
            Value = new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, string label, IEnumerable<CheckBoxListItem> value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<CheckBoxListItem>();
        }

        public CheckBoxList(string name, string label, params CheckBoxListItem[] value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<CheckBoxListItem>();
        }

        #endregion

        #region Member methods

        public CheckBoxList AddValue(string value, string label) {
            Value.Add(new CheckBoxListItem(value, label));
            return this;
        }

        #endregion

        #region Static methods

        public static CheckBoxList CreateFromEnum<T>(string name, string label) where T : Enum {
            return CreateFromEnum<T>(name, label, default);
        }

        public static CheckBoxList CreateFromEnum<T>(string name, string label, T defaultValue) where T : Enum {

            List<CheckBoxListItem> values = new List<CheckBoxListItem>();

            foreach (T value in (T[]) Enum.GetValues(typeof(T))) {

                string valueName = value.ToString();

                if (value.HasCustomAttribute(out DescriptionAttribute result)) {
                    valueName = result.Description;
                }

                values.Add(new CheckBoxListItem(value.ToCamelCase(), valueName, Equals(value, defaultValue)));

            }

            return new CheckBoxList(name, label, values);

        }

        #endregion

    }

}
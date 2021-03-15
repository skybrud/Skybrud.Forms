using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Forms.Models.Fields.Radio {

    public class RadioList : FieldBase {

        protected const string FieldType = "radioList";

        #region Properties

        [JsonProperty("value", Order = 500)]
        public new List<RadioListItem> Value { get; set; }

        #endregion

        #region Constructors

        public RadioList() : base(FieldType, null) {
            Value = new List<RadioListItem>();
        }

        public RadioList(string name) : base(FieldType, name) {
            Value = new List<RadioListItem>();
        }

        public RadioList(string name, IEnumerable<RadioListItem> value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<RadioListItem>();
        }

        public RadioList(string name, params RadioListItem[] value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<RadioListItem>();
        }

        public RadioList(string name, string label) : base(FieldType, name) {
            Label = label;
            Value = new List<RadioListItem>();
        }

        public RadioList(string name, string label, IEnumerable<RadioListItem> value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<RadioListItem>();
        }

        public RadioList(string name, string label, params RadioListItem[] value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<RadioListItem>();
        }

        #endregion

        #region Static methods

        public static RadioList CreateFromEnum<T>(string name, string label) where T : Enum {
            return CreateFromEnum<T>(name, label, default);
        }

        public static RadioList CreateFromEnum<T>(string name, string label, T defaultValue) where T : Enum {

            List<RadioListItem> values = new List<RadioListItem>();

            foreach (T value in (T[]) Enum.GetValues(typeof(T))) {

                string valueName = value.ToString();

                if (value.HasCustomAttribute(out DescriptionAttribute result)) {
                    valueName = result.Description;
                }

                values.Add(new RadioListItem(value.ToCamelCase(), valueName, Equals(value, defaultValue)));

            }

            return new RadioList(name, label, values);

        }

        #endregion

    }

}
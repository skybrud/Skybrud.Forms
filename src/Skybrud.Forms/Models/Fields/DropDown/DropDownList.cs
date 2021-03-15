using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Forms.Models.Fields.DropDown {

    public class DropDownList : FieldBase {

        protected const string FieldType = "dropdown";

        #region Properties

        [JsonProperty("value", Order = 500)]
        public new List<DropDownItem> Value { get; set; }

        #endregion

        #region Constructors

        public DropDownList() : base(FieldType, null) {
            Value = new List<DropDownItem>();
        }

        public DropDownList(string name) : base(FieldType, name) {
            Value = new List<DropDownItem>();
        }

        public DropDownList(string name, IEnumerable<DropDownItem> value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<DropDownItem>();
        }

        public DropDownList(string name, params DropDownItem[] value) : base(FieldType, name) {
            Value = value?.ToList() ?? new List<DropDownItem>();
        }

        public DropDownList(string name, string label) : base(FieldType, name) {
            Label = label;
            Value = new List<DropDownItem>();
        }

        public DropDownList(string name, string label, IEnumerable<DropDownItem> value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<DropDownItem>();
        }

        public DropDownList(string name, string label, params DropDownItem[] value) : base(FieldType, name) {
            Label = label;
            Value = value?.ToList() ?? new List<DropDownItem>();
        }

        #endregion

        #region Static methods

        public static DropDownList CreateFromEnum<T>(string name, string label) where T : Enum {
            return CreateFromEnum<T>(name, label, default);
        }

        public static DropDownList CreateFromEnum<T>(string name, string label, T defaultValue) where T : Enum {

            List<DropDownItem> values = new List<DropDownItem>();

            foreach (T value in (T[]) Enum.GetValues(typeof(T))) {

                string valueName = value.ToString();

                if (value.HasCustomAttribute(out DescriptionAttribute result)) {
                    valueName = result.Description;
                }

                values.Add(new DropDownItem(value.ToCamelCase(), valueName, Equals(value, defaultValue)));

            }

            return new DropDownList(name, label, values);

        }

        #endregion

    }

}
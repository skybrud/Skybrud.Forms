using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {

    public class CheckBoxListTemp : ListBase {

        protected const string FieldType = "checkboxList";

        #region Constructors

        public CheckBoxListTemp() : base(FieldType) { }

        public CheckBoxListTemp(string name) : base(FieldType, name) { }

        public CheckBoxListTemp(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        public CheckBoxListTemp(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        public CheckBoxListTemp(string name, string label) : base(FieldType, name, label) { }

        public CheckBoxListTemp(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        public CheckBoxListTemp(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
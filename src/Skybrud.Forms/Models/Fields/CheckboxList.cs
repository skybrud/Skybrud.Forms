using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {

    public class CheckboxList : ListBase {

        protected const string FieldType = "checkboxList";

        #region Constructors

        public CheckboxList() : base(FieldType) { }

        public CheckboxList(string name) : base(FieldType, name) { }

        public CheckboxList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        public CheckboxList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        public CheckboxList(string name, string label) : base(FieldType, name, label) { }

        public CheckboxList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        public CheckboxList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
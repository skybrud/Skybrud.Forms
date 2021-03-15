using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {

    public class CheckBoxList : ListBase {

        protected const string FieldType = "checkboxList";

        #region Constructors

        public CheckBoxList() : base(FieldType) { }

        public CheckBoxList(string name) : base(FieldType, name) { }

        public CheckBoxList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        public CheckBoxList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        public CheckBoxList(string name, string label) : base(FieldType, name, label) { }

        public CheckBoxList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        public CheckBoxList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
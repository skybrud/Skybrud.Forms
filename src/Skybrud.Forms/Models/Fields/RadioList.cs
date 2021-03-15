using System.Collections.Generic;

namespace Skybrud.Forms.Models.Fields {

    public class RadioList : ListBase {

        protected const string FieldType = "radioList";

        #region Constructors

        public RadioList() : base(FieldType) { }

        public RadioList(string name) : base(FieldType, name) { }

        public RadioList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        public RadioList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        public RadioList(string name, string label) : base(FieldType, name, label) { }

        public RadioList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        public RadioList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
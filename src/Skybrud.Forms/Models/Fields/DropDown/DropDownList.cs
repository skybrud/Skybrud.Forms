using System.Collections.Generic;
using Skybrud.Forms.Models.Fields.Lists;

namespace Skybrud.Forms.Models.Fields.DropDown {

    public class DropDownList : ListBase {

        protected const string FieldType = "dropdown";

        #region Constructors

        public DropDownList() : base(FieldType) { }

        public DropDownList(string name) : base(FieldType, name) { }

        public DropDownList(string name, IEnumerable<ListItem> items) : base(FieldType, name, null, items) { }

        public DropDownList(string name, params ListItem[] items) : base(FieldType, name, null, items) { }

        public DropDownList(string name, string label) : base(FieldType, name, label) { }

        public DropDownList(string name, string label, IEnumerable<ListItem> items) : base(FieldType, name, label, items) { }

        public DropDownList(string name, string label, params ListItem[] items) : base(FieldType, name, label, items) { }

        #endregion

    }

}
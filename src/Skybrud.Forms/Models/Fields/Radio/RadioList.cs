using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Forms.Models.Fields.Lists;

namespace Skybrud.Forms.Models.Fields.Radio {

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
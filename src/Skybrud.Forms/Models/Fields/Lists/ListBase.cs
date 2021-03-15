using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields.Lists {

    public abstract class ListBase : FieldBase {

        #region Properties

        [JsonProperty("items", Order = 510)]
        public List<ListItem> Items { get; set; }

        #endregion

        #region Constructors

        protected ListBase(string type) : base(type, null) {
            Items = new List<ListItem>();
        }

        protected ListBase(string type, string name) : base(type, name) {
            Items = new List<ListItem>();
        }

        protected ListBase(string type, string name, string label) : base(type, name) {
            Label = label;
            Items = new List<ListItem>();
        }

        protected ListBase(string type, string name, string label, IEnumerable<ListItem> items) : base(type, name) {
            Label = label;
            Items = items?.ToList() ?? new List<ListItem>();
        }

        protected ListBase(string type, string name, string label, params ListItem[] items) : base(type, name) {
            Label = label;
            Items = items?.ToList() ?? new List<ListItem>();
        }

        protected ListBase(string type, string name, Enum defaultItem) : base(type, name) {
            
            Items = new List<ListItem>();

            foreach (Enum value in Enum.GetValues(defaultItem.GetType())) {
                Items.Add(new ListItem(value, Equals(value, defaultItem)));
            }

        }

        #endregion

    }

}
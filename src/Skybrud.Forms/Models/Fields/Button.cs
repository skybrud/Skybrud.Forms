namespace Skybrud.Forms.Models.Fields {

    public class Button : ButtonBase {

        protected const string FieldType = "button";

        #region Constructors

        public Button() : base(FieldType) { }

        public Button(string name, string label) : base(FieldType, name, label) { }

        #endregion

    }

}
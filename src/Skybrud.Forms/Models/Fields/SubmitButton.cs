namespace Skybrud.Forms.Models.Fields {

    public class SubmitButton : ButtonBase {

        protected const string FieldType = "button";

        #region Constructors

        public SubmitButton() : base(FieldType) { }

        public SubmitButton(string name, string label) : base(FieldType, name, label) { }

        #endregion

    }

}
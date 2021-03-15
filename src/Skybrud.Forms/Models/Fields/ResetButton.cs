namespace Skybrud.Forms.Models.Fields {

    public class ResetButton : ButtonBase {

        protected const string FieldType = "reset";

        #region Constructors

        public ResetButton() : base(FieldType) { }

        public ResetButton(string name, string label) : base(FieldType, name, label) { }

        #endregion

    }

}
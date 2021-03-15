namespace Skybrud.Forms.Models.Fields {

    public abstract class ButtonBase : FieldBase {

        #region Constructors

        protected ButtonBase(string type) : base(type, null, null) { }

        protected ButtonBase(string type, string name, string label) : base(type, name, label) { }

        #endregion

    }

}
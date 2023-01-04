using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a caption style field with a title and/or description.
    /// </summary>
    public class Caption : FieldBase {

        /// <summary>
        /// Gets the type of buttons based on <see cref="Caption"/>.
        /// </summary>
        protected const string FieldType = "caption";

        #region Properties

        /// <summary>
        /// GHets or sets the title.
        /// </summary>
        [JsonProperty("title", Order = -301)]
        public string? Title { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public Caption() : base(FieldType) { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="title"/>.
        /// </summary>
        /// <param name="title">The title.</param>
        public Caption(string? title) : base(FieldType) {
            Title = title;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="title"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public Caption(string? title, string? description) : base(FieldType) {
            Title = title;
            Description = description;
        }

        #endregion

    }

}
using System;

// ReSharper disable InconsistentNaming

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Static class with various generic extension methods for <see cref="ListBase"/>.
    /// </summary>
    public static class ListExtensions {

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, int value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, int value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, Guid value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, Guid value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, string value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        /// <summary>
        /// Appends a new item with the specified <paramref name="value"/> and <paramref name="label"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The value of the item.</param>
        /// <param name="label">The label of the item.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, string value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        /// <summary>
        /// Appends a new item based on the specified enum <paramref name="value"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The enum value.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, Enum value) where T : ListBase {
            list?.Items.Add(new ListItem(value));
            return list;
        }

        /// <summary>
        /// Appends a new item based on the specified enum <paramref name="value"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="value">The enum value.</param>
        /// <param name="isChecked">Whether the item should initially be checked/selected.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItem<T>(this T list, Enum value, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, isChecked));
            return list;
        }

        /// <summary>
        /// Appends the items representing the fields of <typeparamref name="TEnum"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItems<T, TEnum>(this T list) where T : ListBase where TEnum : Enum {

            if (list == null) return null;

            foreach (TEnum value in (TEnum[]) Enum.GetValues(typeof(TEnum))) {
                list.Items.Add(new ListItem(value));

            }

            return list;

        }

        /// <summary>
        /// Appends the items representing the fields of <typeparamref name="TEnum"/> to <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="list">The list to which the item should be added.</param>
        /// <param name="defaultValue">Indicates the default value where the corresponding should be checked/selected.</param>
        /// <returns><paramref name="list"/> - which may be used for mehtod chaining.</returns>
        public static T AddItems<T, TEnum>(this T list, TEnum defaultValue) where T : ListBase where TEnum : Enum {

            if (list == null) return null;

            foreach (TEnum value in (TEnum[]) Enum.GetValues(typeof(TEnum))) {
                list.Items.Add(new ListItem(value, Equals(value, defaultValue)));

            }

            return list;

        }

        /// <summary>
        /// Sets the placeholder text of the specified <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="placeholder">The placeholder text.</param>
        /// <returns><paramref name="list"/> - which may be used for method chaining.</returns>
        public static T SetPlaceholder<T>(this T list, string placeholder) where T : ListBase {
            if (list is null) return null;
            list.Placeholder = placeholder;
            return list;
        }

        /// <summary>
        /// Appends <paramref name="list"/> to <paramref name="form"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="form">The form.</param>
        /// <returns><paramref name="list"/> - which may be used for method chaining.</returns>
        public static T AppendTo<T>(this T list, Form form) where T : ListBase {
            if (list is null) return null;
            form.Fields.Add(list);
            return list;
        }

    }

}
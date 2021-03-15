using System;

namespace Skybrud.Forms.Models.Fields.Lists {
    
    public static class ListExtensions {

        public static T AddItem<T>(this T list, int value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        public static T AddItem<T>(this T list, int value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        public static T AddItem<T>(this T list, Guid value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        public static T AddItem<T>(this T list, Guid value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        public static T AddItem<T>(this T list, string value, string label) where T : ListBase {
            list?.Items.Add(new ListItem(value, label));
            return list;
        }

        public static T AddItem<T>(this T list, string value, string label, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, label, isChecked));
            return list;
        }

        public static T AddItem<T>(this T list, Enum value) where T : ListBase {
            list?.Items.Add(new ListItem(value));
            return list;
        }

        public static T AddItem<T>(this T list, Enum value, bool isChecked) where T : ListBase {
            list?.Items.Add(new ListItem(value, isChecked));
            return list;
        }

        public static T AddItems<T, TEnum>(this T list) where T : ListBase where TEnum : Enum {

            if (list == null) return null;

            foreach (TEnum value in (TEnum[]) Enum.GetValues(typeof(TEnum))) {
                list.Items.Add(new ListItem(value));

            }

            return list;

        }

        public static T AddItems<T, TEnum>(this T list, TEnum defaultValue) where T : ListBase where TEnum : Enum {

            if (list == null) return null;

            foreach (TEnum value in (TEnum[])Enum.GetValues(typeof(TEnum))) {
                list.Items.Add(new ListItem(value, Equals(value, defaultValue)));

            }

            return list;

        }

    }

}
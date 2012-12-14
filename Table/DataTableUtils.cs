using System;
using System.Data;
using System.Collections;

namespace FunTest.Table
{
    /// <summary>
    /// Summary description for DataTableUtils.
    /// </summary>
    public class DataTableUtils
    {
        public static string PrimaryColumnProperty = "__IsPartOfPrimaryKeySet";
        public static string AllowDBNullProperty = "__AllowDBNull";
        public static string CompressedProperty = "__IsCompressed";
        public static string SpecialColumnProperty = "__SpecialColumn";
        public static string RecordMappingColumnName = "__RecordMapping";
        public static string BelongsToSameInvestmentIdGroupProperty = "__BelongsToSameInvestmentIdGroup";

        public static DataColumn GetColumn(string name, Type tType)
        {
            return GetColumn(name, tType, true);
        }

        public static DataColumn GetColumn(string name, Type tType, bool allowDBNull)
        {
            return GetColumn(name, tType, allowDBNull, false);
        }

        public static DataColumn GetColumn(string name, Type tType, bool allowDBNull, bool isPartOfPrimaryKeySet)
        {
            var column = new DataColumn(name, tType);
            column.ExtendedProperties[AllowDBNullProperty] = allowDBNull;
            column.ExtendedProperties[PrimaryColumnProperty] = isPartOfPrimaryKeySet;
            return column;
        }

        public static DataColumn GetColumn(string name, Type tType, bool allowDBNull, bool isPartOfPrimaryKeySet, bool belongsToSameInvestmentIdGroup)
        {
            var column = GetColumn(name, tType, allowDBNull, isPartOfPrimaryKeySet);
            column.ExtendedProperties[BelongsToSameInvestmentIdGroupProperty] = belongsToSameInvestmentIdGroup;
            return column;
        }

        public static DataColumn GetCompressedColumn(string name)
        {
            var column = GetColumn(name, typeof(string));
            column.ExtendedProperties[CompressedProperty] = true;
            return column;
        }

        public static bool IsCompressed(DataColumn column)
        {
            object obj = column.ExtendedProperties[CompressedProperty];
            return obj != null && obj.ToString().ToLower() == "true";
        }

        public static bool IsSpecialColumn(DataColumn column)
        {
            return DataColumnHasExtendedProperty(column, SpecialColumnProperty, true, BooleanComparator);
        }

        public static bool IsPartOfPrimaryColumn(DataColumn column)
        {
            return DataColumnHasExtendedProperty(column, PrimaryColumnProperty, true, BooleanComparator);
        }

        public static bool AllowDBNull(DataColumn column)
        {
            return column.ExtendedProperties[AllowDBNullProperty] != null && ((bool)column.ExtendedProperties[AllowDBNullProperty]);
        }

        public static DataColumn[] GetPrimaryKeyColumns(DataColumn[] columns)
        {
            return GetColumnsWithExtendedPropertyValue(columns, PrimaryColumnProperty, true, BooleanComparator);
        }

        public static DataColumn[] GetPrimaryKeyColumns(DataColumnCollection columns)
        {
            var cols = new DataColumn[columns.Count];
            columns.CopyTo(cols, 0);
            return GetColumnsWithExtendedPropertyValue(cols, PrimaryColumnProperty, true, BooleanComparator);
        }

        public static bool DataColumnHasExtendedProperty(DataColumn column, string propertyName, object propertyValue)
        {
            var obj = column.ExtendedProperties[propertyName];
            return obj != null && obj == propertyValue;
        }

        public static bool DataColumnHasExtendedProperty(DataColumn column, string propertyName, object propertyValue,
            ColumnPropertyComparer comparer)
        {
            var obj = column.ExtendedProperties[propertyName];
            return obj != null && comparer(obj, propertyValue);
        }

        public static DataColumn[] GetColumnsWithExtendedPropertyValue(DataColumn[] columns, string propertyName,
            object propertyValue, ColumnPropertyComparer comparer)
        {
            var list = new ArrayList();
            foreach (var t in columns)
            {
                var currentValue = t.ExtendedProperties[propertyName];
                if (currentValue == null) continue;
                if (comparer(propertyValue, currentValue))
                    list.Add(t);
            }
            var cols = new DataColumn[list.Count];
            for (var i = 0; i < cols.Length; i++) cols[i] = list[i] as DataColumn;
            return cols;
        }

        public static ColumnPropertyComparer BooleanComparator = BooleanComparatorFunction;
        private static bool BooleanComparatorFunction(object a, object b)
        {
            return (bool)a == (bool)b;
        }

        public delegate bool ColumnPropertyComparer(object a, object b);
    }

}

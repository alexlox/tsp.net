using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    /**
     * <summary>Filter by the properties of an object.</summary>
     */
    public class Filter
    {
        public readonly static string EQ = "==";
        public readonly static string LE = "<=";
        public readonly static string GE = ">=";
        public readonly static string NE = "!=";
        public readonly static string BT = "><";
        public readonly static string CA = "%%";

        string property;
        string operation;
        object value1;
        object value2;

        /**
         * <summary>Constructor.</summary>
         * <param name="property">Property of the object.</param>
         * <param name="operation">Available operation ar static attributes for this class.</param>
         * <param name="value1">Value to be filtered by.</param>
         * <param name="value2">Value to be filtered by.</param>
         * <exception cref="NotImplementedException">Invalid operation or value type. Use the static attributes for operation.</exception>
         */
        public Filter(string property, string operation, object value1, object value2)
        {
            if (operation != Filter.EQ &&
                operation != Filter.LE &&
                operation != Filter.GE &&
                operation != Filter.NE &&
                operation != Filter.BT &&
                operation != Filter.CA)
            {
                throw new NotImplementedException("Invalid operation.");
            }

            if (!(value1 is string ||
                value1 is int ||
                value1 is DateTime ||
                value1 is float ||
                value1 is double ||
                value1 is bool))
            {
                throw new NotImplementedException("Invalid value type.");
            }

            if (!(value2 is string ||
                value2 is int ||
                value2 is DateTime ||
                value2 is float ||
                value2 is double ||
                value2 is bool))
            {
                throw new NotImplementedException("Invalid value type.");
            }

            this.property = property;
            this.operation = operation;
            this.value1 = value1;
            this.value2 = value2;
        }
    }
}

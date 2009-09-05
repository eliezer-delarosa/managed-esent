﻿//-----------------------------------------------------------------------
// <copyright file="Copy.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Microsoft.Isam.Esent.Collections.Generic
{
    /// <summary>
    /// Provides generic copy methods.
    /// </summary>
    internal static class Copy
    {
        /// <summary>
        /// Compare two objects to determine if they are equal.
        /// </summary>
        /// <typeparam name="T">The type to compare.</typeparam>
        /// <param name="items">The items to copy.</param>
        /// <param name="array">The index to copy into.</param>
        /// <param name="arrayIndex">The location in the index to start copying into.</param>
        public static void CopyTo<T>(ICollection<T> items, T[] array, int arrayIndex)
        {
            if (null == items)
            {
                throw new ArgumentNullException("items");
            }

            if (null == array)
            {
                throw new ArgumentNullException("array");
            }

            if (arrayIndex < 0 || arrayIndex >= array.Length)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, "not inside array");
            }

            if (checked(array.Length - arrayIndex) > items.Count)
            {
                throw new ArgumentOutOfRangeException("array", array.Length, "array is not long enough");
            }                

            int i = arrayIndex;
            foreach (T t in items)
            {
                array[i++] = t;
            }
        }
    }
}
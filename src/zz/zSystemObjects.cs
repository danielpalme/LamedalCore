﻿using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;

namespace LamedalCore.zz
{
    /// <summary>
    /// Shortcuts on object class
    /// </summary>
    [BlueprintRule_Class(enBlueprintClassNetworkType.Transformation_Extention)]
    [Test_IgnoreCoverage(enTestIgnore.MethodIsShortCut)]
    public static class zSystemObjects
    {
        /// <summary>
        /// Work on sender object to convert to other class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <returns></returns>
        public static zSystemObjects_Extender zObject(this object sender)
        {
            return new zSystemObjects_Extender(sender);
        }

        ///// <summary>
        ///// Work on sender object to convert to other class.
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="variable">The parameter.</param>
        ///// <returns></returns>
        //public static zSystemObjects_ExtenderList<T> zFind<T>(this T variable)
        //{
        //    return new zSystemObjects_ExtenderList<T>(variable);
        //}
        //

    }
}

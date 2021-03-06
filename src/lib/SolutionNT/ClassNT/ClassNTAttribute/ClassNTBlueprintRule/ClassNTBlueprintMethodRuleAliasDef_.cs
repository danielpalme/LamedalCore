﻿using System;
using System.Collections.Generic;
using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;
using LamedalCore.zz;

namespace LamedalCore.lib.SolutionNT.ClassNT.ClassNTAttribute.ClassNTBlueprintRule
{
    [BlueprintRule_Class(enBlueprintClassNetworkType.Node_State)]
    public sealed class ClassNTBlueprintMethodRuleAliasDef_ : BlueprintRule_MethodAliasDefAttribute
    {
        public static ClassNTBlueprintMethodRuleAliasDef_ Create(string attributeCode)
        {
            var result = new ClassNTBlueprintMethodRuleAliasDef_(); 
            // Execute static method to populate result parameters
            string attrinuteName;
            string mirrorClass;
            ClassNTBlueprintMethodRuleAliasDef_Methods.Attribute_AliasDefinition(attributeCode, out attrinuteName, out result.MirrorParameter1, out mirrorClass, out result.MirrorMethodName);
            result.MirrorClass = Type.GetType(mirrorClass);  // If type cannot be found -> do other conversions here
            return result;
        }

        public static ClassNTBlueprintMethodRuleAliasDef_ Create(List<string> attributeLines)
        {
            foreach (string attLine in attributeLines)
            {
                if (BlueprintMethodAliasRuleIsIn(attLine)) return Create(attLine);
            }
            return null;
        }

        /// <summary>Identifies a Blueprint method rule.</summary>
        /// <param name="codeLine">The code line to be tested</param>
        /// <returns></returns>
        private static bool BlueprintMethodAliasRuleIsIn(string codeLine)
        {
            if (_BlueprintMethodAliasRule1 == null)
            {
                _BlueprintMethodAliasRule1 = typeof(BlueprintRule_MethodAliasDefAttribute).Name;
                _BlueprintMethodAliasRule2 = _BlueprintMethodAliasRule1.Replace("Attribute", "");
            }
            return codeLine.zContains_Any(_BlueprintMethodAliasRule1,_BlueprintMethodAliasRule2);
        }
        private static string _BlueprintMethodAliasRule1 = null;
        private static string _BlueprintMethodAliasRule2 = null;


        private ClassNTBlueprintMethodRuleAliasDef_() { }  // Hide default constructor
    }
}

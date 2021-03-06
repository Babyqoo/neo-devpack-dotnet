﻿using System;

namespace Neo.SmartContract.Framework
{
    public enum ConvertMethod
    {
        HexToBytes,
        ToScriptHash,
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class NonemitWithConvertAttribute : Attribute
    {
        public ConvertMethod Method { get; }

        public NonemitWithConvertAttribute(ConvertMethod method)
        {
            this.Method = method;
        }
    }
}

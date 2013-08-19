﻿using System;
using ExCSS.Model.Factories;

// ReSharper disable CheckNamespace
namespace ExCSS
// ReSharper restore CheckNamespace
{
    public class StyleRule : RuleSet
    {
        private string _value;
        private SimpleSelector _selector;
        private readonly StyleDeclaration _declarations;

        public StyleRule() : this(null)
        {
            
        }

        internal StyleRule(StyleSheet context) : base(context)
        {
            RuleType = RuleType.Style;
            _declarations = new StyleDeclaration();
        }

        public SimpleSelector Selector
        {
            get { return _selector; }
            set
            {
                _selector = value;
                _value = value.ToString();
            }
        }

        public string Value
        {
            get { return _value; }
            set
            {
                _selector = RuleFactory.ParseSelector(value);
                _value = value;
            }
        }

        public StyleDeclaration Declarations
        {
            get { return _declarations; }
        }

        public override string ToString()
        {
            return _value + " {" + Environment.NewLine + _declarations + "}";
        }
    }
}

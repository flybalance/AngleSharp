﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/page-break-inside
    /// Gets the selected break mode.
    /// </summary>
    sealed class CssPageBreakInsideProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<BreakMode> Converter = 
            Converters.Assign(Keywords.Auto, BreakMode.Auto).Or(Keywords.Avoid, BreakMode.Avoid);

        #endregion

        #region ctor

        internal CssPageBreakInsideProperty()
            : base(PropertyNames.PageBreakInside)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return BreakMode.Auto;
        }

        protected override Object Compute(IElement element)
        {
            return Converter.Convert(Value);
        }

        protected override Boolean IsValid(CssValue value)
        {
            return Converter.Validate(value);
        }

        #endregion
    }
}

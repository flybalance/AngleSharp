﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/clear
    /// Gets the value of the clear mode.
    /// </summary>
    sealed class CssClearProperty : CssProperty
    {
        #region ctor

        internal CssClearProperty()
            : base(PropertyNames.Clear)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return ClearMode.None;
        }

        protected override Object Compute(IElement element)
        {
            return Converters.ClearModeConverter.Convert(Value);
        }

        protected override Boolean IsValid(CssValue value)
        {
            return Converters.ClearModeConverter.Validate(value);
        }

        #endregion
    }
}

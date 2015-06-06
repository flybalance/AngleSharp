﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/CSS/transition-timing-function
    /// Gets the enumeration over all timing functions.
    /// </summary>
    sealed class CssTransitionTimingFunctionProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<ITimingFunction[]> Converter =
            Converters.TransitionConverter.FromList();

        #endregion

        #region ctor

        internal CssTransitionTimingFunctionProperty()
            : base(PropertyNames.TransitionTimingFunction)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return Map.TimingFunctions[Keywords.Ease];
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

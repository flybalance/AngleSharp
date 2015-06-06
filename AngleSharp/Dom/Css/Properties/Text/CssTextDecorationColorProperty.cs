﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More Information:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/text-decoration-color
    /// Gets the selected text-decoration color.
    /// </summary>
    sealed class CssTextDecorationColorProperty : CssProperty
    {
        #region ctor

        internal CssTextDecorationColorProperty()
            : base(PropertyNames.TextDecorationColor, PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return Color.Black;
        }

        protected override Object Compute(IElement element)
        {
            return Converters.ColorConverter.Convert(Value);
        }

        protected override Boolean IsValid(CssValue value)
        {
            return Converters.ColorConverter.Validate(value);
        }

        #endregion
    }
}

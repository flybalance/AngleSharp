﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/background-position
    /// Gets the list of all given positions.
    /// </summary>
    sealed class CssBackgroundPositionProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<Point[]> Converter = 
            Converters.PointConverter.FromList();

        #endregion

        #region ctor

        internal CssBackgroundPositionProperty()
            : base(PropertyNames.BackgroundPosition, PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return Point.Center;
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

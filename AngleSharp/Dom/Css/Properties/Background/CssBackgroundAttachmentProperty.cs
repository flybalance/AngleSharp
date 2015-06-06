﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/background-attachment
    /// Gets an enumeration with the desired attachment settings.
    /// </summary>
    sealed class CssBackgroundAttachmentProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<BackgroundAttachment[]> Converter =
            Converters.BackgroundAttachmentConverter.FromList();

        #endregion

        #region ctor

        internal CssBackgroundAttachmentProperty()
            : base(PropertyNames.BackgroundAttachment)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return BackgroundAttachment.Scroll;
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

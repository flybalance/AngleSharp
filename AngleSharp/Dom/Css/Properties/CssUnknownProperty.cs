﻿namespace AngleSharp.Dom.Css
{
    using System;

    /// <summary>
    /// Represents an unknown property that takes every value.
    /// </summary>
    sealed class CssUnknownProperty : CssProperty
    {
        #region ctor

        internal CssUnknownProperty(String name)
            : base(name)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return null;
        }

        protected override Object Compute(IElement element)
        {
            return null;
        }

        protected override Boolean IsValid(CssValue value)
        {
            return true;
        }

        #endregion
    }
}

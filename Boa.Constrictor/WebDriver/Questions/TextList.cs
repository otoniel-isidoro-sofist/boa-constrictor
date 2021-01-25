﻿using OpenQA.Selenium;
using System;

namespace Boa.Constrictor.WebDriver
{
    /// <summary>
    /// Gets a list of Web elements' text values.
    /// </summary>
    public class TextList : AbstractWebLocatorListQuestion
    {
        #region Constructors

        /// <summary>
        /// Private constructor.
        /// (Use static methods for public construction.)
        /// </summary>
        /// <param name="locator">The target Web element's locator.</param>
        private TextList(IWebLocator locator) : base(locator) { }

        #endregion

        #region Properties

        /// <summary>
        /// Retrieves the Web element's text.
        /// </summary>
        protected override Func<IWebElement, string> Retrieval => e => e.Text;

        #endregion

        #region Builder Methods

        /// <summary>
        /// Constructs the question.
        /// </summary>
        /// <param name="locator">The target Web element's locator.</param>
        /// <returns></returns>
        public static TextList For(IWebLocator locator) => new TextList(locator);

        #endregion
    }
}

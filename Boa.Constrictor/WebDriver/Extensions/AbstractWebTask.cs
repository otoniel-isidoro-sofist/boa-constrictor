﻿using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;
using System;

namespace Boa.Constrictor.WebDriver
{
    /// <summary>
    /// Abstract class that makes it easier to write tasks that use the BrowseTheWeb ability.
    /// </summary>
    public abstract class AbstractWebTask : ITask
    {
        #region Abstract Methods

        /// <summary>
        /// Performs the task.
        /// </summary>
        /// <param name="actor">The actor.</param>
        /// <param name="driver">The WebDriver from the BrowseTheWeb ability.</param>
        public abstract void PerformAs(IActor actor, IWebDriver driver);

        #endregion

        #region Methods

        /// <summary>
        /// Performs the task.
        /// Internally calls PerformAs with the WebDriver from the BrowseTheWeb ability.
        /// </summary>
        /// <param name="actor">The actor.</param>
        public virtual void PerformAs(IActor actor) => PerformAs(actor, actor.Using<BrowseTheWeb>().WebDriver);

        /// <summary>
        /// Checks if this interaction is equal to another interaction.
        /// </summary>
        /// <param name="obj">The other object.</param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj.GetType().Equals(GetType());

        /// <summary>
        /// Gets a unique hash code for this interaction.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => HashCode.Combine(GetType());

        /// <summary>
        /// Returns a description of the task.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => GetType().Name;

        #endregion
    }
}

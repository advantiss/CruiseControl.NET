﻿namespace CruiseControl.Core.Channels
{
    using CruiseControl.Common;
    using CruiseControl.Core.Interfaces;

    /// <summary>
    /// The channel implementation for WCF.
    /// </summary>
    public class WcfChannel
        : ICommunicationsChannel
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="WcfChannel"/> class.
        /// </summary>
        /// <param name="invoker">The invoker.</param>
        public WcfChannel(IActionInvoker invoker)
        {
            this.Invoker = invoker;
        }
        #endregion

        #region Public properties
        #region Server
        /// <summary>
        /// Gets the invoker.
        /// </summary>
        public IActionInvoker Invoker { get; private set; }
        #endregion
        #endregion

        #region Public methods
        #region Invoke()
        /// <summary>
        /// Invokes an action on the specified urn.
        /// </summary>
        /// <param name="urn">The URN to invoke the action.</param>
        /// <param name="arguments">The arguments for the action.</param>
        /// <returns>
        /// The results of the action.
        /// </returns>
        public InvokeResult Invoke(string urn, InvokeArguments arguments)
        {
            return this.Invoker.Invoke(urn, arguments);
        }
        #endregion

        #region Query()
        /// <summary>
        /// Queries the specified urn.
        /// </summary>
        /// <param name="urn">The URN to query for actions.</param>
        /// <param name="arguments">The arguments for the query.</param>
        /// <returns>
        /// The allowed actions on the URN.
        /// </returns>
        public QueryResult Query(string urn, QueryArguments arguments)
        {
            return this.Invoker.Query(urn, arguments);
        }
        #endregion
        #endregion
    }
}
﻿using System;

namespace CommonMessages
{
    using EasyNetQ;

    /// <summary>   A deployment stop message. </summary>
    [Serializable]
    [Queue("Deployments", ExchangeName = "EvolvedAI")]
    public class DeploymentStopMessage
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public long ID { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the date. </summary>
        ///
        /// <value> The date. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime Date { get; set; }
    }
}
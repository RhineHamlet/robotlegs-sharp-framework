﻿using System;

namespace robotlegs.bender.framework.api
{
	public class LifecycleException : Exception
	{

		/*============================================================================*/
		/* Public Static Properties                                                   */
		/*============================================================================*/

		public const string SYNC_HANDLER_ARG_MISMATCH = "When and After handlers must accept 0 or 1 arguments";

		public const string LATE_HANDLER_ERROR_MESSAGE = "Handler added late and will never fire";

		/*============================================================================*/
		/* Constructor                                                                */
		/*============================================================================*/

		/// <summary>
		/// Creates a Lifecycle Exception
		/// </summary>
		/// <param name="message">The error message</param>
		public LifecycleException (string message) : base(message)
		{
		}
	}
}

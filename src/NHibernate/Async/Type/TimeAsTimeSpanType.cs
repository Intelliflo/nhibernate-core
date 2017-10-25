﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Data.Common;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using System.Collections.Generic;
using System.Data;

namespace NHibernate.Type
{
	using System.Threading.Tasks;
	using System.Threading;
	public partial class TimeAsTimeSpanType : PrimitiveType, IVersionType
	{

		#region IVersionType Members

		public Task<object> NextAsync(object current, ISessionImplementor session, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			return SeedAsync(session, cancellationToken);
		}

		public virtual Task<object> SeedAsync(ISessionImplementor session, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<object>(cancellationToken);
			}
			try
			{
				return Task.FromResult<object>(Seed(session));
			}
			catch (Exception ex)
			{
				return Task.FromException<object>(ex);
			}
		}

		#endregion
	}
}
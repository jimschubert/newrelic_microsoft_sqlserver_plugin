using System;

namespace NewRelic.Microsoft.SqlServer.Plugin.Core
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public sealed class SqlMonitorQueryAttribute : Attribute
	{
		public string ResourceName { get; private set; }
		public string QueryName { get; set; }
		public bool Enabled { get; set; }

		public SqlMonitorQueryAttribute(string resourceName)
		{
			ResourceName = resourceName;
			Enabled = true;
		}
	}
}
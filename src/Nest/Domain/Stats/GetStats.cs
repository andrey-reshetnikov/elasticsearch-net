﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject]
	public class GetStats
	{
		[JsonProperty(PropertyName = "total")]
		public long Total { get; set; }
		[JsonProperty(PropertyName = "time")]
		public string Time { get; set; }
		[JsonProperty(PropertyName = "time_in_millis")]
		public double TimeInMilliseconds { get; set; }
		[JsonProperty(PropertyName = "current")]
		public long Current { get; set; }

		[JsonProperty(PropertyName = "exists_total")]
		public long ExistsTotal { get; set; }
		[JsonProperty(PropertyName = "exists_time")]
		public string ExistsTime { get; set; }
		[JsonProperty(PropertyName = "exists_time_in_millis")]
		public double ExistsTimeInMilliseconds { get; set; }

		[JsonProperty(PropertyName = "missing_total")]
		public long MissingTotal { get; set; }
		[JsonProperty(PropertyName = "missing_time")]
		public string MissingTime { get; set; }
		[JsonProperty(PropertyName = "missing_time_in_millis")]
		public double MissingTimeInMilliseconds { get; set; }
	}
}

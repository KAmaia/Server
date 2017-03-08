using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Eventing.Library;

namespace Server.Core.ServerEvents {
	class ServerStartEvent : IEvent {
		public string Message { get { return "Server Starting Up"; }}
	}
}

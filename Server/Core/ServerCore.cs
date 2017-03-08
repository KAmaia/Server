using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Eventing.Library.Impl;
using Server.Core.ServerEvents;

namespace Server.Core {
	class ServerCore {
		private EventManager em;
		public ServerCore(EventManager em ) {
			this.em = em;
			em.StartReceiving<ServerStartEvent>(@event => this.StartUp( @event ) );
		}

		private void StartUp( ServerStartEvent @event ) {
			Console.WriteLine( @event.Message );
		}


	}

	
}

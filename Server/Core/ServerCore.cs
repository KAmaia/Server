using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Eventing.Library.Impl;
using Server.Core.ServerEvents;
using Eventing.Library;

namespace Server.Core {
	class ServerCore {
		private EventManager eventManager;
		public ServerCore(EventManager em ) {
			eventManager = em;
			StartReceiving( );
		}

		private void StartUp( ServerStartEvent @event ) {
			Console.WriteLine( @event.Message );
		}

		private void StartReceiving( ) {
			eventManager.StartReceiving<ServerStartEvent>( @event => this.StartUp( @event ) );
		}



	}

	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Eventing.Library;
using Eventing.Library.Impl;
using System.Threading;
using Server.Core.ServerEvents;
using Server.Core;

namespace Server {
	class Program {
		static void Main( string[ ] args ) {
			var synchronizationContext = new SingleThreadSynchronizationContext( "Client" );
			var eventManager = new EventManager(new MessageBus());
			SynchronizationContext.SetSynchronizationContext( synchronizationContext );
			ServerCore server = new ServerCore(eventManager);
			eventManager.RaiseEvent( new ServerStartEvent( ) );
		}
	}
}

using System.Configuration;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Ninject.Web.Common;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Extensions;

namespace ThenComesMarriage
{
	public class RavenDBNinjectModule : NinjectModule
	{
		public override void Load()
		{

			Bind<IDocumentStore>().ToMethod(CreateDocumentStore).InSingletonScope();
			Bind<IDocumentSession>().ToMethod(OpenDocumentSession).InRequestScope();
		}
		private static IDocumentStore CreateDocumentStore(IContext context)
		{
			DocumentStore documentStore = new DocumentStore
			{
				ConnectionStringName = "RavenDB"
			};
			documentStore.Initialize();
			documentStore.DatabaseCommands.EnsureDatabaseExists(ConfigurationManager.AppSettings["Raven.Database.Name"]);

			return documentStore;
		}

		private IDocumentSession OpenDocumentSession(IContext context)
		{
			IDocumentStore documentStore = (IDocumentStore)Kernel.GetService(typeof(IDocumentStore));
			return documentStore.OpenSession(ConfigurationManager.AppSettings["Raven.Database.Name"]);
		}
	}
}
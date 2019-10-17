using System.Collections.Generic;
using Umbraco.Core.Composing;
using Umbraco.Web.WebApi;

namespace TestCollections.Code
{
    public interface IMyThing
    {
        string Name { get; }

        string DoSomething(string message);
    }

    public class ExampleThing : IMyThing
    {
        public string Name => "Example";

        public string DoSomething(string message)
        {
            return $"Hello {message}";
        }
    }

    public class AnotherThing : IMyThing
    {
        public string Name => "Example";

        public string DoSomething(string message)
        {
            return $"Hello {message}";
        }
    }

    public class SomeOtherThing : IMyThing
    {
        public string Name => "Example";

        public string DoSomething(string message)
        {
            return $"Hello {message}";
        }
    }

    // OrderedCollection - use when order of items is important (You may want to execute them in order)
    // Different types of collections - https://our.umbraco.com/Documentation/Implementation/Composing/#types-of-collections
    public class MyThingsCollectionBuilder : OrderedCollectionBuilderBase<MyThingsCollectionBuilder, MyThingsCollection, IMyThing>
    {
        protected override MyThingsCollectionBuilder This => this;
    }

    public class MyThingsCollection : BuilderCollectionBase<IMyThing>
    {
        public MyThingsCollection(IEnumerable<IMyThing> items)
            : base(items)
        { }
    }

    public static class WebCompositionExtensions
    {
        public static MyThingsCollectionBuilder MyThings(this Composition composition)
            => composition.WithCollectionBuilder<MyThingsCollectionBuilder>();
    }

    public class MyThingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Explicitly add to the collection a Type in a specific order
            composition.MyThings().Append<ExampleThing>()
                .Append<AnotherThing>()
                .Append<SomeOtherThing>();
        }
    }

    // An Umbraco Backoffice Web API Controller - Used in a dashboard or Property Editor perhaps?
    public class SomeBackofficeApiController : UmbracoAuthorizedApiController
    {
        private MyThingsCollection _mythings;

        public SomeBackofficeApiController()
        {
        }

        public SomeBackofficeApiController(MyThingsCollection mythings)
        {
            _mythings = mythings;
        }

        public List<string> GetMessages(string message)
        {
            var items = new List<string>();

            foreach (var thing in _mythings)
            {
                items.Add(thing.DoSomething(message));
            }

            return items;
        }
    }
}
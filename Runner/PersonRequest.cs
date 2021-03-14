using System;

namespace Pythia
{
    public class PersonRequest : IRequest
    {
        private readonly Action<Person> _request;
        private readonly Person _person;

        public PersonRequest(Action<Person> request, Person person)
        {
            _request = request;
            _person = person;
        }

        public void FulFill()
        {
            _request.Invoke(_person);
        }
    }
}

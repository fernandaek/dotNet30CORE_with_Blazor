using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_06_Collections
{
    public class Todos
    {
        private List<Todo> todos = new List<Todo>();

        public List<Todo> Get()
        {
            return todos;
        }

        public void Add(string description) => todos.Add(new Todo(description));

        public void Remove(Todo todo) => todos.Remove(todo);
    }
}

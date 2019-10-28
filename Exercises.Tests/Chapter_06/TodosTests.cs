using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercise1.Classes.Chapter_06_Collections;

namespace Exercises.Tests.Chapter_06
{
    public class TodosTests
    {
        [Fact]
        public void CanCreateTodoInstance()
        {
            var todo = new Todo("Todo 1");

            Assert.NotNull(todo);
        }

        [Fact]
        public void CanReadDescriptionAndCollectionsAreEmpty()
        {
            var todo = new Todo("Todo 1");

            Assert.Equal("Todo 1", todo.GetDescription());
            Assert.Empty(todo.GetCheckboxAttributes());
            Assert.Empty(todo.GetDescriptionAttributes());
        }

        [Fact]
        public void CanCreateTodosInstance()
        {
            var todos = new Todos();
            todos.Add("Todo 1");

            Assert.NotEmpty(todos.Get());
        }

        [Fact]
        public void CanRemoveTodos()
        {
            var todos = new Todos();
            todos.Add("To-do 1");
            var countBeforeDelete = todos.Get().Count;

            var todo = todos.Get().Find(t => t.GetDescription().Equals("To-do 1"));

            todos.Remove(todo);

            Assert.Equal(1, countBeforeDelete);
            Assert.Empty(todos.Get());
        }

    }
}

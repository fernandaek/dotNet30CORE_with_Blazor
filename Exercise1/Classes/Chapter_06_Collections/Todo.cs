using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_06_Collections
{
    public class Todo
    {
        private string description;
        public bool completed;

        private Dictionary<string, object> checkboxAttributes = new Dictionary<string, object>();
        private Dictionary<string, object> descriptionAttributes = new Dictionary<string, object>();

        public Todo(string description)
        {
            this.description = description;
        }

        public string GetDescription() => description;

        public Dictionary<string, object> GetCheckboxAttributes() => checkboxAttributes;

        public Dictionary<string, object> GetDescriptionAttributes() => descriptionAttributes;


        public void CheckAttributes()
        {
            completed = !completed;

            if(completed)
            {
                checkboxAttributes.Add("checked", "checked");
                descriptionAttributes.Add("class", "completed");
            }
            else
            {
                checkboxAttributes.Clear();
                descriptionAttributes.Clear();
            }
        }
    }
}

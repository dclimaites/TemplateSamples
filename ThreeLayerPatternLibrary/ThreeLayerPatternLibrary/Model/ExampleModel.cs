using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayerPatternLibrary.Model
{
    public class ExampleModel : Entity
    {
        public ExampleModel(string Name, int Age, int Id) : base(Id)
        {
            _name = Name;
            _age = Age;
        }

        private string _name;
        private int _age;
    }
}

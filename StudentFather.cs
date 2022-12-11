using System;

namespace WpfApp8
{
    internal class StudentFather : IHuman, IComparable, ICloneable
    {
        private string _name;
        private int _age;
        private string _secondName;
        private int _numberOfChildren;
        

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public int NumberOfChildren { get => _numberOfChildren; set => _numberOfChildren = value; }
        

        public StudentFather(string name, int age, string secondName, int numberOfChildren)
        {
            _name = name;
            _age = age;
            _secondName = secondName;
            _numberOfChildren = numberOfChildren;
            
        }

        public int CompareTo(object obj)
        {
            if (_secondName.Length > ((StudentFather)obj).SecondName.Length)
            {
                return 1;
            }
            else if (_secondName.Length < ((StudentFather)obj).SecondName.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public string ShowInfo()
        {
            return " Cтудента зовут " + _name + '\n' +
                   " Возраст " + _age + '\n' +
                   " Фамилия " + _secondName + "\n" +
                   " Кол-во детей " + _numberOfChildren + "\n\n";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}

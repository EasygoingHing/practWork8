using System;

namespace WpfApp8
{
    internal class Student : IHuman, IComparable, ICloneable
    {
        private string _name;
        private int _age;
        private string _secondName;        

        
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }

        public Student(string name, int age, string secondName)
        {
            _name = name;
            _age = age;
            _secondName = secondName;
        }

        public int CompareTo(object obj)
        {
            if (_secondName.Length > ((Student)obj).SecondName.Length)
            {
                return 1;
            }  
            else if(_secondName.Length < ((Student)obj).SecondName.Length)
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
            return  " Cтудента зовут "  + _name + '\n' +
                    " Возраст " + _age + '\n' +                   
                    " Фамилия " + _secondName + "\n\n";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }    
}


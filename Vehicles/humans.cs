namespace Humans
{

    public class Person
    {
        private string _hairColor;
        private int _age;
        private string _eyeColor;
        private string _gender;

        public Person()
        {
            this._hairColor = "Black";
            this._age = 45;
            this._eyeColor = "Blue";
            this._gender = "Male";
        }

        public Person(string hairColor, int age, string eyeColor, string gender)
        {
            this._hairColor = hairColor;
            this._age = age;
            this._eyeColor = eyeColor;
            this._gender = gender;
        }

        public string HairColor
        {
            get { 
                return _hairColor; 
                }
            
            set { 
                _hairColor = value; 
                }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

         public string EyeColor
        {
            get { 
                return _eyeColor; 
                }
            
            set { 
                _eyeColor = value; 
                }
        }

         public string Gender
        {
            get { 
                return _gender; 
                }
            
            set { 
                _gender = value; 
                }
        }

        public void birthDay(int increment)
        {
            _age += increment;

        }


        public string GetHairColor()
        {
            return _hairColor;
        }

         public void SetHairColore(string hairColor)
        {
            _hairColor = hairColor;
        }

        public int GetAge()
        {
            return _age;    
        }

    }
}
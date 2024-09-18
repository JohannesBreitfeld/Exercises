
namespace BasicOOP
{
    class Person
    {
        public string firstName;
        public string lastName;
        public Person mother;
        public Person father;
        private double _length;
        private double _weight;

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }
        public string GetFullName(string titel)
        {
            return $"{titel}.{firstName} {lastName}";
        }
        public string GetFullNameReversed()
        {
            char[] reversed = new char[GetFullName().Length];
            string fullName = GetFullName();
            for (int i = 0; i < fullName.Length; i++)
            {
                reversed[i] = fullName[fullName.Length - 1 - i];
            }
            string reverse = new string(reversed);
            return reverse;
        }
        public string GetSelfAndParents()
        {
            string mothersName = (mother == null) ? "okänd" : mother.GetFullName();
            string fathersName = (father == null) ? "okänd" : father.GetFullName();

            return $"Ditt namn: {GetFullName()}, Mammas namn: {mothersName}, Pappas namn: {fathersName}";
        }
        public void SetLength(double length)
        {
            this._length = length;
        }
        public double GetLength()
        {
            return _length;
        }
        public void SetWeight(double weight)
        {
            this._weight = weight;
        }
        public double GetWeight()
        {
            return _weight;
        }
        public double GetBMI()
        {
            return _weight / (_length * 2);
        }
    }
}

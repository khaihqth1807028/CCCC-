namespace baitapCCCCCC.entity
{
    public class People
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public People(string name, bool gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public People()
        {
            
        }
    }
    
}
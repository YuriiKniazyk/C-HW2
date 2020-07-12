namespace HW2Structure
{
    public struct DogStruct
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"The dog is: \n {name} \n {mark} \n {age}" ;
        }
    }
}
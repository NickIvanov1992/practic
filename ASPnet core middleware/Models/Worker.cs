namespace middleware.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Adress { get; set; }

        public Worker(string name, string age, string dateofbirth, string adress)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateofbirth;
            Adress = adress;
        }
        public override string ToString()
        {
            return ($"Имя: {Name} , Возраст: {Age} ,Дата рождения: {DateOfBirth} , Адрес: {Adress}");
        }
    }
}

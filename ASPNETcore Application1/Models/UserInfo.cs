namespace WebApplication1.Models
{
    public class UserInfo
    {
         
        public string Firstname { get; set; } 
        public string Secondname { get; set; } 
        public string Middlename { get; set; } 
        public string DateOfBirth { get; set; } 
        public string Gender { get; set; } 
        public string Info { get; set; }
        public UserInfo(string firstname, string secondname, string middlename, string dateofbirth, string gender, string info)
        {
            Firstname = firstname;
            Secondname = secondname;
            Middlename = middlename;
            DateOfBirth = dateofbirth;
            Gender = gender;
            Info = info;
        }
        public override string ToString()
        {
            return ($"Имя: {Firstname} , Фамилия: {Secondname} , Отчество: {Middlename}, Пол: {Gender} , Дата рождения: {DateOfBirth} , О себе: {Info}");
        }
    }
}

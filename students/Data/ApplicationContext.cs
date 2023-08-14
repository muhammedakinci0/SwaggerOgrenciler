using students.Models;
namespace students.Data
{
    public static class ApplicationContext
    {
        public static List<Student> Students { get; set; }
        static ApplicationContext()
        {
            Students = new List<Student>()
            {
                new Student(){Id=1,Ad="Muhammed",Soyad="Akıncı",Yas="52"},
                new Student(){Id=2,Ad="ahmet",Soyad="Akıncı",Yas="22"},
                new Student(){Id=3,Ad="Arda",Soyad="Akıncı",Yas="12"},
            };
        }
    }
}

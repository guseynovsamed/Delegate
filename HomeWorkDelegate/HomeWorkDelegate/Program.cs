


using HomeWorkDelegate;

Person person = new Person();
Book book = new Book();


#region DataBase
List<Person> persons = new List<Person>()
{
     new Person() { Name = "Semed", Surname = "Huseynov", Address = "Ehmedli", Salary = 1200 },
     new Person() { Name = "Ilham", Surname = "Abasli", Address = "Lokbatan", Salary = 1000 },
     new Person() { Name = "Aqsin", Surname = "Veliyev", Address = "Bakixanov", Salary = 1800 },
};
List<Book> books = new List<Book>()
{
    new Book () {Author = "Nizami" , BookName = "Yeddi Gozel" },
    new Book () {Author = "Victor Hugo" , BookName = "Sefiller" },
    new Book () {Author = "Cingiz Abdullayev" , BookName = "Boyuk Oyun" },
    new Book () {Author = "Nizami" , BookName = "Sirler Xezinesi" }
};
#endregion



static void CheckPerson(List<Person> persons , Predicate<Person> func)
{
    foreach (Person person in persons)
    {
        if(func(person))
        {
            Console.WriteLine(person.Name+" "+person.Surname +" "+person.Salary+" "+person.Address);
        }
    }
}
static bool CheckSalary(Person person)
{
    return person.Salary > 1000;
}

static void CheckBook(List<Book> books , Predicate<Book> func)
{
    int count = 0;
    foreach (Book book in books)
    {
        if (func(book))
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
static bool CheckAuthor(Book book)
{
    return book.Author == "Nizami";
}


//CheckBook(books , CheckAuthor);
//CheckPerson(persons , CheckSalary);

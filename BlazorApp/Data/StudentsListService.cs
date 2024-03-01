namespace BlazorApp.Data
{
    public class StudentsListService
    {
        private static readonly string[] Surnames = new[]
        {
            "Сагдиева", "Кудашова", "Корнилова", "Файзуллина", "Зиятдинова"
        };

        private static readonly string[] Names = new[]
        {
            "Камилла", "Анна", "Варвара", "Эльвина", "Камилла"
        };

        private static readonly string[] Patronymics = new[]
        {
            "Рамилевна", "Вячеславовна", "Дмитриевна", "Рафаэлевна", "Овиковна"
        };

        private static readonly string[] DatesOfBirth = new[]
        {
            "21.03.2005", "09.02.2005", "21.05.2003", "06.03.2005", "14.11.2005"
        };

        private static readonly string[] Groups = new[]
        {
            "320П", "321П", "322П", "315ВЕБ", "327АС"
        };

        public Task<StudentsList[]> GetListAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(0, 5).Select(index => new StudentsList
            {
                Surname = Surnames[index],
                Name = Names[index],
                Patronymic = Patronymics[index],
                DateOfBirth = DatesOfBirth[index],
                Group = Groups[index]
            }).ToArray());
        }
    }
}

namespace Template_Method_Pattern
{
    public class CourseReportGenerator : ReportGenerator
    {
        protected override void data()
        {
            Console.WriteLine("Сбор данных о курсах...");
            Console.WriteLine("Данные о курсах собраны");
        }

        protected override void process()
        {
            Console.WriteLine("Обработка данных о курсах...");
            Console.WriteLine("Данные о курсах обработаны");
        }

        protected override void format()
        {
            Console.WriteLine("Форматирование данных о курсах");
            Console.WriteLine("Отчет по курсам сформирован");
        }

        protected override void export()
        {
            Console.WriteLine("Экспорт отчета по курсам в файл...");
            Console.WriteLine("Отчет по курсам экспортирован");
        }
    }
}

namespace Template_Method_Pattern
{
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void data()
        {
            Console.WriteLine("Сбор данных...");
            Console.WriteLine("Данные о студентах собраны");
        }

        protected override void process()
        {
            Console.WriteLine("Обработка данных");
            Console.WriteLine("Данные о студентах обработаны");
        }

        protected override void format()
        {
            Console.WriteLine("Формирование данных");
            Console.WriteLine("Отчет по студентам сформирован");
        }

        protected override void export()
        {
            Console.WriteLine("Экспорт данных по стурентам в файл");
            Console.WriteLine("Отчет по студентам экспортирован");
        }
    }
}

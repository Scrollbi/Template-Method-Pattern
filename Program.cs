using Template_Method_Pattern;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Отчет начал генерироваться.");
        data();
        process();
        format();
        export();
        Console.WriteLine("Отчет сгенерирован успешно!");
    }

    protected abstract void data();
    protected abstract void process();
    protected abstract void format();
    protected abstract void export();
}
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("\nГенерация отчета по студентам:");
        StudentReportGenerator studentReportGenerator = new StudentReportGenerator();
        studentReportGenerator.GenerateReport();

        Console.WriteLine("\nГенерация отчета по курсам:");
        CourseReportGenerator courseReportGenerator = new CourseReportGenerator();
        courseReportGenerator.GenerateReport();
    }
}

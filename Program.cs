
using System.Runtime.InteropServices;
using DemoLinqCountBy;

Console.Clear();
Console.WriteLine($"Testes com {RuntimeInformation.FrameworkDescription} - Linq Método CountBy \n\n");

var students = new Student[] 
{
    new(1, "Marcos Lima", 'A'),
    new (2, "João Carlos", 'A'),
    new (3, "Carlos de Souza", 'B'),
    new (4, "Maria Silva", 'A'),
    new (5, "Joana Lima", 'C'),
    new (6, "Isabela Oliveira", 'D'),
    new (7, "Michele Pinto", 'A'),
    new (8, "Licas Oliveira", 'B'),
    new (9, "Victoria Martins", 'D'),
    new (10, "Felipe Lima", 'A'),
};

foreach (var student in students)
    Console.WriteLine($"\t O {student.Name} estuda na classe: {student.Classroom}");

var countStudentsInClasses = students.Select(_ => _.Classroom).CountBy(classroom => classroom);


Console.WriteLine("\n Quantidade de alunos em cada sala:");
foreach (var student in countStudentsInClasses)
    Console.WriteLine($"    {student.Key} = {student.Value}");

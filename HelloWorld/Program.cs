using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
using HelloWorld;
public static class Program
{

    public static void Main()
    {
        string CsvPath = "./employees.csv";

        // TODO: Lire les employés depuis le fichier CSV et les stocker dans une liste

        // TODO: Afficher les employés et vérifier si les emails sont valides

        // TODO: Trier les employés par date d'entrée dans l'entreprise

        // TODO: Afficher les employés triés par date d'entrée

        // TODO: Convertir le temps de travail hebdomadaire au format classique et afficher

    }

    // Fonction pour lire les employés depuis un fichier CSV
    private static List<Employee> ReadEmployeesFromCsv(string csvPath)
    {
        // TODO: Implémentez cette méthode pour lire les données d'employés depuis un fichier CSV et les retourner sous forme de liste d'objets Employee
        if (File.Exists(csvPath))
        {
            List<Employee> employees = new List<Employee>();
            using (TextFieldParser parser = new TextFieldParser(csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 4)
                    {
                        string name = fields[0];
                        string email = fields[1];
                        DateTime startDate;
                        if (DateTime.TryParse(fields[2], out startDate))
                        {
                            double weeklyHours;
                            if (double.TryParse(fields[3], out weeklyHours))
                            {
                                employees.Add(new Employee(name, email, startDate, weeklyHours));
                            }
                        }
                    }
                }
            }
            return employees;
        }
        return new List<Employee>();
    }

    // Fonction pour trier les employés par date d'entrée dans l'entreprise
    private static void SortEmployeesByDate(List<Employee> employees)
    {
        // TODO: Implémentez cette méthode pour trier la liste des employés par leur date d'entrée dans l'entreprise
    }

    // Fonction pour convertir le temps de travail hebdomadaire au format classique (hh:mm)
    private static string ConvertToClassicFormat(double tempsTravailHebdomadaire)
    {
        // TODO: Implémentez cette méthode pour convertir un double représentant le temps de travail hebdomadaire en une chaîne de caractères au format hh:mm
        return "";
    }

    // Fonction pour valider une adresse email en utilisant une expression régulière
    public static bool IsValidEmail(string email)
    {
        // TODO: Implémentez cette méthode pour valider une adresse email en utilisant une expression régulière et retourner vrai ou faux
        // Veuillez utiliser une expression régulière pour valider l'adresse email
        // Retourne vrai si l'adresse email est valide, sinon faux
        Regex regex = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
        return regex.IsMatch(email);

        return false;
    }
}

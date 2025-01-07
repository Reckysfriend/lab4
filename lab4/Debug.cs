﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class Debug
    {
        int amountOfRandomPeople = 100;
        string[] firstName = ["Greg", "Jenny", "Ivan", "Micky", "Sarah"];
        string[] lastName = ["Smith", "Andersson", "Joy", "Wickers", "Saint"];
        string[] hairLength = ["10", "15", "20", "25", "30" , "35"];
        string[] hairType = ["Curly", "Wavy", "Stright"];
        string[] colors = ["Brown", "Blue", "Green", "Yellow", "Red"];

        Genders gender = new Genders();
        Random random = new Random();
        string firstNameStr = "";
        string lastNameStr = "";
        string fullName = "";
        string eyeColourStr = "";
        string hairLengthStr = "";
        string hairTypeStr = "";
        string hairColourStr = "";
        int birthYear = 0;
        int birthMonth = 0;
        int birthDay = 0;
        int avalibleDays = 0;

        public void RunDebug()
        {
            for (int i = 0; i < amountOfRandomPeople; i++)
            {
                firstNameStr = firstName[random.Next(0,5)];
                lastNameStr = lastName[random.Next(0, 5)];
                hairLengthStr = hairLength[random.Next(0, 5)];
                hairTypeStr = hairType[random.Next(0, 3)];
                hairColourStr = colors[random.Next(0, 5)];
                eyeColourStr = colors[random.Next(0, 5)];
                birthYear = random.Next(1950, 2024 + 1);
                birthMonth = random.Next(1, 12 + 1);
                avalibleDays = DateTime.DaysInMonth(birthYear, birthMonth);
                birthDay = random.Next(1, avalibleDays + 1);
                gender = (Genders)random.Next(0, 4);

                DateTime birthday = new DateTime(birthYear, birthMonth, birthDay);
                Hair hair = new Hair(hairLengthStr, hairColourStr, hairTypeStr);
                fullName = $"{firstNameStr} {lastNameStr}";
                Person person = new Person(gender, hair, birthday, eyeColourStr, fullName);
                ListOfPeople.listOfPeople.Add(person);
                
            }
        }
    }
}

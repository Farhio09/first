using System;


        // Variables
        string name = "Farhio Bashiir";
        Console.WriteLine(name);

        string motherName = "Saido Ali";
        Console.WriteLine(motherName);

        string dobString = "1990-06-25";  // Taariikhda dhalashada string ahaan
        Console.WriteLine(dobString);

        // Convert dob string to DateTime
        DateTime dob = DateTime.Parse(dobString);
        Console.WriteLine(dob.ToShortDateString());

        // Calculate age
        DateTime today = DateTime.Today;
        int age = today.Year - dob.Year;
        if (dob > today.AddYears(-age)) age--;
        Console.WriteLine(age);

        string pop = "Somali";
        Console.WriteLine(pop);

        string address = "Galkacyo, Somalia";
        Console.WriteLine(address);

        string telephone = "09000000";
        Console.WriteLine(telephone);

        string sex = "Female";
        Console.WriteLine(sex);

        string status = "Single";
        Console.WriteLine(status);


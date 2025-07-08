using System;


//// Variables
//string name = "Farhio Bashiir";
//Console.WriteLine(name);

//string motherName = "Saido Ali";
//Console.WriteLine(motherName);

//string dobString = "1990-06-25";  // Taariikhda dhalashada string ahaan
//Console.WriteLine(dobString);

//// Convert dob string to DateTime
//DateTime dob = DateTime.Parse(dobString);
//Console.WriteLine(dob.ToShortDateString());

//// Calculate age
//DateTime today = DateTime.Today;
//int age = today.Year - dob.Year;
//if (dob > today.AddYears(-age)) age--;
//Console.WriteLine(age);

//string pop = "Somali";
//Console.WriteLine(pop);

//string address = "Galkacyo, Somalia";
//Console.WriteLine(address);

//string telephone = "09000000";
//Console.WriteLine(telephone);

//string sex = "Female";
//Console.WriteLine(sex);

//string status = "Single";
//Console.WriteLine(status);

//string name, motherName, dobString, pop, address ,single , sex,status;
//int tell;
//Console.WriteLine("gali magacaga");
//name = Console.ReadLine();

//Console.WriteLine("gali hooyada");
//motherName =Console.ReadLine();

//Console.WriteLine("gali taariikhda dhalashada");
//dobString = Console.ReadLine();


//Console.WriteLine("gali meesha kudhalatay");
//pop = Console.ReadLine();

//Console.WriteLine("gali address");
//address = Console.ReadLine();

//Console.WriteLine("gali sex");
//sex = Console.ReadLine();


//Console.WriteLine("gali statuskaga");
//status = Console.ReadLine();


//int tiro;
//Random qulxin = new Random(); // random object
// function to generate a random number between 1 and 50


//int loop;
//for (loop = 1; loop <= 10; loop++)
//{
//    tiro = qulxin.Next(1, 50);
//    Console.WriteLine(tiro);

//}


//int tiro;
//int iskuday = 0; 
//Random qulxin = new Random(); // Object Random

//int loop;
//for (loop = 1; loop <= 10; loop++)
//{
//    tiro = qulxin.Next(1, 50); // Random 1 ilaa 49
//    Console.WriteLine(loop+"\t\t"+tiro);
//    iskuday = iskuday + tiro;

//}
//Console.WriteLine("iskudarka" +iskuday);

        Random r = new Random();

        Console.Write("Magaca: ");
        string name = Console.ReadLine();

        Console.Write("ID: ");
        string id = Console.ReadLine();

        Console.WriteLine("\nDooro nooca xisaabta:");
        Console.WriteLine("1. Kudar\n2. Kajar\n3. Kudhufo\n4. Uqeybi");
        Console.Write("Xulo (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        string operation = "";
        int a = r.Next(1, 20), b = r.Next(1, 10), correctAns = 0;
        string question = "";

        switch (choice)
        {
            case 1:
                operation = "Kudar";
                correctAns = a + b;
                question = $"{a} + {b}";
                break;
            case 2:
                operation = "Kajar";
                correctAns = a - b;
                question = $"{a} - {b}";
                break;
            case 3:
                operation = "Kudhufo";
                correctAns = a * b;
                question = $"{a} * {b}";
                break;
            case 4:
                operation = "Uqeybi";
                while (b == 0) b = r.Next(1, 10);
                correctAns = a / b;
                question = $"{a} / {b}";
                break;
            default:
                Console.WriteLine("Doorasho khaldan.");
                return;
        }

        Console.Write($"Su'aal: {question} = ");
        int userAns = int.Parse(Console.ReadLine());


        bool isCorrect = userAns == correctAns;
        int score = isCorrect ? 10 : 0;
        string level = isCorrect ? "Excellent" : "Needs Improvement";

        // Natiijo Table
        Console.WriteLine("\n------ Natiijada ------");
        Console.WriteLine("ID\tMagac\tNooc\tSu'aal\tJwb Sax\tJwb User\tSax\tScore\tHeer");
        Console.WriteLine($"{id}\t{name}\t{operation}\t{question}\t{correctAns}\t{userAns}\t\t{(isCorrect ? "Haa" : "Maya")}\t{score}/10\t{level}");
    

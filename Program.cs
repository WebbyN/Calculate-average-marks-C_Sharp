
    
    public class MainTest
    {
    static int MANLENGTH = Convert.ToInt32(Console.ReadLine());

    static void InputData(ref double[] test1, ref double[] test2, ref double[] assignment, ref double[] exam, ref string[] studentsArray, ref int count)
        {
            while (count < MANLENGTH)
            {
                Console.Write("Please enter the Students' name: " + "((Q to Quit)) ");
                studentsArray[count] = Console.ReadLine();
                if (studentsArray[count] == "Q" || studentsArray[count] == "q")
                {
                    break;
                }
                Console.Write("Please enter " + studentsArray[count] + " Test 1: ");
                test1[count] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter " + studentsArray[count] + " Test 2: ");
                test2[count] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter " + studentsArray[count] + " Assignment: ");
                assignment[count] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter " + studentsArray[count] + " Exam: ");
                exam[count] = Convert.ToDouble(Console.ReadLine());
                count++;
            }
        }

        static void DisplayPlayerData(ref double[] test1, ref double[] test2, ref double[] assignment, ref double[] exam, ref string[] studentsArray, ref int count)
        {
        double[] total;
        Console.WriteLine("Student       Test1    Test2   Assignment   Exam    Final Mark");
            for (int i = 0; i < count; i++)
            {
           int totale = (int)((0.33 * test1[i] + 0.33 * test2[i] + 0.34 * assignment[i]) * 0.4 + exam[i] * 0.6);
                Console.WriteLine("{0,-12}   {1,-7}    {2,-7}    {3,-7}   {4,-7}   {5,-7}", studentsArray[i], test1[i], test2[i], assignment[i], exam[i], totale);
            }
        }

        static void CalculateAverageScore(ref double[] test1, ref double[] test2, ref double[] assignment, ref double[] exam, ref string[] studentsArray, ref int count)
        {
            double total1 = 0;
            double total2 = 0;
            double total3 = 0;
            double total4 = 0;
            double average1 = 0;
            double average2 = 0;
            double average3 = 0;
            double average4 = 0;
        for (int i = 0; i < test1.Length; i++)
            {
                total1 += test1[i];
                total2 += test2[i];
                total3 += assignment[i];
                total4 += exam[i];
            }
            average1 = total1 / test1.Length;
            Console.WriteLine("The average score for test 1 is : " + average1);
            average2 = total2 / test1.Length;
            Console.WriteLine("The average score for test 2 is : " + average2);
            average3 = total3 / test1.Length;
            Console.WriteLine("The average score for Assignment is : " + average3);
            average4 = total4 / test1.Length;
            Console.WriteLine("The average score for Exam is : " + average4);
        Console.ReadLine();
        }

        static void Main(string[] args)
        {
        Console.WriteLine("Enter number of students");

         
            double[] test1 = new double[MANLENGTH];
            double[] test2 = new double[MANLENGTH];
            double[] assignment = new double[MANLENGTH];
            double[] exam = new double[MANLENGTH];
            double[] finalMark = new double[MANLENGTH];
            string[] studentsArray = new string[MANLENGTH];
            string reloop = "N";
            int count = 0;

            do
            {
                InputData(ref test1, ref test2, ref assignment, ref exam, ref studentsArray, ref count);
                DisplayPlayerData(ref test1, ref test2, ref assignment, ref exam, ref studentsArray, ref count);
                CalculateAverageScore(ref test1, ref test2, ref assignment, ref exam, ref studentsArray, ref count);
                Console.WriteLine("Continue or not?");
                reloop = Console.ReadLine();
            } while (reloop == "Y");

        }
    }

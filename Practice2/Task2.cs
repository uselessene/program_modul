// Console.Write("Studenti: ");
// int k = int.Parse(Console.ReadLine());

// Console.Write("Predmeti: ");
// int m = int.Parse(Console.ReadLine());

// int[,] grades = new int[k, m];
// for (int i = 0; i < k; i++) {
//     Console.WriteLine("Student " + (i + 1));
//     for (int j = 0; j < m; j++) {
//         Console.Write("Ocenka: ");
//         grades[i, j] = int.Parse(Console.ReadLine());
//     }
// }

// for (int i = 0; i < k; i++) {
//     int sum = 0;
//     for (int j = 0; j < m; j++) {
//         sum = sum + grades[i, j];
//     }
//     double sredn = (double)sum / m;
//     Console.WriteLine("Srednee " + (i + 1) + ": " + sredn);
// }
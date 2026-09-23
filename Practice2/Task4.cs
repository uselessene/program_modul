// string[] names = new string[100];
// string[] phones = new string[100];
// int count = 0;

// while (true) {
//     Console.Write("add, find, list, exit: ");
//     string cmd = Console.ReadLine();

//     if (cmd == "exit") {
//         break;
//     }

//     if (cmd == "add") {
//         Console.Write("Imya: ");
//         names[count] = Console.ReadLine();
//         Console.Write("Telefon: ");
//         phones[count] = Console.ReadLine();
//         count++;
//     }

//     else if (cmd == "find") {
//         Console.Write("Imya: ");
//         string search = Console.ReadLine();

//         bool found = false;
//         for (int i = 0; i < count; i++) {
//             if (names[i] == search) {
//                 Console.WriteLine(names[i] + ": " + phones[i]);
//                 found = true;
//             }
//         }

//         if (found == false) {
//             Console.WriteLine("Net");
//         }
//     }
//     else if (cmd == "list") {
//         for (int i = 0; i < count; i++) {
//             Console.WriteLine(names[i] + ": " + phones[i]);
//         }
//     }
//     else {
//         Console.WriteLine("Oshibka");
//     }
// }
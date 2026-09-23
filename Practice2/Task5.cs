// string[] words = new string[100];
// int[] counts = new int[100];
// int count = 0;

// while (true) {
//     string word = Console.ReadLine();
//     if (word == "exit") {
//         break;
//     }

//     bool found = false;
//     for (int i = 0; i < count; i++) {
//         if (words[i] == word) {
//             counts[i] = counts[i] + 1;
//             Console.WriteLine(word + ":" + counts[i]);
//             found = true;
//         }
//     }

//     if (found == false) {
//         words[count] = word;
//         counts[count] = 1;
//         count++;
//         Console.WriteLine(word + ":1");
//     }
// }
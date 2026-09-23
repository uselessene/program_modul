Console.Write("Razmer massiva: ");
int n = int.Parse(Console.ReadLine());

int[] massiv = new int[n];
int sum = 0;

for (int i = 0; i < n; i++) {
    Console.Write("Chislo: ");
    massiv[i] = int.Parse(Console.ReadLine());
    sum = sum + massiv[i];
}
double sred = (double)sum / n;

Console.Write("Obratny: ");
for (int i = n - 1; i >= 0; i--) {
    Console.Write(massiv[i] + " ");
}
Console.WriteLine();

int bliz = massiv[0];
double minrazn = massiv[0] - sred;
if (minrazn < 0) minrazn = -minrazn;

for (int i = 1; i < n; i++) {
    double razn = massiv[i] - sred;
    if (razn < 0) razn = -razn;

    if (razn < minrazn) {
        minrazn = razn;
        bliz = massiv[i];
    }
}

Console.WriteLine("Srednee: " + sred);
Console.WriteLine("Blizashee: " + bliz);
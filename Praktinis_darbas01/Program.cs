double izambine; //Vienas is kintamuju


izambine = Math.Sqrt(10 * 10 + 15 * 15); // Kintamojo reiksme priskirta


Console.WriteLine(izambine); // Tiesiog pasitikrinau

/*PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ŽEMĖS RUTULIO SPINDULĮ, O IŠVEDA PAVIRŠIAUS ŽEMĖS PAVIRŠIAUS PLOTĄ IR TŪRĮ*/

double sphereDiameter = 6371;
double sphereRadius = sphereDiameter / 2;
double numberPI = (double)Math.PI;

double sphereSurfaceArea = 4 * numberPI * Math.Pow(sphereRadius, 2);
double sphereVolume = 4.0 / 3 * numberPI * Math.Pow(sphereRadius, 3);

/*Console.WriteLine($"Sphere surface area: {sphereSurfaceArea:0.00}");
Console.WriteLine($"Sphere volume2: {sphereVolume:0.00}");*/
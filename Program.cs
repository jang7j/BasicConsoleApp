 static float MetersToMiles (float meters)
{
    float answer = meters * .000621371f;
    return answer;
}


var mileage = MetersToMiles(3000);
Console.WriteLine(mileage);

//string name = "sound of music";
//int year = 1965;
//char ch = 's';
//bool goodmovie = true;
//double rating = 10;
//decimal budget = 8200000;

//console.writeline($"{name} is the best movie of all time that was released in {year}.");

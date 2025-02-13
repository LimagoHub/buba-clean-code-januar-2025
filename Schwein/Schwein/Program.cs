// See https://aka.ms/new-console-template for more information

using Schwein.animals;

Pig piggy = new Pig("Miss Piggy");

Console.WriteLine(piggy);

piggy.Feed();

Console.WriteLine(piggy);

while(piggy.Weight < 11);
Console.WriteLine(piggy);
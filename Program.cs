string[] party = { "Farros", "Ade", "kamil", "Ata" };

for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"member {i}: {party[i]}");
}

party[2] = "Kamil";
Console.WriteLine($"\nUpdated Member 2: {party[2]}");

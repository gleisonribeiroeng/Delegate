PrintDelegate PrintConsole = (string text) =>
{
    Console.WriteLine(text);
};

PrintDelegate PrintToFile = (string text) =>
{
    File.AppendAllText("./logs.txt", text);
};

static void ConnectToDatabase(PrintDelegate log)
{
    log("Inserting a new record into the database.");

    log("The record got insert into the database.");
}

ConnectToDatabase(PrintToFile);

delegate void PrintDelegate(string text);
using ConsoleApp.Model;

namespace ConsoleApp
{
    internal static class Menu
    {
        private static List<Notes> notesCollection = new List<Notes>();
        private static Notes notes;
        private static int id;
        public static void Action()
        {
            //Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine("  _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \r\n |                                 |\r\n |   1 - Show all notes            |\r\n |   2 - Add notes                 |\r\n |   3 - Edit notes                |\r\n |   4 - Delete notes              |\r\n |   5 - Exit                      |\r\n |_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");
                Console.Write("     Press to activate: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        if (notesCollection.Count == 0)
                        {
                            Console.WriteLine("No notes");
                            break;
                        }
                        else
                        {
                            foreach (var item in notesCollection)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }

                    case "2":
                        Console.Clear();

                        notes = new Notes();

                        Console.WriteLine("Enter a title:");
                        string noteTitle = Console.ReadLine();
                        Console.WriteLine("Enter a note:");
                        string note = Console.ReadLine();
                        id++;

                        notes.SetTitle(noteTitle);
                        notes.SetNote(note);
                        notes.SetId(id);

                        notesCollection.Add(notes);
                        break;

                    case "3":
                        Console.Clear();

                        break;

                    case "4":
                        Console.Clear();

                        Console.WriteLine("Enter the id of the note which you want to delete: ");
                        string str_delete_id = Console.ReadLine();

                        int int_delete_id = Convert.ToInt32(str_delete_id);
                        notesCollection.RemoveAt(--int_delete_id);

                        Console.Clear();
                        Console.WriteLine("Note deleted");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Exiting program");
                        return;
                        
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

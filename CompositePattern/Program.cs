namespace CompositePattern
{
    static class Program
    {
        /*
         * Composite is a structural design pattern that lets you compose objects into 
         * tree structures and then work with these structures as if they were 
         * individual objects.
         */

        /*
         * Imagine a file system with files and folders:
            A file is a single unit of data.
            A folder can contain files or other folders, forming a hierarchy.
            Using the Composite Pattern:

            A file is a leaf node (no children).
            A folder is a composite node (can contain files and other folders).
            The client can treat both files and folders as the same type (e.g., display the size or structure).
         */
        public static void Main()
        {

            // Create files
            File file1 = new File("File1.txt", 10);
            File file2 = new File("File2.txt", 20);
            File file3 = new File("File3.jpg", 30);

            // Create folders
            Folder folder1 = new Folder("Folder1");
            Folder folder2 = new Folder("Folder2");

            // Build hierarchy
            folder1.Add(file1);
            folder1.Add(file2);
            folder2.Add(file3);
            folder1.Add(folder2);

            // Display the hierarchy
            folder1.Display("");

            // Get total size
            Console.WriteLine($"Total size: {folder1.GetSize()} KB");

        }
    }
}

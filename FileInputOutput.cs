using System;
using System.IO;
public class FileInputOutput
{
	public static void Main(string[] args) { 

		string folderName = "fileCheck";
		string fileName = folderName + "/file1.txt";

		try
		{
			if (!Directory.Exists(folderName))
			{
				Directory.CreateDirectory(folderName);
				Console.WriteLine("Folder '" + folderName + "' created.");
			}

			string data = "Date: 20202 | Action: Deposit | Amount: $500\n";
			File.AppendAllText(fileName, data);
			Console.WriteLine("Data written to: " + fileName);

			if (File.Exists(fileName))
			{
				string content = File.ReadAllText(fileName);
				Console.WriteLine("\n--- File Content ---");
				Console.WriteLine(content);
			}
		}
		catch (IOException ex)
		{
			Console.WriteLine("Hard Drive Error: " + ex.Message);
		}
		catch (Exception ex)
		{
			Console.WriteLine("General Error: " + ex.Message);
		}
	}
}

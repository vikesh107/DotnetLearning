using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

class Program
{
    static void Main()
    {
        // Initialize Excel application
        Excel.Application excelApp = new Excel.Application();
        excelApp.Visible = true; // Make Excel visible

        // Open the workbook
        Excel.Workbook workbook = excelApp.Workbooks.Open(@"D:\Vikesh Workspace\Server Side\demo01.xlsx");
        Excel.Worksheet worksheet = workbook.Worksheets[1]; // Assuming you're working with the first worksheet

        // Get the used range of the worksheet
        Excel.Range usedRange = worksheet.UsedRange;

        // Assuming you have headers in the first row, starting from the second row
        int startRow = 2;
        int leftSubColumnIndex = 6; // Your left sub-column index
        int rightSubColumnIndex = 7; // Your right sub-column index
        var key = "b14ca5898a4e4133bbce2ea2315a1916";

        // Loop through each row
        for (int row = startRow; row <= usedRange.Rows.Count; row++)
        {
            // Get the value of the right sub-column
            string rightSubColumnValue = (usedRange.Cells[row, rightSubColumnIndex].Value as string)?.Trim();

            if (!string.IsNullOrEmpty(rightSubColumnValue) && IsValidBase64String(rightSubColumnValue))
            {
                try
                {
                    byte[] cipherBytes = Convert.FromBase64String(rightSubColumnValue);
                    string decryptedText = Encoding.UTF8.GetString(cipherBytes);
                    // Paste the value into the left sub-column
                    usedRange.Cells[row, leftSubColumnIndex].Value = DecryptString(key, decryptedText);
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log the error)
                    Console.WriteLine($"Error processing row {row}: {ex.Message}");
                }
            }
            else
            {
                // Handle the case where the string is not a valid Base64 string
                Console.WriteLine($"Invalid Base64 string at row {row}");
                // You might choose to skip this row or take other appropriate actions
            }
        }

        // Save and close the workbook
        workbook.Save();
        workbook.Close();
        excelApp.Quit();
    }

    // Function to check if a string is a valid Base64 string
    private static bool IsValidBase64String(string s)
    {
        s = s.Replace(" ", "+"); // Replace spaces with '+' (common in some Base64 representations)
        s = s.Replace("\t", ""); // Remove tabs

        // Check if the string is a valid Base64 string
        try
        {
            byte[] result = Convert.FromBase64String(s);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static string DecryptString(string key, string cipherText)
    {
        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}

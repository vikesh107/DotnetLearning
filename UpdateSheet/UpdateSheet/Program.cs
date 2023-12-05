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
        int leftSubColumnIndex = 8; // Your left sub-column index
        int rightSubColumnIndex = 9; // Your right sub-column index
        var key = "b14ca5898a4e4133bbce2ea2315a1916";
        // Loop through each row
        for (int row = startRow; row <= usedRange.Rows.Count; row++)
        {
            // Get the value of the right sub-column

           
            string rightSubColumnValue = (string)(usedRange.Cells[row, rightSubColumnIndex].Value);
            Console.WriteLine(rightSubColumnValue);
            if (!string.IsNullOrEmpty(rightSubColumnValue))
            {
                try
                {
                    string decryptedValue = DecryptString(key, rightSubColumnValue);
                    Console.WriteLine($"Decrypted Value: {decryptedValue}");
                    usedRange.Cells[row, leftSubColumnIndex].Value = decryptedValue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error decrypting row {row}: {ex.Message}");
                }
            }
            

        }

        // Save and close the workbook
        workbook.Save();
        workbook.Close();
        excelApp.Quit();
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
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}
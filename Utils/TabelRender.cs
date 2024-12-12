using System;
using System.Collections.Generic;
using System.Linq;

namespace WomemFashionManagement.Utils
{
  public class TableRender
  {
    public static void CreateTable<T>(List<T> data)
    {
      if (data == null || !data.Any())
      {
        Console.WriteLine("Không có dữ liệu để hiển thị.");
        return;
      }

      // Lấy tất cả các thuộc tính (field/column) của đối tượng
      var properties = typeof(T).GetProperties();

      // Tạo header bằng tên các thuộc tính
      var headers = properties.Select(p => p.Name).ToList();

      // Tính độ dài tối đa của mỗi cột (bao gồm cả header và dữ liệu)
      var columnWidths = headers
          .Select((header, index) => Math.Max(header.Length, data.Max(item => properties[index].GetValue(item)?.ToString()?.Length ?? 0)))
          .ToArray();

      Console.WriteLine();

      // In header
      PrintRow(headers, columnWidths);
      PrintSeparator(columnWidths);

      // In dữ liệu từng hàng
      foreach (var item in data)
      {
        var row = properties.Select(p => p.GetValue(item)?.ToString() ?? string.Empty).ToList();
        PrintRow(row, columnWidths);
      }
      Console.WriteLine();
    }

    private static void PrintRow(List<string> columns, int[] columnWidths)
    {
      var formattedRow = columns.Select((column, index) => column.PadRight(columnWidths[index])).ToList();
      Console.WriteLine("| " + string.Join(" | ", formattedRow) + " |");
    }

    private static void PrintSeparator(int[] columnWidths)
    {
      Console.WriteLine("+" + string.Join("+", columnWidths.Select(width => new string('-', width + 2))) + "+");
    }
  }

}